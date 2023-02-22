using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace RecogUI
{
    public static class SubRenderer
    {
        private static readonly Brush ShadowBrush = new SolidBrush(Color.FromArgb(110, 0, 0, 0));
        private const int ShadowOffset = 2;
        public static readonly StringFormat Format = new StringFormat(StringFormatFlags.NoWrap)
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Near
        };

        private static Pen _borderPen;
        private static Font _mainFont, _subFont;
        private static Color _color1, _color2;
        private static GredientType _type;
        private static int _width = 1024;
        private static int _dpi = 72;

        // Use property instead of method to avoid thread safety issue
        public static SettingsObj Settings { get; set; }

        public static void SetDpi(int deviceDpi) => _dpi = deviceDpi;

        public static void UpdateFromSettings(SettingsObj settings, int width)
        {
            _mainFont = settings.FontActual;
            _subFont = new Font(_mainFont.FontFamily, _mainFont.Size * 0.8f, _mainFont.Style, _mainFont.Unit, _mainFont.GdiCharSet);
            _borderPen?.Dispose();
            _borderPen = new Pen(settings.BorderColor, 2f)
            {
                LineJoin = LineJoin.Round,
                EndCap = LineCap.Round,
                StartCap = LineCap.Round
            };
            _type = (GredientType)settings.GradientType;
            _color1 = settings.Color1;
            _color2 = settings.Color2;

            _width = width;
        }

        public static Bitmap Render1LineSub(string line1, IDeviceContext dc) => RenderSub(line1, _mainFont, dc);

        public static Bitmap Render2LineSub(string line1, string line2, IDeviceContext dc)
        {
            using (Bitmap line1Bitmap = RenderSub(line1, _mainFont, dc),
                   line2Bitmap = RenderSub(line2, _subFont, dc))
            {
                var bitmap = new Bitmap(Math.Max(line1Bitmap.Width, line2Bitmap.Width), line1Bitmap.Height + line2Bitmap.Height);
                using (var g = Graphics.FromImage(bitmap))
                {
                    g.DrawImage(line1Bitmap, new PointF(0, 0));
                    g.DrawImage(line2Bitmap, new PointF(0, line1Bitmap.Height * 0.9f));
                }
                return bitmap;
            }
        }

        public static Bitmap RenderSub(string lyric, Font font, IDeviceContext dc)
        {
            var fontBounds = TextRenderer.MeasureText(dc, lyric, font);
            var height = fontBounds.Height <= 0 ? 1 : fontBounds.Height;
            var bitmap = new Bitmap(_width, height);
            bitmap.SetResolution(_dpi, _dpi);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.High;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                g.CompositingQuality = CompositingQuality.HighQuality;

                var fontEmSize = font.SizeInPoints * _dpi / 72;

                var initialRect = new RectangleF(0, 0, _width, height);
                using (var stringPath = new GraphicsPath(FillMode.Alternate))
                {
                    stringPath.AddString(lyric, font.FontFamily, (int)font.Style, fontEmSize, initialRect, Format);

                    // Using matrix to translate the path
                    using (var mat = new Matrix())
                    {
                        mat.Translate(-ShadowOffset, -ShadowOffset);
                        stringPath.Transform(mat);

                        g.FillPath(ShadowBrush, stringPath);

                        mat.Translate(ShadowOffset * 2, ShadowOffset * 2);
                        stringPath.Transform(mat);
                    }

                    if (_borderPen != null)
                        g.DrawPath(_borderPen, stringPath);

                    using (var stringBrush = CreateGradientBrush(initialRect))
                        g.FillPath(stringBrush, stringPath);
                }
            }

            return bitmap;
        }

        private static Brush CreateGradientBrush(RectangleF dstRect)
        {
            switch (_type)
            {
                case GredientType.DoubleColor:
                    return new LinearGradientBrush(dstRect.Location, new PointF(dstRect.X, dstRect.Y + dstRect.Height), _color1, _color2)
                    {
                        WrapMode = WrapMode.TileFlipXY
                    };
                case GredientType.TripleColor:
                    return new LinearGradientBrush(dstRect.Location, new PointF(dstRect.X, dstRect.Y + dstRect.Height / 3 * 2), _color1, _color2)
                    {
                        WrapMode = WrapMode.TileFlipXY
                    };
                default:
                    return new SolidBrush(_color1);
            }
        }
    }
}
