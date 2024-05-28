
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AnStaff = new clsStaffCollection();
            Assert.IsNotNull(AnStaff);
        }
        [TestMethod]
        public void StafflistOK()
        {
            clsStaffCollection AnStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffId = 24;
            TestItem.StaffName = "Can";
            TestItem.StaffPosition = "Doctor";
            TestItem.StaffContactNumber = 1111111111;
            TestItem.StaffSalary = 10000;
            TestItem.AdminID = 1;
            TestList.Add(TestItem);
            AnStaff.StaffLIST = TestList;
            Assert.AreEqual(AnStaff.StaffLIST, TestList);
        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AnStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.StaffId = 24;
            TestStaff.StaffName = "Can";
            TestStaff.StaffPosition = "Doctor";
            TestStaff.StaffContactNumber = 1111111111;
            TestStaff.StaffSalary = 10000;
            TestStaff.AdminID = 1;
            AnStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AnStaff.ThisStaff , TestStaff);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            
            clsStaffCollection AnStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffId = 24;
            TestItem.StaffName = "Can";
            TestItem.StaffPosition = "Doctor";
            TestItem.StaffContactNumber = 1111111111;
            TestItem.StaffSalary = 10000;
            TestItem.AdminID = 1;
            TestList.Add(TestItem);
            AnStaff.StaffLIST = TestList;
            Assert.AreEqual(AnStaff.Count, TestList.Count);
        }
    }
}
