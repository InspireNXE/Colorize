using System;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Windows.Media;
using Gma.System.MouseKeyHook;

namespace Colorize
{
    internal static class PickerUtil
    {
        public static bool IsPicking { get; set; }

        public static Color? LastPickedColor { get; set; }

        private static Action _onClick, _onMove;

        #region Tracking
        private static IKeyboardMouseEvents _globalMouseHook;

        internal static void StartTracking(Action onClick, Action onMove)
        {
            if (IsPicking) return;

            // Assign actions
            _onClick = onClick;
            _onMove = onMove;

            // Mark us as picking
            IsPicking = true;

            // Set hook
            _globalMouseHook = Hook.GlobalEvents();

            // Assign event
            _globalMouseHook.MouseDown += _globalMouseHook_OnMouseDown;
            _globalMouseHook.MouseMove += _globalMouseHook_OnMouseMove;

            // Override cursor
            Mouse.OverrideCursor = Cursors.Cross;
        }

        internal static void StopTracking()
        {
            if (!IsPicking) return;

            // Mark us as not picking
            IsPicking = false;

            // Un-assign event
            _globalMouseHook.MouseDown -= _globalMouseHook_OnMouseDown;
            _globalMouseHook.MouseMove -= _globalMouseHook_OnMouseMove;

            // Dispose of hook
            _globalMouseHook.Dispose();

            // Reset override on cursor
            Mouse.OverrideCursor = null;
        }

        private static void _globalMouseHook_OnMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Get the color at the mouse position
            var (red, green, blue) = GetPixelArgb(e.X, e.Y);
            LastPickedColor = Color.FromArgb(255, red, green, blue);

            // Invoke our click action if present
            _onClick?.Invoke();

            // Stop tracking the mouse
            StopTracking();
        }

        private static void _globalMouseHook_OnMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Invoke our move action is present
            _onMove?.Invoke();
        }
        #endregion

        #region Pixel Color
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        /// <summary>
        /// Gets the RGB of the pixel at the specified x and y on screen
        /// </summary>
        /// <param name="x">The x</param>
        /// <param name="y">The y</param>
        /// <returns>The RGB values</returns>
        internal static (byte red, byte green, byte blue) GetPixelArgb(int x, int y)
        {
            var hdc = GetDC(IntPtr.Zero);

            // Get the pixel at the specified x and y
            var pixel = GetPixel(hdc, x, y);

            ReleaseDC(IntPtr.Zero, hdc);

            return (red: (byte) (pixel & 0x000000FF),
                  green: (byte) ((pixel & 0x0000FF00) >> 8),
                   blue: (byte) ((pixel & 0x00FF0000) >> 16));
        }
        #endregion
    }
}
