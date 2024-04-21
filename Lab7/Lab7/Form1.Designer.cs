// Ваш Form1.Designer.cs

namespace Lab7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.ComboBox comboBoxLanguages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 397);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 12);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(93, 12);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(75, 23);
            this.btnCenter.TabIndex = 2;
            this.btnCenter.Text = "Center";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(174, 12);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(255, 12);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnBold
            // 
            this.btnBold.Location = new System.Drawing.Point(336, 12);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(75, 23);
            this.btnBold.TabIndex = 5;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Location = new System.Drawing.Point(417, 12);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(75, 23);
            this.btnItalic.TabIndex = 6;
            this.btnItalic.Text = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Location = new System.Drawing.Point(498, 12);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(75, 23);
            this.btnUnderline.TabIndex = 7;
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // comboBoxLanguages
            // 
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Location = new System.Drawing.Point(579, 12);
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLanguages.TabIndex = 8;
            this.comboBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguages_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxLanguages);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
    }
}
