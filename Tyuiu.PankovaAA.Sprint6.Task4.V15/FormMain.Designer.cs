namespace Tyuiu.PankovaAA.Sprint6.Task4.V15
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTask_PAA;
        private System.Windows.Forms.Label labelCondition_PAA;
        private System.Windows.Forms.TextBox textBoxCondition_PAA;
        private System.Windows.Forms.Label labelInput_PAA;
        private System.Windows.Forms.Label labelStart_PAA;
        private System.Windows.Forms.TextBox textBoxStartStep_PAA;
        private System.Windows.Forms.Label labelStop_PAA;
        private System.Windows.Forms.TextBox textBoxStopStep_PAA;
        private System.Windows.Forms.Button buttonDone_PAA;
        private System.Windows.Forms.Button buttonSave_PAA;
        private System.Windows.Forms.Button buttonHelp_PAA;
        private System.Windows.Forms.Label labelOutput_PAA;
        private System.Windows.Forms.TextBox textBoxResult_PAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PAA;

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
            this.labelTask_PAA = new System.Windows.Forms.Label();
            this.labelCondition_PAA = new System.Windows.Forms.Label();
            this.textBoxCondition_PAA = new System.Windows.Forms.TextBox();
            this.labelInput_PAA = new System.Windows.Forms.Label();
            this.labelStart_PAA = new System.Windows.Forms.Label();
            this.textBoxStartStep_PAA = new System.Windows.Forms.TextBox();
            this.labelStop_PAA = new System.Windows.Forms.Label();
            this.textBoxStopStep_PAA = new System.Windows.Forms.TextBox();
            this.buttonDone_PAA = new System.Windows.Forms.Button();
            this.buttonSave_PAA = new System.Windows.Forms.Button();
            this.buttonHelp_PAA = new System.Windows.Forms.Button();
            this.labelOutput_PAA = new System.Windows.Forms.Label();
            this.textBoxResult_PAA = new System.Windows.Forms.TextBox();
            this.chartFunction_PAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PAA)).BeginInit();
            this.SuspendLayout();

            this.labelTask_PAA.AutoSize = true;
            this.labelTask_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_PAA.Location = new System.Drawing.Point(12, 12);
            this.labelTask_PAA.Name = "labelTask_PAA";
            this.labelTask_PAA.Size = new System.Drawing.Size(400, 20);
            this.labelTask_PAA.TabIndex = 0;
            this.labelTask_PAA.Text = "Спринт 6 | Таск 4 | Вариант 15 | Панькова А.А.";

            this.labelCondition_PAA.AutoSize = true;
            this.labelCondition_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition_PAA.Location = new System.Drawing.Point(12, 45);
            this.labelCondition_PAA.Name = "labelCondition_PAA";
            this.labelCondition_PAA.Size = new System.Drawing.Size(75, 17);
            this.labelCondition_PAA.TabIndex = 1;
            this.labelCondition_PAA.Text = "Условие:";

            this.textBoxCondition_PAA.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_PAA.Location = new System.Drawing.Point(12, 65);
            this.textBoxCondition_PAA.Multiline = true;
            this.textBoxCondition_PAA.Name = "textBoxCondition_PAA";
            this.textBoxCondition_PAA.ReadOnly = true;
            this.textBoxCondition_PAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCondition_PAA.Size = new System.Drawing.Size(300, 100);
            this.textBoxCondition_PAA.TabIndex = 2;
            this.textBoxCondition_PAA.Text = "Написать программу, которая выводит таблицу значений функции:\r\n\r\nF(x) = sin(x) + (2x/3) - cos(x) * 4x\r\n\r\nДиапазон [-5; 5], шаг 1\r\nОкругление до 2 знаков\r\nПри делении на ноль вернуть 0";

            this.labelInput_PAA.AutoSize = true;
            this.labelInput_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput_PAA.Location = new System.Drawing.Point(12, 180);
            this.labelInput_PAA.Name = "labelInput_PAA";
            this.labelInput_PAA.Size = new System.Drawing.Size(105, 17);
            this.labelInput_PAA.TabIndex = 3;
            this.labelInput_PAA.Text = "Ввод данных:";

            this.labelStart_PAA.AutoSize = true;
            this.labelStart_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart_PAA.Location = new System.Drawing.Point(20, 210);
            this.labelStart_PAA.Name = "labelStart_PAA";
            this.labelStart_PAA.Size = new System.Drawing.Size(80, 15);
            this.labelStart_PAA.TabIndex = 4;
            this.labelStart_PAA.Text = "Старт шага:";

            this.textBoxStartStep_PAA.Location = new System.Drawing.Point(100, 208);
            this.textBoxStartStep_PAA.Name = "textBoxStartStep_PAA";
            this.textBoxStartStep_PAA.Size = new System.Drawing.Size(50, 20);
            this.textBoxStartStep_PAA.TabIndex = 5;
            this.textBoxStartStep_PAA.Text = "-5";

            this.labelStop_PAA.AutoSize = true;
            this.labelStop_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStop_PAA.Location = new System.Drawing.Point(170, 210);
            this.labelStop_PAA.Name = "labelStop_PAA";
            this.labelStop_PAA.Size = new System.Drawing.Size(80, 15);
            this.labelStop_PAA.TabIndex = 6;
            this.labelStop_PAA.Text = "Конец шага:";

            this.textBoxStopStep_PAA.Location = new System.Drawing.Point(250, 208);
            this.textBoxStopStep_PAA.Name = "textBoxStopStep_PAA";
            this.textBoxStopStep_PAA.Size = new System.Drawing.Size(50, 20);
            this.textBoxStopStep_PAA.TabIndex = 7;
            this.textBoxStopStep_PAA.Text = "5";

            this.buttonDone_PAA.Location = new System.Drawing.Point(12, 250);
            this.buttonDone_PAA.Name = "buttonDone_PAA";
            this.buttonDone_PAA.Size = new System.Drawing.Size(90, 30);
            this.buttonDone_PAA.TabIndex = 8;
            this.buttonDone_PAA.Text = "Выполнить";
            this.buttonDone_PAA.UseVisualStyleBackColor = true;
            this.buttonDone_PAA.Click += new System.EventHandler(this.buttonDone_PAA_Click);

            this.buttonSave_PAA.Location = new System.Drawing.Point(112, 250);
            this.buttonSave_PAA.Name = "buttonSave_PAA";
            this.buttonSave_PAA.Size = new System.Drawing.Size(90, 30);
            this.buttonSave_PAA.TabIndex = 9;
            this.buttonSave_PAA.Text = "Сохранить";
            this.buttonSave_PAA.UseVisualStyleBackColor = true;
            this.buttonSave_PAA.Click += new System.EventHandler(this.buttonSave_PAA_Click);

            this.buttonHelp_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PAA.Location = new System.Drawing.Point(282, 250);
            this.buttonHelp_PAA.Name = "buttonHelp_PAA";
            this.buttonHelp_PAA.Size = new System.Drawing.Size(30, 30);
            this.buttonHelp_PAA.TabIndex = 10;
            this.buttonHelp_PAA.Text = "?";
            this.buttonHelp_PAA.UseVisualStyleBackColor = true;
            this.buttonHelp_PAA.Click += new System.EventHandler(this.buttonHelp_PAA_Click);

            this.labelOutput_PAA.AutoSize = true;
            this.labelOutput_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput_PAA.Location = new System.Drawing.Point(12, 290);
            this.labelOutput_PAA.Name = "labelOutput_PAA";
            this.labelOutput_PAA.Size = new System.Drawing.Size(81, 17);
            this.labelOutput_PAA.TabIndex = 11;
            this.labelOutput_PAA.Text = "Вывод:";

            this.textBoxResult_PAA.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_PAA.Location = new System.Drawing.Point(12, 310);
            this.textBoxResult_PAA.Multiline = true;
            this.textBoxResult_PAA.Name = "textBoxResult_PAA";
            this.textBoxResult_PAA.ReadOnly = true;
            this.textBoxResult_PAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PAA.Size = new System.Drawing.Size(300, 150);
            this.textBoxResult_PAA.TabIndex = 12;

            chartArea1.Name = "ChartArea1";
            this.chartFunction_PAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_PAA.Legends.Add(legend1);
            this.chartFunction_PAA.Location = new System.Drawing.Point(330, 65);
            this.chartFunction_PAA.Name = "chartFunction_PAA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PAA.Series.Add(series1);
            this.chartFunction_PAA.Size = new System.Drawing.Size(450, 395);
            this.chartFunction_PAA.TabIndex = 13;
            this.chartFunction_PAA.Text = "chart1";

            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.chartFunction_PAA);
            this.Controls.Add(this.textBoxResult_PAA);
            this.Controls.Add(this.labelOutput_PAA);
            this.Controls.Add(this.buttonHelp_PAA);
            this.Controls.Add(this.buttonSave_PAA);
            this.Controls.Add(this.buttonDone_PAA);
            this.Controls.Add(this.textBoxStopStep_PAA);
            this.Controls.Add(this.labelStop_PAA);
            this.Controls.Add(this.textBoxStartStep_PAA);
            this.Controls.Add(this.labelStart_PAA);
            this.Controls.Add(this.labelInput_PAA);
            this.Controls.Add(this.textBoxCondition_PAA);
            this.Controls.Add(this.labelCondition_PAA);
            this.Controls.Add(this.labelTask_PAA);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}