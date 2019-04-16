using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirTicketBookingManagement
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        
        string username = "";

        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        string password = "";

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string describe = "";

        public string Describe
        {
            get { return describe; }
            set { describe = value; }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            toolStripLabel3.Text = Describe;
          
        }

        private void QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            frm_KhachHang kh = new frm_KhachHang();
            kh.ShowDialog();
        }

        private void QuanLyChangBay_Click(object sender, EventArgs e)
        {
            frm_ChangBay tuyenbay = new frm_ChangBay();
            tuyenbay.ShowDialog();
        }

        private void AddChangBay_Click(object sender, EventArgs e)
        {
            frm_ChangBay tuyenbay = new frm_ChangBay();

            tuyenbay.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDongHo.Text = DateTime.Now.ToShortTimeString();
        }

        private void DoanhThuThang_Click(object sender, EventArgs e)
        {
            
        }

        private void DoanhThuNam_Click(object sender, EventArgs e)
        {

        }

        private void SearchThongTinKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void SearchVe_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frm_NhanVien nhanvien = new frm_NhanVien();
            nhanvien.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            frm_ThayDoiPass doipass = new frm_ThayDoiPass();
            //gửi user qua form đổi pass
            doipass.username = this.username;
            doipass.ShowDialog();
        }

        private void QuanLySanBay_Click(object sender, EventArgs e)
        {
            frm_SanBay sanbay = new frm_SanBay();
            sanbay.ShowDialog();
        }

        private void AddBooking_Click(object sender, EventArgs e)
        {
            frm_DatVe AddVe = new frm_DatVe();
            AddVe.ShowDialog();

        }
        
    }
}
