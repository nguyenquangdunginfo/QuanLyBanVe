using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using AirTicketBookingManagement;
using System.Windows.Forms;


namespace AirTicketTester
{
    [TestClass]
    public class UnitTestLogin
    {
        private frm_Login frm_login = new frm_Login();
        private frm_Main frm_main;

        // login fail
        [TestMethod]
        public void Test_Login_Success1()
        {
            bool rs = frm_login.Login("abc", "123");
            Assert.IsFalse(rs);
        }



        // Ngo lam
        [TestMethod]
        public void Test_Login_Success()
        {
            Connection conn = new Connection();
            string mess = "kiem tra lai thong tin dang nhap";
            frm_login = new frm_Login();
            DataTable dulieu = conn.ExecuteData("select * from Account where Username = 'admin' and Password='123'");
            Assert.IsTrue(dulieu.Rows.Count > 0, mess);
        }

        [TestMethod]
        public void Test_User_NotEmpty()
        {
            Connection conn = new Connection();
            string mess = "Username phai la dang chuoi ky tu";
            DataTable dulieu_tong = conn.ExecuteData("select * from Account");
            int count_dulieu_tong = dulieu_tong.Rows.Count;
            DataTable dulieu = conn.ExecuteData("select * from Account where Username is not null and ISNUMERIC(Username) = 0");
            Assert.IsTrue(dulieu.Rows.Count == count_dulieu_tong, mess);
        }

        [TestMethod]
        public void Test_Pass_NotEmpty()
        {
            Connection conn = new Connection();
            string mess = "Mat khau khong duoc de trong";
            DataTable dulieu_tong = conn.ExecuteData("select * from Account");
            int count_dulieu_tong = dulieu_tong.Rows.Count;
            DataTable dulieu = conn.ExecuteData("select * from Account where Password IS NOT NULL");
            Assert.IsTrue(dulieu.Rows.Count == count_dulieu_tong, mess);
        }
        [TestMethod]
        public void Test_Login_Fail()
        {
            Connection conn = new Connection();
            DataTable dulieu = conn.ExecuteData("select * from Account where Username ='admin123' and Password='1234'");
            Assert.IsTrue(dulieu.Rows.Count > 0);
        }
    }
}
