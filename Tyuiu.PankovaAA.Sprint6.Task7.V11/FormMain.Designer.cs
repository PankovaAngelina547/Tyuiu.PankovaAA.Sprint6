using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tyuiu.PankovaAA.Sprint6.Task7.V11.Lib;

namespace Sprint6Task7V11_PAA
{
    public partial class FormMain : Form
    {
        private DataService dataService;
        private int[,] originalMatrix;
        private string currentFilePath;
        private PictureBox pictureBoxPhoto_PAA;

        public FormMain()
        {
            InitializeComponent();
            dataService = new DataService();
            InitializeAppearance();
            InitializePhotoBox();
        }

        private void InitializeAppearance()
        {
            this.Text = "Таск 7 | Вариант 11 | Панькова А.А.";
            this.Size = new Size(900, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializePhotoBox()
        {
            pictureBoxPhoto_PAA = new PictureBox();
            pictureBoxPhoto_PAA.Size = new Size(150, 180);
            pictureBoxPhoto_PAA.Location = new Point(700, 450);
            pictureBoxPhoto_PAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto_PAA.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPhoto_PAA.Visible = false;
            this.Controls.Add(pictureBoxPhoto_PAA);
        }

        private void ButtonLoadFile_PAA_Click(object sender, EventArgs e)
        {
            if (openFileDialog_PAA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentFilePath = openFileDialog_PAA.FileName;

                    if (!Path.GetExtension(currentFilePath).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Пожалуйста, выберите CSV файл", "Неверный формат",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    FileInfo fileInfo = new FileInfo(currentFilePath);
                    if (fileInfo.Length == 0)
                    {
                        MessageBox.Show("Файл пустой", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (fileInfo.Length > 10 * 1024 * 1024)
                    {
                        MessageBox.Show("Файл слишком большой (максимум 10 МБ)", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    originalMatrix = dataService.GetMatrix(currentFilePath);

                    if (originalMatrix == null || originalMatrix.Length == 0)
                    {
                        MessageBox.Show("Не удалось загрузить данные из файла", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DisplayMatrixInDataGridView(dataGridViewIn_PAA, originalMatrix);
                    buttonTransform_PAA.Enabled = true;
                    buttonSaveFile_PAA.Enabled = false;

                    richTextBoxCondition_PAA.Text = $"Файл загружен: {Path.GetFileName(currentFilePath)}\n" +
                                                   $"Размер матрицы: {originalMatrix.GetLength(0)} строк × {originalMatrix.GetLength(1)} столбцов\n" +
                                                   "Нажмите 'Преобразовать' для замены отрицательных чисел в 5-й строке на 9";
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Ошибка загрузки файла:\n{ex.Message}";

                    if (ex.InnerException != null)
                    {
                        errorMessage += $"\n\nДетали: {ex.InnerException.Message}";
                    }

                    MessageBox.Show(errorMessage, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    buttonTransform_PAA.Enabled = false;
                    buttonSaveFile_PAA.Enabled = false;
                    dataGridViewIn_PAA.Rows.Clear();
                    dataGridViewIn_PAA.Columns.Clear();
                    dataGridViewOut_PAA.Rows.Clear();
                    dataGridViewOut_PAA.Columns.Clear();
                    originalMatrix = null;
                }
            }
        }

        private void ButtonTransform_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                if (originalMatrix == null)
                {
                    MessageBox.Show("Сначала загрузите файл!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[,] transformedMatrix = TransformMatrixFifthRow(originalMatrix);

                DisplayMatrixInDataGridView(dataGridViewOut_PAA, transformedMatrix);
                buttonSaveFile_PAA.Enabled = true;

                richTextBoxCondition_PAA.Text += "\n\nПреобразование выполнено! Отрицательные числа в 5-й строке заменены на 9.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка преобразования: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[,] TransformMatrixFifthRow(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows < 5)
            {
                throw new ArgumentException("Матрица должна содержать хотя бы 5 строк");
            }

            int[,] result = (int[,])matrix.Clone();

            for (int j = 0; j < cols; j++)
            {
                if (result[4, j] < 0)
                {
                    result[4, j] = 9;
                }
            }

            return result;
        }

        private void ButtonSaveFile_PAA_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_PAA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int[,] matrix = GetMatrixFromDataGridView(dataGridViewOut_PAA);
                    int rows = matrix.GetLength(0);
                    int cols = matrix.GetLength(1);

                    using (StreamWriter sw = new StreamWriter(saveFileDialog_PAA.FileName))
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            var row = new string[cols];
                            for (int j = 0; j < cols; j++)
                            {
                                row[j] = matrix[i, j].ToString();
                            }
                            sw.WriteLine(string.Join(";", row));
                        }
                    }

                    MessageBox.Show($"Файл успешно сохранён: {saveFileDialog_PAA.FileName}",
                        "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    richTextBoxCondition_PAA.Text += $"\n\nРезультат сохранён в файл: {Path.GetFileName(saveFileDialog_PAA.FileName)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonAbout_PAA_Click(object sender, EventArgs e)
        {
            Form aboutForm = new Form();
            aboutForm.Text = "О программе";
            aboutForm.Size = new Size(450, 400);
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            aboutForm.MaximizeBox = false;
            aboutForm.MinimizeBox = false;

            PictureBox photoBox = new PictureBox();
            photoBox.Size = new Size(150, 180);
            photoBox.Location = new Point(20, 20);
            photoBox.SizeMode = PictureBoxSizeMode.Zoom;
            photoBox.BorderStyle = BorderStyle.FixedSingle;

            try
            {
                string photoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "photo.jpg");
                if (File.Exists(photoPath))
                {
                    photoBox.Image = Image.FromFile(photoPath);
                }
                else
                {
                    CreatePlaceholderPhoto(photoBox);
                }
            }
            catch
            {
                CreatePlaceholderPhoto(photoBox);
            }

            Label infoLabel = new Label();
            infoLabel.Location = new Point(180, 20);
            infoLabel.Size = new Size(240, 300);
            infoLabel.Text = "Разработчик: Панькова Ангелина Алексеевна\n" +
                            "Группа: ПИНб-25-1\n\n" +
                            "Программа разработана в рамках изучения языка C#\n\n" +
                            "Тюменский индустриальный университет (с) 2025\n" +
                            "Высшая школа цифровых технологий (с) 2025\n\n" +
                            "Внутреннее имя: Tyuiu.PankovaAA.Sprint6.Task7.V11";

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Location = new Point(180, 320);
            okButton.Size = new Size(80, 30);
            okButton.Click += (s, args) => aboutForm.Close();

            aboutForm.Controls.Add(photoBox);
            aboutForm.Controls.Add(infoLabel);
            aboutForm.Controls.Add(okButton);

            aboutForm.ShowDialog();
        }

        private void CreatePlaceholderPhoto(PictureBox photoBox)
        {
            Bitmap placeholder = new Bitmap(150, 180);
            using (Graphics g = Graphics.FromImage(placeholder))
            {
                g.Clear(Color.LightGray);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString("Фото\nстудента",
                    new Font("Arial", 12, FontStyle.Bold),
                    Brushes.Black,
                    new RectangleF(0, 0, 150, 180),
                    sf);
                g.DrawRectangle(Pens.Black, 0, 0, 149, 179);
            }
            photoBox.Image = placeholder;
        }

        private void DisplayMatrixInDataGridView(DataGridView dgv, int[,] matrix)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int c = 0; c < cols; c++)
            {
                dgv.Columns.Add($"Col{c}", $"Столбец {c + 1}");
                dgv.Columns[c].Width = 70;
            }

            for (int r = 0; r < rows; r++)
            {
                dgv.Rows.Add();
                for (int c = 0; c < cols; c++)
                {
                    dgv.Rows[r].Cells[c].Value = matrix[r, c];

                    if (r == 4)
                    {
                        dgv.Rows[r].DefaultCellStyle.BackColor = Color.LightYellow;
                        dgv.Rows[r].DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
                    }

                    if (r == 4 && matrix[r, c] == 9 && originalMatrix != null && originalMatrix[4, c] < 0)
                    {
                        dgv.Rows[r].Cells[c].Style.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private int[,] GetMatrixFromDataGridView(DataGridView dgv)
        {
            int rows = dgv.Rows.Count;
            int cols = dgv.Columns.Count;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int.TryParse(dgv.Rows[i].Cells[j].Value?.ToString(), out matrix[i, j]);
                }
            }

            return matrix;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            richTextBoxCondition_PAA.Text =
                "УСЛОВИЕ ЗАДАЧИ (Вариант 11):\n" +
                "--------------------------------------------------\n" +
                "Дан файл InPutFileTask7V11.csv в котором хранится матрица целочисленных значений.\n\n" +
                "ТРЕБОВАНИЯ:\n" +
                "1. Загрузить файл через диалоговое окно\n" +
                "2. Изменить в пятой строке матрицы все отрицательные числа на 9\n" +
                "3. Результат вывести в правую таблицу\n" +
                "4. Сохранить результат в CSV файл\n\n" +
                "ИСПОЛЬЗУЕМАЯ БИБЛИОТЕКА:\n" +
                "• DataService.GetMatrix(string path) - загрузка матрицы из файла\n\n" +
                "АЛГОРИТМ РАБОТЫ:\n" +
                "1. Нажмите 'Загрузить файл' → выберите CSV файл\n" +
                "2. Нажмите 'Преобразовать' → выполняется замена в 5-й строке\n" +
                "3. Нажмите 'Сохранить результат' → сохраняете изменения\n" +
                "4. Нажмите 'Справка' → информация о разработчике\n\n" +
                "ФОРМАТ ФАЙЛА:\n" +
                "• Разделитель - точка с запятой (;)\n" +
                "• Пример: 1;2;-3;4;5\n" +
                "          6;-7;8;9;-10";
        }
    }
}