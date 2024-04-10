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
    public partial class tech_all_requests : Form
    {
        DataBase database = new DataBase();
        public tech_all_requests()
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
                        $"Repair_Request.requestNum AS 'Номер заказа', " +
                        $"Status.statusName AS 'Статус', " +
                        $"Equipment_Type.equipmentTypeName AS 'Тип оборудования', " +
                        $"Repair_Request.equipmentSerialNum AS 'Серийный номер оборудования', " +
                        $"Repair_Request.problemDesc AS 'Описание проблемы', " +
                        $"Repair_Request.malfunctionType AS 'Тип неисправности', " +
                        $"Repair_Request.requestDate AS 'Дата добавления', " +
                        $"Repair_Request.deadline AS 'Срок выполнения' " +
                    $"FROM " +
                        $"Repair_Request " +
                    $"JOIN " +
                        $"Employee ON Repair_Request.employeeID = Employee.UID " +
                    $"JOIN " +
                        $"Equipment_Type ON Repair_Request.equipmentType = Equipment_Type.equipmentTypeID " +
                    $"JOIN " +
                        $"Status ON Repair_Request.requestStatus = Status.statusID " +
                    $"WHERE " +
                        $"Employee.UID = '{CurrentUser.userID}'";

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
            technichian_control_panel frm_tech_control_panel = new technichian_control_panel();
            Hide();
            frm_tech_control_panel.ShowDialog();
            Close();
        }
    }
}
