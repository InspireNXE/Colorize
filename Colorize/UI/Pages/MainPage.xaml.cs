using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Colorize.UI.Models;
using Colorize.UI.Windows;
using Xceed.Wpf.Toolkit;

namespace Colorize.UI.Pages
{
    public partial class MainPage
    {
        private readonly Dictionary<TextBox, OmniColor.ColorType?> _textBoxSliderDictionary;
        public MainPage()
        {
            InitializeComponent();
            _textBoxSliderDictionary = new Dictionary<TextBox, OmniColor.ColorType?>()
            {
                {TBByteAlpha, OmniColor.ColorType.Alpha},
                {TBByteRed, OmniColor.ColorType.Red},
                {TBByteGreen, OmniColor.ColorType.Green},
                {TBByteBlue, OmniColor.ColorType.Blue},
                {TBFloatAlpha, OmniColor.ColorType.Alpha},
                {TBFloatRed, OmniColor.ColorType.Red},
                {TBFloatGreen, OmniColor.ColorType.Green},
                {TBFloatBlue, OmniColor.ColorType.Blue}
            };
            ((MainViewModel) this.DataContext).CurrentColor = new OmniColor(90, 90, 90, 90);
        }

        #region Byte
        private void SliderAlphaByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((MainViewModel) this.DataContext).CurrentColor.ByteA = (byte) e.NewValue;
        }

