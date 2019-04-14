using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using AirTicketBookingManagement;


namespace AirTicketTester
{
    [TestClass]
    public class UnitTestlogin
    {
        [TestMethod]
        public void Test_Login_Success()
        {
            Connection conn = new Connection();
            DataTable dulieu = conn.ExecuteData("select * from Account where Username ='admin' and Password='123'");
            Assert.IsTrue(dulieu.Rows.Count > 0);
        }

        [TestMethod]
        public void Test_pass_notEmpty()
        {
            Connection conn = new Connection();
            DataTable dulieu_tong = conn.ExecuteData("select * from Account");
            int count_dulieu_tong = dulieu_tong.Rows.Count;
            DataTable dulieu = conn.ExecuteData("select * from Account where Password IS NOT NULL");
            Assert.IsTrue(dulieu.Rows.Count == count_dulieu_tong);
        }

    }
}
