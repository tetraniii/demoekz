
namespace demoekz
{
    partial class sign_up
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_registration = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.linkLabel_toLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(80, 54);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(186, 20);
            this.textBox_login.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(80, 81);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(186, 20);
            this.textBox_password.TabIndex = 4;
            // 
            // button_registration
            // 
            this.button_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_registration.Location = new System.Drawing.Point(16, 146);
            this.button_registration.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(165, 31);
            this.button_registration.TabIndex = 5;
            this.button_registration.Text = "Зарегистрироваться";
            this.button_registration.UseVisualStyleBackColor = true;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(34, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(80, 108);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(186, 20);
            this.textBox_name.TabIndex = 7;
            // 
            // linkLabel_toLogin
            // 
            this.linkLabel_toLogin.AutoSize = true;
            this.linkLabel_toLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel_toLogin.Location = new System.Drawing.Point(13, 190);
            this.linkLabel_toLogin.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.linkLabel_toLogin.Name = "linkLabel_toLogin";
            this.linkLabel_toLogin.Size = new System.Drawing.Size(104, 13);
            this.linkLabel_toLogin.TabIndex = 8;
            this.linkLabel_toLogin.TabStop = true;
            this.linkLabel_toLogin.Text = "Уже есть аккаунт?";
            this.linkLabel_toLogin.Click += new System.EventHandler(this.linkLabel_toLogin_Click);
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 234);
            this.Controls.Add(this.linkLabel_toLogin);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_registration);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sign_up";
            this.Text = "sign_in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.LinkLabel linkLabel_toLogin;
    }
}

