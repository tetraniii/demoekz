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
            string querystring1 = $"select equipmentTypeName from Equipment_Type";
            try
            {
                SqlCommand command1 = new SqlCommand(querystring1, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                adapter.Fill(table1);

                comboBox_equipment_type.Items.Clear();

                foreach(DataRow row in table1.Rows)
                {
                    comboBox_equipment_type.Items.Add(row["equipmentTypeName"].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки данных");
                client_control_panel frm_client_control_panel = new client_control_panel();
                this.Hide();
                frm_client_control_panel.ShowDialog();
                Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            client_control_panel frm_client_control_panel = new client_control_panel();
            this.Hide();
            frm_client_control_panel.ShowDialog();
            Close();
        }

        private void button_create_request_Click(object sender, EventArgs e)
        {
            if (comboBox_equipment_type.Text == "" || textBox_serial_number.Text == "" || richTextBox_problem_desc.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                var requestDate = DateTime.Now;
                var equipmentType = comboBox_equipment_type.Text;
                var problemDesc = richTextBox_problem_desc.Text;
                var equipmentSerialNum = textBox_serial_number.Text;

                int clientID = CurrentUser.userID;

                string queryGetEquipType = $"select equipmentTypeID from Equipment_Type where equipmentTypeName = '{equipmentType}'";
                SqlCommand commandGetEquipType = new SqlCommand(queryGetEquipType, database.getConnection());
                object resultEquip = commandGetEquipType.ExecuteScalar();
                int equipmentTypeID = (int)resultEquip;

                string querystring = $"insert into Repair_Request(requestDate, clientID, equipmentType, problemDesc, requestStatus, equipmentSerialNum)" +
                    $" values('{requestDate}', '{clientID}', '{equipmentTypeID}', '{problemDesc}', 1, '{equipmentSerialNum}')";

                SqlCommand command = new SqlCommand(querystring, database.getConnection());

                database.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запрос успешно создан", "Успех");
                    client_control_panel frm_client_control_panel = new client_control_panel();
                    this.Hide();
                    frm_client_control_panel.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Не удалось создать запрос");
                }
            }
        }
    }
}
