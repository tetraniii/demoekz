
namespace demoekz
{
    partial class admin_control_panel
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
            this.button_create_new_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_create_new_user
            // 
            this.button_create_new_user.AutoSize = true;
            this.button_create_new_user.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_create_new_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_create_new_user.Location = new System.Drawing.Point(35, 39);
            this.button_create_new_user.Margin = new System.Windows.Forms.Padding(30, 30, 30, 3);
            this.button_create_new_user.Name = "button_create_new_user";
            this.button_create_new_user.Size = new System.Drawing.Size(216, 27);
            this.button_create_new_user.TabIndex = 0;
            this.button_create_new_user.Text = "Создать нового пользователя";
            this.button_create_new_user.UseVisualStyleBackColor = true;
            // 
            // admin_control_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 173);
            this.Controls.Add(this.button_create_new_user);
            this.Name = "admin_control_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_create_new_user;
    }
}