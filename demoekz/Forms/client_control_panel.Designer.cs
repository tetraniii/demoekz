
namespace demoekz
{
    partial class client_control_panel
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
            this.button_client_new_request = new System.Windows.Forms.Button();
            this.button_client_requests = new System.Windows.Forms.Button();
            this.button_client_toManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_client_new_request
            // 
            this.button_client_new_request.AutoSize = true;
            this.button_client_new_request.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_client_new_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_client_new_request.Location = new System.Drawing.Point(35, 35);
            this.button_client_new_request.Margin = new System.Windows.Forms.Padding(30, 30, 30, 3);
            this.button_client_new_request.Name = "button_client_new_request";
            this.button_client_new_request.Size = new System.Drawing.Size(186, 27);
            this.button_client_new_request.TabIndex = 0;
            this.button_client_new_request.Text = "Подать заявку на ремонт";
            this.button_client_new_request.UseVisualStyleBackColor = true;
            this.button_client_new_request.Click += new System.EventHandler(this.button_client_new_request_Click);
            // 
            // button_client_requests
            // 
            this.button_client_requests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_client_requests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_client_requests.Location = new System.Drawing.Point(35, 68);
            this.button_client_requests.Name = "button_client_requests";
            this.button_client_requests.Size = new System.Drawing.Size(186, 27);
            this.button_client_requests.TabIndex = 1;
            this.button_client_requests.Text = "Просмотреть заявки";
            this.button_client_requests.UseVisualStyleBackColor = true;
            this.button_client_requests.Click += new System.EventHandler(this.button_client_requests_Click);
            // 
            // button_client_toManager
            // 
            this.button_client_toManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_client_toManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_client_toManager.Location = new System.Drawing.Point(35, 101);
            this.button_client_toManager.Name = "button_client_toManager";
            this.button_client_toManager.Size = new System.Drawing.Size(186, 27);
            this.button_client_toManager.TabIndex = 2;
            this.button_client_toManager.Text = "Связаться с менеджером";
            this.button_client_toManager.UseVisualStyleBackColor = true;
            this.button_client_toManager.Click += new System.EventHandler(this.button_client_toManager_Click);
            // 
            // client_control_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 171);
            this.Controls.Add(this.button_client_toManager);
            this.Controls.Add(this.button_client_requests);
            this.Controls.Add(this.button_client_new_request);
            this.Name = "client_control_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_client_new_request;
        private System.Windows.Forms.Button button_client_requests;
        private System.Windows.Forms.Button button_client_toManager;
    }
}