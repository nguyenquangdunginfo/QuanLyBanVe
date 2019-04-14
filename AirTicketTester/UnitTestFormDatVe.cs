using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using AirTicketBookingManagement;
namespace AirTicketTester
{
    [TestClass]
    public class UnitTestFormDatVe
    {
        [TestMethod]
        public void TestSearchCMNDKH()
        {
            Connection conn = new Connection();
            DataTable dulieu = conn.ExecuteData("select * from ChiTietDatVe where CMND ='241154073' ");
            Assert.IsTrue(dulieu.Rows.Count > 0);
        }
    }
}
