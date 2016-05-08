using System;
using System.Windows.Forms;

namespace Colorize
{
    static class Program
    {
        public const string Repo = "https://github.com/InspireNXE/Colorize/";
        public const string Issues = Repo + "issues";
        public const string Donate = "https://www.paypal.me/sdowner";
        public const string Releases = Repo + "releases";

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
