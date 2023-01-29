namespace БиблиотекаСтудент
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginenbox = new System.Windows.Forms.TextBox();
            this.passenbox = new System.Windows.Forms.TextBox();
            this.loginregbox = new System.Windows.Forms.TextBox();
            this.passregbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enterbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // loginenbox
            // 
            this.loginenbox.Location = new System.Drawing.Point(161, 191);
            this.loginenbox.Name = "loginenbox";
            this.loginenbox.Size = new System.Drawing.Size(100, 20);
            this.loginenbox.TabIndex = 4;
            this.loginenbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passenbox
            // 
            this.passenbox.Location = new System.Drawing.Point(161, 229);
            this.passenbox.Name = "passenbox";
            this.passenbox.Size = new System.Drawing.Size(100, 20);
            this.passenbox.TabIndex = 5;
            this.passenbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // loginregbox
            // 
            this.loginregbox.Location = new System.Drawing.Point(418, 191);
            this.loginregbox.Name = "loginregbox";
            this.loginregbox.Size = new System.Drawing.Size(100, 20);
            this.loginregbox.TabIndex = 6;
            // 
            // passregbox
            // 
            this.passregbox.Location = new System.Drawing.Point(418, 229);
            this.passregbox.Name = "passregbox";
            this.passregbox.Size = new System.Drawing.Size(100, 20);
            this.passregbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вход";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Регистрация";
            // 
            // enterbutton
            // 
            this.enterbutton.Location = new System.Drawing.Point(172, 268);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(75, 23);
            this.enterbutton.TabIndex = 10;
            this.enterbutton.Text = "Войти";
            this.enterbutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passregbox);
            this.Controls.Add(this.loginregbox);
            this.Controls.Add(this.passenbox);
            this.Controls.Add(this.loginenbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Авторизация в библиотеке";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginenbox;
        private System.Windows.Forms.TextBox passenbox;
        private System.Windows.Forms.TextBox loginregbox;
        private System.Windows.Forms.TextBox passregbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.Button button1;
    }
}

