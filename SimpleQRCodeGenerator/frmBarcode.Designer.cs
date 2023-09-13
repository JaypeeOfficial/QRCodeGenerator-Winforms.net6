namespace SimpleQRCodeGenerator
{
    partial class frmBarcode
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
            textBox1 = new TextBox();
            btnGenerate = new Button();
            chkWLogo = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(235, 8);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(228, 28);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // chkWLogo
            // 
            chkWLogo.AutoSize = true;
            chkWLogo.Location = new Point(22, 50);
            chkWLogo.Name = "chkWLogo";
            chkWLogo.Size = new Size(95, 19);
            chkWLogo.TabIndex = 2;
            chkWLogo.Text = "Is with Logo?";
            chkWLogo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(616, 596);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmBarcode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 699);
            Controls.Add(pictureBox1);
            Controls.Add(chkWLogo);
            Controls.Add(btnGenerate);
            Controls.Add(textBox1);
            Name = "frmBarcode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBarcode";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnGenerate;
        private CheckBox chkWLogo;
        private PictureBox pictureBox1;
    }
}