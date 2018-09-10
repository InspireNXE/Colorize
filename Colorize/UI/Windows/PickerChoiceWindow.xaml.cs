using System;
using System.Drawing;
using System.Threading;
using System.Windows;
using Microsoft.Win32;

namespace Colorize.UI.Windows
{
    public partial class PickerChoiceWindow
    {
        public PickerChoiceWindow(Window owner)
        {
            this.Owner = owner;
            InitializeComponent();
        }

        #region Events
        private void BtnDesktop_OnClick(object sender, RoutedEventArgs e)
        {
            
            this.Closed += (s, arg) =>
            {
                // You'd think being in the 'closed' would be good enough but nope!
                // Sleep about 0.5 seconds to give the window a chance to fully close
                Thread.Sleep(500);

                // Open the picker window with a capture of the current screen
                new PickerWindow(this.Owner, PickerUtil.CaptureScreen()).ShowDialog();
            };
            this.Close();
        }

        private void BtnFile_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog { Filter = "Image files (*.png;*.jpeg;*.tiff;*.bmp)|*.png;*.jpeg;*.tiff;*.bmp|All files (*.*)|*.*" };
            if (openFileDialog.ShowDialog(this) != true) return;
            this.Close();
            try
            {
                new PickerWindow(this.Owner, new Bitmap(openFileDialog.FileName)).ShowDialog();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("An error occured while loading the specified file as an image. This could mean the file is corrupt or not a valid image file.", "Uh oh!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnExit_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
