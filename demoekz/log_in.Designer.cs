
namespace demoekz
{
    partial class log_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.linkLabel_toRegistration = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
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
            this.textBox_login.Location = new System.Drawing.Point(79, 54);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(186, 20);
            this.textBox_login.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(79, 81);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(186, 20);
            this.textBox_password.TabIndex = 4;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_login.Location = new System.Drawing.Point(16, 119);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 31);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // linkLabel_toRegistration
            // 
            this.linkLabel_toRegistration.AutoSize = true;
            this.linkLabel_toRegistration.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel_toRegistration.Location = new System.Drawing.Point(12, 163);
            this.linkLabel_toRegistration.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.linkLabel_toRegistration.Name = "linkLabel_toRegistration";
            this.linkLabel_toRegistration.Size = new System.Drawing.Size(104, 13);
            this.linkLabel_toRegistration.TabIndex = 6;
            this.linkLabel_toRegistration.TabStop = true;
            this.linkLabel_toRegistration.Text = "Еще нет аккаунта?";
            this.linkLabel_toRegistration.Click += new System.EventHandler(this.linkLabel_toRegistration_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 204);
            this.Controls.Add(this.linkLabel_toRegistration);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "log_in";
            this.Text = "log_in";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel linkLabel_toRegistration;
    }
}