namespace Sprint6Task7V11_PAA
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain_PAA = new System.Windows.Forms.TabControl();
            this.tabPageCondition_PAA = new System.Windows.Forms.TabPage();
            this.richTextBoxCondition_PAA = new System.Windows.Forms.RichTextBox();
            this.tabPageSolution_PAA = new System.Windows.Forms.TabPage();
            this.panelSolution_PAA = new System.Windows.Forms.Panel();
            this.dataGridViewOut_PAA = new System.Windows.Forms.DataGridView();
            this.dataGridViewIn_PAA = new System.Windows.Forms.DataGridView();
            this.labelOutput_PAA = new System.Windows.Forms.Label();
            this.labelInput_PAA = new System.Windows.Forms.Label();
            this.panelButtons_PAA = new System.Windows.Forms.Panel();
            this.buttonAbout_PAA = new System.Windows.Forms.Button();
            this.buttonSaveFile_PAA = new System.Windows.Forms.Button();
            this.buttonTransform_PAA = new System.Windows.Forms.Button();
            this.buttonLoadFile_PAA = new System.Windows.Forms.Button();
            this.openFileDialog_PAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_PAA = new System.Windows.Forms.SaveFileDialog();
            this.tabControlMain_PAA.SuspendLayout();
            this.tabPageCondition_PAA.SuspendLayout();
            this.tabPageSolution_PAA.SuspendLayout();
            this.panelSolution_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_PAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_PAA)).BeginInit();
            this.panelButtons_PAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain_PAA
            // 
            this.tabControlMain_PAA.Controls.Add(this.tabPageCondition_PAA);
            this.tabControlMain_PAA.Controls.Add(this.tabPageSolution_PAA);
            this.tabControlMain_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain_PAA.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain_PAA.Name = "tabControlMain_PAA";
            this.tabControlMain_PAA.SelectedIndex = 0;
            this.tabControlMain_PAA.Size = new System.Drawing.Size(884, 611);
            this.tabControlMain_PAA.TabIndex = 0;
            // 
            // tabPageCondition_PAA
            // 
            this.tabPageCondition_PAA.Controls.Add(this.richTextBoxCondition_PAA);
            this.tabPageCondition_PAA.Location = new System.Drawing.Point(4, 22);
            this.tabPageCondition_PAA.Name = "tabPageCondition_PAA";
            this.tabPageCondition_PAA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCondition_PAA.Size = new System.Drawing.Size(876, 585);
            this.tabPageCondition_PAA.TabIndex = 0;
            this.tabPageCondition_PAA.Text = "Условие задачи";
            this.tabPageCondition_PAA.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCondition_PAA
            // 
            this.richTextBoxCondition_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCondition_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxCondition_PAA.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxCondition_PAA.Name = "richTextBoxCondition_PAA";
            this.richTextBoxCondition_PAA.ReadOnly = true;
            this.richTextBoxCondition_PAA.Size = new System.Drawing.Size(870, 579);
            this.richTextBoxCondition_PAA.TabIndex = 0;
            this.richTextBoxCondition_PAA.Text = "";
            // 
            // tabPageSolution_PAA
            // 
            this.tabPageSolution_PAA.Controls.Add(this.panelSolution_PAA);
            this.tabPageSolution_PAA.Controls.Add(this.panelButtons_PAA);
            this.tabPageSolution_PAA.Location = new System.Drawing.Point(4, 22);
            this.tabPageSolution_PAA.Name = "tabPageSolution_PAA";
            this.tabPageSolution_PAA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolution_PAA.Size = new System.Drawing.Size(876, 585);
            this.tabPageSolution_PAA.TabIndex = 1;
            this.tabPageSolution_PAA.Text = "Решение";
            this.tabPageSolution_PAA.UseVisualStyleBackColor = true;
            // 
            // panelSolution_PAA
            // 
            this.panelSolution_PAA.Controls.Add(this.dataGridViewOut_PAA);
            this.panelSolution_PAA.Controls.Add(this.dataGridViewIn_PAA);
            this.panelSolution_PAA.Controls.Add(this.labelOutput_PAA);
            this.panelSolution_PAA.Controls.Add(this.labelInput_PAA);
            this.panelSolution_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSolution_PAA.Location = new System.Drawing.Point(3, 53);
            this.panelSolution_PAA.Name = "panelSolution_PAA";
            this.panelSolution_PAA.Size = new System.Drawing.Size(870, 529);
            this.panelSolution_PAA.TabIndex = 1;
            // 
            // dataGridViewOut_PAA
            // 
            this.dataGridViewOut_PAA.AllowUserToAddRows = false;
            this.dataGridViewOut_PAA.AllowUserToDeleteRows = false;
            this.dataGridViewOut_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_PAA.Location = new System.Drawing.Point(440, 50);
            this.dataGridViewOut_PAA.Name = "dataGridViewOut_PAA";
            this.dataGridViewOut_PAA.ReadOnly = true;
            this.dataGridViewOut_PAA.Size = new System.Drawing.Size(420, 450);
            this.dataGridViewOut_PAA.TabIndex = 3;
            // 
            // dataGridViewIn_PAA
            // 
            this.dataGridViewIn_PAA.AllowUserToAddRows = false;
            this.dataGridViewIn_PAA.AllowUserToDeleteRows = false;
            this.dataGridViewIn_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_PAA.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewIn_PAA.Name = "dataGridViewIn_PAA";
            this.dataGridViewIn_PAA.ReadOnly = true;
            this.dataGridViewIn_PAA.Size = new System.Drawing.Size(420, 450);
            this.dataGridViewIn_PAA.TabIndex = 2;
            // 
            // labelOutput_PAA
            // 
            this.labelOutput_PAA.AutoSize = true;
            this.labelOutput_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput_PAA.Location = new System.Drawing.Point(437, 20);
            this.labelOutput_PAA.Name = "labelOutput_PAA";
            this.labelOutput_PAA.Size = new System.Drawing.Size(186, 17);
            this.labelOutput_PAA.TabIndex = 1;
            this.labelOutput_PAA.Text = "Результат (dataGridViewOut)";
            // 
            // labelInput_PAA
            // 
            this.labelInput_PAA.AutoSize = true;
            this.labelInput_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput_PAA.Location = new System.Drawing.Point(7, 20);
            this.labelInput_PAA.Name = "labelInput_PAA";
            this.labelInput_PAA.Size = new System.Drawing.Size(179, 17);
            this.labelInput_PAA.TabIndex = 0;
            this.labelInput_PAA.Text = "Исходные данные (dataGridViewIn)";
            // 
            // panelButtons_PAA
            // 
            this.panelButtons_PAA.Controls.Add(this.buttonAbout_PAA);
            this.panelButtons_PAA.Controls.Add(this.buttonSaveFile_PAA);
            this.panelButtons_PAA.Controls.Add(this.buttonTransform_PAA);
            this.panelButtons_PAA.Controls.Add(this.buttonLoadFile_PAA);
            this.panelButtons_PAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_PAA.Location = new System.Drawing.Point(3, 3);
            this.panelButtons_PAA.Name = "panelButtons_PAA";
            this.panelButtons_PAA.Size = new System.Drawing.Size(870, 50);
            this.panelButtons_PAA.TabIndex = 0;
            // 
            // buttonAbout_PAA
            // 
            this.buttonAbout_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout_PAA.Location = new System.Drawing.Point(690, 10);
            this.buttonAbout_PAA.Name = "buttonAbout_PAA";
            this.buttonAbout_PAA.Size = new System.Drawing.Size(170, 30);
            this.buttonAbout_PAA.TabIndex = 3;
            this.buttonAbout_PAA.Text = "Справка";
            this.buttonAbout_PAA.UseVisualStyleBackColor = true;
            this.buttonAbout_PAA.Click += new System.EventHandler(this.ButtonAbout_PAA_Click);
            // 
            // buttonSaveFile_PAA
            // 
            this.buttonSaveFile_PAA.Enabled = false;
            this.buttonSaveFile_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile_PAA.Location = new System.Drawing.Point(470, 10);
            this.buttonSaveFile_PAA.Name = "buttonSaveFile_PAA";
            this.buttonSaveFile_PAA.Size = new System.Drawing.Size(200, 30);
            this.buttonSaveFile_PAA.TabIndex = 2;
            this.buttonSaveFile_PAA.Text = "Сохранить результат";
            this.buttonSaveFile_PAA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_PAA.Click += new System.EventHandler(this.ButtonSaveFile_PAA_Click);
            // 
            // buttonTransform_PAA
            // 
            this.buttonTransform_PAA.Enabled = false;
            this.buttonTransform_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTransform_PAA.Location = new System.Drawing.Point(240, 10);
            this.buttonTransform_PAA.Name = "buttonTransform_PAA";
            this.buttonTransform_PAA.Size = new System.Drawing.Size(210, 30);
            this.buttonTransform_PAA.TabIndex = 1;
            this.buttonTransform_PAA.Text = "Преобразовать (5-я строка → 9)";
            this.buttonTransform_PAA.UseVisualStyleBackColor = true;
            this.buttonTransform_PAA.Click += new System.EventHandler(this.ButtonTransform_PAA_Click);
            // 
            // buttonLoadFile_PAA
            // 
            this.buttonLoadFile_PAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadFile_PAA.Location = new System.Drawing.Point(10, 10);
            this.buttonLoadFile_PAA.Name = "buttonLoadFile_PAA";
            this.buttonLoadFile_PAA.Size = new System.Drawing.Size(210, 30);
            this.buttonLoadFile_PAA.TabIndex = 0;
            this.buttonLoadFile_PAA.Text = "Загрузить файл (CSV)";
            this.buttonLoadFile_PAA.UseVisualStyleBackColor = true;
            this.buttonLoadFile_PAA.Click += new System.EventHandler(this.ButtonLoadFile_PAA_Click);
            // 
            // openFileDialog_PAA
            // 
            this.openFileDialog_PAA.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            this.openFileDialog_PAA.Title = "Выберите файл InPutFileTask7V11.csv";
            // 
            // saveFileDialog_PAA
            // 
            this.saveFileDialog_PAA.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            this.saveFileDialog_PAA.Title = "Сохранить результат как OutPutFileTask7.csv";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.tabControlMain_PAA);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №1 | Вариант 11 | Панькова А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain_PAA.ResumeLayout(false);
            this.tabPageCondition_PAA.ResumeLayout(false);
            this.tabPageSolution_PAA.ResumeLayout(false);
            this.panelSolution_PAA.ResumeLayout(false);
            this.panelSolution_PAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_PAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_PAA)).EndInit();
            this.panelButtons_PAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain_PAA;
        private System.Windows.Forms.TabPage tabPageCondition_PAA;
        private System.Windows.Forms.RichTextBox richTextBoxCondition_PAA;
        private System.Windows.Forms.TabPage tabPageSolution_PAA;
        private System.Windows.Forms.Panel panelButtons_PAA;
        private System.Windows.Forms.Button buttonAbout_PAA;
        private System.Windows.Forms.Button buttonSaveFile_PAA;
        private System.Windows.Forms.Button buttonTransform_PAA;
        private System.Windows.Forms.Button buttonLoadFile_PAA;
        private System.Windows.Forms.Panel panelSolution_PAA;
        private System.Windows.Forms.DataGridView dataGridViewOut_PAA;
        private System.Windows.Forms.DataGridView dataGridViewIn_PAA;
        private System.Windows.Forms.Label labelOutput_PAA;
        private System.Windows.Forms.Label labelInput_PAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_PAA;
    }
}