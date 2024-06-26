﻿using System;
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
    public partial class client_control_panel : Form
    {
        public client_control_panel()
        {
            InitializeComponent();
        }

        private void button_client_new_request_Click(object sender, EventArgs e)
        {
            client_repair_request frm_client_repair_request = new client_repair_request();
            Hide();
            frm_client_repair_request.ShowDialog();
            Close();
        }

        private void button_client_requests_Click(object sender, EventArgs e)
        {
            client_all_requests frm_client_all_requests = new client_all_requests();
            Hide();
            frm_client_all_requests.ShowDialog();
            Close();
        }

        private void button_client_toManager_Click(object sender, EventArgs e)
        {
            client_managers frm_client_managers = new client_managers();
            Hide();
            frm_client_managers.ShowDialog();
            Close();
        }
    }
}
