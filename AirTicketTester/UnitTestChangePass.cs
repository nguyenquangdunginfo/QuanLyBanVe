using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using AirTicketBookingManagement;

namespace AirTicketTester
{
    [TestClass]
    public class UnitTestChangePass
    {
        [TestMethod]
        public void Test_ChangePass_Success()
        {
            Connection conn = new Connection();
            string mess = "kiem tra lai thong tin dang nhap";
           // frm_ = new frm_Login();
            DataTable dulieu = conn.ExecuteData("update * from Account where Username = 'admin' and Password='123'");
            Assert.IsTrue(dulieu.Rows.Count > 0, mess);
        }
    }
}
