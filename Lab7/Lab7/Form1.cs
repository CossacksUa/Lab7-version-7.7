using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Завантаження мов інтерфейсу
            LoadLanguages();
        }

        // Завантаження мов інтерфейсу
        private void LoadLanguages()
        {
            comboBoxLanguages.Items.Add("English");
            comboBoxLanguages.Items.Add("Українська");
            comboBoxLanguages.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Встановлення шрифту за замовчуванням
            richTextBox1.Font = new Font("Arial", 12);
        }

        // Зміна мови інтерфейсу
        private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLanguages.SelectedItem.ToString() == "Українська")
            {
                ChangeLanguage("uk");
            }
            else
            {
                ChangeLanguage("en");
            }
        }

        private void ChangeLanguage(string lang)
        {
            // Встановлення культури для зміни мови
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

            // Оновлення всіх елементів форми
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this, "$this");
            ApplyResources(this, resources);
        }

        private void ApplyResources(Control control, ComponentResourceManager resources)
        {
            foreach (Control c in control.Controls)
            {
                resources.ApplyResources(c, c.Name);
                if (c.Controls.Count > 0)
                {
                    ApplyResources(c, resources);
                }
            }
        }

        // Вирівнювання тексту
        private void btnLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        // Зміна шрифту тексту
        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }

        private void ToggleFontStyle(FontStyle style)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Bold && style == FontStyle.Bold)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else if (richTextBox1.SelectionFont.Italic && style == FontStyle.Italic)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else if (richTextBox1.SelectionFont.Underline && style == FontStyle.Underline)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = richTextBox1.SelectionFont.Style | style;
                }

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }
    }
}
