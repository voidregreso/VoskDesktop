using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace RecogUI
{
    public static class GdiplusHelper
    {

        public const int ULW_COLORKEY = 0x00000001;
        public const int ULW_ALPHA = 0x00000002;
        public const int ULW_OPAQUE = 0x00000004;

        public const byte AC_SRC_OVER = 0x00;
        public const byte AC_SRC_ALPHA = 0x01;


        [StructLayout(LayoutKind.Sequential)]
        public struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y) { this.x = x; this.y = y; }
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct Size
        {
            public int cx;
            public int cy;
            public Size(int cx, int cy) { this.cx = cx; this.cy = cy; }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern Bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pprSrc, Int32 crKey, ref BLENDFUNCTION pblend, Int32 dwFlags);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern Bool DeleteDC(IntPtr hdc);

        [DllImport("gdi32.dll", ExactSpelling = true)]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern Bool DeleteObject(IntPtr hObject);

        public static void SetBitmap(Bitmap bitmap, byte opacity, IntPtr handle, int left, int top, int width, int height)
        {
            if (bitmap.PixelFormat != PixelFormat.Format32bppArgb) return;

            var screenDc = GetDC(IntPtr.Zero);
            var memDc = CreateCompatibleDC(screenDc);
            var oldBitmap = IntPtr.Zero;
            var hBitmap = IntPtr.Zero;

            try
            {
                hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                oldBitmap = SelectObject(memDc, hBitmap);

                var size = new Size(width, height);
                var pointSource = new Point(0, 0);
                var topPos = new Point(left, top);
                var blend = new BLENDFUNCTION
                {
                    BlendOp = AC_SRC_OVER,
                    BlendFlags = 0,
                    SourceConstantAlpha = opacity,
                    AlphaFormat = AC_SRC_ALPHA
                };

                UpdateLayeredWindow(
                    handle,
                    screenDc, 
                    ref topPos,
                    ref size, 
                    memDc, 
                    ref pointSource, 
                    0, 
                    ref blend, 
                    ULW_ALPHA);
            }
            finally
            {
                ReleaseDC(IntPtr.Zero, screenDc);
                if (hBitmap != IntPtr.Zero)
                {
                    DeleteObject(hBitmap);
                    SelectObject(memDc, oldBitmap);
                }
                DeleteDC(memDc);
            }
        }
    }

}
