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
        }
    }
}
