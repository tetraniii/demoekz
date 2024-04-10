
namespace demoekz
{
    partial class client_all_requests
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
            this.components = new System.ComponentModel.Container();
            this.demoekzDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoekzDataSet = new demoekz.demoekzDataSet();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.demoekzDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoekzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // demoekzDataSetBindingSource
            // 
            this.demoekzDataSetBindingSource.DataSource = this.demoekzDataSet;
            this.demoekzDataSetBindingSource.Position = 0;
            // 
            // demoekzDataSet
            // 
            this.demoekzDataSet.DataSetName = "demoekzDataSet";
            this.demoekzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_back
            // 
            this.button_back.AutoSize = true;
            this.button_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_back.Location = new System.Drawing.Point(729, 410);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(59, 27);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 392);
            this.dataGridView1.TabIndex = 4;
            // 
            // client_all_requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_back);
            this.Name = "client_all_requests";
            this.Text = "Управление заявками";
            ((System.ComponentModel.ISupportInitialize)(this.demoekzDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoekzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource demoekzDataSetBindingSource;
        private demoekzDataSet demoekzDataSet;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}