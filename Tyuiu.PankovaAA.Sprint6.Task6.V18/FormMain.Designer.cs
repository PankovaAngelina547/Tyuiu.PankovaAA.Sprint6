namespace Tyuiu.PankovaAA.Sprint6.Task6.V18
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTask_PAA;
        private System.Windows.Forms.Label labelCondition_PAA;
        private System.Windows.Forms.TextBox textBoxCondition_PAA;
        private System.Windows.Forms.Button buttonOpenFile_PAA;
        private System.Windows.Forms.Button buttonDo_PAA;
        private System.Windows.Forms.Button buttonHelp_PAA;
        private System.Windows.Forms.Label labelInput_PAA;
        private System.Windows.Forms.TextBox textBoxIn_PAA;
        private System.Windows.Forms.Label labelOutput_PAA;
        private System.Windows.Forms.TextBox textBoxOut_PAA;
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
            this.labelTask_PAA = new System.Windows.Forms.Label();
            this.labelCondition_PAA = new System.Windows.Forms.Label();
            this.textBoxCondition_PAA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_PAA = new System.Windows.Forms.Button();
            this.buttonDo_PAA = new System.Windows.Forms.Button();
            this.buttonHelp_PAA = new System.Windows.Forms.Button();
            this.labelInput_PAA = new System.Windows.Forms.Label();
            this.textBoxIn_PAA = new System.Windows.Forms.TextBox();
            this.labelOutput_PAA = new System.Windows.Forms.Label();
            this.textBoxOut_PAA = new System.Windows.Forms.TextBox();
            this.labelPath_PAA = new System.Windows.Forms.Label();
            this.textBoxPath_PAA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // labelTask_PAA
            this.labelTask_PAA.AutoSize = true;
            this.labelTask_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTask_PAA.Location = new System.Drawing.Point(12, 12);
            this.labelTask_PAA.Name = "labelTask_PAA";
            this.labelTask_PAA.Size = new System.Drawing.Size(400, 20);
            this.labelTask_PAA.TabIndex = 0;
            this.labelTask_PAA.Text = "Спринт 6 | Таск 6 | Вариант 18 | Панькова А.А.";

            // labelCondition_PAA
            this.labelCondition_PAA.AutoSize = true;
            this.labelCondition_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCondition_PAA.Location = new System.Drawing.Point(12, 45);
            this.labelCondition_PAA.Name = "labelCondition_PAA";
            this.labelCondition_PAA.Size = new System.Drawing.Size(75, 17);
            this.labelCondition_PAA.TabIndex = 1;
            this.labelCondition_PAA.Text = "Условие:";

            // textBoxCondition_PAA
            this.textBoxCondition_PAA.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxCondition_PAA.Location = new System.Drawing.Point(12, 65);
            this.textBoxCondition_PAA.Multiline = true;
            this.textBoxCondition_PAA.Name = "textBoxCondition_PAA";
            this.textBoxCondition_PAA.ReadOnly = true;
            this.textBoxCondition_PAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCondition_PAA.Size = new System.Drawing.Size(400, 60);
            this.textBoxCondition_PAA.TabIndex = 2;
            this.textBoxCondition_PAA.Text = "Дан файл InPutFileTask6V18.txt который может находится в любом месте на диске.\r\nЗагрузить файл в textBoxIn через openFileDialog.\r\nВывести слова в которых встречается буква \"n\" в результирующую строку.";

            // buttonOpenFile_PAA
            this.buttonOpenFile_PAA.Location = new System.Drawing.Point(12, 140);
            this.buttonOpenFile_PAA.Name = "buttonOpenFile_PAA";
            this.buttonOpenFile_PAA.Size = new System.Drawing.Size(100, 30);
            this.buttonOpenFile_PAA.TabIndex = 3;
            this.buttonOpenFile_PAA.Text = "Открыть файл";
            this.buttonOpenFile_PAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_PAA.Click += new System.EventHandler(this.buttonOpenFile_PAA_Click);

            // buttonDo_PAA
            this.buttonDo_PAA.Location = new System.Drawing.Point(118, 140);
            this.buttonDo_PAA.Name = "buttonDo_PAA";
            this.buttonDo_PAA.Size = new System.Drawing.Size(100, 30);
            this.buttonDo_PAA.TabIndex = 4;
            this.buttonDo_PAA.Text = "Выполнить";
            this.buttonDo_PAA.UseVisualStyleBackColor = true;
            this.buttonDo_PAA.Click += new System.EventHandler(this.buttonDo_PAA_Click);

            // buttonHelp_PAA
            this.buttonHelp_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonHelp_PAA.Location = new System.Drawing.Point(382, 140);
            this.buttonHelp_PAA.Name = "buttonHelp_PAA";
            this.buttonHelp_PAA.Size = new System.Drawing.Size(30, 30);
            this.buttonHelp_PAA.TabIndex = 5;
            this.buttonHelp_PAA.Text = "?";
            this.buttonHelp_PAA.UseVisualStyleBackColor = true;
            this.buttonHelp_PAA.Click += new System.EventHandler(this.buttonHelp_PAA_Click);

            // labelInput_PAA
            this.labelInput_PAA.AutoSize = true;
            this.labelInput_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelInput_PAA.Location = new System.Drawing.Point(12, 180);
            this.labelInput_PAA.Name = "labelInput_PAA";
            this.labelInput_PAA.Size = new System.Drawing.Size(49, 17);
            this.labelInput_PAA.TabIndex = 6;
            this.labelInput_PAA.Text = "Ввод:";

            // textBoxIn_PAA
            this.textBoxIn_PAA.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxIn_PAA.Location = new System.Drawing.Point(12, 200);
            this.textBoxIn_PAA.Multiline = true;
            this.textBoxIn_PAA.Name = "textBoxIn_PAA";
            this.textBoxIn_PAA.ReadOnly = true;
            this.textBoxIn_PAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_PAA.Size = new System.Drawing.Size(400, 100);
            this.textBoxIn_PAA.TabIndex = 7;

            // labelOutput_PAA
            this.labelOutput_PAA.AutoSize = true;
            this.labelOutput_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOutput_PAA.Location = new System.Drawing.Point(12, 310);
            this.labelOutput_PAA.Name = "labelOutput_PAA";
            this.labelOutput_PAA.Size = new System.Drawing.Size(57, 17);
            this.labelOutput_PAA.TabIndex = 8;
            this.labelOutput_PAA.Text = "Вывод:";

            // textBoxOut_PAA
            this.textBoxOut_PAA.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxOut_PAA.Location = new System.Drawing.Point(12, 330);
            this.textBoxOut_PAA.Multiline = true;
            this.textBoxOut_PAA.Name = "textBoxOut_PAA";
            this.textBoxOut_PAA.ReadOnly = true;
            this.textBoxOut_PAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_PAA.Size = new System.Drawing.Size(400, 100);
            this.textBoxOut_PAA.TabIndex = 9;

            // labelPath_PAA
            this.labelPath_PAA.AutoSize = true;
            this.labelPath_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelPath_PAA.Location = new System.Drawing.Point(12, 440);
            this.labelPath_PAA.Name = "labelPath_PAA";
            this.labelPath_PAA.Size = new System.Drawing.Size(98, 15);
            this.labelPath_PAA.TabIndex = 10;
            this.labelPath_PAA.Text = "Путь к файлу:";

            // textBoxPath_PAA
            this.textBoxPath_PAA.Location = new System.Drawing.Point(116, 438);
            this.textBoxPath_PAA.Name = "textBoxPath_PAA";
            this.textBoxPath_PAA.ReadOnly = true;
            this.textBoxPath_PAA.Size = new System.Drawing.Size(296, 20);
            this.textBoxPath_PAA.TabIndex = 11;

            // FormMain
            this.ClientSize = new System.Drawing.Size(430, 480);
            this.Controls.Add(this.textBoxPath_PAA);
            this.Controls.Add(this.labelPath_PAA);
            this.Controls.Add(this.textBoxOut_PAA);
            this.Controls.Add(this.labelOutput_PAA);
            this.Controls.Add(this.textBoxIn_PAA);
            this.Controls.Add(this.labelInput_PAA);
            this.Controls.Add(this.buttonHelp_PAA);
            this.Controls.Add(this.buttonDo_PAA);
            this.Controls.Add(this.buttonOpenFile_PAA);
            this.Controls.Add(this.textBoxCondition_PAA);
            this.Controls.Add(this.labelCondition_PAA);
            this.Controls.Add(this.labelTask_PAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 18 | Панькова А.А.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}