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

        [TestMethod]
        public void Test_CMND_ISNUMERIC_SUM()
        {
            Connection conn = new Connection();
            string mess = "Kiem tra Tong So CMND hop le la so nguyen";
            DataTable dulieu_tong = conn.ExecuteData("select * from ChiTietDatVe");
            int count_dulieu_tong = dulieu_tong.Rows.Count;
            DataTable dulieu = conn.ExecuteData("select * from ChiTietDatVe where ISNUMERIC(CMND) > 0 ");
            Assert.IsTrue(dulieu.Rows.Count == count_dulieu_tong, mess);
        }

        [TestMethod]
        public void Test_CMND_KhongQua12()
        {
            
        }
    }
}
