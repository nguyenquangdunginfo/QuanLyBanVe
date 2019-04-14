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
            DataTable dulieu = conn.ExecuteData("select * from Account where Username ='" );
           
            Assert.IsTrue(dulieu.Rows.Count > 0);
        }
    }
}
