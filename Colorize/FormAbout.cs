using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Colorize
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            LblName.Text = Application.ProductName;

            var versionSegments = Application.ProductVersion.Split('.');
            LblVersion.Text = $"v{versionSegments[0]}.{versionSegments[1]}.{versionSegments[2]}";
            TBLicense.Text = Properties.Resources.LICENSE;
            TBLicense.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void PBLogo_Click(object sender, System.EventArgs e)
        {
            Process.Start(Program.Organization);
        }

        private void TBLicense_Enter(object sender, System.EventArgs e)
        {
            LblName.Focus();
        }
    }
}
