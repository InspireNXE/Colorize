using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Colorize
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void RGB_Int_TextChanged(object sender, EventArgs e)
        {
            if (Extensions.AreEmpty(TB_Int_A, TB_Int_R, TB_Int_G, TB_Int_B))
            {
                return;
            }

            int a;
            int r;
            int g;
            int b;

            try
            {
                a = int.Parse(TB_Int_A.Text);
                r = int.Parse(TB_Int_R.Text);
                g = int.Parse(TB_Int_G.Text);
                b = int.Parse(TB_Int_B.Text);
            }
            catch (FormatException)
            {
                return;
            }


            try
            {
                Populate(RGB_Int_TextChanged, Color.FromArgb(a, r, g, b));
            }
            catch (ArgumentException)
            {
            }
        }

        private void RGB_Float_TextChanged(object sender, EventArgs e)
        {
            if (Extensions.AreEmpty(TB_Float_A, TB_Float_R, TB_Float_G, TB_Float_B))
            {
                return;
            }

            int a;
            int r;
            int g;
            int b;

            try
            {
                a = (int)(float.Parse(TB_Float_A.Text) * 255f);
                r = (int)(float.Parse(TB_Float_R.Text) * 255f);
                g = (int)(float.Parse(TB_Float_G.Text) * 255f);
                b = (int)(float.Parse(TB_Float_B.Text) * 255f);
            }
            catch (FormatException)
            {
                return;
            }


            try
            {
                Populate(RGB_Float_TextChanged, Color.FromArgb(a, r, g, b));
            }
            catch (ArgumentException)
            {
                // ignored
            }
        }

        private void HEX_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null || textBox.IsEmpty())
            {
                return;
            }

            var id = sender == TB_PROG ? "0x" : "#";
            try
            {
                Populate(HEX_TextChanged, ColorTranslator.FromHtml((textBox.Text.StartsWith(id) ? string.Empty : id) + textBox.Text));
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void Int_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null || textBox.IsEmpty() || textBox.Text.Equals("-"))
            {
                return;
            }
            try
            {
                Populate(Int_TextChanged, Color.FromArgb(Convert.ToInt32(textBox.Text)));
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void PBCurrentColor_Click(object sender, EventArgs e)
        {
            CDCustomColor.FullOpen = true;
            if (CDCustomColor.ShowDialog(this) == DialogResult.OK)
            {
                Populate(PBCurrentColor_Click, CDCustomColor.Color);
            }
        }

        private void TB_Leave(object sender, EventArgs e)
        {
            if (sender is TextBoxBase)
            {
                var control = (TextBoxBase)sender;
                var value = "0";
                if (control.Text.IsEmpty())
                {
                    if (control == TB_HEX)
                    {
                        value = @"#000000";
                    }
                    else if (control == TB_Int_A)
                    {
                        value = @"255";
                    }
                    else if (control == TB_PROG)
                    {
                        value = @"0x000000";
                    }
                    else if (control == TB_Float_A)
                    {
                        value = @"1";
                    }
                    control.Text = value;
                }
            }
        }

        private void TSMI_File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_Help_Source_Click(object sender, EventArgs e)
        {
            Process.Start(Program.Repo);
        }

        private void TSMI_Help_Issues_Click(object sender, EventArgs e)
        {
            Process.Start(Program.Issues);
        }

        private void TSMI_Help_Donate_Click(object sender, EventArgs e)
        {
            Process.Start(Program.Donate);
        }

        private void TSMI_Help_Releases_Click(object sender, EventArgs e)
        {
            Process.Start(Program.Releases);
        }

        private void TSMI_Help_About_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog(this);
        }

        private void Populate(EventHandler handler, Color color)
        {
            if (handler == HEX_TextChanged || handler == Int_TextChanged)
            {
                color = Color.FromArgb(255, color.R, color.G, color.B);
            }

            PBCurrentColor.BackColor = color;

            // Remove TextChanged handlers to avoid stackoverflows
            Utils.RemoveTextChangedHandlers(RGB_Int_TextChanged, TB_Int_R, TB_Int_G, TB_Int_B, TB_Int_A);
            Utils.RemoveTextChangedHandlers(RGB_Float_TextChanged, TB_Float_R, TB_Float_G, TB_Float_B, TB_Float_A);
            Utils.RemoveTextChangedHandlers(HEX_TextChanged, TB_HEX);
            Utils.RemoveTextChangedHandlers(Int_TextChanged, TB_Int);
            Utils.RemoveTextChangedHandlers(HEX_TextChanged, TB_PROG);

            // Populate Int RGBA textboxes
            TB_Int_R.SetTextIfNotFocused(color.R.ToString());
            TB_Int_G.SetTextIfNotFocused(color.G.ToString());
            TB_Int_B.SetTextIfNotFocused(color.B.ToString());
            TB_Int_A.SetTextIfNotFocused(color.A.ToString());

            // Populate Float RGBA textboxes
            TB_Float_R.SetTextIfNotFocused((color.R / 255f).ToString(CultureInfo.InvariantCulture));
            TB_Float_G.SetTextIfNotFocused((color.G / 255f).ToString(CultureInfo.InvariantCulture));
            TB_Float_B.SetTextIfNotFocused((color.B / 255f).ToString(CultureInfo.InvariantCulture));
            TB_Float_A.SetTextIfNotFocused((color.A / 255f).ToString(CultureInfo.InvariantCulture));

            // Populate HEX textbox
            TB_HEX.SetTextIfNotFocused(color.ToHex("#"));

            // Populate Int textbox
            TB_Int.SetTextIfNotFocused(color.ToInt().ToString());

            // Populate PROG textbox
            TB_PROG.SetTextIfNotFocused(color.ToHex("0x"));

            // Populate CDCustomColor
            CDCustomColor.Color = color;

            // Add TextChanged handlers now that we're finished
            Utils.AddTextChangedHandlers(RGB_Int_TextChanged, TB_Int_R, TB_Int_G, TB_Int_B, TB_Int_A);
            Utils.AddTextChangedHandlers(RGB_Float_TextChanged, TB_Float_R, TB_Float_G, TB_Float_B, TB_Float_A);
            Utils.AddTextChangedHandlers(HEX_TextChanged, TB_HEX);
            Utils.AddTextChangedHandlers(Int_TextChanged, TB_Int);
            Utils.AddTextChangedHandlers(HEX_TextChanged, TB_PROG);
        }

        private void PBCurrentColor_MouseEnter(object sender, EventArgs e)
        {
            TTColorDialog.Show("Click to show a color picker", PBCurrentColor);
        }

        private void PBCurrentColor_MouseLeave(object sender, EventArgs e)
        {
            TTColorDialog.Hide(PBCurrentColor);
        }
    }
}
