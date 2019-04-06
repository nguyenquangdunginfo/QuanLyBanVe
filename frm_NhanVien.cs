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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        Connection ketnoi = new Connection(); 
        public void INSERT(string MANV, string TENNV, string DIENTHOAI, string DIACHI)
        {
            string sql = "INSERT INTO NHANVIEN(MANV,TENNV,DIENTHOAI,DIACHI) VALUES (N'" + MANV + "',N'" + TENNV + "',N'" + DIENTHOAI + "',N'" + DIACHI + "')";
           
            ketnoi.ExecuteNonQuery(sql);
        }
        public void UPDATE(string MANV, string TENNV, string DIENTHOAI, string DIACHI)
        {
          
            string sql = "UPDATE NHANVIEN SET [MANV]=N'" + MANV + "',[TENNV]=N'" + TENNV + "',[DIENTHOAI]=N'" + DIENTHOAI + "',[DIACHI]=N'" + DIACHI + "' WHERE [MANV]=N'" + MANV + "'";
            ketnoi.ExecuteNonQuery(sql);
        }
        public void Delete(string MANV)
        {
            
            string sql = "DELETE FROM NHANVIEN WHERE [MANV]=N'" + MANV + "'";
            ketnoi.ExecuteNonQuery(sql);
            dataGridView1.DataSource = ketnoi.ExecuteData("select * from NHANVIEN");

        }
        private void frm_QuanlyNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ketnoi.ExecuteData("select * from NHANVIEN");// load tất cả dữ liệu lên khi mới mở form

        }
       
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try  
           {
            txt_manv.Text=  dataGridView1.CurrentRow.Cells[0].Value.ToString(); //MANV là cột 0 có  thể dùng dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tennv.Text = dataGridView1.CurrentRow.Cells["TENNV"].Value.ToString();//"TENNV"
            txt_dienthoai.Text = dataGridView1.CurrentRow.Cells["DIENTHOAI"].Value.ToString();//"DIACHI"
            txt_diachi.Text = dataGridView1.CurrentRow.Cells["Diachi"].Value.ToString();//"Diachi"
  
            }
            catch( Exception j){ MessageBox.Show(j.Message);  }
        }

    

        private void Add_Click(object sender, EventArgs e)
        {

            if (txt_manv.Text != "" && txt_tennv.Text != "") 
            {
                
                    INSERT(txt_manv.Text, txt_tennv.Text, txt_dienthoai.Text, txt_diachi.Text);
                    MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
            }
            else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = ketnoi.ExecuteData("select * from NHANVIEN");
        }

        private void Update_Click(object sender, EventArgs e)
        {

            if (txt_manv.Text != "" && txt_tennv.Text != "" ) 
            {
               
                    UPDATE(txt_manv.Text, txt_tennv.Text, txt_dienthoai.Text, txt_diachi.Text);

                    MessageBox.Show("Đã cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = ketnoi.ExecuteData("select * from NHANVIEN");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txt_tennv.Clear();
            txt_diachi.Clear();
            txt_manv.Clear();
            txt_dienthoai.Clear();
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text != "")
            {
                Delete(txt_manv.Text);
                MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = ketnoi.ExecuteData("select * from NHANVIEN");
            }
        }
    }
}
