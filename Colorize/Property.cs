using System.ComponentModel;
using System.Windows;
using Colorize.UI.Pages;

namespace Colorize
{
    internal class Property : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        internal void UpdateProperty(DependencyProperty property, object value)
        {
            this.SetCurrentValue(property, value);
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property.Name));
        }

        internal static DependencyProperty RegisterProperty<T>(string name)
        {
            return DependencyProperty.Register(name, typeof(T), typeof(MainPage));
        }

        internal static DependencyProperty RegisterProperty<T>(string name, T defaultValue)
        {
            return DependencyProperty.Register(name, typeof(T), typeof(MainPage), new UIPropertyMetadata(defaultValue));
        }
    }
}
