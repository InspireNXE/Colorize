using System.Drawing;
using System.Windows;

namespace Colorize
{
    internal class OmniColor : Property
    {
        private static readonly Color DefaultColor = Color.FromArgb(128, 90, 90, 175);

        internal static DependencyProperty MasterColorProperty = RegisterProperty(nameof(MasterColor), DefaultColor);
        public Color MasterColor
        {
            get => (Color) this.GetValue(MasterColorProperty);
            set
            {
                this.UpdateProperty(MasterColorProperty, value);
                this.Update();
            }
        }

        internal static DependencyProperty MediaColorProperty = RegisterProperty(nameof(MediaColor), System.Windows.Media.Color.FromArgb(DefaultColor.A, DefaultColor.R, DefaultColor.G, DefaultColor.B));
        public System.Windows.Media.Color MediaColor
        {
            get => (System.Windows.Media.Color) this.GetValue(MediaColorProperty);
            set => this.MasterColor = Color.FromArgb(value.A, value.R, value.G, value.B);
        }

        internal static DependencyProperty ProgrammaticProperty = RegisterProperty(nameof(Programmatic), GetHex("0x", DefaultColor));
        public string Programmatic
        {
            get => (string) this.GetValue(ProgrammaticProperty);
            set => this.MasterColor = ColorTranslator.FromHtml(value);
        }

        internal static DependencyProperty HexProperty = RegisterProperty(nameof(Hex), GetHex("#", DefaultColor));
        public string Hex
        {
            get => (string) this.GetValue(HexProperty);
            set => this.MasterColor = ColorTranslator.FromHtml(value);
        }

        internal static DependencyProperty ArgbProperty = RegisterProperty(nameof(Argb), DefaultColor.ToArgb());
        public int Argb
        {
            get => (int) this.GetValue(ArgbProperty);
            set => this.MasterColor = Color.FromArgb(value);
        }

        #region Bytes
        internal static DependencyProperty ByteAProperty = RegisterProperty(nameof(ByteA), DefaultColor.A);
        internal static DependencyProperty ByteRProperty = RegisterProperty(nameof(ByteR), DefaultColor.R);
        internal static DependencyProperty ByteGProperty = RegisterProperty(nameof(ByteG), DefaultColor.G);
        internal static DependencyProperty ByteBProperty = RegisterProperty(nameof(ByteB), DefaultColor.B);

        public byte ByteA
        {
            get => (byte) this.GetValue(ByteAProperty);
            set => this.UpdateColor(ColorType.Alpha, value);
        }

        public byte ByteR
        {
            get => (byte) this.GetValue(ByteRProperty);
            set => this.UpdateColor(ColorType.Red, value);
        }

        public byte ByteG
        {
            get => (byte) this.GetValue(ByteGProperty);
            set => this.UpdateColor(ColorType.Green, value);
        }

        public byte ByteB
        {
            get => (byte) this.GetValue(ByteBProperty);
            set => this.UpdateColor(ColorType.Blue, value);
        }
        #endregion

        #region Floats
        internal static DependencyProperty FloatAProperty = RegisterProperty(nameof(FloatA), ScaleToFloat(DefaultColor.A));
        internal static DependencyProperty FloatRProperty = RegisterProperty(nameof(FloatR), ScaleToFloat(DefaultColor.R));
        internal static DependencyProperty FloatGProperty = RegisterProperty(nameof(FloatG), ScaleToFloat(DefaultColor.G));
        internal static DependencyProperty FloatBProperty = RegisterProperty(nameof(FloatB), ScaleToFloat(DefaultColor.B));

        public float FloatA
        {
            get => (float) this.GetValue(FloatAProperty);
            set => this.UpdateColor(ColorType.Alpha, ScaleToByte(value));
        }
        public float FloatR
        {
            get => (float) this.GetValue(FloatRProperty);
            set => this.UpdateColor(ColorType.Red, ScaleToByte(value));
        }
        public float FloatG
        {
            get => (float) this.GetValue(FloatGProperty);
            set => this.UpdateColor(ColorType.Green, ScaleToByte(value));
        }

