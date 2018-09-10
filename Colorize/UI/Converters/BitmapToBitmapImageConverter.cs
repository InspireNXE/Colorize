using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Colorize.UI.Converters
{
    internal class BitmapToBitmapImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            if (!(value is Bitmap bitmap)) throw new ArgumentException("Attempted to convert an object that was not a System.Drawing.Bitmap.");
            using (var memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                var bmImage = new BitmapImage();
                bmImage.BeginInit();
                bmImage.StreamSource = memory;
                bmImage.CacheOption = BitmapCacheOption.OnLoad;
                bmImage.EndInit();

                return bmImage;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}