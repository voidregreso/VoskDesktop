using NAudio.Wave;
using NAudio.CoreAudioApi;
using Vosk;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Reflection;
using System.ComponentModel;
using Cyotek.Windows.Forms;

namespace RecogUI
{
    public partial class MainForm : Form
    {

        private Model? model = null;
        private bool parado = true;
        private static BackgroundWorker bw;
        private WasapiCapture waveIn;
        private volatile FrmSubtitle _frmSubtitle;
        private volatile SettingsObj _settings;
        private readonly ColorPickerDialog _colorDialog = new ColorPickerDialog();
        private Font _font = DefaultFont;

        public MainForm()
        {
            InitializeComponent();
            comboLang.SelectedIndex = 2;
            comboSmpR.SelectedIndex = 3;
            rbLoop.Checked = true;
            LoadModel(comboLang.SelectedIndex);
            cbxGradientType.SelectedIndex = 0;
            _settings = new SettingsObj
            {
                BorderColor = Color.Black,
                Color1 = Color.GhostWhite,
                Color2 = Color.LightGray,
                FontActual = new Font(new FontFamily("Microsoft Yahei"), 24.0f, FontStyle.Regular, GraphicsUnit.Point),
                GradientType = 1
            };
            try
            {
                _font = FontSerializationHelper.Deserialize(_settings.Font);
                cbxGradientType.SelectedIndex = _settings.GradientType;
                btnColor1.BackColor = _settings.Color1;
                btnColor2.BackColor = _settings.Color2;
                btnBorderColor.BackColor = _settings.BorderColor;
                checkBoxPreserveSlash.Checked = _settings.PreserveSlash;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private WasapiCapture getInstance()
        {
            if (rbLoop.Checked) return new WasapiLoopbackCapture();
            else return new WasapiCapture();
        }

        public void LoadModel(int idx)
        {
            string[] models = { "model-small-en", "model-small-fr", "model-small-es", "model-small-pt", "model-small-it", "model-small-de" };
            string cpath = Directory.GetCurrentDirectory() + "\\";

            if (idx >= 0 && idx < models.Length)
            {
                model = new Model(cpath + models[idx]);

                Type type = model.GetType();
                FieldInfo field = type.GetField("handle", BindingFlags.NonPublic | BindingFlags.Instance);
                IntPtr handle = ((HandleRef)field.GetValue(model)).Handle;

                if (handle == IntPtr.Zero)
                {
                    MessageBox.Show("Model cannot be loaded! Check whether it exists.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
            }
            else
            {
                MessageBox.Show("Internal Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        public int getSampleRate(int idx)
        {
            switch (idx)
            {
                case 0:
                    return 16000;
                case 1:
                    return 24000;
                case 2:
                    return 32000;
                case 3:
                default:
                    return 44100;
                case 4:
                    return 48000;
            }
        }
        private void ProcessHoverBox(string sub)
        {
            int wordCount = sub.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

            if (wordCount < 15 && _frmSubtitle != null)
                _frmSubtitle.BeginInvoke(new Action<string, string>((line1, line2) => _frmSubtitle.UpdateSub(line1, line2)), sub, "");
            else if (_frmSubtitle != null)
            {
                string[] words = sub.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstPart = string.Join(' ', words, 0, 15);
                string secondPart = string.Join(' ', words, 15, Math.Min(wordCount - 15, 15));

                if (wordCount > 30)
                {
                    words = words.Skip(Math.Max(0, wordCount - 30)).Take(30).ToArray();
                    firstPart = string.Join(' ', words, 0, Math.Min(words.Length, 20));
                    secondPart = string.Join(' ', words, Math.Min(words.Length, 20), Math.Max(0, words.Length - 20));
                }

                _frmSubtitle.BeginInvoke(new Action<string, string>((line1, line2) => _frmSubtitle.UpdateSub(line1, line2)), firstPart, secondPart);
            }
        }

        public void HandleResult(string res, bool pa)
        {
            var resObject = JsonConvert.DeserializeObject<Result>(res);
            if (resObject == null) return;

            if (pa && resObject.partial.Length > 0)
            {
                tbRealtime.Text = resObject.partial;
                ProcessHoverBox(resObject.partial);
            }
            else if (!pa && resObject.text.Length > 0)
            {
                tbFinalText.Text += $"{resObject.text}\r\n\r\n";
                tbStats.Clear();
                foreach (Result.Words w in resObject.result ?? Enumerable.Empty<Result.Words>())
                    tbStats.Text += $"Duration of {w.word}: {(w.end - w.start)}s, Confidence: {(w.conf * 100.0f):N2}%\r\n";
            }
        }

        private void PerformLongRunningTask(object sender, DoWorkEventArgs e)
        {
            parado = false;
            waveIn = getInstance();

            using (waveIn)
            {
                Invoke((MethodInvoker)delegate
                {
                    waveIn.WaveFormat = new WaveFormat(getSampleRate(comboSmpR.SelectedIndex), 1);
                });

                var rec = new VoskRecognizer(model, waveIn.WaveFormat.SampleRate);
                rec.SetMaxAlternatives(0);
                rec.SetWords(true);

                waveIn.DataAvailable += (_, e) =>
                {
                    if (rec.AcceptWaveform(e.Buffer, e.BytesRecorded))
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            HandleResult(rec.Result(), false);
                        });
                    }
                    else
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            HandleResult(rec.PartialResult(), true);
                        });
                    }
                };
                waveIn.StartRecording();
                while (true)
                { // keep running in order to listen the DataAvailable event
                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                waveIn.StopRecording();
                parado = true;
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Worker exception:" + e.Error.ToString());
            }
        }

        private void btnStartRecog_Click(object sender, EventArgs e)
        {
            btnStopRecog.Enabled = true;
            btnStartRecog.Enabled = false;
            comboLang.Enabled = false;
            comboSmpR.Enabled = false;
            rbLoop.Enabled = false;
            rbMic.Enabled = false;
            bw = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            bw.DoWork += PerformLongRunningTask;
            bw.RunWorkerCompleted += RunWorkerCompleted;

            bw.RunWorkerAsync();
        }

        private void btnStopRecog_Click(object sender, EventArgs e)
        {
            btnStopRecog.Enabled = false;
            btnStartRecog.Enabled = true;
            comboLang.Enabled = true;
            comboSmpR.Enabled = true;
            rbLoop.Enabled = true;
            rbMic.Enabled = true;
            _frmSubtitle?.Hide();
            bw.CancelAsync();
        }

        private void comboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadModel(comboLang.SelectedIndex);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnStopRecog.Enabled = false;
            btnStartRecog.Enabled = true;
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if(!parado)
            {
                e.Cancel = true;
                MessageBox.Show("Please stop recognition thread before exiting!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbSub_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSub.Checked)
            {
                var f = (Form)Control.FromHandle(Handle);
                f.Invoke(new Action(() =>
                {
                    _frmSubtitle?.Dispose();
                    _frmSubtitle = new FrmSubtitle(_settings);
                    _frmSubtitle.Show();
                }));
            } else
            {
                _frmSubtitle?.Hide();
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            dlgFont.Font = _font;
            var res = dlgFont.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Yes)
            {
                var font = dlgFont.Font;
                // Force point unit
                _font = new Font(font.FontFamily, font.Size, font.Style, GraphicsUnit.Point, font.GdiCharSet);
            }
        }

        private void btnColors_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            _colorDialog.Color = button.BackColor;
            var res = _colorDialog.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Yes)
                button.BackColor = _colorDialog.Color;
        }

        private void checkBoxPreserveSlash_CheckedChanged(object sender, EventArgs e)
        {
            _settings.PreserveSlash = checkBoxPreserveSlash.Checked;
        }

        private void btn_applySubSettings_Click(object sender, EventArgs e)
        {
            _settings.Font = FontSerializationHelper.Serialize(_font);
            _settings.Color1 = btnColor1.BackColor;
            _settings.Color2 = btnColor2.BackColor;
            _settings.BorderColor = btnBorderColor.BackColor;
            _settings.GradientType = cbxGradientType.SelectedIndex;
            _settings.PreserveSlash = checkBoxPreserveSlash.Checked;
            _frmSubtitle?.UpdateFromSettings(_settings);
        }
    }
}