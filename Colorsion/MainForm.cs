using System;
using System.Drawing;
using System.Windows.Forms;

namespace Colorsion
{
    public partial class MainForm : Form
    {
        private static readonly ToolTip colorToolTip = new ToolTip();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            switch (tabControlInput.SelectedIndex)
            {
                case 0: // RGBA
                    Populate(Color.FromArgb((int) NUDInputRGBAAlpha.Value, (int) NUDInputRGBARed.Value, (int) NUDInputRGBAGreen.Value, (int) NUDInputRGBABlue.Value));
                    break;
                case 1: // Float
                    if (string.IsNullOrEmpty(TBInputFloatAlpha.Text) || string.IsNullOrWhiteSpace(TBInputFloatAlpha.Text)
                        || string.IsNullOrEmpty(TBInputFloatRed.Text) || string.IsNullOrWhiteSpace(TBInputFloatRed.Text)
                        || string.IsNullOrEmpty(TBInputFloatGreen.Text) || string.IsNullOrWhiteSpace(TBInputFloatGreen.Text)
                        || string.IsNullOrEmpty(TBInputFloatBlue.Text) || string.IsNullOrWhiteSpace(TBInputFloatBlue.Text))
                    {
                        return;
                    }

                    try
                    {
                        var a = float.Parse(TBInputFloatAlpha.Text);
                        var r = float.Parse(TBInputFloatRed.Text);
                        var g = float.Parse(TBInputFloatGreen.Text);
                        var b = float.Parse(TBInputFloatBlue.Text);

                        Populate(Color.FromArgb((int)(a * 255f), (int)(r * 255f), (int)(g * 255f), (int)(b * 255f)));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Values must be between 0 and 1!");
                    }
                    break;
                case 2: // Hex
                    if (string.IsNullOrEmpty(TBInputHex.Text) || string.IsNullOrWhiteSpace(TBInputHex.Text))
                    {
                        return;
                    }

                    try
                    {
                        // Ensure that we pass in a # to the translator
                        Populate(ColorTranslator.FromHtml((TBInputHex.Text.StartsWith("#") ? "" : "#") + TBInputHex.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid Hex value!");
                    }
                    break;
                case 3: // Int
                    if (string.IsNullOrEmpty(TBInputInt.Text) || string.IsNullOrWhiteSpace(TBInputInt.Text))
                    {
                        return;
                    }

                    try
                    {
                        var value = int.Parse(TBInputInt.Text);
                        Populate(Color.FromArgb(value));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Value must be between " + int.MinValue + " and " + int.MaxValue);
                    }
                    break;
            }
        }

        private void Populate(Color color)
        {
            PictureBoxColor.BackColor = color;

            // RGBA Output
            TBOutputRGBAAlpha.Text = color.A.ToString();
            TBOutputRGBARed.Text = color.R.ToString();
            TBOutputRGBAGreen.Text = color.G.ToString();
            TBOutputRGBABlue.Text = color.B.ToString();

            // Float Output
            TBOutputFloatAlpha.Text = (color.A / 255f).ToString();
            TBOutputFloatRed.Text = (color.R / 255f).ToString();
            TBOutputFloatGreen.Text = (color.G / 255f).ToString();
            TBOutputFloatBlue.Text = (color.B / 255f).ToString();

            // Hex Output
            TBOutputHex.Text = ToHex(color);

            // Int Output
            TBOutputInt.Text = ToInt(color).ToString();
        }

        private void PictureBoxColor_MouseHover(object sender, EventArgs e)
        {
            colorToolTip.RemoveAll();
            colorToolTip.Show(string.Format("Alpha: {0}\nRed: {1}\nGreen: {2}\nBlue: {3}\nHex: {4}\nInt: {5}",
                                              PictureBoxColor.BackColor.A,
                                              PictureBoxColor.BackColor.R,
                                              PictureBoxColor.BackColor.G,
                                              PictureBoxColor.BackColor.B,
                                              ToHex(PictureBoxColor.BackColor),
                                              ToInt(PictureBoxColor.BackColor)), PictureBoxColor);
        }

        private static string ToHex(Color color)
        {
            return string.Format("#{0}{1}{2}{3}",
                color.A.ToString("X").Length == 1 ? string.Format("0{0}", color.A.ToString("X")) : color.A.ToString("X"),
                color.R.ToString("X").Length == 1 ? string.Format("0{0}", color.R.ToString("X")) : color.R.ToString("X"),
                color.G.ToString("X").Length == 1 ? string.Format("0{0}", color.G.ToString("X")) : color.G.ToString("X"),
                color.B.ToString("X").Length == 1 ? string.Format("0{0}", color.B.ToString("X")) : color.B.ToString("X"));
        }

        private static int ToInt(Color color)
        {
            return Convert.ToInt32(color.ToArgb());
        }
    }
}
