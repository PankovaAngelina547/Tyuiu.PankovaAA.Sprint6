#nullable disable
using System;
using System.Windows.Forms;

namespace Tyuiu.PankovaAA.Sprint6.Task0.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            this.buttonCalculate_PAA.Click += ButtonCalculate_Click_PAA;
            this.оПрограммеToolStripMenuItem.Click += AboutMenuItem_Click;
            this.buttonHelp_PAA.Click += ButtonHelp_PAA_Click;
        }

        private void ButtonCalculate_Click_PAA(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(this.textBoxX_PAA.Text);

                if (x * x - 2 <= 0)
                {
                    MessageBox.Show("Ошибка: x² должно быть больше 2", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double numerator = 2 * x * x - 1;
                double denominator = Math.Sqrt(x * x - 2);
                double result = numerator / denominator;
                result = Math.Round(result, 3);

                this.textBoxResult_PAA.Text = result.ToString("F3");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: введите числовое значение для x!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentInfo();
        }

        private void ButtonHelp_PAA_Click(object sender, EventArgs e)
        {
            ShowStudentInfo();
        }

        private void ShowStudentInfo()
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПИНб-25-1 Панькова Ангелина Алексеевна",
                          "Информация о студенте",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
    }
}