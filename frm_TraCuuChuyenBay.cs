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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // khai báo đối tương class kết nối để gọi lên dùng
        Connection kn= new Connection();
        private void Form1_Load(object sender, EventArgs e)
        {
          //  kn.KetNoi();

            cb_1.DataSource = kn.ExecuteData("select * from SANBAY"); // câu lệnh lấy dữ liệu từ bảng sanbay
            cb_1.DisplayMember = "TenSanBay";// hiên thị
            cb_1.ValueMember = "MaSanBay";// giá trị chọn

            cb_2.DataSource = kn.ExecuteData("select * from SANBAY");
            cb_2.DisplayMember = "TenSanBay";
            cb_2.ValueMember = "MaSanBay";
           
            dataGridView1.DataSource = kn.ExecuteData("select * from chuyenbay"); 
          //  kn.DongKetNoi();
        }

        private void bnt_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string c = cb_1.SelectedValue.ToString() + "-" + cb_2.SelectedValue.ToString();

                dataGridView1.DataSource = kn.ExecuteData("select * from CHUYENBAY where MATUYENBAY='" + c + "' and  NGAYGIO >='" + dateTimePicker1.Value.ToString("MM/dd/yyy") + "' and Ngaygio<='" + dateTimePicker2.Value.ToString("MM/dd/yyy") + "'");
            }
            catch { MessageBox.Show("Không thực hiện được vui long kiểm tra lại"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cb_2.DataSource = kn.ExecuteData("select * from View_2 where MASANBAYDI='" + cb_1.SelectedValue + "' ");
                cb_2.DisplayMember = "TenSanBay";
                cb_2.ValueMember = "MaSanBayden";
            }
            catch { }
         
        }
    }
}