        public float FloatB
        {
            get => (float) this.GetValue(FloatBProperty);
            set => this.UpdateColor(ColorType.Blue, ScaleToByte(value));
        }
        #endregion

        public OmniColor(Color color)
        {
            UpdateProperty(MasterColorProperty, color);
            this.Update();
        }

        public OmniColor(System.Windows.Media.Color color)
        {
            UpdateProperty(MasterColorProperty, Color.FromArgb(color.A, color.R, color.G, color.B));
            this.Update();
        }

        public OmniColor(string hex)
        {
            UpdateProperty(MasterColorProperty, ColorTranslator.FromHtml(hex));
            this.Update();
        }

        public OmniColor(byte a, byte r, byte g, byte b)
        {
            UpdateProperty(MasterColorProperty, Color.FromArgb(a, r, g, b));
            this.Update();
        }

        public OmniColor(float a, float r, float g, float b)
        {
            var byteA = ScaleToByte(this.MasterColor.A);
            var byteR = ScaleToByte(this.MasterColor.R);
            var byteG = ScaleToByte(this.MasterColor.G);
            var byteB = ScaleToByte(this.MasterColor.B);

            UpdateProperty(MasterColorProperty, Color.FromArgb(byteA, byteR, byteG, byteB));

            this.Update();
        }

        private void Update()
        {
            // Floats
            this.UpdateProperty(FloatAProperty, ScaleToFloat(this.MasterColor.A));
            this.UpdateProperty(FloatRProperty, ScaleToFloat(this.MasterColor.R));
            this.UpdateProperty(FloatGProperty, ScaleToFloat(this.MasterColor.G));
            this.UpdateProperty(FloatBProperty, ScaleToFloat(this.MasterColor.B));

            this.UpdateProperty(MediaColorProperty, System.Windows.Media.Color.FromArgb(this.MasterColor.A, this.MasterColor.R, this.MasterColor.G, this.MasterColor.B));

            this.UpdateProperty(HexProperty, GetHex("#", this.MasterColor));

            this.UpdateProperty(ProgrammaticProperty, GetHex("0x", this.MasterColor));

            this.UpdateProperty(ArgbProperty, this.MasterColor.ToArgb());

            // Bytes
            this.UpdateProperty(ByteAProperty, this.MasterColor.A);
            this.UpdateProperty(ByteRProperty, this.MasterColor.R);
            this.UpdateProperty(ByteGProperty, this.MasterColor.G);
            this.UpdateProperty(ByteBProperty, this.MasterColor.B);
        }

        internal void UpdateColor(ColorType type, byte value)
        {
            var a = this.MasterColor.A;
            var r = this.MasterColor.R;
            var g = this.MasterColor.G;
            var b = this.MasterColor.B;

            switch (type)
            {
                case ColorType.Alpha:
                    a = value;
                    break;
                case ColorType.Red:
                    r = value;
                    break;
                case ColorType.Green:
                    g = value;
                    break;
                case ColorType.Blue:
                    b = value;
                    break;
            }
            this.MasterColor = Color.FromArgb(a, r, g, b);
        }

        private static string GetHex(string id, Color color)
        {
            return id +
                   $"{(color.R.ToString("X").Length == 1 ? $"0{color.R:X}" : color.R.ToString("X"))}" +
                   $"{(color.G.ToString("X").Length == 1 ? $"0{color.G:X}" : color.G.ToString("X"))}" +
                   $"{(color.B.ToString("X").Length == 1 ? $"0{color.B:X}" : color.B.ToString("X"))}";
        }

        internal static byte ScaleToByte(float value)
        {
            return (byte) Scale(value, 0f, 1f, 0, 255);
        }

        private static float ScaleToFloat(byte value)
        {
            return Scale(value, 0, 255, 0f, 1f);
        }

        private static float Scale(float originalValue, float originalMin, float originalMax, float newMin, float newMax)
        {
            var originalRange = (originalMax - originalMin);
            if (originalRange == 0.0f)
            {
                return newMin;
            }
            else
            {
                var newRange = (newMax - newMin);
                return (originalValue - originalMin) * newRange / originalRange + newMin;
            }
        }

        internal enum ColorType
        {
            Alpha,
            Red,
            Green,
            Blue
        }
    }
}
