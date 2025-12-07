using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.PankovaAA.Sprint6.Task5.V4
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
                    InitialDirectory = Directory.GetCurrentDirectory()
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    textBoxPath_PAA.Text = path;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExecute_PAA_Click(object sender, EventArgs e)
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
                double[] nums = ds.LoadFromDataFile(path);

                dataGridViewResult_PAA.Rows.Clear();
                dataGridViewResult_PAA.Columns.Clear();
                dataGridViewResult_PAA.Columns.Add("Значения", "Значения");

                chartResult_PAA.Series[0].Points.Clear();
                chartResult_PAA.Titles.Clear();
                chartResult_PAA.Titles.Add("Диаграмма целых чисел");
                chartResult_PAA.Series[0].ChartType = SeriesChartType.Column;
                chartResult_PAA.Series[0].Color = System.Drawing.Color.Blue;

                for (int i = 0; i < nums.Length; i++)
                {
                    dataGridViewResult_PAA.Rows.Add(nums[i].ToString());
                    chartResult_PAA.Series[0].Points.AddXY(i + 1, nums[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студент группы ПИНб-25-1 Панькова Ангелина Алексеевна",
                          "Справка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
    }

    public class DataService
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double[] numbers = new double[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(',', '.');
                if (double.TryParse(lines[i], System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out double num))
                {
                    numbers[i] = Math.Round(num, 3);
                }
                else
                {
                    numbers[i] = 0;
                }
            }

            double[] allIntegers = new double[0];
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i] - Math.Round(numbers[i])) < 0.001)
                {
                    Array.Resize(ref allIntegers, count + 1);
                    allIntegers[count] = Math.Round(numbers[i]);
                    count++;
                }
            }

            return allIntegers;
        }
    }
}