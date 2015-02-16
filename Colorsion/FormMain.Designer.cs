namespace Colorsion
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BTNConvert = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.tabControlInput = new System.Windows.Forms.TabControl();
            this.tabPageInputRGBA = new System.Windows.Forms.TabPage();
            this.NUDInputRGBAAlpha = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDInputRGBABlue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDInputRGBAGreen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDInputRGBARed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageInputFloat = new System.Windows.Forms.TabPage();
            this.TBInputFloatAlpha = new System.Windows.Forms.TextBox();
            this.TBInputFloatBlue = new System.Windows.Forms.TextBox();
            this.TBInputFloatGreen = new System.Windows.Forms.TextBox();
            this.TBInputFloatRed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageInputHex = new System.Windows.Forms.TabPage();
            this.TBInputHex = new System.Windows.Forms.TextBox();
            this.tabPageInputInt = new System.Windows.Forms.TabPage();
            this.TBInputInt = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.tabControlOutput = new System.Windows.Forms.TabControl();
            this.tabPageOutputRGBA = new System.Windows.Forms.TabPage();
            this.TBOutputRGBAAlpha = new System.Windows.Forms.TextBox();
            this.TBOutputRGBABlue = new System.Windows.Forms.TextBox();
            this.TBOutputRGBAGreen = new System.Windows.Forms.TextBox();
            this.TBOutputRGBARed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageOutputFloat = new System.Windows.Forms.TabPage();
            this.TBOutputFloatAlpha = new System.Windows.Forms.TextBox();
            this.TBOutputFloatBlue = new System.Windows.Forms.TextBox();
            this.TBOutputFloatGreen = new System.Windows.Forms.TextBox();
            this.TBOutputFloatRed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPageOutputHex = new System.Windows.Forms.TabPage();
            this.TBOutputHex = new System.Windows.Forms.TextBox();
            this.tabPageOutputInt = new System.Windows.Forms.TabPage();
            this.TBOutputInt = new System.Windows.Forms.TextBox();
            this.PictureBoxColor = new System.Windows.Forms.PictureBox();
            this.groupBoxInput.SuspendLayout();
            this.tabControlInput.SuspendLayout();
            this.tabPageInputRGBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputRGBAAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputRGBABlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputRGBAGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputRGBARed)).BeginInit();
            this.tabPageInputFloat.SuspendLayout();
            this.tabPageInputHex.SuspendLayout();
            this.tabPageInputInt.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.tabControlOutput.SuspendLayout();
            this.tabPageOutputRGBA.SuspendLayout();
            this.tabPageOutputFloat.SuspendLayout();
            this.tabPageOutputHex.SuspendLayout();
            this.tabPageOutputInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNConvert
            // 
            this.BTNConvert.Location = new System.Drawing.Point(311, 173);
            this.BTNConvert.Name = "BTNConvert";
            this.BTNConvert.Size = new System.Drawing.Size(75, 23);
            this.BTNConvert.TabIndex = 3;
            this.BTNConvert.Text = "Convert";
            this.BTNConvert.UseVisualStyleBackColor = true;
            this.BTNConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.tabControlInput);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(184, 155);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // tabControlInput
            // 
            this.tabControlInput.Controls.Add(this.tabPageInputRGBA);
            this.tabControlInput.Controls.Add(this.tabPageInputFloat);
            this.tabControlInput.Controls.Add(this.tabPageInputHex);
            this.tabControlInput.Controls.Add(this.tabPageInputInt);
            this.tabControlInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInput.Location = new System.Drawing.Point(3, 16);
            this.tabControlInput.Name = "tabControlInput";
            this.tabControlInput.SelectedIndex = 0;
            this.tabControlInput.Size = new System.Drawing.Size(178, 136);
            this.tabControlInput.TabIndex = 0;
            // 
            // tabPageInputRGBA
            // 
            this.tabPageInputRGBA.Controls.Add(this.NUDInputRGBAAlpha);
            this.tabPageInputRGBA.Controls.Add(this.label4);
            this.tabPageInputRGBA.Controls.Add(this.NUDInputRGBABlue);
            this.tabPageInputRGBA.Controls.Add(this.label3);
            this.tabPageInputRGBA.Controls.Add(this.NUDInputRGBAGreen);
            this.tabPageInputRGBA.Controls.Add(this.label2);
            this.tabPageInputRGBA.Controls.Add(this.NUDInputRGBARed);
            this.tabPageInputRGBA.Controls.Add(this.label1);
            this.tabPageInputRGBA.Location = new System.Drawing.Point(4, 22);
            this.tabPageInputRGBA.Name = "tabPageInputRGBA";
            this.tabPageInputRGBA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputRGBA.Size = new System.Drawing.Size(170, 110);
            this.tabPageInputRGBA.TabIndex = 0;
            this.tabPageInputRGBA.Text = "RGBA";
            this.tabPageInputRGBA.UseVisualStyleBackColor = true;
            // 
            // NUDInputRGBAAlpha
            // 
            this.NUDInputRGBAAlpha.Location = new System.Drawing.Point(112, 84);
            this.NUDInputRGBAAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDInputRGBAAlpha.Name = "NUDInputRGBAAlpha";
            this.NUDInputRGBAAlpha.Size = new System.Drawing.Size(52, 20);
            this.NUDInputRGBAAlpha.TabIndex = 4;
            this.NUDInputRGBAAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDInputRGBAAlpha.Enter += new System.EventHandler(this.Control_Enter);
            this.NUDInputRGBAAlpha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alpha";
            // 
            // NUDInputRGBABlue
            // 
            this.NUDInputRGBABlue.Location = new System.Drawing.Point(112, 58);
            this.NUDInputRGBABlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDInputRGBABlue.Name = "NUDInputRGBABlue";
            this.NUDInputRGBABlue.Size = new System.Drawing.Size(52, 20);
            this.NUDInputRGBABlue.TabIndex = 3;
            this.NUDInputRGBABlue.Enter += new System.EventHandler(this.Control_Enter);
            this.NUDInputRGBABlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blue";
            // 
            // NUDInputRGBAGreen
            // 
            this.NUDInputRGBAGreen.Location = new System.Drawing.Point(112, 32);
            this.NUDInputRGBAGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDInputRGBAGreen.Name = "NUDInputRGBAGreen";
            this.NUDInputRGBAGreen.Size = new System.Drawing.Size(52, 20);
            this.NUDInputRGBAGreen.TabIndex = 2;
            this.NUDInputRGBAGreen.Enter += new System.EventHandler(this.Control_Enter);
            this.NUDInputRGBAGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green";
            // 
            // NUDInputRGBARed
            // 
            this.NUDInputRGBARed.Location = new System.Drawing.Point(112, 6);
            this.NUDInputRGBARed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDInputRGBARed.Name = "NUDInputRGBARed";
            this.NUDInputRGBARed.Size = new System.Drawing.Size(52, 20);
            this.NUDInputRGBARed.TabIndex = 1;
            this.NUDInputRGBARed.Enter += new System.EventHandler(this.Control_Enter);
            this.NUDInputRGBARed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // tabPageInputFloat
            // 
            this.tabPageInputFloat.Controls.Add(this.TBInputFloatAlpha);
            this.tabPageInputFloat.Controls.Add(this.TBInputFloatBlue);
            this.tabPageInputFloat.Controls.Add(this.TBInputFloatGreen);
            this.tabPageInputFloat.Controls.Add(this.TBInputFloatRed);
            this.tabPageInputFloat.Controls.Add(this.label5);
            this.tabPageInputFloat.Controls.Add(this.label6);
            this.tabPageInputFloat.Controls.Add(this.label7);
            this.tabPageInputFloat.Controls.Add(this.label8);
            this.tabPageInputFloat.Location = new System.Drawing.Point(4, 22);
            this.tabPageInputFloat.Name = "tabPageInputFloat";
            this.tabPageInputFloat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputFloat.Size = new System.Drawing.Size(170, 110);
            this.tabPageInputFloat.TabIndex = 1;
            this.tabPageInputFloat.Text = "Float";
            this.tabPageInputFloat.UseVisualStyleBackColor = true;
            // 
            // TBInputFloatAlpha
            // 
            this.TBInputFloatAlpha.Location = new System.Drawing.Point(112, 83);
            this.TBInputFloatAlpha.Name = "TBInputFloatAlpha";
            this.TBInputFloatAlpha.Size = new System.Drawing.Size(52, 20);
            this.TBInputFloatAlpha.TabIndex = 4;
            this.TBInputFloatAlpha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            this.TBInputFloatAlpha.Enter += new System.EventHandler(this.Control_Enter);
            // 
            // TBInputFloatBlue
            // 
            this.TBInputFloatBlue.Location = new System.Drawing.Point(112, 57);
            this.TBInputFloatBlue.Name = "TBInputFloatBlue";
            this.TBInputFloatBlue.Size = new System.Drawing.Size(52, 20);
            this.TBInputFloatBlue.TabIndex = 3;
            this.TBInputFloatBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            this.TBInputFloatBlue.Enter += new System.EventHandler(this.Control_Enter);
            // 
            // TBInputFloatGreen
            // 
            this.TBInputFloatGreen.Location = new System.Drawing.Point(112, 31);
            this.TBInputFloatGreen.Name = "TBInputFloatGreen";
            this.TBInputFloatGreen.Size = new System.Drawing.Size(52, 20);
            this.TBInputFloatGreen.TabIndex = 2;
            this.TBInputFloatGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            this.TBInputFloatGreen.Enter += new System.EventHandler(this.Control_Enter);
            // 
            // TBInputFloatRed
            // 
            this.TBInputFloatRed.Location = new System.Drawing.Point(112, 5);
            this.TBInputFloatRed.Name = "TBInputFloatRed";
            this.TBInputFloatRed.Size = new System.Drawing.Size(52, 20);
            this.TBInputFloatRed.TabIndex = 1;
            this.TBInputFloatRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            this.TBInputFloatRed.Enter += new System.EventHandler(this.Control_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alpha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Blue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Green";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Red";
            // 
            // tabPageInputHex
            // 
            this.tabPageInputHex.Controls.Add(this.TBInputHex);
            this.tabPageInputHex.Location = new System.Drawing.Point(4, 22);
            this.tabPageInputHex.Name = "tabPageInputHex";
            this.tabPageInputHex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputHex.Size = new System.Drawing.Size(170, 110);
            this.tabPageInputHex.TabIndex = 2;
            this.tabPageInputHex.Text = "Hex";
            this.tabPageInputHex.UseVisualStyleBackColor = true;
            // 
            // TBInputHex
            // 
            this.TBInputHex.Location = new System.Drawing.Point(6, 6);
            this.TBInputHex.Name = "TBInputHex";
            this.TBInputHex.Size = new System.Drawing.Size(158, 20);
            this.TBInputHex.TabIndex = 1;
            this.TBInputHex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            this.TBInputHex.Enter += new System.EventHandler(this.Control_Enter);
            // 
            // tabPageInputInt
            // 
            this.tabPageInputInt.Controls.Add(this.TBInputInt);
            this.tabPageInputInt.Location = new System.Drawing.Point(4, 22);
            this.tabPageInputInt.Name = "tabPageInputInt";
            this.tabPageInputInt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputInt.Size = new System.Drawing.Size(170, 110);
            this.tabPageInputInt.TabIndex = 3;
            this.tabPageInputInt.Text = "Int";
            this.tabPageInputInt.UseVisualStyleBackColor = true;
            // 
            // TBInputInt
            // 
            this.TBInputInt.Location = new System.Drawing.Point(6, 6);
            this.TBInputInt.Name = "TBInputInt";
            this.TBInputInt.Size = new System.Drawing.Size(158, 20);
            this.TBInputInt.TabIndex = 1;
            this.TBInputInt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            this.TBInputInt.Enter += new System.EventHandler(this.Control_Enter);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.tabControlOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(202, 12);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(184, 155);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // tabControlOutput
            // 
            this.tabControlOutput.Controls.Add(this.tabPageOutputRGBA);
            this.tabControlOutput.Controls.Add(this.tabPageOutputFloat);
            this.tabControlOutput.Controls.Add(this.tabPageOutputHex);
            this.tabControlOutput.Controls.Add(this.tabPageOutputInt);
            this.tabControlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOutput.Location = new System.Drawing.Point(3, 16);
            this.tabControlOutput.Name = "tabControlOutput";
            this.tabControlOutput.SelectedIndex = 0;
            this.tabControlOutput.Size = new System.Drawing.Size(178, 136);
            this.tabControlOutput.TabIndex = 0;
            // 
            // tabPageOutputRGBA
            // 
            this.tabPageOutputRGBA.Controls.Add(this.TBOutputRGBAAlpha);
            this.tabPageOutputRGBA.Controls.Add(this.TBOutputRGBABlue);
            this.tabPageOutputRGBA.Controls.Add(this.TBOutputRGBAGreen);
            this.tabPageOutputRGBA.Controls.Add(this.TBOutputRGBARed);
            this.tabPageOutputRGBA.Controls.Add(this.label9);
            this.tabPageOutputRGBA.Controls.Add(this.label10);
            this.tabPageOutputRGBA.Controls.Add(this.label11);
            this.tabPageOutputRGBA.Controls.Add(this.label12);
            this.tabPageOutputRGBA.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutputRGBA.Name = "tabPageOutputRGBA";
            this.tabPageOutputRGBA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutputRGBA.Size = new System.Drawing.Size(170, 110);
            this.tabPageOutputRGBA.TabIndex = 0;
            this.tabPageOutputRGBA.Text = "RGBA";
            this.tabPageOutputRGBA.UseVisualStyleBackColor = true;
            // 
            // TBOutputRGBAAlpha
            // 
            this.TBOutputRGBAAlpha.Location = new System.Drawing.Point(112, 83);
            this.TBOutputRGBAAlpha.Name = "TBOutputRGBAAlpha";
            this.TBOutputRGBAAlpha.ReadOnly = true;
            this.TBOutputRGBAAlpha.Size = new System.Drawing.Size(52, 20);
            this.TBOutputRGBAAlpha.TabIndex = 4;
            this.TBOutputRGBAAlpha.TabStop = false;
            this.TBOutputRGBAAlpha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // TBOutputRGBABlue
            // 
            this.TBOutputRGBABlue.Location = new System.Drawing.Point(112, 57);
            this.TBOutputRGBABlue.Name = "TBOutputRGBABlue";
            this.TBOutputRGBABlue.ReadOnly = true;
            this.TBOutputRGBABlue.Size = new System.Drawing.Size(52, 20);
            this.TBOutputRGBABlue.TabIndex = 3;
            this.TBOutputRGBABlue.TabStop = false;
            this.TBOutputRGBABlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // TBOutputRGBAGreen
            // 
            this.TBOutputRGBAGreen.Location = new System.Drawing.Point(112, 31);
            this.TBOutputRGBAGreen.Name = "TBOutputRGBAGreen";
            this.TBOutputRGBAGreen.ReadOnly = true;
            this.TBOutputRGBAGreen.Size = new System.Drawing.Size(52, 20);
            this.TBOutputRGBAGreen.TabIndex = 2;
            this.TBOutputRGBAGreen.TabStop = false;
            this.TBOutputRGBAGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // TBOutputRGBARed
            // 
            this.TBOutputRGBARed.Location = new System.Drawing.Point(112, 5);
            this.TBOutputRGBARed.Name = "TBOutputRGBARed";
            this.TBOutputRGBARed.ReadOnly = true;
            this.TBOutputRGBARed.Size = new System.Drawing.Size(52, 20);
            this.TBOutputRGBARed.TabIndex = 1;
            this.TBOutputRGBARed.TabStop = false;
            this.TBOutputRGBARed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Alpha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(6, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Blue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(6, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Green";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(6, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Red";
            // 
            // tabPageOutputFloat
            // 
            this.tabPageOutputFloat.Controls.Add(this.TBOutputFloatAlpha);
            this.tabPageOutputFloat.Controls.Add(this.TBOutputFloatBlue);
            this.tabPageOutputFloat.Controls.Add(this.TBOutputFloatGreen);
            this.tabPageOutputFloat.Controls.Add(this.TBOutputFloatRed);
            this.tabPageOutputFloat.Controls.Add(this.label13);
            this.tabPageOutputFloat.Controls.Add(this.label14);
            this.tabPageOutputFloat.Controls.Add(this.label15);
            this.tabPageOutputFloat.Controls.Add(this.label16);
            this.tabPageOutputFloat.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutputFloat.Name = "tabPageOutputFloat";
            this.tabPageOutputFloat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutputFloat.Size = new System.Drawing.Size(170, 110);
            this.tabPageOutputFloat.TabIndex = 1;
            this.tabPageOutputFloat.Text = "Float";
            this.tabPageOutputFloat.UseVisualStyleBackColor = true;
            // 
            // TBOutputFloatAlpha
            // 
            this.TBOutputFloatAlpha.Location = new System.Drawing.Point(112, 83);
            this.TBOutputFloatAlpha.Name = "TBOutputFloatAlpha";
            this.TBOutputFloatAlpha.ReadOnly = true;
            this.TBOutputFloatAlpha.Size = new System.Drawing.Size(52, 20);
            this.TBOutputFloatAlpha.TabIndex = 4;
            this.TBOutputFloatAlpha.TabStop = false;
            this.TBOutputFloatAlpha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // TBOutputFloatBlue
            // 
            this.TBOutputFloatBlue.Location = new System.Drawing.Point(112, 57);
            this.TBOutputFloatBlue.Name = "TBOutputFloatBlue";
            this.TBOutputFloatBlue.ReadOnly = true;
            this.TBOutputFloatBlue.Size = new System.Drawing.Size(52, 20);
            this.TBOutputFloatBlue.TabIndex = 3;
            this.TBOutputFloatBlue.TabStop = false;
            this.TBOutputFloatBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // TBOutputFloatGreen
            // 
            this.TBOutputFloatGreen.Location = new System.Drawing.Point(112, 31);
            this.TBOutputFloatGreen.Name = "TBOutputFloatGreen";
            this.TBOutputFloatGreen.ReadOnly = true;
            this.TBOutputFloatGreen.Size = new System.Drawing.Size(52, 20);
            this.TBOutputFloatGreen.TabIndex = 2;
            this.TBOutputFloatGreen.TabStop = false;
            this.TBOutputFloatGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // TBOutputFloatRed
            // 
            this.TBOutputFloatRed.Location = new System.Drawing.Point(112, 5);
            this.TBOutputFloatRed.Name = "TBOutputFloatRed";
            this.TBOutputFloatRed.ReadOnly = true;
            this.TBOutputFloatRed.Size = new System.Drawing.Size(52, 20);
            this.TBOutputFloatRed.TabIndex = 1;
            this.TBOutputFloatRed.TabStop = false;
            this.TBOutputFloatRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(6, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Alpha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(6, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Blue";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(6, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Green";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(6, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Red";
            // 
            // tabPageOutputHex
            // 
            this.tabPageOutputHex.Controls.Add(this.TBOutputHex);
            this.tabPageOutputHex.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutputHex.Name = "tabPageOutputHex";
            this.tabPageOutputHex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutputHex.Size = new System.Drawing.Size(170, 110);
            this.tabPageOutputHex.TabIndex = 2;
            this.tabPageOutputHex.Text = "Hex";
            this.tabPageOutputHex.UseVisualStyleBackColor = true;
            // 
            // TBOutputHex
            // 
            this.TBOutputHex.Location = new System.Drawing.Point(6, 6);
            this.TBOutputHex.Name = "TBOutputHex";
            this.TBOutputHex.ReadOnly = true;
            this.TBOutputHex.Size = new System.Drawing.Size(158, 20);
            this.TBOutputHex.TabIndex = 1;
            this.TBOutputHex.TabStop = false;
            this.TBOutputHex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // tabPageOutputInt
            // 
            this.tabPageOutputInt.Controls.Add(this.TBOutputInt);
            this.tabPageOutputInt.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutputInt.Name = "tabPageOutputInt";
            this.tabPageOutputInt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutputInt.Size = new System.Drawing.Size(170, 110);
            this.tabPageOutputInt.TabIndex = 3;
            this.tabPageOutputInt.Text = "Int";
            this.tabPageOutputInt.UseVisualStyleBackColor = true;
            // 
            // TBOutputInt
            // 
            this.TBOutputInt.Location = new System.Drawing.Point(6, 6);
            this.TBOutputInt.Name = "TBOutputInt";
            this.TBOutputInt.ReadOnly = true;
            this.TBOutputInt.Size = new System.Drawing.Size(158, 20);
            this.TBOutputInt.TabIndex = 1;
            this.TBOutputInt.TabStop = false;
            this.TBOutputInt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            // 
            // PictureBoxColor
            // 
            this.PictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxColor.Location = new System.Drawing.Point(12, 173);
            this.PictureBoxColor.Name = "PictureBoxColor";
            this.PictureBoxColor.Size = new System.Drawing.Size(23, 23);
            this.PictureBoxColor.TabIndex = 0;
            this.PictureBoxColor.TabStop = false;
            this.PictureBoxColor.MouseHover += new System.EventHandler(this.PictureBoxColor_MouseHover);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 208);
            this.Controls.Add(this.PictureBoxColor);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.BTNConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Colorsion";
            this.groupBoxInput.ResumeLayout(false);
            this.tabControlInput.ResumeLayout(false);
            this.tabPageInputRGBA.ResumeLayout(false);
            this.tabPageInputRGBA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputRGBAAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputRGBABlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputRGBAGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputRGBARed)).EndInit();
            this.tabPageInputFloat.ResumeLayout(false);
            this.tabPageInputFloat.PerformLayout();
            this.tabPageInputHex.ResumeLayout(false);
            this.tabPageInputHex.PerformLayout();
            this.tabPageInputInt.ResumeLayout(false);
            this.tabPageInputInt.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.tabControlOutput.ResumeLayout(false);
            this.tabPageOutputRGBA.ResumeLayout(false);
            this.tabPageOutputRGBA.PerformLayout();
            this.tabPageOutputFloat.ResumeLayout(false);
            this.tabPageOutputFloat.PerformLayout();
            this.tabPageOutputHex.ResumeLayout(false);
            this.tabPageOutputHex.PerformLayout();
            this.tabPageOutputInt.ResumeLayout(false);
            this.tabPageOutputInt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTNConvert;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TabControl tabControlInput;
        private System.Windows.Forms.TabPage tabPageInputRGBA;
        private System.Windows.Forms.TabPage tabPageInputFloat;
        private System.Windows.Forms.TabPage tabPageInputHex;
        private System.Windows.Forms.TabPage tabPageInputInt;
        private System.Windows.Forms.NumericUpDown NUDInputRGBAAlpha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDInputRGBABlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDInputRGBAGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDInputRGBARed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBInputFloatAlpha;
        private System.Windows.Forms.TextBox TBInputFloatBlue;
        private System.Windows.Forms.TextBox TBInputFloatGreen;
        private System.Windows.Forms.TextBox TBInputFloatRed;
        private System.Windows.Forms.TextBox TBInputHex;
        private System.Windows.Forms.TextBox TBInputInt;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TabControl tabControlOutput;
        private System.Windows.Forms.TabPage tabPageOutputRGBA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPageOutputFloat;
        private System.Windows.Forms.TextBox TBOutputFloatAlpha;
        private System.Windows.Forms.TextBox TBOutputFloatBlue;
        private System.Windows.Forms.TextBox TBOutputFloatGreen;
        private System.Windows.Forms.TextBox TBOutputFloatRed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPageOutputHex;
        private System.Windows.Forms.TextBox TBOutputHex;
        private System.Windows.Forms.TabPage tabPageOutputInt;
        private System.Windows.Forms.TextBox TBOutputInt;
        private System.Windows.Forms.TextBox TBOutputRGBAAlpha;
        private System.Windows.Forms.TextBox TBOutputRGBABlue;
        private System.Windows.Forms.TextBox TBOutputRGBAGreen;
        private System.Windows.Forms.TextBox TBOutputRGBARed;
        private System.Windows.Forms.PictureBox PictureBoxColor;
    }
}

