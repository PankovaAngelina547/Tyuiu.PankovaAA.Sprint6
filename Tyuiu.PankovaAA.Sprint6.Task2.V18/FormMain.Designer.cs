namespace Tyuiu.PankovaAA.Sprint6.Task0.V2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCondition = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelStop = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.textBoxStopStep_PAA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_PAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.chartFunction_PAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_PAA = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCalculate_PAA = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PAA)).BeginInit();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // файлToolStripMenuItem
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";

            // справкаToolStripMenuItem
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";

            // labelCondition
            this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition.Location = new System.Drawing.Point(20, 40);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(660, 50);
            this.labelCondition.TabIndex = 1;
            this.labelCondition.Text = "Условие\r\nПротабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            this.labelCondition.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // groupBoxInput
            this.groupBoxInput.Controls.Add(this.labelStop);
            this.groupBoxInput.Controls.Add(this.labelStart);
            this.groupBoxInput.Controls.Add(this.textBoxStopStep_PAA);
            this.groupBoxInput.Controls.Add(this.textBoxStartStep_PAA);
            this.groupBoxInput.Location = new System.Drawing.Point(20, 100);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(300, 80);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";

            // labelStop
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(150, 35);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(80, 13);
            this.labelStop.TabIndex = 3;
            this.labelStop.Text = "Конец шага:";

            // labelStart
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(20, 35);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(77, 13);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "Старт шага:";

            // textBoxStopStep_PAA
            this.textBoxStopStep_PAA.Location = new System.Drawing.Point(230, 32);
            this.textBoxStopStep_PAA.Name = "textBoxStopStep_PAA";
            this.textBoxStopStep_PAA.Size = new System.Drawing.Size(60, 20);
            this.textBoxStopStep_PAA.TabIndex = 1;
            this.textBoxStopStep_PAA.Text = "5";

            // textBoxStartStep_PAA
            this.textBoxStartStep_PAA.Location = new System.Drawing.Point(100, 32);
            this.textBoxStartStep_PAA.Name = "textBoxStartStep_PAA";
            this.textBoxStartStep_PAA.Size = new System.Drawing.Size(60, 20);
            this.textBoxStartStep_PAA.TabIndex = 0;
            this.textBoxStartStep_PAA.Text = "-5";

            // groupBoxOutput
            this.groupBoxOutput.Controls.Add(this.chartFunction_PAA);
            this.groupBoxOutput.Controls.Add(this.dataGridViewFunction_PAA);
            this.groupBoxOutput.Location = new System.Drawing.Point(20, 190);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(660, 300);
            this.groupBoxOutput.TabIndex = 3;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";

            // chartFunction_PAA
            this.chartFunction_PAA.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_PAA.Legends.Add(legend1);
            this.chartFunction_PAA.Location = new System.Drawing.Point(340, 30);
            this.chartFunction_PAA.Name = "chartFunction_PAA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PAA.Series.Add(series1);
            this.chartFunction_PAA.Size = new System.Drawing.Size(310, 250);
            this.chartFunction_PAA.TabIndex = 1;
            this.chartFunction_PAA.Text = "chart1";

            // dataGridViewFunction_PAA
            this.dataGridViewFunction_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_PAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnFx});
            this.dataGridViewFunction_PAA.Location = new System.Drawing.Point(20, 30);
            this.dataGridViewFunction_PAA.Name = "dataGridViewFunction_PAA";
            this.dataGridViewFunction_PAA.ReadOnly = true;
            this.dataGridViewFunction_PAA.Size = new System.Drawing.Size(300, 250);
            this.dataGridViewFunction_PAA.TabIndex = 0;

            // ColumnX
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 140;

            // ColumnFx
            this.ColumnFx.HeaderText = "F(x)";
            this.ColumnFx.Name = "ColumnFx";
            this.ColumnFx.ReadOnly = true;
            this.ColumnFx.Width = 140;

            // buttonCalculate_PAA
            this.buttonCalculate_PAA.BackColor = System.Drawing.Color.Red;
            this.buttonCalculate_PAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate_PAA.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate_PAA.Location = new System.Drawing.Point(340, 115);
            this.buttonCalculate_PAA.Name = "buttonCalculate_PAA";
            this.buttonCalculate_PAA.Size = new System.Drawing.Size(150, 40);
            this.buttonCalculate_PAA.TabIndex = 4;
            this.buttonCalculate_PAA.Text = "ВЫПОЛНИТЬ";
            this.buttonCalculate_PAA.UseVisualStyleBackColor = false;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.buttonCalculate_PAA);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 18 | Панькова А.А.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TextBox textBoxStopStep_PAA;
        private System.Windows.Forms.TextBox textBoxStartStep_PAA;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.DataGridView dataGridViewFunction_PAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx;
        private System.Windows.Forms.Button buttonCalculate_PAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PAA;
    }
}