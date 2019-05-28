namespace WindowsFormsApp2
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
            this.TotalLostTextBox = new System.Windows.Forms.Label();
            this.TotalZTextBox = new System.Windows.Forms.Label();
            this.Proc1TextBox = new System.Windows.Forms.Label();
            this.Proc2TextBox = new System.Windows.Forms.Label();
            this.OcheredTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinZTextBox = new System.Windows.Forms.TextBox();
            this.MaxZTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxSTextBox = new System.Windows.Forms.TextBox();
            this.MinSTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ТАП";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // TotalLostTextBox
            // 
            this.TotalLostTextBox.AutoSize = true;
            this.TotalLostTextBox.Location = new System.Drawing.Point(124, 78);
            this.TotalLostTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLostTextBox.Name = "TotalLostTextBox";
            this.TotalLostTextBox.Size = new System.Drawing.Size(77, 17);
            this.TotalLostTextBox.TabIndex = 1;
            this.TotalLostTextBox.Text = "Потеряно:";
            // 
            // TotalZTextBox
            // 
            this.TotalZTextBox.AutoSize = true;
            this.TotalZTextBox.Location = new System.Drawing.Point(124, 107);
            this.TotalZTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalZTextBox.Name = "TotalZTextBox";
            this.TotalZTextBox.Size = new System.Drawing.Size(98, 17);
            this.TotalZTextBox.TabIndex = 2;
            this.TotalZTextBox.Text = "Всего заявок:";
            // 
            // Proc1TextBox
            // 
            this.Proc1TextBox.AutoSize = true;
            this.Proc1TextBox.Location = new System.Drawing.Point(124, 135);
            this.Proc1TextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Proc1TextBox.Name = "Proc1TextBox";
            this.Proc1TextBox.Size = new System.Drawing.Size(141, 17);
            this.Proc1TextBox.TabIndex = 3;
            this.Proc1TextBox.Text = "Загрузка сервера 1:";
            this.Proc1TextBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Proc2TextBox
            // 
            this.Proc2TextBox.AutoSize = true;
            this.Proc2TextBox.Location = new System.Drawing.Point(124, 165);
            this.Proc2TextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Proc2TextBox.Name = "Proc2TextBox";
            this.Proc2TextBox.Size = new System.Drawing.Size(141, 17);
            this.Proc2TextBox.TabIndex = 4;
            this.Proc2TextBox.Text = "Загрузка сервера 2:";
            this.Proc2TextBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OcheredTextBox
            // 
            this.OcheredTextBox.AutoSize = true;
            this.OcheredTextBox.Location = new System.Drawing.Point(124, 50);
            this.OcheredTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OcheredTextBox.Name = "OcheredTextBox";
            this.OcheredTextBox.Size = new System.Drawing.Size(70, 17);
            this.OcheredTextBox.TabIndex = 5;
            this.OcheredTextBox.Text = "Очередь:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Интервал заявок:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MinZTextBox
            // 
            this.MinZTextBox.Location = new System.Drawing.Point(263, 191);
            this.MinZTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinZTextBox.Name = "MinZTextBox";
            this.MinZTextBox.Size = new System.Drawing.Size(36, 22);
            this.MinZTextBox.TabIndex = 7;
            this.MinZTextBox.Text = "20";
            // 
            // MaxZTextBox
            // 
            this.MaxZTextBox.Location = new System.Drawing.Point(317, 191);
            this.MaxZTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxZTextBox.Name = "MaxZTextBox";
            this.MaxZTextBox.Size = new System.Drawing.Size(36, 22);
            this.MaxZTextBox.TabIndex = 8;
            this.MaxZTextBox.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Интервал сервера:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MaxSTextBox
            // 
            this.MaxSTextBox.Location = new System.Drawing.Point(317, 223);
            this.MaxSTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxSTextBox.Name = "MaxSTextBox";
            this.MaxSTextBox.Size = new System.Drawing.Size(36, 22);
            this.MaxSTextBox.TabIndex = 11;
            this.MaxSTextBox.Text = "47";
            // 
            // MinSTextBox
            // 
            this.MinSTextBox.Location = new System.Drawing.Point(263, 223);
            this.MinSTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinSTextBox.Name = "MinSTextBox";
            this.MinSTextBox.Size = new System.Drawing.Size(36, 22);
            this.MinSTextBox.TabIndex = 10;
            this.MinSTextBox.Text = "44";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 657);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxSTextBox);
            this.Controls.Add(this.MinSTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxZTextBox);
            this.Controls.Add(this.MinZTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OcheredTextBox);
            this.Controls.Add(this.Proc2TextBox);
            this.Controls.Add(this.Proc1TextBox);
            this.Controls.Add(this.TotalZTextBox);
            this.Controls.Add(this.TotalLostTextBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalLostTextBox;
        private System.Windows.Forms.Label TotalZTextBox;
        private System.Windows.Forms.Label Proc1TextBox;
        private System.Windows.Forms.Label Proc2TextBox;
        private System.Windows.Forms.Label OcheredTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MinZTextBox;
        private System.Windows.Forms.TextBox MaxZTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxSTextBox;
        private System.Windows.Forms.TextBox MinSTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

