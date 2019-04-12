﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirTicketBookingManagement
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            DataTable dulieu = conn.ExecuteData("select * from Account where Username ='" + txtUser.Text + "' and Password='" + txtPass.Text + "' ");
            if (dulieu.Rows.Count > 0)
            {
                frm_Main main = new frm_Main();
                // truyền thông tin của tài khoản qua form main
                main.Username = dulieu.Rows[0][0].ToString();
                main.Password = dulieu.Rows[0][0].ToString();
                main.Describe = dulieu.Rows[0][0].ToString();
                main.Show();
                this.Hide();
            }
            else if (txtUser.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Username");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Password");
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại Username và Password! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtUser.Clear();
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
