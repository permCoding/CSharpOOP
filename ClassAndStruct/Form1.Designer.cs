namespace ClassAndStruct
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtClassAge = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtStructAge = new System.Windows.Forms.TextBox();
            this.txtStructName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 240);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(198, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Василий";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(360, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 34);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "12";
            // 
            // txtClassAge
            // 
            this.txtClassAge.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtClassAge.Location = new System.Drawing.Point(347, 179);
            this.txtClassAge.Name = "txtClassAge";
            this.txtClassAge.Size = new System.Drawing.Size(100, 34);
            this.txtClassAge.TabIndex = 4;
            this.txtClassAge.Text = "12";
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtClassName.Location = new System.Drawing.Point(185, 179);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(138, 34);
            this.txtClassName.TabIndex = 3;
            this.txtClassName.Text = "Василий";
            // 
            // txtStructAge
            // 
            this.txtStructAge.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStructAge.Location = new System.Drawing.Point(347, 230);
            this.txtStructAge.Name = "txtStructAge";
            this.txtStructAge.Size = new System.Drawing.Size(100, 34);
            this.txtStructAge.TabIndex = 6;
            this.txtStructAge.Text = "12";
            // 
            // txtStructName
            // 
            this.txtStructName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStructName.Location = new System.Drawing.Point(185, 230);
            this.txtStructName.Name = "txtStructName";
            this.txtStructName.Size = new System.Drawing.Size(138, 34);
            this.txtStructName.TabIndex = 5;
            this.txtStructName.Text = "Василий";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 312);
            this.Controls.Add(this.txtStructAge);
            this.Controls.Add(this.txtStructName);
            this.Controls.Add(this.txtClassAge);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtClassAge;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtStructAge;
        private System.Windows.Forms.TextBox txtStructName;
    }
}

