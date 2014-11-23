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
                    Populate(Color.FromArgb((int) NUDInputIntAlpha.Value, (int) NUDInputIntRed.Value, (int) NUDInputIntGreen.Value, (int) NUDInputIntBlue.Value));
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
                        var alpha = float.Parse(TBInputFloatAlpha.Text);
                        var red = float.Parse(TBInputFloatRed.Text);
                        var green = float.Parse(TBInputFloatGreen.Text);
                        var blue = float.Parse(TBInputFloatBlue.Text);

                        Populate(Color.FromArgb((int)(alpha * 255f), (int)(red * 255f), (int)(green * 255f), (int)(blue * 255f)));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Float values must be between 0 and 1!");
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
                        MessageBox.Show("Please enter a valid Hex value");
                    }
                    break;
                case 3: // UInt
                    if (string.IsNullOrEmpty(TBInputUInt.Text) || string.IsNullOrWhiteSpace(TBInputUInt.Text))
                    {
                        return;
                    }

                    try
                    {
                        Populate(ColorTranslator.FromWin32(int.Parse(TBInputUInt.Text)));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("UInt value must be between either " + uint.MinValue + " and " + uint.MaxValue + " or " + int.MinValue + " and " + int.MaxValue);
                    }
                    break;
            }
        }

        private void Populate(Color color)
        {
            PictureBoxColor.BackColor = color;

            // Int Output
            TBOutputIntAlpha.Text = color.A.ToString();
            TBOutputIntRed.Text = color.R.ToString();
            TBOutputIntGreen.Text = color.G.ToString();
            TBOutputIntBlue.Text = color.B.ToString();

            // Float Output
            TBOutputFloatAlpha.Text = (color.A / 255f).ToString();
            TBOutputFloatRed.Text = (color.R / 255f).ToString();
            TBOutputFloatGreen.Text = (color.G / 255f).ToString();
            TBOutputFloatBlue.Text = (color.B / 255f).ToString();

            // Hex Output
            TBOutputHex.Text = ColorTranslator.ToHtml(color);

            // UInt Output
            TBOutputUInt.Text = ColorTranslator.ToWin32(color).ToString();
        }

        private void PictureBoxColor_MouseHover(object sender, EventArgs e)
        {
            colorToolTip.RemoveAll();
            colorToolTip.Show(string.Format("Alpha: {0}\nRed: {1}\nGreen: {2}\nBlue: {3}\nUInt: {4}\nHex: {5}",
                                              PictureBoxColor.BackColor.A,
                                              PictureBoxColor.BackColor.R,
                                              PictureBoxColor.BackColor.G,
                                              PictureBoxColor.BackColor.B,
                                              ColorTranslator.ToWin32(PictureBoxColor.BackColor),
                                              ColorTranslator.ToHtml(PictureBoxColor.BackColor)), PictureBoxColor);
        }
    }
}
