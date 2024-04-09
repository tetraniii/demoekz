
namespace demoekz
{
    partial class manager_control_panel
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
            this.button_manager_requests = new System.Windows.Forms.Button();
            this.button_manager_messages = new System.Windows.Forms.Button();
            this.button_manager_reviews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_manager_requests
            // 
            this.button_manager_requests.AutoSize = true;
            this.button_manager_requests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_manager_requests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_manager_requests.Location = new System.Drawing.Point(56, 35);
            this.button_manager_requests.Name = "button_manager_requests";
            this.button_manager_requests.Size = new System.Drawing.Size(154, 27);
            this.button_manager_requests.TabIndex = 0;
            this.button_manager_requests.Text = "Просмотреть заявки";
            this.button_manager_requests.UseVisualStyleBackColor = true;
            // 
            // button_manager_messages
            // 
            this.button_manager_messages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_manager_messages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_manager_messages.Location = new System.Drawing.Point(56, 68);
            this.button_manager_messages.Name = "button_manager_messages";
            this.button_manager_messages.Size = new System.Drawing.Size(154, 27);
            this.button_manager_messages.TabIndex = 1;
            this.button_manager_messages.Text = "Сообщения";
            this.button_manager_messages.UseVisualStyleBackColor = true;
            // 
            // button_manager_reviews
            // 
            this.button_manager_reviews.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_manager_reviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_manager_reviews.Location = new System.Drawing.Point(56, 101);
            this.button_manager_reviews.Name = "button_manager_reviews";
            this.button_manager_reviews.Size = new System.Drawing.Size(154, 27);
            this.button_manager_reviews.TabIndex = 2;
            this.button_manager_reviews.Text = "Отзывы";
            this.button_manager_reviews.UseVisualStyleBackColor = true;
            // 
            // manager_control_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 171);
            this.Controls.Add(this.button_manager_reviews);
            this.Controls.Add(this.button_manager_messages);
            this.Controls.Add(this.button_manager_requests);
            this.Name = "manager_control_panel";
            this.Text = "Панель управления менеджера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_manager_requests;
        private System.Windows.Forms.Button button_manager_messages;
        private System.Windows.Forms.Button button_manager_reviews;
    }
}