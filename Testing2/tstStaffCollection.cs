
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffId = 24;
            TestItem.StaffName = "Can";
            TestItem.StaffPosition = "Doctor";
            TestItem.StaffContactNumber = 1111111111;
            TestItem.StaffSalary = 10000;
            TestItem.AdminID = 1;
           allStaff.ThisStaff = TestItem;
            PrimaryKey = allStaff.Add();
            TestItem.StaffId = PrimaryKey;
            allStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(allStaff.ThisStaff, TestItem);


        }
        [TestMethod]
        public void UpdateMethod()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffId = 24;
            TestItem.StaffName = "Can";
            TestItem.StaffPosition = "Doctor";
            TestItem.StaffContactNumber = 1111111111;
            TestItem.StaffSalary = 10000;
            TestItem.AdminID = 1;
            allStaff.ThisStaff = TestItem;
            PrimaryKey = allStaff.Add();
            TestItem.StaffId = PrimaryKey;
            TestItem.StaffId = 24;
            TestItem.StaffName = "Can";
            TestItem.StaffPosition = "Doctor";
            TestItem.StaffContactNumber = 1111111111;
            TestItem.StaffSalary = 10000;
            TestItem.AdminID = 1;
            allStaff.ThisStaff = TestItem;
            allStaff.Update();
            allStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual (allStaff.ThisStaff, TestItem);



        }
        [TestMethod]
        public void DeleteMethod()
        {
            clsStaffCollection allstaf = new clsStaffCollection ();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffId = 24;
            TestItem.StaffName = "Can";
            TestItem.StaffPosition = "Doctor";
            TestItem.StaffContactNumber = 1111111111;
            TestItem.StaffSalary = 10000;
            TestItem.AdminID = 1;
            allstaf.ThisStaff = TestItem;
            PrimaryKey = allstaf.Add();
            TestItem.StaffId = PrimaryKey;
            allstaf.ThisStaff.Find(PrimaryKey);
            allstaf.Delete();
            Boolean Found = allstaf.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByPositionMethodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            clsStaffCollection FiltereStaff = new clsStaffCollection();
            FiltereStaff.ReportByPosition("");
            Assert.AreEqual(allStaff.Count, FiltereStaff.Count);
        }
        [TestMethod]
        public void ReportByPositionNoneFound()
        {
            clsStaffCollection FiltereStaff = new clsStaffCollection();
            FiltereStaff.ReportByPosition("YYYYYY");
            Assert.AreEqual(0, FiltereStaff.Count);
        }
        [TestMethod]
        public void ReportByPositionTestDataFound()
        {
            clsStaffCollection FiltereStaff = new clsStaffCollection();
            Boolean OK = true;
            FiltereStaff.ReportByPosition("yyyy");
            if (FiltereStaff.Count == 2)
            {
                if (FiltereStaff.StaffLIST[0].StaffId != 4)
                {
                    OK = false;
                }
                if (FiltereStaff.StaffLIST[1].StaffId != 5)
                {
                    OK = false;
                }
               

            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
