using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Colorize.UI.Models;

namespace Colorize.UI.Windows
{
    public partial class MainWindow : IModeled<MainViewModel>
    {
        private readonly Dictionary<TextBox, OmniColor.ColorType?> _textBoxSliderDictionary;

        public MainWindow()
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
            this.GetViewModel().CurrentColor = new OmniColor(175, 28, 156, 255);
        }

        #region Byte

        private void SliderAlphaByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Update alpha
            this.GetViewModel().CurrentColor.ByteA = (byte) e.NewValue;
        }

        private void SliderRedByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Update red
            this.GetViewModel().CurrentColor.ByteR = (byte) e.NewValue;
        }

        private void SliderGreenByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Update green
            this.GetViewModel().CurrentColor.ByteG = (byte) e.NewValue;
        }

        private void SliderBlueByte_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Update blue
            this.GetViewModel().CurrentColor.ByteB = (byte) e.NewValue;
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
            var a = OmniColor.ScaleToByte((float) e.NewValue);
            if (a.Equals(this.GetViewModel().CurrentColor.ByteA)) return;

            this.GetViewModel().CurrentColor.ByteA = a;
        }

        private void SliderRedFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var r = OmniColor.ScaleToByte((float) e.NewValue);
            if (r.Equals(this.GetViewModel().CurrentColor.ByteR)) return;

            this.GetViewModel().CurrentColor.ByteR = r;
        }

        private void SliderGreenFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var g = OmniColor.ScaleToByte((float) e.NewValue);
            if (g.Equals(this.GetViewModel().CurrentColor.ByteG)) return;

            this.GetViewModel().CurrentColor.ByteG = g;
        }

        private void SliderBlueFloat_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var b = OmniColor.ScaleToByte((float) e.NewValue);
            if (b.Equals(this.GetViewModel().CurrentColor.ByteB)) return;

            this.GetViewModel().CurrentColor.ByteB = b;
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
            if (!(sender is TextBox textBox) || e.Key != Key.Enter) return;
            this.UpdateHex(textBox.Text);
        }

        private void TBHex_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            this.UpdateHex(textBox.Text);
        }

        private void TBHex_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            var currentText = textBox.SelectedText.Length == 0
                ? textBox.Text + e.Text
                : textBox.Text.Replace(textBox.Text.Substring(textBox.SelectionStart, textBox.SelectionLength), e.Text);
            if (Regex.IsMatch(currentText, "[0-9A-Fa-f#]+$") &&
                currentText.Length <= (currentText.StartsWith("#") ? 7 : 6))
            {
                return;
            }

            e.Handled = true;
        }

        private void UpdateHex(string value)
        {
            ((MainViewModel)this.DataContext).CurrentColor.Hex = value.StartsWith("#") ? value : "#" + value;
        }
        #endregion

        #region Programmatic
        private void TBProg_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!(sender is TextBox textBox) || e.Key != Key.Enter) return;
            this.UpdateProgrammatic(textBox.Text);
        }

        private void TBProg_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            this.UpdateProgrammatic(textBox.Text);
        }

        private void TBProg_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            var currentText = textBox.SelectedText.Length == 0
                ? textBox.Text + e.Text
                : textBox.Text.Replace(textBox.Text.Substring(textBox.SelectionStart, textBox.SelectionLength), e.Text);
            if (Regex.IsMatch(currentText, "[0-9A-Fa-f#]+$") &&
                currentText.Length <= (currentText.StartsWith("0x") ? 8 : 6))
            {
                return;
            }

            e.Handled = true;
        }

        private void UpdateProgrammatic(string value)
        {
            ((MainViewModel)this.DataContext).CurrentColor.Programmatic = value.StartsWith("0x") ? value : "0x" + value;
        }
        #endregion

        #region ARGB
        private void TBArgb_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!(sender is TextBox textBox) || e.Key != Key.Enter) return;
            this.UpdateArgb(textBox.Text);
        }

        private void TBArgb_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            this.UpdateArgb(textBox.Text);
        }

        private void TBArgb_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(sender is TextBox textBox)) return;
            var currentText = textBox.SelectedText.Length == 0
                ? textBox.Text + e.Text
                : textBox.Text.Replace(textBox.Text.Substring(textBox.SelectionStart, textBox.SelectionLength), e.Text);

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

        private void UpdateArgb(string value)
        {
            this.GetViewModel().CurrentColor.Argb = int.Parse(value);
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
                    this.GetViewModel().CurrentColor.ByteA += value;
                    break;
                case OmniColor.ColorType.Red:
                    this.GetViewModel().CurrentColor.ByteR += value;
                    break;
                case OmniColor.ColorType.Green:
                    this.GetViewModel().CurrentColor.ByteG += value;
                    break;
                case OmniColor.ColorType.Blue:
                    this.GetViewModel().CurrentColor.ByteB += value;
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

        #region Picker
        private void BtnColorPick_OnClick(object sender, RoutedEventArgs e)
        {
            new PickerChoiceWindow(this).ShowDialog();
        }
        #endregion

        public MainViewModel GetViewModel()
        {
            return (MainViewModel) this.DataContext;
        }
    }
}
