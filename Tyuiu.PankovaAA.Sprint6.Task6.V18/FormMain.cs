using System;
using System.IO;
using System.Windows.Forms;

namespace Tyuiu.PankovaAA.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    Title = "Выберите файл для обработки"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    textBoxPath_PAA.Text = path;

                    string fileContent = File.ReadAllText(path, System.Text.Encoding.Default);
                    textBoxIn_PAA.Text = fileContent;

                    textBoxOut_PAA.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDo_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxPath_PAA.Text))
                {
                    MessageBox.Show("Сначала откройте файл", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string path = textBoxPath_PAA.Text;

                DataService ds = new DataService();
                string result = ds.CollectTextFromFile(path);

                textBoxOut_PAA.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнила студент группы ПИНб-25-1 Панькова Ангелина Алексеевна",
                          "Справка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        public class DataService
        {
            public string CollectTextFromFile(string path)
            {
                string[] lines = File.ReadAllLines(path, System.Text.Encoding.Default);
                System.Text.StringBuilder result = new System.Text.StringBuilder();

                foreach (string line in lines)
                {
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t' },
                                               System.StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.IndexOf('n', System.StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            result.Append(word + " ");
                        }
                    }
                }

                return result.ToString().Trim();
            }
        }
    }
}