using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Colorize.UI.Models;
using Color = System.Windows.Media.Color;
using Image = System.Windows.Controls.Image;
using MouseEventArgs = System.Windows.Input.MouseEventArgs;
using Point = System.Windows.Point;

namespace Colorize.UI.Windows
{
    public partial class PickerWindow : IModeled<PickerViewModel>
    {
        private Point _origin;
        private Point _start;

        public PickerWindow(Window owner, Bitmap bitmap)
        {
            InitializeComponent();

            this.Owner = owner;

            this.GetViewModel().CurrentBitmap = bitmap;

            var group = new TransformGroup();
            group.Children.Add(new ScaleTransform());

            var tt = new TranslateTransform();
            group.Children.Add(tt);

            CaptureImage.RenderTransform = group;
            CaptureImage.MouseWheel += CaptureImage_MouseWheel;
            CaptureImage.MouseLeftButtonDown += CaptureImage_MouseLeftButtonDown;
            CaptureImage.MouseLeftButtonUp += CaptureImage_MouseLeftButtonUp;
            CaptureImage.MouseMove += CaptureImage_MouseMove;

            this.GetViewModel().PropertyChanged += (s, e) =>
            {
                var model = this.GetViewModel();
                if (!nameof(model.ZoomFactor).Equals(e.PropertyName)) return;

                // Our scale is always 1 + ZOOM_FACTOR, min of 0, max of 15
                var scale = 1 + model.ZoomFactor;

                // If we're at our min or max then don't continue
                if (scale <= 0 || scale >= SliderZoomFactor.Maximum) return;

                var transform = (ScaleTransform) ((TransformGroup) CaptureImage.RenderTransform).Children[0];

                // We're zooming via mouse
                if (CaptureImage.IsMouseOver)
                {
                    // Get the mouse position relative to the image
                    var position = Mouse.GetPosition(CaptureImage);

                    // Set the center to the offset Mouse X/Y values
                    transform.CenterX = position.X - CaptureImage.ActualWidth / 2;
                    transform.CenterY = position.Y - CaptureImage.ActualHeight / 2;
                }

                // Update the scale
                transform.ScaleX = scale;
                transform.ScaleY = scale;
            };
        }

        #region Events
        private void CaptureImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CaptureImage.ReleaseMouseCapture();
        }

        private void CaptureImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!CaptureImage.IsMouseCaptured) return;

            var tt = (TranslateTransform) ((TransformGroup)CaptureImage.RenderTransform).Children.First(tr => tr is TranslateTransform);
            var v = _start - e.GetPosition(CaptureImageBorder);
            tt.X = _origin.X - v.X;
            tt.Y = _origin.Y - v.Y;
        }

        private void CaptureImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CaptureImage.CaptureMouse();
            var tt = (TranslateTransform) ((TransformGroup) CaptureImage.RenderTransform).Children.First(tr => tr is TranslateTransform);
            _start = e.GetPosition(CaptureImageBorder);
            _origin = new Point(tt.X, tt.Y);

            if (!(sender is Image image) || image.Source == null || !image.IsMouseOver) return;
            this.GetViewModel().PickedColor = PickerUtil.GetColorAt(this.GetViewModel().CurrentBitmap, PickerViewModel.GetCoordsAt(image, e.GetPosition(CaptureImage)));
        }

        private void CaptureImage_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            var speed = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift) ? 0.6 : 0.3;
            var zoomFactor = this.GetViewModel().ZoomFactor + (e.Delta > 0 ? speed : -speed);
            this.GetViewModel().ZoomFactor = zoomFactor.Squish(0, SliderZoomFactor.Maximum);
        }

        private void CaptureImage_OnPreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (!(sender is Image image) || image.Source == null || !image.IsMouseOver) return;
            this.GetViewModel().HoveredColor = PickerUtil.GetColorAt(this.GetViewModel().CurrentBitmap, PickerViewModel.GetCoordsAt(image, e.GetPosition(CaptureImage)));
        }

        private void BtnOK_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(this.Owner is MainWindow mainWindow)) return;
            if (!this.GetViewModel().PickedColor.Equals(Color.FromArgb(0, 0, 0, 0)))
            {
                mainWindow.GetViewModel().CurrentColor.MediaColor = this.GetViewModel().PickedColor;
            }

            this.Close();
        }

        private void SliderZoomFactor_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.GetViewModel().ZoomFactor = e.NewValue.Squish(0, SliderZoomFactor.Maximum);
        }
        #endregion

        public PickerViewModel GetViewModel()
        {
            return (PickerViewModel) this.DataContext;
        }
    }
}
