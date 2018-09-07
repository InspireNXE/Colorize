using System.Windows;

namespace Colorize.UI.Models
{
    internal class MainViewModel : Property
    {

        internal static DependencyProperty CurrentColorProperty = RegisterProperty<OmniColor>(nameof(CurrentColor));
        public OmniColor CurrentColor
        {
            get => (OmniColor) this.GetValue(CurrentColorProperty);
            set => this.UpdateProperty(CurrentColorProperty, value);
        }
    }
}
