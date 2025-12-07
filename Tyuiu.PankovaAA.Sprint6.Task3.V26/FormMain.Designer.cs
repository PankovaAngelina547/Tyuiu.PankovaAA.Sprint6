namespace Tyuiu.PankovaAA.Sprint6.Task3.V26
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxResult_PAA;
        private System.Windows.Forms.Button buttonDone_PAA;
        private System.Windows.Forms.Button buttonHelp_PAA;
        private System.Windows.Forms.Label labelCondition_PAA;
        private System.Windows.Forms.TextBox textBoxCondition_PAA;

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
            this.textBoxResult_PAA = new System.Windows.Forms.TextBox();
            this.buttonDone_PAA = new System.Windows.Forms.Button();
            this.buttonHelp_PAA = new System.Windows.Forms.Button();
            this.labelCondition_PAA = new System.Windows.Forms.Label();
            this.textBoxCondition_PAA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.textBoxResult_PAA.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_PAA.Location = new System.Drawing.Point(160, 55);
            this.textBoxResult_PAA.Multiline = true;
            this.textBoxResult_PAA.Name = "textBoxResult_PAA";
            this.textBoxResult_PAA.ReadOnly = true;
            this.textBoxResult_PAA.Size = new System.Drawing.Size(150, 120);
            this.textBoxResult_PAA.TabIndex = 1;

            this.buttonDone_PAA.Location = new System.Drawing.Point(160, 220);
            this.buttonDone_PAA.Name = "buttonDone_PAA";
            this.buttonDone_PAA.Size = new System.Drawing.Size(100, 30);
            this.buttonDone_PAA.TabIndex = 2;
            this.buttonDone_PAA.Text = "Выполнить";
            this.buttonDone_PAA.UseVisualStyleBackColor = true;
            this.buttonDone_PAA.Click += new System.EventHandler(this.buttonDone_PAA_Click);

            this.buttonHelp_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonHelp_PAA.Location = new System.Drawing.Point(280, 220);
            this.buttonHelp_PAA.Name = "buttonHelp_PAA";
            this.buttonHelp_PAA.Size = new System.Drawing.Size(30, 30);
            this.buttonHelp_PAA.TabIndex = 3;
            this.buttonHelp_PAA.Text = "?";
            this.buttonHelp_PAA.UseVisualStyleBackColor = true;
            this.buttonHelp_PAA.Click += new System.EventHandler(this.buttonHelp_PAA_Click);

            this.labelCondition_PAA.AutoSize = true;
            this.labelCondition_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCondition_PAA.Location = new System.Drawing.Point(12, 35);
            this.labelCondition_PAA.Name = "labelCondition_PAA";
            this.labelCondition_PAA.Size = new System.Drawing.Size(75, 17);
            this.labelCondition_PAA.TabIndex = 4;
            this.labelCondition_PAA.Text = "Условие:";

            this.textBoxCondition_PAA.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxCondition_PAA.Location = new System.Drawing.Point(12, 55);
            this.textBoxCondition_PAA.Multiline = true;
            this.textBoxCondition_PAA.Name = "textBoxCondition_PAA";
            this.textBoxCondition_PAA.ReadOnly = true;
            this.textBoxCondition_PAA.Size = new System.Drawing.Size(140, 155);
            this.textBoxCondition_PAA.TabIndex = 5;
            this.textBoxCondition_PAA.Text = "Дан массив 5 на 5 элементов.\r\nЗаменить четные значения\r\nв третьей строке на 0.";

            this.ClientSize = new System.Drawing.Size(320, 260);
            this.Controls.Add(this.textBoxCondition_PAA);
            this.Controls.Add(this.labelCondition_PAA);
            this.Controls.Add(this.buttonHelp_PAA);
            this.Controls.Add(this.buttonDone_PAA);
            this.Controls.Add(this.textBoxResult_PAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 26 | Панькова А.А.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}