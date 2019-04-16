using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay
{
    public partial class frm_GiaVe : Form
    {
        public frm_GiaVe()
        {
            InitializeComponent();
        }
        Connection ketnoi = new Connection();
        private void frm_quanlygia_Load(object sender, EventArgs e)
        {
            cb_chuyenbay.DataSource = ketnoi.ExecuteData("select * from TUYENBAY");//hien du lieu len combox chuyen bay
            cb_chuyenbay.DisplayMember = "MATUYENBAY";// tên hiển thị
            cb_chuyenbay.ValueMember = "MATUYENBAY";//giá trị chọn
            cb_hangve.DataSource = ketnoi.ExecuteData("select * from HANGVE");
            cb_hangve.DisplayMember = "TENHANGVE";// tên hiển thị
            cb_hangve.ValueMember = "MAHANGVE";//giá trị chọn
            dataGridView1.DataSource=  ketnoi.ExecuteData("select * from DONGIA"); // lòad dữ liệu bảng đơn giá lên lưới
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        // bắt sự kiên click chuôt trênb dataGridView1
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          cb_chuyenbay.SelectedValue=  dataGridView1.CurrentRow.Cells[1].Value.ToString();
          cb_hangve.SelectedValue=   dataGridView1.CurrentRow.Cells[2].Value.ToString();
         txtgia.Text=   dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
