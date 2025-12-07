#nullable disable
using System;
using System.Text;
using System.Windows.Forms;

namespace Tyuiu.PankovaAA.Sprint6.Task0.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonCalculate_PAA.Click += ButtonCalculate_Click_PAA;
            оПрограммеToolStripMenuItem.Click += AboutMenuItem_Click;
        }

        private void ButtonCalculate_Click_PAA(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_PAA.Text);
                int end = Convert.ToInt32(textBoxEnd_PAA.Text);

                if (start > end)
                {
                    MessageBox.Show("Старт шага должен быть меньше или равен концу шага", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var service = new DataService();
                double[] results = service.GetMassFunction(start, end);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("|   X   |  F(x)  |");
                sb.AppendLine("+-------+--------+");

                for (int i = 0; i < results.Length; i++)
                {
                    int x = start + i;
                    sb.AppendLine($"| {x,5} | {results[i],7:F2} |");
                }
                sb.AppendLine("+-------+--------+");

                textBoxResult_PAA.Text = sb.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: введите целые числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПИНб-25-1 Панькова Ангелина Алексеевна", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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