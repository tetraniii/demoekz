using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demoekz
{
    public partial class client_managers : Form
    {
        DataBase database = new DataBase();
        public client_managers()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                database.openConnection();

                string querystring = $"select name as 'Имя менеджера', phoneNum as 'Номер телефона' from Employee where roleID = 2";

                SqlCommand command = new SqlCommand(querystring, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table1 = new DataTable();
                adapter.Fill(table1);

                dataGridView1.DataSource = table1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            client_control_panel frm_client_control_panel = new client_control_panel();
            this.Hide();
            frm_client_control_panel.ShowDialog();
            Close();
        }
    }
}
