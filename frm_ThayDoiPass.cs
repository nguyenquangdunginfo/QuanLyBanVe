using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AirTicketBookingManagement
{
    public partial class frm_ThayDoiPass : Form
    {

        string strcon = @"server=.\SQLEXPRESS;database= AirTicketDatabase;integrated security=true";
        
        SqlDataAdapter dtbAirTicket;
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        public frm_ThayDoiPass()
            
        {
            InitializeComponent();    
        }

        public string username;
        public string password;

        Connection cn = new Connection();

        public int doiMatKhau(string matkhaumoi)
        {

            conn = new SqlConnection(strcon);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            dtbAirTicket = new SqlDataAdapter("select * from Account", strcon);

            string sql1 = "select Password from Account where Username ='" + txtUsername.Text + "'";
            SqlCommand cmdPass = new SqlCommand(sql1, conn);


            if (txtOldPass.Text.CompareTo((string)cmdPass.ExecuteScalar()) == 0)
                {   
                    string sql2 = "update Account set password ='" + matkhaumoi + "' where username='" + this.username + "'";
                    return cn.ExecuteNonQuery(sql2);  
                }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại mật khẩu cũ");
            }
            return -1;    
        }
          
  
        private void frm_ThayDoiPass_Load(object sender, EventArgs e)
        {
            txtUsername.Text = username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text.Trim() == txtNewPass.Text.Trim())
            {
                MessageBox.Show("Mật khẩu cũ không được trùng mật khẩu mới");
                return;
            }

            if (txtConfirmPass.Text.Trim() != txtNewPass.Text.Trim())
            {
                MessageBox.Show("Xác nhận mật khẩu sai");
                return;
            }

            if (doiMatKhau(txtNewPass.Text.Trim()) != -1)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
