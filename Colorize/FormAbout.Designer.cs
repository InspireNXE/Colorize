namespace Colorize
{
    partial class FormAbout
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
            this.TBLicense = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBLicense
            // 
            this.TBLicense.Location = new System.Drawing.Point(12, 149);
            this.TBLicense.Multiline = true;
            this.TBLicense.Name = "TBLicense";
            this.TBLicense.ReadOnly = true;
            this.TBLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBLicense.Size = new System.Drawing.Size(406, 146);
            this.TBLicense.TabIndex = 0;
            this.TBLicense.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Colorize.Properties.Resources.logo_120x120;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblName.Location = new System.Drawing.Point(232, 10);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(117, 20);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "ProductName";
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.Location = new System.Drawing.Point(248, 31);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(79, 13);
            this.LblVersion.TabIndex = 3;
            this.LblVersion.Text = "ProductVersion";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(138, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "Colorize is a simple and lightweight tool aimed to take one color format and conv" +
    "ert it to another.";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBLicense);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBLicense;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label label3;
    }
}