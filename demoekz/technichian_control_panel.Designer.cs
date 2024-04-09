
namespace demoekz
{
    partial class technichian_control_panel
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
            this.button_tech_requests = new System.Windows.Forms.Button();
            this.button_tech_order_spares = new System.Windows.Forms.Button();
            this.button_tech_toManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_tech_requests
            // 
            this.button_tech_requests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_tech_requests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_tech_requests.Location = new System.Drawing.Point(39, 39);
            this.button_tech_requests.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            this.button_tech_requests.Name = "button_tech_requests";
            this.button_tech_requests.Size = new System.Drawing.Size(184, 27);
            this.button_tech_requests.TabIndex = 0;
            this.button_tech_requests.Text = "Просмотреть заявки";
            this.button_tech_requests.UseVisualStyleBackColor = true;
            // 
            // button_tech_order_spares
            // 
            this.button_tech_order_spares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_tech_order_spares.Location = new System.Drawing.Point(39, 73);
            this.button_tech_order_spares.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            this.button_tech_order_spares.Name = "button_tech_order_spares";
            this.button_tech_order_spares.Size = new System.Drawing.Size(184, 27);
            this.button_tech_order_spares.TabIndex = 1;
            this.button_tech_order_spares.Text = "Заказать запчасти";
            this.button_tech_order_spares.UseVisualStyleBackColor = true;
            // 
            // button_tech_toManager
            // 
            this.button_tech_toManager.AutoSize = true;
            this.button_tech_toManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_tech_toManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_tech_toManager.Location = new System.Drawing.Point(39, 107);
            this.button_tech_toManager.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            this.button_tech_toManager.Name = "button_tech_toManager";
            this.button_tech_toManager.Size = new System.Drawing.Size(184, 27);
            this.button_tech_toManager.TabIndex = 2;
            this.button_tech_toManager.Text = "Связаться с менеджером";
            this.button_tech_toManager.UseVisualStyleBackColor = true;
            // 
            // technichian_control_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 174);
            this.Controls.Add(this.button_tech_toManager);
            this.Controls.Add(this.button_tech_order_spares);
            this.Controls.Add(this.button_tech_requests);
            this.Name = "technichian_control_panel";
            this.Text = "Панель управления исполнителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_tech_requests;
        private System.Windows.Forms.Button button_tech_order_spares;
        private System.Windows.Forms.Button button_tech_toManager;
    }
}