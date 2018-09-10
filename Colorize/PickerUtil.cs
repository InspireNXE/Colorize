using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Color = System.Windows.Media.Color;
using Point = System.Windows.Point;

namespace Colorize
{
    public static class PickerUtil
    {
        #region Capture Screen
        internal static Bitmap CaptureScreen()
        {
            // Capture bitmap of virtual screen to use as a cache
            var left = SystemInformation.VirtualScreen.Left;
            var top = SystemInformation.VirtualScreen.Top;
            var width = SystemInformation.VirtualScreen.Width;
            var height = SystemInformation.VirtualScreen.Height;

            var bitmap = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(left, top, 0, 0, bitmap.Size);
            }

            return bitmap;
        }
        #endregion

        #region Get Pixel Color
        internal static Color GetColorAt(Bitmap bitmap, Point point)
        {
            return GetColorAt(bitmap, (int) point.X, (int) point.Y);
        }

        internal static unsafe Color GetColorAt(Bitmap bitmap, int xPos, int yPos)
        {
            var rgb = new byte[] {0, 0, 0};

            // Lock bits
            try
            {
                var data = bitmap.LockBits(new Rectangle(xPos, yPos, 1, 1), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                var pt = (byte*)data.Scan0;
                var bpp = data.Stride / bitmap.Width;

                for (var y = 0; y < data.Height; y++)
                {
                    var row = pt + y * data.Stride;

                    for (var x = 0; x < data.Width; x++)
                    {
                        var pixel = row + x * bpp;
                        // Order: Blue -> Green -> Red -> Alpha (skipped)
                        for (var bit = 0; bit < bpp - 1; bit++)
                        {
                            rgb[bit] = pixel[bit];
                        }
                    }
                }
                bitmap.UnlockBits(data);
            }
            catch (ArgumentException) { }

            return Color.FromArgb(255, rgb[2], rgb[1], rgb[0]);
        }
        #endregion
    }
}
