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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCondition = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX_PAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.buttonCalculate_PAA = new System.Windows.Forms.Button();
            this.textBoxResult_PAA = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonHelp_PAA = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // файлToolStripMenuItem
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";

            // справкаToolStripMenuItem
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";

            // оПрограммеToolStripMenuItem
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";

            // labelCondition
            this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition.Location = new System.Drawing.Point(20, 40);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(350, 80);
            this.labelCondition.TabIndex = 1;
            this.labelCondition.Text = "Условие\r\nВычислить выражение по формуле\r\n\r\ny(x) = (2x² - 1) / √(x² - 2)\r\nпри x = 3";
            this.labelCondition.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // groupBoxInput
            this.groupBoxInput.Controls.Add(this.labelX);
            this.groupBoxInput.Controls.Add(this.textBoxX_PAA);
            this.groupBoxInput.Location = new System.Drawing.Point(20, 140);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(350, 60);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";

            // labelX
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(20, 28);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(89, 13);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "Значение x = 3:";

            // textBoxX_PAA
            this.textBoxX_PAA.Location = new System.Drawing.Point(115, 25);
            this.textBoxX_PAA.Name = "textBoxX_PAA";
            this.textBoxX_PAA.Size = new System.Drawing.Size(60, 20);
            this.textBoxX_PAA.TabIndex = 0;
            this.textBoxX_PAA.Text = "3";

            // groupBoxOutput
            this.groupBoxOutput.Controls.Add(this.buttonCalculate_PAA);
            this.groupBoxOutput.Controls.Add(this.textBoxResult_PAA);
            this.groupBoxOutput.Controls.Add(this.labelResult);
            this.groupBoxOutput.Location = new System.Drawing.Point(20, 210);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(350, 60);
            this.groupBoxOutput.TabIndex = 3;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";

            // buttonCalculate_PAA
            this.buttonCalculate_PAA.BackColor = System.Drawing.Color.LightBlue;
            this.buttonCalculate_PAA.Location = new System.Drawing.Point(220, 25);
            this.buttonCalculate_PAA.Name = "buttonCalculate_PAA";
            this.buttonCalculate_PAA.Size = new System.Drawing.Size(100, 25);
            this.buttonCalculate_PAA.TabIndex = 2;
            this.buttonCalculate_PAA.Text = "Вычислить";
            this.buttonCalculate_PAA.UseVisualStyleBackColor = false;

            // textBoxResult_PAA
            this.textBoxResult_PAA.Location = new System.Drawing.Point(95, 25);
            this.textBoxResult_PAA.Name = "textBoxResult_PAA";
            this.textBoxResult_PAA.ReadOnly = true;
            this.textBoxResult_PAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_PAA.TabIndex = 1;

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(20, 28);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Результат:";

            // buttonHelp_PAA
            this.buttonHelp_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_PAA.Location = new System.Drawing.Point(360, 280);
            this.buttonHelp_PAA.Name = "buttonHelp_PAA";
            this.buttonHelp_PAA.Size = new System.Drawing.Size(30, 30);
            this.buttonHelp_PAA.TabIndex = 4;
            this.buttonHelp_PAA.Text = "?";
            this.buttonHelp_PAA.UseVisualStyleBackColor = true;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.buttonHelp_PAA);
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
            this.Text = "Спринт 6 | Таск 0 | Вариант 2 | Панькова А.А.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX_PAA;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Button buttonCalculate_PAA;
        private System.Windows.Forms.TextBox textBoxResult_PAA;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonHelp_PAA;
    }
}