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
    public partial class log_in : Form
    {
        DataBase database = new DataBase();
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_password.MaxLength = 25;
            textBox_login.MaxLength = 50;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_login.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                var loginUser = textBox_login.Text;
                var passwordUser = textBox_password.Text;

                SqlDataAdapter adapter1 = new SqlDataAdapter();
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                DataTable table1 = new DataTable();
                DataTable table2 = new DataTable();

                string querystring1 = $"select UID, login, password from Client where login = '{loginUser}' and password = '{passwordUser}'";
                string querystring2 = $"select UID, login, password, roleID from Employee where login = '{loginUser}' and password = '{passwordUser}'";

                SqlCommand command1 = new SqlCommand(querystring1, database.getConnection());
                SqlCommand command2 = new SqlCommand(querystring2, database.getConnection());

                adapter1.SelectCommand = command1;
                adapter1.Fill(table1);

                adapter2.SelectCommand = command2;
                adapter2.Fill(table2);

                CurrentUser.userLogin = textBox_login.Text;

                

                if (table1.Rows.Count == 1)
                {
                    string queryGetClient = $"select UID from Client where login = '{CurrentUser.userLogin}'";
                    SqlCommand commandGetClient = new SqlCommand(queryGetClient, database.getConnection());
                    database.openConnection();
                    object resultClient = commandGetClient.ExecuteScalar();
                    CurrentUser.userID = (int)resultClient;

                    MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    client_control_panel frm1 = new client_control_panel();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Close();
                }
                else if (table2.Rows.Count == 1)
                {
                    bool containsRoleID1 = table2.AsEnumerable().Any(row => row.Field<int>("roleID") == 1);
                    bool containsRoleID2 = table2.AsEnumerable().Any(row => row.Field<int>("roleID") == 2);
                    bool containsRoleID3 = table2.AsEnumerable().Any(row => row.Field<int>("roleID") == 3);
                    
                    string queryGetEmployee = $"select UID from Employee where login = '{CurrentUser.userLogin}'";
                    SqlCommand commandGetEmployee = new SqlCommand(queryGetEmployee, database.getConnection());
                    database.openConnection();
                    object resultEmployee = commandGetEmployee.ExecuteScalar();
                    CurrentUser.userID = (int)resultEmployee;

                    if (containsRoleID1)
                    {
                        MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        technichian_control_panel frm1 = new technichian_control_panel();
                        this.Hide();
                        frm1.ShowDialog();
                        this.Close();
                    }
                    else if (containsRoleID2)
                    {
                        MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        manager_control_panel frm2 = new manager_control_panel();
                        this.Hide();
                        frm2.ShowDialog();
                        this.Close();
                    }
                    else if (containsRoleID3)
                    {
                        MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        admin_control_panel frm3 = new admin_control_panel();
                        this.Hide();
                        frm3.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    CurrentUser.userLogin = null;
                    CurrentUser.userID = 0;
                    MessageBox.Show("Такого аккаунта не существует", "Аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void linkLabel_toRegistration_Click(object sender, EventArgs e)
        {
            sign_up frm_sign_up = new sign_up();
            this.Hide();
            frm_sign_up.ShowDialog();
            this.Close();
        }
    }
}
