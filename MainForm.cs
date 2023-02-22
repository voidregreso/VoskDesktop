using NAudio.Wave;
using NAudio.CoreAudioApi;
using Vosk;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Reflection;
using System.ComponentModel;

namespace RecogUI
{
    public partial class MainForm : Form
    {

        private Model? model = null;
        private bool parado = false;
        private static BackgroundWorker bw;
        private WasapiCapture waveIn;

        /*[DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        public static extern void FreeConsole();*/

        public void LoadModel(int idx)
        {
            string cpath = Directory.GetCurrentDirectory() + "\\";
            switch (idx)
            {
                case 0:
                    model = new Model(cpath + "model-small-en");
                    break;
                case 1:
                    model = new Model(cpath + "model-small-fr");
                    break;
                case 2:
                    model = new Model(cpath + "model-small-es");
                    break;
                case 3:
                    model = new Model(cpath + "model-small-pt");
                    break;
                case 4:
                    model = new Model(cpath + "model-small-it");
                    break;
                case 5:
                    model = new Model(cpath + "model-small-de");
                    break;
                default:
                    break;
            }
            if (model != null)
            {
                Type type = model.GetType();
                FieldInfo? field = type.GetField("handle", BindingFlags.NonPublic | BindingFlags.Instance);
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
            switch(idx)
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

        public void HandleResult(string res, bool pa)
        {
            var resObject = JsonConvert.DeserializeObject<Result>(res);
            if (resObject != null) {
                if (pa)
                {
                    if (resObject.partial.Length > 0) tbRealtime.Text = resObject.partial;
                }
                else
                {
                    if (resObject.text.Length > 0) tbFinalText.Text += (resObject.text + "\r\n\r\n");
                    if (resObject.result != null)
                    {
                        tbStats.Clear();
                        foreach (Result.Words w in resObject.result)
                        {
                            tbStats.Text += ("Duration of " + w.word + ": " + (w.end - w.start) + "s, Confidence: " + (w.conf * 100.0f) + "%\r\n");
                        }
                    }
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            comboLang.SelectedIndex = 2;
            comboSmpR.SelectedIndex = 3;
            rbLoop.Checked = true;
            LoadModel(comboLang.SelectedIndex);
        }

        private WasapiCapture getInstance()
        {
            if (rbLoop.Checked) return new WasapiLoopbackCapture();
            else return new WasapiCapture();
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
            bw.CancelAsync();
        }

        private void comboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadModel(comboLang.SelectedIndex);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //AllocConsole();
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
    }
}