using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Colorize.UI.Models;
using Colorize.UI.Windows;
using Gma.System.MouseKeyHook;
using Xceed.Wpf.Toolkit;
using Color = System.Windows.Media.Color;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace Colorize.UI.Pages
{
    public partial class MainPage
    {
        private bool _isPicking;

        private readonly Dictionary<TextBox, OmniColor.ColorType?> _textBoxSliderDictionary;
        public MainPage()
        {
            InitializeComponent();

            // Map out color types to relevant textboxes
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

            // Set default color
            this.GetViewModel<MainViewModel>().CurrentColor = new OmniColor(128, 90, 90, 90);
        }

        #region Byte
        private void SliderAlphaByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            // Only process the change if we're focused on the slider or textbox, and the value has changed
            if ((sender is Slider slider && slider.IsFocused || TBByteAlpha.IsFocused) && !e.OldValue.Equals(e.NewValue))
            {
                // Update alpha
                this.GetViewModel<MainViewModel>().CurrentColor.ByteA = (byte) e.NewValue;
            }
        }

        private void SliderRedByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            // Only process the change if we're focused on the slider or textbox, and the value has changed
            if ((sender is Slider slider && slider.IsFocused || TBByteAlpha.IsFocused) &&
                !e.OldValue.Equals(e.NewValue))
            {
                // Update red
                this.GetViewModel<MainViewModel>().CurrentColor.ByteR = (byte) e.NewValue;
            }
        }

        private void SliderGreenByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Only process the change if we're focused on the slider or textbox, and the value has changed
            if ((sender is Slider slider && slider.IsFocused || TBByteAlpha.IsFocused) && !e.OldValue.Equals(e.NewValue))
            {
                // Update green
                this.GetViewModel<MainViewModel>().CurrentColor.ByteG = (byte) e.NewValue;
                }
        }

        private void SliderBlueByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Only process the change if we're focused on the slider or textbox, and the value has changed
            if ((sender is Slider slider && slider.IsFocused || TBByteAlpha.IsFocused) && !e.OldValue.Equals(e.NewValue))
            {
                // Update blue
                this.GetViewModel<MainViewModel>().CurrentColor.ByteB = (byte) e.NewValue;
            }
        }

        private void TBByte_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Ensure we're working with a textbox
            if (!(sender is TextBox textBox)) return;

            // Assess the current text based on if we have selected text and where our selection start is
            // If we're 1|23 with no selection, assume we're trying to add a character between 1 and 2
            // If we're 1|23| with a selection from the start of 2 to the end of 3, assume we're trying to replace that range of text
            var currentText = textBox.SelectedText.Length == 0
                ? textBox.Text.Insert(textBox.SelectionStart, e.Text)
                : textBox.Text.Replace(textBox.Text.Substring(textBox.SelectionStart, textBox.SelectionLength), e.Text);

            // Ensure that we match a format of 123 and can parse as a byte
            if (Regex.IsMatch(currentText, "[\\d{1,3}]") && byte.TryParse(currentText, out var result))
            {
                // Ensure we're not over 255
                e.Handled = result > 255;
                return;
            }

            e.Handled = true;
        }
        #endregion

        #region Float
        private void SliderAlphaFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Only process the change if we're focused on the slider or textbox, and the value has changed
            if ((sender is Slider slider && slider.IsFocused || TBByteAlpha.IsFocused) && !e.OldValue.Equals(e.NewValue))
            {
                var a = OmniColor.ScaleToByte((float) e.NewValue);
                if (a.Equals(this.GetViewModel<MainViewModel>().CurrentColor.ByteA)) return;

                this.GetViewModel<MainViewModel>().CurrentColor.ByteA = a;
            }
        }

        private void SliderRedFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Only process the change if we're focused on the slider or textbox, and the value has changed
            if ((sender is Slider slider && slider.IsFocused || TBByteAlpha.IsFocused) && !e.OldValue.Equals(e.NewValue))
            {
                var r = OmniColor.ScaleToByte((float) e.NewValue);
                if (r.Equals(this.GetViewModel<MainViewModel>().CurrentColor.ByteR)) return;

                this.GetViewModel<MainViewModel>().CurrentColor.ByteR = r;
            }
        }

        private void SliderGreenFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Only process the change if we're focused on the slider or textbox, and the value has changed
            if ((sender is Slider slider && slider.IsFocused || TBByteAlpha.IsFocused) && !e.OldValue.Equals(e.NewValue))
            {
                var g = OmniColor.ScaleToByte((float) e.NewValue);
                if (g.Equals(this.GetViewModel<MainViewModel>().CurrentColor.ByteG)) return;

                this.GetViewModel<MainViewModel>().CurrentColor.ByteG = g;
            }
        }

        private void SliderBlueFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Only process the change if we're focused on the slider or textbox, and the value has changed
            if ((sender is Slider slider && slider.IsFocused || TBByteAlpha.IsFocused) && !e.OldValue.Equals(e.NewValue))
            {
                var b = OmniColor.ScaleToByte((float) e.NewValue);
                if (b.Equals(this.GetViewModel<MainViewModel>().CurrentColor.ByteB)) return;

                this.GetViewModel<MainViewModel>().CurrentColor.ByteB = b;
            }
        }

        private void TBFloat_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Ensure we're working with a textbox
            if (!(sender is TextBox textBox)) return;

            // Assess the current text based on if we have selected text and where our selection start is
            // If we're 1|23 with no selection, assume we're trying to add a character between 1 and 2
            // If we're 1|23| with a selection from the start of 2 to the end of 3, assume we're trying to replace that range of text
            var currentText = textBox.SelectedText.Length == 0
                ? textBox.Text.Insert(textBox.SelectionStart, e.Text)
                : textBox.Text.Replace(textBox.Text.Substring(textBox.SelectionStart, textBox.SelectionLength), e.Text);

            // Ensure that we match a format of 0.0000000 and can parse as a float
            if (Regex.IsMatch(currentText, "[\\d{1}.\\d{0,7}]") && float.TryParse(currentText, out var result))
            {
                // Ensure we aren't outside our range
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
                this.GetViewModel<MainViewModel>().CurrentColor.Argb = int.Parse(textBox.Text);
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
            // Stop if we aren't pressing up or down
            if (e.Key != Key.Up && e.Key != Key.Down) return;

            // Stop if we aren't a textbox
            if (!(sender is TextBox textBox)) return;

            // Stop if our color type is somehow null
            var colorType = _textBoxSliderDictionary[textBox];
            if (colorType == null) return;

            // Determine our direction
            var value = (byte) (e.Key == Key.Up ? 1 : -1);

            // Apply the change
            switch (colorType.Value)
            {
                case OmniColor.ColorType.Alpha:
                    this.GetViewModel<MainViewModel>().CurrentColor.ByteA += value;
                    break;
                case OmniColor.ColorType.Red:
                    this.GetViewModel<MainViewModel>().CurrentColor.ByteR += value;
                    break;
                case OmniColor.ColorType.Green:
                    this.GetViewModel<MainViewModel>().CurrentColor.ByteG += value;
                    break;
                case OmniColor.ColorType.Blue:
                    this.GetViewModel<MainViewModel>().CurrentColor.ByteB += value;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        } 
        #endregion

        #region Menu
        private void MIFileExit_Click(object sender, RoutedEventArgs e)
        {
            // Shutdown the application
            Application.Current.Shutdown();
        }

        private void MIHelpIssues_Click(object sender, RoutedEventArgs e)
        {
            // Open the issues url
            System.Diagnostics.Process.Start(App.SourceLocation + @"/issues");
        }

        private void MIHelpReleases_Click(object sender, RoutedEventArgs e)
        {
            // Open the releases url
            System.Diagnostics.Process.Start(App.SourceLocation + @"/releases");
        }

        private void MIHelpSource_Click(object sender, RoutedEventArgs e)
        {
            // Open the source url
            System.Diagnostics.Process.Start(App.SourceLocation);
        }

        private void MIHelpDonate_Click(object sender, RoutedEventArgs e)
        {
            // Open the donation url
            System.Diagnostics.Process.Start(App.DonateLocation);
        }

        private void MIHelpAbout_Click(object sender, RoutedEventArgs e)
        {
            // Show about window
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

        #region Picker
        private void BtnColorPick_OnClick(object sender, RoutedEventArgs e)
        {
            if (PickerUtil.IsPicking)
            {
                PickerUtil.StopTracking();
            }
            else
            {
                
                PickerUtil.StartTracking(() =>
                {
                    if (!PickerUtil.LastPickedColor.HasValue) return;
                    this.GetViewModel<MainViewModel>().CurrentColor.MediaColor = PickerUtil.LastPickedColor.Value;
                }, null);
            }
        }
        #endregion

        private T GetViewModel<T>()
        {
            return (T) this.DataContext;
        }
    }
}
