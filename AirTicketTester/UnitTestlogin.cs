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

        // login success
        [TestMethod]
        public void Test_Login_Success01()
        {
            bool rs = frm_login.Login("admin", "123");
            Assert.IsTrue(rs);
        }

        // login fail
        [TestMethod]
        public void Test_Login_Fail01()
        {
            bool rs = frm_login.Login("abc", "123");
            Assert.IsFalse(rs);
           // MessageBox.Show("Sai User");
        }

        [TestMethod]
        public void Test_Login_Fail02()
        {
            bool rs = frm_login.Login("dung", "321");
            Assert.IsFalse(rs);
           // MessageBox.Show("Sai Password");
        }

        [TestMethod]
        public void Test_Login_Fail03()
        {
            bool rs = frm_login.Login("", "");
            Assert.IsFalse(rs);
           // MessageBox.Show("User và Pass không được rỗng");
        }

        [TestMethod]
        public void Login_Fail06()
        {
            bool rs = frm_login.Login("administrator", "abc");
            Assert.IsFalse(rs);
            //MessageBox.Show("User và Pass không đúng");
        }
        [TestMethod]
        public void Test_Login_Fail07()
        {
            bool rs = frm_login.Login("", "123");
            Assert.IsFalse(rs);
            
        }

        // Test CSDL
        [TestMethod]
        public void Test_Login_Success02()
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
        public void Test_Login_Fail005()
        {
            Connection conn = new Connection();
            DataTable dulieu = conn.ExecuteData("select * from Account where Username ='admin123' and Password='1234'");
            Assert.IsFalse(dulieu.Rows.Count > 0);
        }
    }
}
