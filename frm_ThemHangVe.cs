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
    public partial class frm_ThemHangVe : Form
    {
        public frm_ThemHangVe()
        {
            InitializeComponent();
        }
        Connection x = new Connection();
        private void frm_ThemHangVe_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = x.ExecuteData("select * from HANGVE");
            comboBox1.ValueMember = "Tenhangve";
        }
        public void INSERT(string MAHANGVE, string TENHANGVE)
        {
            string sql = "INSERT INTO HANGVE(MAHANGVE,TENHANGVE) VALUES (N'" + MAHANGVE + "',N'" + TENHANGVE + "')";
            x.ExecuteNonQuery(sql);
        }
        public void UPDATE(string MAHANGVE, string TENHANGVE)
        {
            this.x.KetNoi();
            string sql = "UPDATE HANGVE SET [MAHANGVE]=" + MAHANGVE + ",[TENHANGVE]=" + TENHANGVE + " WHERE [MAHANGVE]=N'" + MAHANGVE + "'";
            SqlCommand cm = new SqlCommand(sql, x.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            x.cn.Close();
        }
         public void Delete(string MAHANGVE)

       { 
        this.x.KetNoi();
        string sql="DELETE FROM HANGVE WHERE [MAHANGVE]=N'"+MAHANGVE+"'";
        SqlCommand cm = new SqlCommand(sql, x.cn);
        cm.CommandType = CommandType.Text;
        cm.ExecuteNonQuery();
        x.cn.Close();
      }
  
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text!=""&&textBox2.Text!="")
                UPDATE(textBox1.Text, textBox2.Text);
                comboBox1.DataSource = x.ExecuteData("select * from HANGVE");
                comboBox1.ValueMember = "Mahangve";
                comboBox1.DisplayMember = "Tenhangve";
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text != "" && textBox2.Text != "")
                 INSERT(textBox1.Text, textBox2.Text);
                 comboBox1.DataSource = x.ExecuteData("select * from HANGVE");
                 comboBox1.ValueMember  = "Mahangve";
                 comboBox1.DisplayMember ="Tenhangve";
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox2.Text = comboBox1.Text;
           // textBox1.Text = comboBox1.SelectedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
