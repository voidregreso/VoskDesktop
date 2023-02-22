using System;
using System.Windows.Forms;

namespace RecogUI
{
    public partial class FrmSubtitle : Form
    {
        private SettingsObj _settings;
        public FrmSubtitle(SettingsObj settings)
        {
            _settings = settings;
            InitializeComponent();
        }
        
        private void FrmSubtitle_Load(object sender, EventArgs e)
        {
            var scrBounds = Screen.PrimaryScreen.Bounds;
            SubRenderer.SetDpi(DeviceDpi);
            Width = scrBounds.Width;
            Height = 150;
            if (_settings.PosY < 0)
            {
                Top = scrBounds.Height - Height - 150;
                Left = 0;
            }
            else
            {
                Top = _settings.PosY;
                Left = _settings.PosX;
            }

            TopMost = true;

            UnmanagedHelper.SetTopMost(this);
            UpdateFromSettings(_settings);

            Move += (o, args) =>
            {
                _settings.PosX = Left;
                _settings.PosY = Top;
            };
            FormClosing += (o, args) =>
            {
                if (args.CloseReason == CloseReason.UserClosing)
                    args.Cancel = true;
            };
        }
        
        public void UpdateFromSettings(SettingsObj settings)
        {
            _settings = settings;
            SubRenderer.UpdateFromSettings(settings, Width);

            Redraw();
        }

        private void Redraw()
        {
            if (_line1 == null)
            {
                Clear();
                return;
            }

            if (_line2 == null)
            {
                DrawSub1Line(_line1);
                return;
            }
            DrawSub2Line(_line1, _line2);
        }

        public void Clear()
        {
            if (_line1 != "")
                DrawSub1Line("");
            _line1 = "";
        }

        private string _line1, _line2;
        public void UpdateSub(string line1, string line2)
        {
            _line1 = line1;
            _line2 = line2;
            Redraw();
        }

        public void DrawSub1Line(string subtitles)
        {
            using (var g = CreateGraphics())
            {
                var bitmap = SubRenderer.Render1LineSub(subtitles, g);

                if (bitmap == null)
                    return;

                using (bitmap)
                {
                    if (Width != bitmap.Width) Width = bitmap.Width;
                    if (Height != bitmap.Height) Height = bitmap.Height;

                    GdiplusHelper.SetBitmap(bitmap, 255, Handle, Left, Top, Width, Height);
                }
            }
        }

        public void DrawSub2Line(string line1, string line2)
        {
            using (var g = CreateGraphics())
            {
                var bitmap = SubRenderer.Render2LineSub(line1, line2, g);

                if (bitmap == null) return;

                using (bitmap)
                {
                    if (Width != bitmap.Width) Width = bitmap.Width;
                    if (Height != bitmap.Height) Height = bitmap.Height;

                    GdiplusHelper.SetBitmap(bitmap, 255, Handle, Left, Top, Width, Height);
                }
            }
        }

        private void FrmSubtitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (Visible)
            {
                Unmanaged.ReleaseCapture();
                if (e.Button != MouseButtons.Left) return;
                Unmanaged.SendMessage(Handle, 0x00A1, new IntPtr(0x0002), null);
            }
        }

        private void FrmSubtitle_MouseUp(object sender, MouseEventArgs e)
        {
            /*if (e.Button != MouseButtons.Left) return;
            global::Unmanaged.SendMessage(Handle, 0x00A2, new IntPtr(0x0002), null);*/
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x00080000; // This form has to have the WS_EX_LAYERED extended style
                cp.ExStyle |= 0x00000080;
                return cp;
            }
        }
    }
}
