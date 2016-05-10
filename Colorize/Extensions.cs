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
            return control == null || control.Text.IsEmpty();
        }

        public static bool AreEmpty(params TextBoxBase[] controls)
        {
            return controls.Any(control => control == null || control.Text.IsEmpty());
        }

        public static void SetTextIfNotFocused(this TextBoxBase control, string value)
        {
            if (!control.Focused)
            {
                control.Text = value;
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