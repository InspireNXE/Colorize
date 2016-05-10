using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Colorize
{
    public class Utils
    {

        #region "TextChangedHandlers"
        public static void AddTextChangedHandlers(EventHandler value, params Control[] controls)
        {
            SetTextChangedHandlers(value, true, controls);
        }

        public static void RemoveTextChangedHandlers(EventHandler value, params Control[] controls)
        {
            SetTextChangedHandlers(value, false, controls);
        }

        public static void SetTextChangedHandlers(EventHandler value, bool add, params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (add)
                {
                    control.TextChanged += value;
                }
                else
                {
                    control.TextChanged -= value;
                }
            }
        }
        #endregion

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        public static Color GetPixelColor(int x, int y)
        {
            var hdc = GetDC(IntPtr.Zero);
            var pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            var color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
    }
}