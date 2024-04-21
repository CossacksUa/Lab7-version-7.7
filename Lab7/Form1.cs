using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private ContextMenuStrip contextMenuStrip;
        private bool isTextChanged = false;

        public Form1()
        {
            InitializeComponent();
            LoadLanguages();
            AddContextMenuItems();
        }

        private void LoadLanguages()
        {
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                new ToolStripMenuItem("English", null, englishToolStripMenuItem_Click),
                new ToolStripMenuItem("Українська", null, українськаToolStripMenuItem_Click)
            });
            ChangeLanguage("en");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial", 12);
            UpdateFontLabel();
            SetStandardTheme();
            richTextBox1.TextChanged += (s, ev) => isTextChanged = true;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isTextChanged)
            {
                DialogResult result = MessageBox.Show("Чи потрібно зберегти зміни?", "Збереження", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void ChangeLanguage(string lang)
        {
            if (lang == "uk")
            {
                fileToolStripMenuItem.Text = "Файл";
                btnImage.Text = "Зображення";
                openToolStripMenuItem.Text = "Відкрити";
                saveToolStripMenuItem.Text = "Зберегти";
                languageToolStripMenuItem.Text = "Мова";
                lblLanguage.Text = "Мова: Українська";
                themesToolStripMenuItem.Text = "Тема";
                    standardThemeToolStripMenuItem.Text = "Стандартна";
                nightThemeToolStripMenuItem.Text = "Нічна";
                syntaxToolStripMenuItem.Text = "Синтакси";
            }
            else
            {
                fileToolStripMenuItem.Text = "File";
                btnImage.Text = "Image";
                openToolStripMenuItem.Text = "Open";
                saveToolStripMenuItem.Text = "Save";
                languageToolStripMenuItem.Text = "Language";
                lblLanguage.Text = "Language: English";
                themesToolStripMenuItem.Text = "Themes";
                standardThemeToolStripMenuItem.Text = "Standart";
                nightThemeToolStripMenuItem.Text = "Night";
                syntaxToolStripMenuItem.Text = "Syntax";
            }
            AddContextMenuItems();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }

        private void українськаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("uk");
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
                UpdateFontLabel();
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
                UpdateFontLabel();
            }
        }

        private void UpdateFontLabel()
        {
            if (richTextBox1.SelectionFont != null)
            {
                lblFont.Text = $"Font: {richTextBox1.SelectionFont.Name}, Size: {richTextBox1.SelectionFont.Size}, Color: {richTextBox1.SelectionColor.Name}";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "RTF Files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                isTextChanged = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF Files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                UpdateFontLabel();
                isTextChanged = false;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                Clipboard.SetImage(img);
                richTextBox1.Paste();
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateFontLabel();
        }

        private void alignLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alignRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }


        private void AddContextMenuItems()
        {
            contextMenuStrip = new ContextMenuStrip();

            // Меню для мов
            var languageMenu = new ToolStripMenuItem("Мова");
            languageMenu.DropDownItems.AddRange(new ToolStripItem[]
            {
        new ToolStripMenuItem("C#", null, (s, e) => HighlightSyntax("C#")),
        new ToolStripMenuItem("C", null, (s, e) => HighlightSyntax("C")),
        new ToolStripMenuItem("C++", null, (s, e) => HighlightSyntax("CPP")),
        new ToolStripMenuItem("Python", null, (s, e) => HighlightSyntax("Python")),
        new ToolStripMenuItem("SQL", null, (s, e) => HighlightSyntax("SQL"))
            });

            // Меню для вирівнювання тексту
            var alignMenu = new ToolStripMenuItem("Вирівнювання");
            alignMenu.DropDownItems.AddRange(new ToolStripItem[]
            {
        new ToolStripMenuItem("Ліворуч", null, alignLeftToolStripMenuItem_Click),
        new ToolStripMenuItem("Центр", null, alignCenterToolStripMenuItem_Click),
        new ToolStripMenuItem("Праворуч", null, alignRightToolStripMenuItem_Click)
            });

            // Меню для налаштування шрифту
            var fontMenu = new ToolStripMenuItem("Шрифт");
            fontMenu.DropDownItems.AddRange(new ToolStripItem[]
            {
        new ToolStripMenuItem("Змінити...", null, btnFont_Click),
        new ToolStripMenuItem("Жирний", null, btnBold_Click),
        new ToolStripMenuItem("Курсив", null, btnItalic_Click),
        new ToolStripMenuItem("Підкреслений", null, btnUnderline_Click)
            });

            // Меню для емодзі
            var emojiMenu = new ToolStripMenuItem("Емодзі");
            emojiMenu.DropDownItems.AddRange(new ToolStripItem[]
            {
        new ToolStripMenuItem("😀", null, (s, e) => InsertEmoji("😀")),
        new ToolStripMenuItem("😁", null, (s, e) => InsertEmoji("😁")),
        new ToolStripMenuItem("😂", null, (s, e) => InsertEmoji("😂")),
        new ToolStripMenuItem("😃", null, (s, e) => InsertEmoji("😃")),
        new ToolStripMenuItem("😄", null, (s, e) => InsertEmoji("😄")),
        new ToolStripMenuItem("😅", null, (s, e) => InsertEmoji("😅")),
        new ToolStripMenuItem("😆", null, (s, e) => InsertEmoji("😆")),
        new ToolStripMenuItem("😉", null, (s, e) => InsertEmoji("😉")),
        new ToolStripMenuItem("😊", null, (s, e) => InsertEmoji("😊")),
        new ToolStripMenuItem("😋", null, (s, e) => InsertEmoji("😋"))
            });

            contextMenuStrip.Items.AddRange(new ToolStripItem[]
            {
        languageMenu,
        new ToolStripSeparator(),
        new ToolStripMenuItem("Вирізати", null, (s, e) => richTextBox1.Cut()),
        new ToolStripMenuItem("Копіювати", null, (s, e) => richTextBox1.Copy()),
        new ToolStripMenuItem("Вставити", null, (s, e) => richTextBox1.Paste()),
        new ToolStripSeparator(),
        fontMenu,
        new ToolStripSeparator(),
        emojiMenu,
        new ToolStripSeparator(),
        alignMenu
            });

            richTextBox1.ContextMenuStrip = contextMenuStrip;
        }

        private void InsertEmoji(string emoji)
        {
            richTextBox1.SelectedText = emoji;
        }





        private void HighlightSyntax(string lang)
        {
            switch (lang)
            {
                case "C#":
                    HighlightCSharpSyntax();
                    break;
                case "C":
                    HighlightCSyntax();
                    break;
                case "CPP":
                    HighlightCppSyntax();
                    break;
                case "Python":
                    HighlightPythonSyntax();
                    break;
                case "SQL":
                    HighlightSQLSyntax();
                    break;
                default:
                    // Ваш код для підсвічування інших мов
                    break;
            }
        }


        private void HighlightCSharpSyntax()
        {
            HighlightSyntaxInternal("C#");
        }

        private void HighlightCSyntax()
        {
            HighlightSyntaxInternal("C");
        }

        private void HighlightCppSyntax()
        {
            HighlightSyntaxInternal("CPP");
        }

        private void HighlightPythonSyntax()
        {
            HighlightSyntaxInternal("Python");
        }

        private void HighlightSQLSyntax()
        {
            HighlightSyntaxInternal("SQL");
        }

        private void HighlightSyntaxInternal(string lang)
        {
            // Очистка попереднього форматування
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;

            // Визначення шаблонів синтаксису
            var patterns = new Dictionary<string, string>();

            switch (lang)
            {
                case "C#":
                    patterns = new Dictionary<string, string>
            {
                { "CSharpKeywords", @"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while)\b" },
                { "CSharpComments", @"\/\/.*" },
                { "CSharpStrings", @"""([^""\\]|\\.)*""" }
            };
                    break;
                case "C":
                    patterns = new Dictionary<string, string>
            {
                { "CKeywords", @"\b(auto|break|case|char|const|continue|default|do|double|else|enum|extern|float|for|goto|if|int|long|register|return|short|signed|sizeof|static|struct|switch|typedef|union|unsigned|void|volatile|while)\b" },
                { "CComments", @"\/\/.*|\/\*.*\*\/" },
                { "CStrings", @"""([^""\\]|\\.)*""" }
            };
                    break;
                case "CPP":
                    patterns = new Dictionary<string, string>
            {
                { "CPPKeywords", @"\b(alignas|alignof|and|and_eq|asm|atomic_cancel|atomic_commit|atomic_noexcept|auto|bitand|bitor|bool|break|case|catch|char|char8_t|char16_t|char32_t|class|compl|concept|const|const_cast|consteval|constexpr|constinit|continue|co_await|co_return|co_yield|decltype|default|delete|do|double|dynamic_cast|else|enum|explicit|export|extern|false|float|for|friend|goto|if|inline|int|long|mutable|namespace|new|noexcept|not|not_eq|nullptr|operator|or|or_eq|private|protected|public|register|reinterpret_cast|requires|return|short|signed|sizeof|static|static_assert|static_cast|struct|switch|synchronized|template|this|thread_local|throw|true|try|typedef|typeid|typename|union|unsigned|using|virtual|void|volatile|wchar_t|while|xor|xor_eq)\b" },
                { "CPPComments", @"\/\/.*|\/\*.*\*\/" },
                { "CPPStrings", @"""([^""\\]|\\.)*""" }
            };
                    break;
                case "Python":
                    patterns = new Dictionary<string, string>
            {
                { "PythonKeywords", @"\b(and|as|assert|async|await|break|class|continue|def|del|elif|else|except|finally|for|from|global|if|import|in|is|lambda|nonlocal|not|or|pass|print|raise|return|try|while|with|yield)\b" },
                { "PythonComments", @"#.*" },
                { "PythonStrings", @"""([^""\\]|\\.)*""" }
            };
                    break;
                case "SQL":
                    patterns = new Dictionary<string, string>
            {
                { "SQL", @"\b(SELECT|FROM|WHERE|AND|OR|INSERT|INTO|VALUES|UPDATE|SET|DELETE|CREATE|TABLE|DROP|DATABASE|JOIN|INNER|OUTER|LEFT|RIGHT|ORDER|BY|GROUP|HAVING|AS|ON|ASC|DESC)\b" }
            };
                    break;
            }

            // Підсвічування синтаксису
            foreach (var pattern in patterns)
            {
                MatchCollection matches = Regex.Matches(richTextBox1.Text, pattern.Value);
                foreach (Match m in matches)
                {
                    richTextBox1.Select(m.Index, m.Length);
                    richTextBox1.SelectionColor = GetSyntaxColorInternal(lang, pattern.Key);
                }
            }

            // Повернення виділення на початок без підсвічування
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionColor = Color.Black;
        }

        private Color GetSyntaxColorInternal(string lang, string syntaxType)
        {
            switch (lang)
            {
                case "C#":
                    return GetCSharpSyntaxColor(syntaxType);
                case "C":
                    return GetCSyntaxColor(syntaxType);
                case "CPP":
                    return GetCppSyntaxColor(syntaxType);
                case "Python":
                    return GetPythonSyntaxColor(syntaxType);
                case "SQL":
                    return GetSQLSyntaxColor(syntaxType);
                default:
                    return Color.Black;
            }
        }

        private Color GetCSharpSyntaxColor(string syntaxType)
        {
            switch (syntaxType)
            {
                case "CSharpKeywords":
                    return Color.Blue;
                case "CSharpComments":
                    return Color.Green;
                case "CSharpStrings":
                    return Color.Brown;
                default:
                    return Color.Black;
            }
        }

        private Color GetCSyntaxColor(string syntaxType)
        {
            switch (syntaxType)
            {
                case "CKeywords":
                    return Color.Blue;
                case "CComments":
                    return Color.Green;
                case "CStrings":
                    return Color.Brown;
                default:
                    return Color.Black;
            }
        }

        private Color GetCppSyntaxColor(string syntaxType)
        {
            switch (syntaxType)
            {
                case "CPPKeywords":
                    return Color.Blue;
                case "CPPComments":
                    return Color.Green;
                case "CPPStrings":
                    return Color.Brown;
                default:
                    return Color.Black;
            }
        }

        private Color GetPythonSyntaxColor(string syntaxType)
        {
            switch (syntaxType)
            {
                case "PythonKeywords":
                    return Color.Blue;
                case "PythonComments":
                    return Color.Green;
                case "PythonStrings":
                    return Color.Brown;
                default:
                    return Color.Black;
            }
        }

        private Color GetSQLSyntaxColor(string syntaxType)
        {
            switch (syntaxType)
            {
                case "SQL":
                    return Color.Red;
                default:
                    return Color.Black;
            }
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (languageToolStripMenuItem.Text == "Мова")
            {
                ChangeLanguage("uk");
            }
            else
            {
                ChangeLanguage("en");
            }
        }

        private void SetStandardTheme()
        {
            this.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
            lblLanguage.ForeColor = Color.Black;
            lblFont.ForeColor = Color.Black;
        }

        private void SetNightTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
            richTextBox1.ForeColor = Color.White;
            lblLanguage.ForeColor = Color.White;
            lblFont.ForeColor = Color.White;
        }

        private void standardThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStandardTheme();
        }

        private void nightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNightTheme();
        }

        private void cSharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightSyntax("C#");
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightSyntax("Python");
        }

        private void sqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightSyntax("SQL");
        }
        private void cqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightSyntax("C");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isTextChanged = true;
        }
    }
    }
