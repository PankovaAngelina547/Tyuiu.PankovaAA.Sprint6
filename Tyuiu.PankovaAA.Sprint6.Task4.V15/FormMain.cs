using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.PankovaAA.Sprint6.Task4.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_PAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_PAA.Text);

                if (startStep > stopStep)
                {
                    MessageBox.Show("Старт шага должен быть меньше или равен концу шага", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataService ds = new DataService();
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_PAA.Clear();
                chartFunction_PAA.Series[0].Points.Clear();

                chartFunction_PAA.Titles.Clear();
                chartFunction_PAA.Titles.Add("График функции F(x)");
                chartFunction_PAA.Series[0].ChartType = SeriesChartType.Spline;
                chartFunction_PAA.Series[0].BorderWidth = 2;

                for (int i = 0; i < valueArray.Length; i++)
                {
                    textBoxResult_PAA.AppendText($"{valueArray[i]}" + Environment.NewLine);
                    chartFunction_PAA.Series[0].Points.AddXY(startStep + i, valueArray[i]);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: введите целые числа!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxResult_PAA.Text))
                {
                    MessageBox.Show("Нет данных для сохранения. Сначала выполните расчет.", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V15.txt";
                File.WriteAllText(path, textBoxResult_PAA.Text);

                DialogResult result = MessageBox.Show($"Файл сохранен по пути: {path}\n\nОткрыть его в блокноте?", "Сообщение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Process.Start("notepad.exe", path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПИНб-25-1 Панькова Ангелина Алексеевна",
                          "Справка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        public class DataService
        {
            public double[] GetMassFunction(int startValue, int stopValue)
            {
                int size = stopValue - startValue + 1;
                double[] result = new double[size];

                for (int i = 0; i < size; i++)
                {
                    int x = startValue + i;
                    result[i] = CalculateFunction(x);
                }

                return result;
            }

            private double CalculateFunction(int x)
            {
                double denominator = 3;

                if (Math.Abs(denominator) < 0.000001)
                {
                    return 0;
                }

                double sinPart = Math.Sin(x);
                double fraction = (2 * x) / denominator;
                double cosPart = Math.Cos(x) * 4 * x;

                double result = sinPart + fraction - cosPart;
                return Math.Round(result, 2);
            }
        }
    }
}