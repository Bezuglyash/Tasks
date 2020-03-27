namespace SecondTask
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
            this.firstMassiv = new System.Windows.Forms.DataGridView();
            this.secondMassiv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firstMassiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondMassiv)).BeginInit();
            this.SuspendLayout();
            // 
            // firstMassiv
            // 
            this.firstMassiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstMassiv.Location = new System.Drawing.Point(12, 31);
            this.firstMassiv.Name = "firstMassiv";
            this.firstMassiv.Size = new System.Drawing.Size(372, 113);
            this.firstMassiv.TabIndex = 0;
            // 
            // secondMassiv
            // 
            this.secondMassiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondMassiv.Location = new System.Drawing.Point(505, 31);
            this.secondMassiv.Name = "secondMassiv";
            this.secondMassiv.Size = new System.Drawing.Size(372, 113);
            this.secondMassiv.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Заполнить первую матрицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Заполнить вторую матрицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 214);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondMassiv);
            this.Controls.Add(this.firstMassiv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.firstMassiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondMassiv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView firstMassiv;
        private System.Windows.Forms.DataGridView secondMassiv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

