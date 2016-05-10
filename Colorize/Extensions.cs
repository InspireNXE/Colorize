using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Colorize
{
    public static class Extensions
    {
        #region "String"
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
        }
        #endregion

        #region "TextBoxBase"
        public static bool IsEmpty(this TextBoxBase control)
        {
            return control.Text.IsEmpty();
        }

        public static bool AreEmpty(params TextBoxBase[] controls)
        {
            return controls.Any(control => control.Text.IsEmpty());
        }

        public static void SetTextIfNotFocused(this TextBoxBase control, string value)
        {
            if (!control.Focused)
            {
                control.Text = value;
            }
        }

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

        #region "Color"
        public static string ToHex(this Color color, string id)
        {
            return
                id +
                $"{(color.R.ToString("X").Length == 1 ? $"0{color.R.ToString("X")}" : color.R.ToString("X"))}" +
                $"{(color.G.ToString("X").Length == 1 ? $"0{color.G.ToString("X")}" : color.G.ToString("X"))}" + 
                $"{(color.B.ToString("X").Length == 1 ? $"0{color.B.ToString("X")}" : color.B.ToString("X"))}";
        }

        public static int ToInt(this Color color)
        {
            var tempColor = Color.FromArgb(255, color.R, color.G, color.B);
            return tempColor.ToArgb();
        }
        #endregion
    }
}