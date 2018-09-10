using System.Windows;

namespace Colorize.UI.Models
{
    public class MainViewModel : Property
    {
        internal static DependencyProperty CurrentColorProperty = RegisterProperty<OmniColor>(nameof(CurrentColor), null, typeof(MainViewModel));
        public OmniColor CurrentColor
        {
            get => (OmniColor) this.GetValue(CurrentColorProperty);
            set => this.UpdateProperty(CurrentColorProperty, value);
        }
    }
}
