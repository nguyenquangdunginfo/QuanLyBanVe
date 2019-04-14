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
        public void TestMethodLogin001()
        {
            Connection conn = new Connection();
            DataTable dulieu = conn.ExecuteData("select * from Account where Username ='admin' and Password='123'");
            Assert.IsTrue(dulieu.Rows.Count > 0);
        }
        
    }
}
