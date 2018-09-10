using System;
using System.ComponentModel;
using System.Windows;

namespace Colorize
{
    public class Property : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        internal void UpdateProperty(DependencyProperty property, object value)
        {
            this.SetCurrentValue(property, value);
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property.Name));
        }

        internal static DependencyProperty RegisterProperty<T>(string name, T defaultValue, Type registrar)
        {
            return DependencyProperty.Register(name, typeof(T), registrar, new UIPropertyMetadata(defaultValue));
        }
    }
}
