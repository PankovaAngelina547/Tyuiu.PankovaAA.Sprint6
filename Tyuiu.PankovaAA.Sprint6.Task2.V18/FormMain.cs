#nullable disable
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.PankovaAA.Sprint6.Task0.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.buttonCalculate_PAA.Click += ButtonCalculate_PAA_Click;
            this.справкаToolStripMenuItem.Click += HelpMenuItem_Click;

            this.buttonCalculate_PAA.MouseEnter += ButtonCalculate_MouseEnter;
            this.buttonCalculate_PAA.MouseLeave += ButtonCalculate_MouseLeave;
        }

        private void ButtonCalculate_MouseEnter(object sender, EventArgs e)
        {
            buttonCalculate_PAA.BackColor = System.Drawing.Color.Green;
        }

        private void ButtonCalculate_MouseLeave(object sender, EventArgs e)
        {
            buttonCalculate_PAA.BackColor = System.Drawing.Color.Red;
        }

        private void ButtonCalculate_PAA_Click(object sender, EventArgs e)
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

                // Очистка
                dataGridViewFunction_PAA.Rows.Clear();
                chartFunction_PAA.Series[0].Points.Clear();
                chartFunction_PAA.Titles.Clear();

                // Настройка графика
                chartFunction_PAA.Titles.Add("График функции F(x)");
                chartFunction_PAA.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_PAA.ChartAreas[0].AxisY.Title = "Ось Y";

                // ВАЖНО: Устанавливаем тип графика - линейный
                chartFunction_PAA.Series[0].ChartType = SeriesChartType.Line;

                // Дополнительные настройки для лучшего отображения
                chartFunction_PAA.Series[0].BorderWidth = 2;
                chartFunction_PAA.Series[0].Color = System.Drawing.Color.Blue;

                // Заполнение таблицы и графика
                for (int i = 0; i < valueArray.Length; i++)
                {
                    dataGridViewFunction_PAA.Rows.Add(Convert.ToString(startStep + i),
                                                      Convert.ToString(valueArray[i]));
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

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПИНб-25-1 Панькова Ангелина Алексеевна",
                          "Информация о студенте",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
    }

    // КЛАСС DATASERVICE ВНУТРИ ФАЙЛА
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
            double denominator = 4 * x - 0.5;

            if (Math.Abs(denominator) < 0.000001)
            {
                return 0;
            }

            double numerator = 3 * Math.Cos(x);
            double fraction = numerator / denominator;
            double sinPart = Math.Sin(x);
            double linearPart = -5 * x - 2;

            double result = fraction + sinPart + linearPart;
            return Math.Round(result, 2);
        }
    }
}