using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay
{
    public partial class frm_VeChuyenBay : Form
    {
        public frm_VeChuyenBay()
        {
            InitializeComponent();
        }

        private void bnt_4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_9_TextChanged(object sender, EventArgs e)
        {

        }
        Connection x= new Connection();

        public DataTable SelectAll()
        {
            return x.ExecuteData("select * from VECHUYENBAY");
        }
        public void INSERT(string MAKH, string MAHANGVE, string MACHUYENBAY, int GiaTien)
        {
            string sql = "INSERT INTO VECHUYENBAY(MAKH,MAHANGVE,MACHUYENBAY,GiaTien) VALUES (N'" + MAKH + "',N'" + MAHANGVE + "',N'" + MACHUYENBAY + "'," + GiaTien + ")";
            x.KetNoi();
            SqlCommand cm = new SqlCommand(sql, x.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            x.cn.Close();
        }
        public void UPDATE(int MAVECHUYENBAY, string MAKH, string MAHANGVE, string MACHUYENBAY, int GiaTien)
        {
            this.x.KetNoi();
            string sql = "UPDATE VECHUYENBAY SET [MAKH]=" + MAKH + ",[MAHANGVE]=" + MAHANGVE + ",[MACHUYENBAY]=" + MACHUYENBAY + ",[GiaTien]=N'" + GiaTien + "' WHERE [MAVECHUYENBAY]=" + MAVECHUYENBAY + "";
            SqlCommand cm = new SqlCommand(sql, x.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            x.cn.Close();
        }
        public void Delete(string MAPHIEUDATCHO)
        {
            this.x.KetNoi();
            string sql = "DELETE FROM PHIEUDATCHO WHERE [MAPHIEUDATCHO]=N'" + MAPHIEUDATCHO + "'";
            SqlCommand cm = new SqlCommand(sql, x.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            x.cn.Close();
        }
      
        private void frm_VeChuyenBay_Load(object sender, EventArgs e)
        {
            cb_1.DataSource = x.ExecuteData("select * from CHUYENBAY ");
            cb_1.ValueMember = "MACHUYENBAY";
            HienthiHangVe();

        }
        public void HienthiHangVe()
        {

            cb_2.DataSource = x.ExecuteData("select * from HANGVE ");
            cb_2.ValueMember = "MAHANGVE";
            cb_2.DisplayMember = "TENHANGVE";
        }
       
        private void bnt_1_Click(object sender, EventArgs e)
        {
            frm_KhachHang kh = new frm_KhachHang();
            kh.ShowDialog();
           txt_7.Text=  kh.Tenkh ;
           txt_5.Text=  kh.Makh ;
           txt_6.Text = kh.Makh;
           txt_8.Text = kh.Cmnd;
        }

        private void bnt_2_Click(object sender, EventArgs e)
        {
            try
            {
                INSERT(txt_5.Text, cb_2.SelectedValue.ToString(), cb_1.SelectedValue.ToString(),int.Parse( textBox10.Text));


                MessageBox.Show("Đã thêm thành công!");
            
            }
            catch (Exception d) { MessageBox.Show(d.Message); }
        }
        string matuyen = "";
        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dulieu = x.ExecuteData("SELECT * FROM View_Vechuyenbay WHERE MACHUYENBAY='" + cb_1.SelectedValue + "'");
                txt_1.Text = x.ExecuteData("select * from SANBAY WHERE  MASANBAY='" + dulieu.Rows[0]["MASANBAYDI"].ToString() + "'").Rows[0]["TENSANBAY"].ToString();
                txt_2.Text = x.ExecuteData("select * from SANBAY WHERE  MASANBAY='" + dulieu.Rows[0]["MASANBAYDEN"].ToString() + "'").Rows[0]["TENSANBAY"].ToString();
                txt_4.Text = "Còn vé";
                txt_3.Text = dulieu.Rows[0]["NGAYGIO"].ToString();
                matuyen = dulieu.Rows[0]["MATUYENBAY"].ToString();
                DataTable giave=x.ExecuteData("SELECT * FROM DONGIA WHERE  MATUYENBAY='" + matuyen + "' AND MAHANGVE='"+cb_2.SelectedValue+"'");
                if (giave.Rows.Count > 0)
                    textBox10.Text = giave.Rows[0]["VND"].ToString();
                else textBox10.Text = "0";
       
            }
            catch { }
        
        }

        private void cb_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable giave = x.ExecuteData("SELECT * FROM DONGIA WHERE  MATUYENBAY='" + matuyen + "' AND MAHANGVE='" + cb_2.SelectedValue + "'");
                if (giave.Rows.Count > 0)
                    textBox10.Text = giave.Rows[0]["VND"].ToString();
                else textBox10.Text = "0";
                  }
            catch (Exception j) {  }
        }
    }
}
