namespace Tyulu.PankovaAA.Sprint6
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        public class DataService
        {
            public string CollectTextFromFile(string path)
            {
                if (!System.IO.File.Exists(path))
                    return "Файл не найден";

                try
                {
                    string text = System.IO.File.ReadAllText(path, System.Text.Encoding.Default);
                    string[] separators = { " ", "\r", "\n", "\t", ",", ".", "!", "?", ";", ":", "(", ")", "[", "]", "{", "}", "\"", "'" };
                    string[] words = text.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);

                    System.Text.StringBuilder result = new System.Text.StringBuilder();

                    foreach (string word in words)
                    {
                        if (word.Contains('n'))
                        {
                            result.Append(word + " ");
                        }
                    }

                    return result.ToString().Trim();
                }
                catch
                {
                    return "Ошибка чтения файла";
                }
            }
        }

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
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBoxIn
            this.textBoxIn.Location = new System.Drawing.Point(20, 60);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn.Size = new System.Drawing.Size(560, 150);
            this.textBoxIn.TabIndex = 0;

            // textBoxOut
            this.textBoxOut.Location = new System.Drawing.Point(20, 260);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(560, 150);
            this.textBoxOut.TabIndex = 1;

            // buttonOpen
            this.buttonOpen.Location = new System.Drawing.Point(20, 220);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(100, 30);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);

            // buttonExecute
            this.buttonExecute.Location = new System.Drawing.Point(130, 220);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(100, 30);
            this.buttonExecute.TabIndex = 3;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);

            // labelPath
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(20, 20);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(84, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Путь к файлу:";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 430);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxIn);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 18";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label labelPath;
    }
}