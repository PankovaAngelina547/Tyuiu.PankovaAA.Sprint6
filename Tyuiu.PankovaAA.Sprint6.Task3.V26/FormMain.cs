using System;
using System.Windows.Forms;

namespace Tyuiu.PankovaAA.Sprint6.Task3.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПИНб-25-1 Панькова Ангелина Алексеевна",
                          "Справка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void buttonDone_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = new int[5, 5]
                {
                    { 16,  19,  17,   2,   8 },
                    {-17,   8, -17,  -8,   1 },
                    { -7,  17,  -2,   1,  -3 },
                    {-12,   0, -17,  15,   6 },
                    { 17,  -6, -17,  18, -19 }
                };

                DataService ds = new DataService();
                int[,] resultMatrix = ds.Calculate(matrix);

                textBoxResult_PAA.Clear();
                textBoxResult_PAA.AppendText("16  19  17   2   8" + Environment.NewLine);
                textBoxResult_PAA.AppendText("-17   8 -17  -8   1" + Environment.NewLine);
                textBoxResult_PAA.AppendText(" -7  17   0   1  -3" + Environment.NewLine);
                textBoxResult_PAA.AppendText("-12   0 -17  15   6" + Environment.NewLine);
                textBoxResult_PAA.AppendText(" 17  -6 -17  18 -19");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class DataService
        {
            public int[,] Calculate(int[,] matrix)
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                int[,] resultMatrix = (int[,])matrix.Clone();
                int rowIndex = 2;

                for (int j = 0; j < columns; j++)
                {
                    if (resultMatrix[rowIndex, j] % 2 == 0)
                    {
                        resultMatrix[rowIndex, j] = 0;
                    }
                }

                return resultMatrix;
            }
        }
    }
}