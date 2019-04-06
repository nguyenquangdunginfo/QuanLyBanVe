using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirTicketBookingManagement
{
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        public void INSERT(string CMND,string TENKH,string DIENTHOAI, string DIACHI)

        {
            string sql = "INSERT INTO KHACHHANG(CMND,TENKH,DIENTHOAI,DIACHI) VALUES (N'" + CMND + "',N'" + TENKH + "',N'" + DIENTHOAI + "',N'" + DIACHI + "')";
            con.KetNoi();
            SqlCommand cm = new SqlCommand(sql, con.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            con.cn.Close();
        }
        public void UPDATE(string CMND,string TENKH,string DIENTHOAI, string DIACHI)

        {
             this.con.KetNoi();
             string sql = "UPDATE KHACHHANG SET [CMND]=" + CMND + ",[TENKH]=" + TENKH + ",[DIACHI]=" + DIACHI + " WHERE [CMND]=N'" + CMND + "'";
             SqlCommand cm = new SqlCommand(sql,  con.cn);
             cm.CommandType = CommandType.Text;
             cm.ExecuteNonQuery();
             con.cn.Close();
        }
        public void Delete(string CMND)

        { 
            this.con.KetNoi();
            string sql="DELETE FROM KHACHHANG WHERE [CMND]=N'"+CMND+"'";
            SqlCommand cm = new SqlCommand(sql, con.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            con.cn.Close();
          }
        string makh = "";

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        string tenkh = "";

        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        string cmnd = "";

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
      
        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.ExecuteData("select * from KHACHHANG");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtCMND.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // lấy cột mã khách hàng khi click chuôt
                txtTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtDienThoai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text != "" && txtTen.Text != "") 
            {

                INSERT(txtCMND.Text, txtTen.Text, txtDienThoai.Text, txtDiaChi.Text);
                MessageBox.Show("Đã thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txtCMND.Text = "";
                txtDiaChi.Text = "";
                txtDienThoai.Text = "";
                txtTen.Text = "";

            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = con.ExecuteData("select * from KhachHang");// lòad lại dữ liệu mới khi them xong
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text != "" && txtTen.Text != "") 
            {

                UPDATE(txtCMND.Text, txtTen.Text, txtDienThoai.Text, txtDiaChi.Text);

                MessageBox.Show("Đã cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCMND.Text = "";
                txtDiaChi.Text = "";
                txtDienThoai.Text = "";
                txtTen.Text = "";

            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = con.ExecuteData("select * from KhachHang");// load lại dữ liệu mới sau khi cập nhật
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text != "")
            {
                Delete(txtCMND.Text);
                MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = con.ExecuteData("select * from KhachHang");
            }

        }
    }
}
