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
    public partial class client_repair_request : Form
    {
        DataBase database = new DataBase();
        public client_repair_request()
        {
            InitializeComponent();
        }

        private void client_repair_request_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();
            string querystring1 = $"select * from Equipment_Type";
            try
            {
                SqlCommand command1 = new SqlCommand(querystring1, database.getConnection());
                SqlDataReader sdr = command1.ExecuteReader();
                listBox_equipment_type.Items.Clear();
                table1.Load(sdr);

                listBox_equipment_type.DataSource = new BindingSource(table1, null);
                listBox_equipment_type.DisplayMember = "equipmentTypeName";
                listBox_equipment_type.ValueMember = "equipmentTypeID";
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки данных");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            client_control_panel frm_client_control_panel = new client_control_panel();
            this.Hide();
            frm_client_control_panel.Show();
        }

        private void button_create_request_Click(object sender, EventArgs e)
        {
            if (listBox_equipment_type.Text == "" || textBox_serial_number.Text == "" || richTextBox_problem_desc.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                var requestDate = DateTime.Now;
                var equipmentType = listBox_equipment_type.Text;
                var problemDesc = richTextBox_problem_desc.Text;
                var equipmentSerialNum = Convert.ToInt32("textBox_serial_number.Text");

                string querystring = $"insert into Repair_Request(requestDate, clientID, equipmentType, problemDesc, requestStatus, equipmentSerialNum)" +
                    $" values('{requestDate}', '{password}', '{name}')";
            }
        }
    }
}
