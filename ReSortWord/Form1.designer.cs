namespace ReSortWord
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSuffle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnSolver = new System.Windows.Forms.Button();
            this.btnGenStr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSuffle
            // 
            this.btnSuffle.Location = new System.Drawing.Point(22, 78);
            this.btnSuffle.Name = "btnSuffle";
            this.btnSuffle.Size = new System.Drawing.Size(210, 52);
            this.btnSuffle.TabIndex = 0;
            this.btnSuffle.Text = "Размешать";
            this.btnSuffle.UseVisualStyleBackColor = true;
            this.btnSuffle.Click += new System.EventHandler(this.btnSuffle_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(247, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 510);
            this.listBox1.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtData.Location = new System.Drawing.Point(22, 136);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(210, 30);
            this.txtData.TabIndex = 2;
            this.txtData.Text = "ABCD";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSolver
            // 
            this.btnSolver.Location = new System.Drawing.Point(22, 188);
            this.btnSolver.Name = "btnSolver";
            this.btnSolver.Size = new System.Drawing.Size(210, 79);
            this.btnSolver.TabIndex = 3;
            this.btnSolver.Text = "RandomSort";
            this.btnSolver.UseVisualStyleBackColor = true;
            this.btnSolver.Click += new System.EventHandler(this.btnSolver_Click);
            // 
            // btnGenStr
            // 
            this.btnGenStr.Location = new System.Drawing.Point(22, 25);
            this.btnGenStr.Name = "btnGenStr";
            this.btnGenStr.Size = new System.Drawing.Size(210, 47);
            this.btnGenStr.TabIndex = 4;
            this.btnGenStr.Text = "Сгенерировать";
            this.btnGenStr.UseVisualStyleBackColor = true;
            this.btnGenStr.Click += new System.EventHandler(this.btnGenStr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 559);
            this.Controls.Add(this.btnGenStr);
            this.Controls.Add(this.btnSolver);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSuffle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuffle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnSolver;
        private System.Windows.Forms.Button btnGenStr;
    }
}

