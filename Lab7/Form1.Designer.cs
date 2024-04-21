namespace Lab7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImage = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSharpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.btnImage,
            this.themesToolStripMenuItem,
            this.syntaxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1312, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            this.languageToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // btnImage
            // 
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(52, 20);
            this.btnImage.Text = "Image";
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardThemeToolStripMenuItem,
            this.nightThemeToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // standardThemeToolStripMenuItem
            // 
            this.standardThemeToolStripMenuItem.Name = "standardThemeToolStripMenuItem";
            this.standardThemeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.standardThemeToolStripMenuItem.Text = "Standard Theme";
            this.standardThemeToolStripMenuItem.Click += new System.EventHandler(this.standardThemeToolStripMenuItem_Click);
            // 
            // nightThemeToolStripMenuItem
            // 
            this.nightThemeToolStripMenuItem.Name = "nightThemeToolStripMenuItem";
            this.nightThemeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nightThemeToolStripMenuItem.Text = "Night Theme";
            this.nightThemeToolStripMenuItem.Click += new System.EventHandler(this.nightThemeToolStripMenuItem_Click);
            // 
            // syntaxToolStripMenuItem
            // 
            this.syntaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSharpToolStripMenuItem,
            this.pythonToolStripMenuItem,
            this.sqlToolStripMenuItem});
            this.syntaxToolStripMenuItem.Name = "syntaxToolStripMenuItem";
            this.syntaxToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.syntaxToolStripMenuItem.Text = "Syntax";
            // 
            // cSharpToolStripMenuItem
            // 
            this.cSharpToolStripMenuItem.Name = "cSharpToolStripMenuItem";
            this.cSharpToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.cSharpToolStripMenuItem.Text = "C#";
            this.cSharpToolStripMenuItem.Click += new System.EventHandler(this.cSharpToolStripMenuItem_Click);
            // 
            // pythonToolStripMenuItem
            // 
            this.pythonToolStripMenuItem.Name = "pythonToolStripMenuItem";
            this.pythonToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pythonToolStripMenuItem.Text = "Python";
            this.pythonToolStripMenuItem.Click += new System.EventHandler(this.pythonToolStripMenuItem_Click);
            // 
            // sqlToolStripMenuItem
            // 
            this.sqlToolStripMenuItem.Name = "sqlToolStripMenuItem";
            this.sqlToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.sqlToolStripMenuItem.Text = "SQL";
            this.sqlToolStripMenuItem.Click += new System.EventHandler(this.sqlToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1245, 654);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(12, 29);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(0, 13);
            this.lblLanguage.TabIndex = 2;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(230, 29);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(0, 13);
            this.lblFont.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 798);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnImage;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nightThemeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem syntaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSharpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pythonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sqlToolStripMenuItem;
    }
}
