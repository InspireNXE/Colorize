using System;
using System.Drawing;
using System.Windows;
using Color = System.Windows.Media.Color;
using Point = System.Windows.Point;

namespace Colorize.UI.Models
{
    public class PickerViewModel : Property
    {
        internal static DependencyProperty PickedColorProperty = RegisterProperty(nameof(PickedColor), Color.FromArgb(0, 0, 0, 0), typeof(PickerViewModel));
        public Color PickedColor
        {
            get => (Color) this.GetValue(PickedColorProperty);
            set => UpdateProperty(PickedColorProperty, value);
        }

        internal static DependencyProperty HoveredColorProperty = RegisterProperty(nameof(HoveredColor), Color.FromArgb(0, 0, 0, 0), typeof(PickerViewModel));
        public Color HoveredColor
        {
            get => (Color) this.GetValue(HoveredColorProperty);
            set => UpdateProperty(HoveredColorProperty, value);
        }

        internal static DependencyProperty CurrentBitmapProperty = RegisterProperty<Bitmap>(nameof(CurrentBitmap), null, typeof(PickerViewModel));
        public Bitmap CurrentBitmap
        {
            get => (Bitmap) this.GetValue(CurrentBitmapProperty);
            set => UpdateProperty(CurrentBitmapProperty, value);
        }

        internal static DependencyProperty ZoomFactorProperty = RegisterProperty(nameof(ZoomFactor), 0.0, typeof(PickerViewModel));
        public double ZoomFactor
        {
            get => (double) this.GetValue(ZoomFactorProperty);
            set => this.UpdateProperty(ZoomFactorProperty, value);
        }

        internal static Point GetCoordsAt(System.Windows.Controls.Image image, Point point)
        {
            // Convert from control position to image position
            var x = Math.Floor(point.X * image.Source.Width / image.ActualWidth);
            var y = Math.Floor(point.Y * image.Source.Height / image.ActualHeight);

            return new Point(x, y);
        }
    }
}
