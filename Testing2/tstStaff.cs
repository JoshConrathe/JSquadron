using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        string StaffName = "CAN";
        string StaffPosition = "DOCTOR";
        string StaffContactNumber = "1231231231";
        string StaffSalary = "1.0000";
        string AdminId = "1";
        

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }
        [TestMethod]
        public void StaffIDProperty()
        {
            clsStaff AnStaff = new clsStaff();
            Int32 TestData = 3;
            AnStaff.StaffId=TestData;
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }
        [TestMethod]
        public void StaffNameProperty()
        {
            clsStaff AnStaff= new clsStaff();
            string TestData = "Ozmen";
            AnStaff.StaffName=TestData;
            Assert.AreEqual(AnStaff.StaffName, TestData);
        }
        [TestMethod]
        public void StaffPositionProperty()
        {
            clsStaff AnStaff = new clsStaff();
            string TestData = "Doctor";
            AnStaff.StaffPosition = TestData;
            Assert.AreEqual(AnStaff.StaffPosition, TestData);
        }
        [TestMethod]
        public void StaffContactNumberProperty()
        {
            clsStaff AnStaff = new clsStaff();
            Int32 TestData = 1231231231;
            AnStaff.StaffContactNumber = TestData;
            Assert.AreEqual(AnStaff.StaffContactNumber, TestData);
        }
        [TestMethod]
        public void StaffSalaryProperty()
        {
            clsStaff AnStaff = new clsStaff();
            Int32 TestData = 100000;
            AnStaff.StaffSalary = TestData;
            Assert.AreEqual(AnStaff.StaffSalary , TestData);
        }
        [TestMethod]
        public void AdminIDPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            Int32 TestData = 1;
            AnStaff.AdminID = TestData;
            Assert.AreEqual(AnStaff.AdminID, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AnStaff = new clsStaff();  
            Boolean Found = false;
            Int32 StaffId = 1;  
            Found= AnStaff.Find(StaffId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId =3;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.StaffId != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffNameFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId =3;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.StaffName != "Ozmen")
            {
                OK=false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffPositionFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId =3;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.StaffPosition != "ss")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffContactNumberFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 3;
            Found= AnStaff.Find(StaffId);
            if (AnStaff.StaffContactNumber != 1231231231)
            {
                OK=false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffSalaryFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId =3;
            Found= AnStaff.Find(StaffId);
            if (AnStaff.StaffSalary != 10.0000)
            {
                OK=false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAdminIdFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 3;
            Found= AnStaff.Find(StaffId);
            if (AnStaff.AdminID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);  

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            Error = AnStaff.Valid(StaffName,StaffPosition,StaffContactNumber,StaffSalary,AdminId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffName = "";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameNoMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffName = "aaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameMinPlusOne()
        {

            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffName = "aaaaaaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffName = "aaaaaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffName = "aaaaaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");
        }
        public void StaffNameNoMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffName = "aaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffName = "aaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameNoMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPositionLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPosition = "";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffPositionNoMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPosition = "aaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffPositionMinPlusOne()
        {

            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPosition = "aaaaaaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPositionMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPosition = "aaaaaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPositionMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPosition = "aaaaaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");
        }
        public void StaffPositionNoMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPosition = "aaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPositionMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPosition = "aaaaaa";
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPositionNoMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPosition = "";
            StaffPosition = StaffPosition.PadRight(51,'a');
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPositionExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffPosition = "";
            StaffPosition = StaffPosition.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNumberNoMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffContactNumber = "";
            StaffContactNumber = StaffContactNumber.PadRight(10, 'a');
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNumberExteremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffContactNumber = "";
            StaffContactNumber = StaffContactNumber.PadRight(11, 'a');
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNumberNoMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffContactNumber = "";
            StaffContactNumber = StaffContactNumber .PadRight(10, 'a');
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNumberMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StaffContactNumber = "";
            StaffContactNumber = StaffContactNumber.PadRight(10, 'a');
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdExtremeMin()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string AdminId = TestAdminID.ToString();
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdExtremeMinlessOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int TestAdminID;
            TestAdminID = 0;
            string AdminId = TestAdminID.ToString();
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMin()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string AdminId = TestAdminID.ToString();
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMinPlusOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int TestAdminID;
            TestAdminID = 2;
            string AdminId = TestAdminID.ToString();
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMax()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string AdminId = TestAdminID.ToString();
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMaxLessOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int TestAdminID;
            TestAdminID = 2;
            string AdminId = TestAdminID.ToString();
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMaxPlussOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int TestAdminID;
            TestAdminID = 2;
            string AdminId = TestAdminID.ToString();
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMid()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string AdminId = TestAdminID.ToString();
            Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
            Assert.AreEqual(Error, "");

        }

    }
}
