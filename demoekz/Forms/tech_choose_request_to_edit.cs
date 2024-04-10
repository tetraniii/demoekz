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
    public partial class tech_choose_request_to_edit : Form
    {
        DataBase database = new DataBase();
        public tech_choose_request_to_edit()
        {
            InitializeComponent();
            LoadDataIntoComboBox();
        }
        private void LoadDataIntoComboBox()
        {
            string querystring = $"select requestNum from Repair_Request where employeeID = '{CurrentUser.userID}' and requestStatus != 3";
            try
            {
                SqlCommand command1 = new SqlCommand(querystring, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                adapter.Fill(table1);

                comboBox_request_num.Items.Clear();

                foreach(DataRow row in table1.Rows)
                {
                    comboBox_request_num.Items.Add(row["requestNum"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                tech_all_requests frm_tech_all_requests = new tech_all_requests();
                this.Hide();
                frm_tech_all_requests.ShowDialog();
                Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            tech_all_requests frm_tech_all_requests = new tech_all_requests();
            this.Hide();
            frm_tech_all_requests.ShowDialog();
            Close();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if(comboBox_request_num.Text == "")
            {
                MessageBox.Show("Выберите номер запроса");
            }
            else
            {
                
            }
        }
    }
}
