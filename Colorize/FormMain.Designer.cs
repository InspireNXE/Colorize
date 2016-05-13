namespace Colorize
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TB_Int_A = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_Int_B = new System.Windows.Forms.TextBox();
            this.TB_Int_G = new System.Windows.Forms.TextBox();
            this.TB_Int_R = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PBCurrentColor = new System.Windows.Forms.PictureBox();
            this.TB_Int = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_HEX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Float_A = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Float_B = new System.Windows.Forms.TextBox();
            this.TB_Float_G = new System.Windows.Forms.TextBox();
            this.TB_Float_R = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Source = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Issues = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Donate = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Releases = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.CDCustomColor = new System.Windows.Forms.ColorDialog();
            this.TTColorDialog = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.TB_PROG = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCurrentColor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.MSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.TB_Int_A);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TB_Int_B);
            this.groupBox1.Controls.Add(this.TB_Int_G);
            this.groupBox1.Controls.Add(this.TB_Int_R);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Int";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 14);
            this.label20.TabIndex = 54;
            this.label20.Text = "A";
            // 
            // TB_Int_A
            // 
            this.TB_Int_A.Location = new System.Drawing.Point(27, 105);
            this.TB_Int_A.Name = "TB_Int_A";
            this.TB_Int_A.Size = new System.Drawing.Size(64, 22);
            this.TB_Int_A.TabIndex = 3;
            this.TB_Int_A.Text = "255";
            this.TB_Int_A.TextChanged += new System.EventHandler(this.RGB_Int_TextChanged);
            this.TB_Int_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_Int_TextChanged);
            this.TB_Int_A.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 14);
            this.label10.TabIndex = 52;
            this.label10.Text = "B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 14);
            this.label11.TabIndex = 51;
            this.label11.Text = "G";
            // 
            // TB_Int_B
            // 
            this.TB_Int_B.Location = new System.Drawing.Point(27, 77);
            this.TB_Int_B.Name = "TB_Int_B";
            this.TB_Int_B.Size = new System.Drawing.Size(64, 22);
            this.TB_Int_B.TabIndex = 2;
            this.TB_Int_B.Text = "255";
            this.TB_Int_B.TextChanged += new System.EventHandler(this.RGB_Int_TextChanged);
            this.TB_Int_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_Int_TextChanged);
            this.TB_Int_B.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // TB_Int_G
            // 
            this.TB_Int_G.Location = new System.Drawing.Point(27, 49);
            this.TB_Int_G.Name = "TB_Int_G";
            this.TB_Int_G.Size = new System.Drawing.Size(64, 22);
            this.TB_Int_G.TabIndex = 1;
            this.TB_Int_G.Text = "156";
            this.TB_Int_G.TextChanged += new System.EventHandler(this.RGB_Int_TextChanged);
            this.TB_Int_G.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_Int_TextChanged);
            this.TB_Int_G.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // TB_Int_R
            // 
            this.TB_Int_R.Location = new System.Drawing.Point(27, 21);
            this.TB_Int_R.Name = "TB_Int_R";
            this.TB_Int_R.Size = new System.Drawing.Size(64, 22);
            this.TB_Int_R.TabIndex = 0;
            this.TB_Int_R.Text = "27";
            this.TB_Int_R.TextChanged += new System.EventHandler(this.RGB_Int_TextChanged);
            this.TB_Int_R.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_Int_TextChanged);
            this.TB_Int_R.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 14);
            this.label12.TabIndex = 47;
            this.label12.Text = "R";
            // 
            // PBCurrentColor
            // 
            this.PBCurrentColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.PBCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBCurrentColor.Location = new System.Drawing.Point(12, 232);
            this.PBCurrentColor.Name = "PBCurrentColor";
            this.PBCurrentColor.Size = new System.Drawing.Size(200, 24);
            this.PBCurrentColor.TabIndex = 25;
            this.PBCurrentColor.TabStop = false;
            this.PBCurrentColor.Click += new System.EventHandler(this.PBCurrentColor_Click);
            this.PBCurrentColor.MouseEnter += new System.EventHandler(this.PBCurrentColor_MouseEnter);
            this.PBCurrentColor.MouseLeave += new System.EventHandler(this.PBCurrentColor_MouseLeave);
            // 
            // TB_Int
            // 
            this.TB_Int.Location = new System.Drawing.Point(149, 176);
            this.TB_Int.Name = "TB_Int";
            this.TB_Int.Size = new System.Drawing.Size(63, 22);
            this.TB_Int.TabIndex = 3;
            this.TB_Int.Text = "-14967553";
            this.TB_Int.TextChanged += new System.EventHandler(this.Int_TextChanged);
            this.TB_Int.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Int_TextChanged);
            this.TB_Int.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 14);
            this.label7.TabIndex = 43;
            this.label7.Text = "HEX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 14);
            this.label9.TabIndex = 42;
            this.label9.Text = "Int";
            // 
            // TB_HEX
            // 
            this.TB_HEX.Location = new System.Drawing.Point(46, 176);
            this.TB_HEX.Name = "TB_HEX";
            this.TB_HEX.Size = new System.Drawing.Size(63, 22);
            this.TB_HEX.TabIndex = 2;
            this.TB_HEX.Text = "#1B9CFF";
            this.TB_HEX.TextChanged += new System.EventHandler(this.HEX_TextChanged);
            this.TB_HEX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HEX_TextChanged);
            this.TB_HEX.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TB_Float_A);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TB_Float_B);
            this.groupBox2.Controls.Add(this.TB_Float_G);
            this.groupBox2.Controls.Add(this.TB_Float_R);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(115, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Float";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 54;
            this.label1.Text = "A";
            // 
            // TB_Float_A
            // 
            this.TB_Float_A.Location = new System.Drawing.Point(27, 105);
            this.TB_Float_A.Name = "TB_Float_A";
            this.TB_Float_A.Size = new System.Drawing.Size(64, 22);
            this.TB_Float_A.TabIndex = 3;
            this.TB_Float_A.Text = "1";
            this.TB_Float_A.TextChanged += new System.EventHandler(this.RGB_Float_TextChanged);
            this.TB_Float_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_Float_TextChanged);
            this.TB_Float_A.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 52;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 14);
            this.label3.TabIndex = 51;
            this.label3.Text = "G";
            // 
            // TB_Float_B
            // 
            this.TB_Float_B.Location = new System.Drawing.Point(27, 77);
            this.TB_Float_B.Name = "TB_Float_B";
            this.TB_Float_B.Size = new System.Drawing.Size(64, 22);
            this.TB_Float_B.TabIndex = 2;
            this.TB_Float_B.Text = "1";
            this.TB_Float_B.TextChanged += new System.EventHandler(this.RGB_Float_TextChanged);
            this.TB_Float_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_Float_TextChanged);
            this.TB_Float_B.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // TB_Float_G
            // 
            this.TB_Float_G.Location = new System.Drawing.Point(27, 49);
            this.TB_Float_G.Name = "TB_Float_G";
            this.TB_Float_G.Size = new System.Drawing.Size(64, 22);
            this.TB_Float_G.TabIndex = 1;
            this.TB_Float_G.Text = "0.6117647";
            this.TB_Float_G.TextChanged += new System.EventHandler(this.RGB_Float_TextChanged);
            this.TB_Float_G.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_Float_TextChanged);
            this.TB_Float_G.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // TB_Float_R
            // 
            this.TB_Float_R.Location = new System.Drawing.Point(27, 21);
            this.TB_Float_R.Name = "TB_Float_R";
            this.TB_Float_R.Size = new System.Drawing.Size(64, 22);
            this.TB_Float_R.TabIndex = 0;
            this.TB_Float_R.Text = "0.1058824";
            this.TB_Float_R.TextChanged += new System.EventHandler(this.RGB_Float_TextChanged);
            this.TB_Float_R.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB_Float_TextChanged);
            this.TB_Float_R.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 14);
            this.label4.TabIndex = 47;
            this.label4.Text = "R";
            // 
            // MSMain
            // 
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(224, 24);
            this.MSMain.TabIndex = 46;
            this.MSMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // TSMI_File_Exit
            // 
            this.TSMI_File_Exit.Name = "TSMI_File_Exit";
            this.TSMI_File_Exit.Size = new System.Drawing.Size(92, 22);
            this.TSMI_File_Exit.Text = "Exit";
            this.TSMI_File_Exit.Click += new System.EventHandler(this.TSMI_File_Exit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Help_Source,
            this.TSMI_Help_Issues,
            this.TSMI_Help_Donate,
            this.TSMI_Help_Releases,
            this.TSMI_Help_About});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // TSMI_Help_Source
            // 
            this.TSMI_Help_Source.Name = "TSMI_Help_Source";
            this.TSMI_Help_Source.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Help_Source.Text = "Source";
            this.TSMI_Help_Source.Click += new System.EventHandler(this.TSMI_Help_Source_Click);
            // 
            // TSMI_Help_Issues
            // 
            this.TSMI_Help_Issues.Name = "TSMI_Help_Issues";
            this.TSMI_Help_Issues.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Help_Issues.Text = "Issues";
            this.TSMI_Help_Issues.Click += new System.EventHandler(this.TSMI_Help_Issues_Click);
            // 
            // TSMI_Help_Donate
            // 
            this.TSMI_Help_Donate.Name = "TSMI_Help_Donate";
            this.TSMI_Help_Donate.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Help_Donate.Text = "Donate";
            this.TSMI_Help_Donate.Click += new System.EventHandler(this.TSMI_Help_Donate_Click);
            // 
            // TSMI_Help_Releases
            // 
            this.TSMI_Help_Releases.Name = "TSMI_Help_Releases";
            this.TSMI_Help_Releases.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Help_Releases.Text = "Releases";
            this.TSMI_Help_Releases.Click += new System.EventHandler(this.TSMI_Help_Releases_Click);
            // 
            // TSMI_Help_About
            // 
            this.TSMI_Help_About.Name = "TSMI_Help_About";
            this.TSMI_Help_About.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Help_About.Text = "About";
            this.TSMI_Help_About.Click += new System.EventHandler(this.TSMI_Help_About_Click);
            // 
            // CDCustomColor
            // 
            this.CDCustomColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            // 
            // TTColorDialog
            // 
            this.TTColorDialog.ShowAlways = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 48;
            this.label5.Text = "PROG";
            // 
            // TB_PROG
            // 
            this.TB_PROG.Location = new System.Drawing.Point(46, 204);
            this.TB_PROG.Name = "TB_PROG";
            this.TB_PROG.Size = new System.Drawing.Size(63, 22);
            this.TB_PROG.TabIndex = 4;
            this.TB_PROG.Text = "0x1B9CFF";
            this.TB_PROG.TextChanged += new System.EventHandler(this.HEX_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 264);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_PROG);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TB_Int);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_HEX);
            this.Controls.Add(this.PBCurrentColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MSMain);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Colorize";
            this.Leave += new System.EventHandler(this.TB_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCurrentColor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PBCurrentColor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TB_Int_A;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_Int_B;
        private System.Windows.Forms.TextBox TB_Int_G;
        private System.Windows.Forms.TextBox TB_Int_R;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_Int;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_HEX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Float_A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Float_B;
        private System.Windows.Forms.TextBox TB_Float_G;
        private System.Windows.Forms.TextBox TB_Float_R;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Source;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Issues;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Donate;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_About;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Releases;
        private System.Windows.Forms.ColorDialog CDCustomColor;
        private System.Windows.Forms.ToolTip TTColorDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_PROG;
    }
}