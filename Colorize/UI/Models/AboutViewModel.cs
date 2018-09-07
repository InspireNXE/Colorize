using System.Reflection;
using System.Windows.Media;

namespace Colorize.UI.Models
{
    public class AboutViewModel
    {
        public string Name => Assembly.GetExecutingAssembly().GetName().Name;
        public string License => Properties.Resources.LICENSE;
        public string Version
        {
            get
            {
                var versionSegments = (Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "0.0.0").Split('.');
                return $"v{versionSegments[0]}.{versionSegments[1]}.{versionSegments[2]}";
            }
        }
        public string Description => "Colorize is a simple and lightweight tool aimed to take one color format and convert it to another.";
        public ImageSource Logo => Properties.Resources.logo_120x120.AsImageSource();
    }
}