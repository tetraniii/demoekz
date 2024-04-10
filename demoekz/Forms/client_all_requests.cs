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
    public partial class client_all_requests : Form
    {
        DataBase database = new DataBase();
        public client_all_requests()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                database.openConnection();

                string querystring = $"SELECT " +
                        $"Status.statusName AS 'Статус', " +
                        $"Equipment_Type.equipmentTypeName AS 'Тип оборудования', "+
                        $"Repair_Request.equipmentSerialNum AS 'Серийный номер оборудования', "+
                        $"Repair_Request.problemDesc AS 'Описание проблемы', " +
                        $"Repair_Request.requestDate AS 'Дата добавления', " +
                        $"Repair_Request.deadline AS 'Срок выполнения' " +
                    $"FROM " +
                        $"Repair_Request " +
                    $"JOIN " +
                        $"Client ON Repair_Request.clientID = Client.UID " +
                    $"JOIN " +
                        $"Equipment_Type ON Repair_Request.equipmentType = Equipment_Type.equipmentTypeID " +
                    $"JOIN " +
                        $"Status ON Repair_Request.requestStatus = Status.statusID " +
                    $"WHERE " +
                        $"Client.UID = '{CurrentUser.userID}'";

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
