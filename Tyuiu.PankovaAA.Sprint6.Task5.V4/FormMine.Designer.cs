namespace Tyuiu.PankovaAA.Sprint6.Task5.V4
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCondition_PAA;
        private System.Windows.Forms.TextBox textBoxCondition_PAA;
        private System.Windows.Forms.Button buttonOpenFile_PAA;
        private System.Windows.Forms.Button buttonExecute_PAA;
        private System.Windows.Forms.Button buttonHelp_PAA;
        private System.Windows.Forms.Label labelResult_PAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_PAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_PAA;
        private System.Windows.Forms.Label labelPath_PAA;
        private System.Windows.Forms.TextBox textBoxPath_PAA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelCondition_PAA = new System.Windows.Forms.Label();
            this.textBoxCondition_PAA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_PAA = new System.Windows.Forms.Button();
            this.buttonExecute_PAA = new System.Windows.Forms.Button();
            this.buttonHelp_PAA = new System.Windows.Forms.Button();
            this.labelResult_PAA = new System.Windows.Forms.Label();
            this.dataGridViewResult_PAA = new System.Windows.Forms.DataGridView();
            this.chartResult_PAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelPath_PAA = new System.Windows.Forms.Label();
            this.textBoxPath_PAA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PAA)).BeginInit();
            this.SuspendLayout();

            this.labelCondition_PAA.AutoSize = true;
            this.labelCondition_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCondition_PAA.Location = new System.Drawing.Point(12, 12);
            this.labelCondition_PAA.Name = "labelCondition_PAA";
            this.labelCondition_PAA.Size = new System.Drawing.Size(75, 17);
            this.labelCondition_PAA.TabIndex = 0;
            this.labelCondition_PAA.Text = "Условие:";

            this.textBoxCondition_PAA.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxCondition_PAA.Location = new System.Drawing.Point(12, 35);
            this.textBoxCondition_PAA.Multiline = true;
            this.textBoxCondition_PAA.Name = "textBoxCondition_PAA";
            this.textBoxCondition_PAA.ReadOnly = true;
            this.textBoxCondition_PAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCondition_PAA.Size = new System.Drawing.Size(300, 80);
            this.textBoxCondition_PAA.TabIndex = 1;
            this.textBoxCondition_PAA.Text = "Прочитать данные из файла InPutFileTask5V4.txt.\r\nВывести в dataGridView.\r\nВывести все целые числа.\r\nПостроить диаграмму по этим значениям.";

            this.buttonOpenFile_PAA.Location = new System.Drawing.Point(12, 130);
            this.buttonOpenFile_PAA.Name = "buttonOpenFile_PAA";
            this.buttonOpenFile_PAA.Size = new System.Drawing.Size(100, 30);
            this.buttonOpenFile_PAA.TabIndex = 2;
            this.buttonOpenFile_PAA.Text = "Открыть файл";
            this.buttonOpenFile_PAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_PAA.Click += new System.EventHandler(this.buttonOpenFile_PAA_Click);

            this.buttonExecute_PAA.Location = new System.Drawing.Point(118, 130);
            this.buttonExecute_PAA.Name = "buttonExecute_PAA";
            this.buttonExecute_PAA.Size = new System.Drawing.Size(100, 30);
            this.buttonExecute_PAA.TabIndex = 3;
            this.buttonExecute_PAA.Text = "Выполнить";
            this.buttonExecute_PAA.UseVisualStyleBackColor = true;
            this.buttonExecute_PAA.Click += new System.EventHandler(this.buttonExecute_PAA_Click);

            this.buttonHelp_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonHelp_PAA.Location = new System.Drawing.Point(282, 130);
            this.buttonHelp_PAA.Name = "buttonHelp_PAA";
            this.buttonHelp_PAA.Size = new System.Drawing.Size(30, 30);
            this.buttonHelp_PAA.TabIndex = 4;
            this.buttonHelp_PAA.Text = "?";
            this.buttonHelp_PAA.UseVisualStyleBackColor = true;
            this.buttonHelp_PAA.Click += new System.EventHandler(this.buttonHelp_PAA_Click);

            this.labelResult_PAA.AutoSize = true;
            this.labelResult_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResult_PAA.Location = new System.Drawing.Point(12, 170);
            this.labelResult_PAA.Name = "labelResult_PAA";
            this.labelResult_PAA.Size = new System.Drawing.Size(81, 17);
            this.labelResult_PAA.TabIndex = 5;
            this.labelResult_PAA.Text = "Вывод данных:";

            this.dataGridViewResult_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PAA.Location = new System.Drawing.Point(12, 190);
            this.dataGridViewResult_PAA.Name = "dataGridViewResult_PAA";
            this.dataGridViewResult_PAA.Size = new System.Drawing.Size(150, 200);
            this.dataGridViewResult_PAA.TabIndex = 6;

            chartArea1.Name = "ChartArea1";
            this.chartResult_PAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult_PAA.Legends.Add(legend1);
            this.chartResult_PAA.Location = new System.Drawing.Point(180, 190);
            this.chartResult_PAA.Name = "chartResult_PAA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_PAA.Series.Add(series1);
            this.chartResult_PAA.Size = new System.Drawing.Size(450, 200);
            this.chartResult_PAA.TabIndex = 7;
            this.chartResult_PAA.Text = "chart1";

            this.labelPath_PAA.AutoSize = true;
            this.labelPath_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelPath_PAA.Location = new System.Drawing.Point(12, 400);
            this.labelPath_PAA.Name = "labelPath_PAA";
            this.labelPath_PAA.Size = new System.Drawing.Size(98, 15);
            this.labelPath_PAA.TabIndex = 8;
            this.labelPath_PAA.Text = "Путь к файлу:";

            this.textBoxPath_PAA.Location = new System.Drawing.Point(116, 398);
            this.textBoxPath_PAA.Name = "textBoxPath_PAA";
            this.textBoxPath_PAA.ReadOnly = true;
            this.textBoxPath_PAA.Size = new System.Drawing.Size(514, 20);
            this.textBoxPath_PAA.TabIndex = 9;

            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.textBoxPath_PAA);
            this.Controls.Add(this.labelPath_PAA);
            this.Controls.Add(this.chartResult_PAA);
            this.Controls.Add(this.dataGridViewResult_PAA);
            this.Controls.Add(this.labelResult_PAA);
            this.Controls.Add(this.buttonHelp_PAA);
            this.Controls.Add(this.buttonExecute_PAA);
            this.Controls.Add(this.buttonOpenFile_PAA);
            this.Controls.Add(this.textBoxCondition_PAA);
            this.Controls.Add(this.labelCondition_PAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 4 | Панькова А.А.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_PAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}