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
    public partial class sign_up : Form
    {

        DataBase database = new DataBase();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_password.MaxLength = 25;
            textBox_login.MaxLength = 50;
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            if(textBox_login.Text == "" || textBox_password.Text == "" || textBox_name.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                var login = textBox_login.Text;
                var password = textBox_password.Text;
                var name = textBox_name.Text;

                string querystring = $"insert into Client(login, password, name) values('{login}', '{password}', '{name}')";

                SqlCommand command = new SqlCommand(querystring, database.getConnection());

                database.openConnection();

                if (checkUser())
                {
                    return;
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт успешно создан", "Успех");
                        log_in frm_log_in = new log_in();
                        Hide();
                        frm_log_in.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Аккаунт не создан");
                    }
                }

                database.closeConnection();
            }
        }

        private Boolean checkUser()
        {
            var loginUser = textBox_login.Text;
            var passwordUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select UID, login, password from Client where login = '{loginUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void linkLabel_toLogin_Click(object sender, EventArgs e)
        {
            log_in frm_log_in = new log_in();
            frm_log_in.Show();
            Hide();
        }
    }
}
