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
    public partial class frm_SanBay : Form
    {
        public frm_SanBay()
        {
            InitializeComponent();

        }
        Connection x = new Connection();

        public void INSERT(string MASANBAY, string TENSANBAY)
        {
            string sql = "INSERT INTO SANBAY(MASANBAY,TENSANBAY) VALUES (N'" + MASANBAY + "',N'" + TENSANBAY + "')";
            x.KetNoi();
            SqlCommand cm = new SqlCommand(sql, x.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            x.cn.Close();
        }
        public void UPDATE(string MASANBAY, string TENSANBAY)
        {
            this.x.KetNoi();
            string sql = "UPDATE SANBAY SET [MASANBAY]='" + MASANBAY + "',[TENSANBAY]=N'" + TENSANBAY + "' WHERE [MASANBAY]=N'" + MASANBAY + "'";
            SqlCommand cm = new SqlCommand(sql, x.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            x.cn.Close();
        }
        public void Delete(string MASANBAY)
        {
            this.x.KetNoi();
            string sql = "DELETE FROM SANBAY WHERE [MASANBAY]=N'" + MASANBAY + "'";
            SqlCommand cm = new SqlCommand(sql, x.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            x.cn.Close();
        }


        public DataTable SelectAll()
        {
            return x.ExecuteData("select * from SANBAY");
        }
        private void frm_ThemSanBay_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = SelectAll();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtMaSanBay.Text != "" && txtTenSanBay.Text != "")

                INSERT(txtMaSanBay.Text, txtTenSanBay.Text);
                dataGridView1.DataSource = SelectAll();

                txtMaSanBay.Text = "";
                txtTenSanBay.Text = "";

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtMaSanBay.Text != "" && txtTenSanBay.Text != "")

                UPDATE(txtMaSanBay.Text, txtTenSanBay.Text);
                dataGridView1.DataSource = SelectAll();

                txtMaSanBay.Text = "";
                txtTenSanBay.Text = "";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          txtMaSanBay.Text=   dataGridView1.CurrentRow.Cells[0].Value.ToString();
          txtTenSanBay.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSanBay.Text != "")
                    Delete(txtMaSanBay.Text);
                dataGridView1.DataSource = SelectAll();
                MessageBox.Show("Đã xóa thành công", "Thông báo");

                txtMaSanBay.Text = "";
                txtTenSanBay.Text = "";
            }
            catch (Exception a) { MessageBox.Show(a.Message, "Thông báo"); }

        }
    }
}
