using System;
using System.Windows.Forms;

namespace Colorize
{
    static class Program
    {
        public const string Organization = "https://github.com/InspireNXE";
        public const string Repo = Organization + "/Colorize";
        public const string Issues = Repo + "issues";
        public const string Releases = Repo + "releases";
        public const string Donate = "https://www.paypal.me/sdowner";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
