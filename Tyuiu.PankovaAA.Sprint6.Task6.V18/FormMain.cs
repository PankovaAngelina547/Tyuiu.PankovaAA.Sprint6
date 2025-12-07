using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Tyulu.PankovaAA.Sprint6
{
    public partial class FormMain : Form
    {
        private DataService dataService;

        public FormMain()
        {
            InitializeComponent();
            dataService = new DataService();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите файл InPutFileTask6V18.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    labelPath.Text = "Путь к файлу: " + openFileDialog.FileName;
                    textBoxIn.Text = dataService.CollectTextFromFile(openFileDialog.FileName);
                }
            }
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            string[] separators = { " ", "\r", "\n", "\t", ",", ".", "!", "?", ";", ":", "(", ")", "[", "]", "{", "}", "\"", "'" };
            string[] words = textBoxIn.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (word.Contains('n'))
                {
                    result.Append(word + " ");
                }
            }

            textBoxOut.Text = result.ToString().Trim();
        }
    }
}