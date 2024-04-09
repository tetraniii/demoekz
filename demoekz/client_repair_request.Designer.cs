
namespace demoekz
{
    partial class client_repair_request
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
            this.textBox_serial_number = new System.Windows.Forms.TextBox();
            this.richTextBox_problem_desc = new System.Windows.Forms.RichTextBox();
            this.button_create_request = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.listBox_equipment_type = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип оборудования:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание проблемы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Серийный номер:";
            // 
            // textBox_serial_number
            // 
            this.textBox_serial_number.Location = new System.Drawing.Point(16, 88);
            this.textBox_serial_number.Name = "textBox_serial_number";
            this.textBox_serial_number.Size = new System.Drawing.Size(201, 20);
            this.textBox_serial_number.TabIndex = 4;
            // 
            // richTextBox_problem_desc
            // 
            this.richTextBox_problem_desc.Location = new System.Drawing.Point(16, 142);
            this.richTextBox_problem_desc.Name = "richTextBox_problem_desc";
            this.richTextBox_problem_desc.Size = new System.Drawing.Size(407, 123);
            this.richTextBox_problem_desc.TabIndex = 5;
            this.richTextBox_problem_desc.Text = "";
            // 
            // button_create_request
            // 
            this.button_create_request.AutoSize = true;
            this.button_create_request.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_create_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_create_request.Location = new System.Drawing.Point(309, 271);
            this.button_create_request.Name = "button_create_request";
            this.button_create_request.Size = new System.Drawing.Size(114, 27);
            this.button_create_request.TabIndex = 6;
            this.button_create_request.Text = "Подать заявку";
            this.button_create_request.UseVisualStyleBackColor = true;
            this.button_create_request.Click += new System.EventHandler(this.button_create_request_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.AutoSize = true;
            this.button_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_cancel.Location = new System.Drawing.Point(234, 271);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(69, 27);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // listBox_equipment_type
            // 
            this.listBox_equipment_type.FormattingEnabled = true;
            this.listBox_equipment_type.Location = new System.Drawing.Point(16, 34);
            this.listBox_equipment_type.Name = "listBox_equipment_type";
            this.listBox_equipment_type.Size = new System.Drawing.Size(201, 17);
            this.listBox_equipment_type.TabIndex = 8;
            // 
            // client_repair_request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 318);
            this.Controls.Add(this.listBox_equipment_type);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_create_request);
            this.Controls.Add(this.richTextBox_problem_desc);
            this.Controls.Add(this.textBox_serial_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "client_repair_request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание завки на ремонт";
            this.Load += new System.EventHandler(this.client_repair_request_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_serial_number;
        private System.Windows.Forms.RichTextBox richTextBox_problem_desc;
        private System.Windows.Forms.Button button_create_request;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ListBox listBox_equipment_type;
    }
}