        private void SliderRedByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((MainViewModel) this.DataContext).CurrentColor.ByteR = (byte) e.NewValue;
        }

        private void SliderGreenByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((MainViewModel) this.DataContext).CurrentColor.ByteG = (byte) e.NewValue;
        }

        private void SliderBlueByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((MainViewModel) this.DataContext).CurrentColor.ByteB = (byte) e.NewValue;
        }

        private void TBByte_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentText = currentTextBox.SelectedText.Length == 0
                ? currentTextBox.Text.Insert(currentTextBox.SelectionStart, e.Text)
                : currentTextBox.Text.Replace(currentTextBox.Text.Substring(currentTextBox.SelectionStart, currentTextBox.SelectionLength), e.Text);
            if (Regex.IsMatch(currentText, "[\\d{1,3}]") && int.TryParse(currentText, out var result))
            {
                e.Handled = !(result >= 0 && result <= 255);
                return;
            }

            e.Handled = true;
        }
        #endregion

        #region Float
        private void SliderAlphaFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider slider && slider.IsFocused && !e.OldValue.Equals(e.NewValue) || TBFloatAlpha.IsFocused)
            {
                var a = OmniColor.ScaleToByte((float) e.NewValue);
                if (a.Equals(((MainViewModel) this.DataContext).CurrentColor.ByteA)) return;

                ((MainViewModel) this.DataContext).CurrentColor.ByteA = a;
            }
        }

        private void SliderRedFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider slider && slider.IsFocused && !e.OldValue.Equals(e.NewValue) || TBFloatRed.IsFocused)
            {
                var r = OmniColor.ScaleToByte((float) e.NewValue);
                if (r.Equals(((MainViewModel) this.DataContext).CurrentColor.ByteR)) return;

                ((MainViewModel) this.DataContext).CurrentColor.ByteR = r;
            }
        }

        private void SliderGreenFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider slider && slider.IsFocused && !e.OldValue.Equals(e.NewValue) || TBFloatGreen.IsFocused)
            {
                var g = OmniColor.ScaleToByte((float) e.NewValue);
                if (g.Equals(((MainViewModel) this.DataContext).CurrentColor.ByteG)) return;

                ((MainViewModel) this.DataContext).CurrentColor.ByteG = g;
            }
        }

        private void SliderBlueFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider slider && slider.IsFocused && !e.OldValue.Equals(e.NewValue) || TBFloatBlue.IsFocused)
            {
                var b = OmniColor.ScaleToByte((float) e.NewValue);
                if (b.Equals(((MainViewModel) this.DataContext).CurrentColor.ByteB)) return;

                ((MainViewModel) this.DataContext).CurrentColor.ByteB = b;
            }
        }

        private void TBFloat_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var currentTextBox = (TextBox) sender;
            var currentText = currentTextBox.SelectedText.Length == 0
                ? currentTextBox.Text.Insert(currentTextBox.SelectionStart, e.Text)
                : currentTextBox.Text.Replace(currentTextBox.Text.Substring(currentTextBox.SelectionStart, currentTextBox.SelectionLength), e.Text);
            if (Regex.IsMatch(currentText, "[\\d{1}.\\d{0,7}]") && float.TryParse(currentText, out var result))
            {
                e.Handled = !(result >= 0 && result <= 1);
                return;
            }

            e.Handled = true;
        }
        #endregion

        #region Hex
        private void TBHex_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox textBox && e.Key == Key.Enter)
            {
                ((MainViewModel)this.DataContext).CurrentColor.Hex = textBox.Text.StartsWith("#") ? textBox.Text : "#" + textBox.Text;
            }
        }

        private void TBHex_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentText = currentTextBox.SelectedText.Length == 0
                ? currentTextBox.Text + e.Text
                : currentTextBox.Text.Replace(currentTextBox.Text.Substring(currentTextBox.SelectionStart, currentTextBox.SelectionLength), e.Text);
            if (Regex.IsMatch(currentText, "[0-9A-Fa-f#]+$") && currentText.Length <= (currentText.StartsWith("#") ? 7 : 6))
            {
                return;
            }

            e.Handled = true;
        }
        #endregion

        #region Programmatic
        private void TBProg_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox textBox && e.Key == Key.Enter)
            {
                ((MainViewModel)this.DataContext).CurrentColor.Programmatic = textBox.Text.StartsWith("0x") ? textBox.Text : "0x" + textBox.Text;
            }
        }

        private void TBProg_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentText = currentTextBox.SelectedText.Length == 0
                ? currentTextBox.Text + e.Text
                : currentTextBox.Text.Replace(currentTextBox.Text.Substring(currentTextBox.SelectionStart, currentTextBox.SelectionLength), e.Text);
            if (Regex.IsMatch(currentText, "[0-9A-Fa-f#]+$") && currentText.Length <= (currentText.StartsWith("0x") ? 8 : 6))
            {
                return;
            }

            e.Handled = true;
        }
        #endregion

        #region ARGB
        private void TBArgb_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox textBox && e.Key == Key.Enter)
            {
                ((MainViewModel) this.DataContext).CurrentColor.Argb = int.Parse(textBox.Text);
            }
        }

        private void TBArgb_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentText = currentTextBox.SelectedText.Length == 0
                ? currentTextBox.Text + e.Text
                : currentTextBox.Text.Replace(currentTextBox.Text.Substring(currentTextBox.SelectionStart, currentTextBox.SelectionLength), e.Text);

            if (string.Equals(currentText, "-"))
            {
                return;
            }

            if (int.TryParse(currentText, out _))
            {
                return;
            }

            e.Handled = true;
        }
        #endregion

        #region Common
        private void TB_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Up && e.Key != Key.Down) return;
            if (!(sender is TextBox textBox)) return;

            var colorType = _textBoxSliderDictionary[textBox];
            if (colorType == null) return;

            var value = (byte) (e.Key == Key.Up ? 1 : -1);

            switch (colorType.Value)
            {
                case OmniColor.ColorType.Alpha:
                    ((MainViewModel) this.DataContext).CurrentColor.ByteA = (byte) (((MainViewModel)this.DataContext).CurrentColor.ByteA + value);
                    break;
                case OmniColor.ColorType.Red:
                    ((MainViewModel) this.DataContext).CurrentColor.ByteR += value;
                    break;
                case OmniColor.ColorType.Green:
                    ((MainViewModel) this.DataContext).CurrentColor.ByteG += value;
                    break;
                case OmniColor.ColorType.Blue:
                    ((MainViewModel) this.DataContext).CurrentColor.ByteB += value;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        } 
        #endregion

        #region Menu
        private void MIFileExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MIHelpIssues_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(App.SourceLocation + @"/issues");
        }

        private void MIHelpReleases_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(App.SourceLocation + @"/releases");
        }

        private void MIHelpSource_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(App.SourceLocation);
        }

        private void MIHelpDonate_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(App.DonateLocation);
        }

        private void MIHelpAbout_Click(object sender, RoutedEventArgs e)
        {
            new AboutWindow().ShowDialog();
        }
        #endregion

        private void ColorPicker_OnOpened(object sender, RoutedEventArgs e)
        {
            if (sender is ColorPicker picker)
            {
                picker.IsOpen = false;
            }
            e.Handled = true;
        }
    }
}
