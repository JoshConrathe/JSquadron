using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.Design;
using System.Data;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstPatient
    {
        string patientName = "OZMEN";
        string patientDataBirth = DateTime.Now.ToShortDateString();
        string patientNumber = "1231233211";
        string patientAddress = "LE1 5SP";
        string patientMedHistory = "EYES";
        string adminID = "1";



        [TestMethod]
        public void InstanceOK()
        {
            ClsPatient Patient = new ClsPatient();
            Assert.IsNotNull(Patient);

        }
        [TestMethod]
        public void PatientIdnoPropertyOK()
        {
            ClsPatient Patient = new ClsPatient();
            Int32 TestData = 1;
            Patient.PatientId = TestData;
            Assert.AreEqual(Patient.PatientId, TestData);
        }
        [TestMethod]
        public void PatientNamePropertOK()
        {
            ClsPatient Patient = new ClsPatient();
            string TestData = "Sehmus Can";
            Patient.PatientName = TestData;
            Assert.AreEqual(Patient.PatientName, TestData);
        }
        [TestMethod]
        public void PatientDateOfBirthPropertOK()
        {
            ClsPatient Patient = new ClsPatient();
            DateTime TestData = DateTime.Now;
            Patient.PatientDataBirth = TestData;
            Assert.AreEqual(Patient.PatientDataBirth, TestData);

        }
        [TestMethod]
        public void PatientNumberPropertOK()
        {
            ClsPatient Patient = new ClsPatient();
            Int32 TestData = 01111111111;
            Patient.PatientNumber = TestData;
            Assert.AreEqual(Patient.PatientNumber, TestData);
        }
        [TestMethod]
        public void PatientAddressPropertOK()
        {
            ClsPatient Patient = new ClsPatient();
            string TestData = "LE1 5SP";
            Patient.PatientAddress = TestData;
            Assert.AreEqual(Patient.PatientAddress, TestData);
        }
        [TestMethod]
        public void PatientMedHistoryPropertOK()
        {
            ClsPatient Patient = new ClsPatient();
            string TestData = "He has a sugar problem.";
            Patient.PatientMedHistory = TestData;
            Assert.AreEqual(Patient.PatientMedHistory, TestData);
        }
        [TestMethod]
        public void AdminIDPropertyOK()
        {
            ClsPatient Patient = new ClsPatient();
            Int32 TestData = 2;
            Patient.AdminID = TestData;
            Assert.AreEqual(Patient.AdminID, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            ClsPatient Patient = new ClsPatient();
            Boolean Found = false;
            Int32 PatientId = 61;
            Found = Patient.Find(PatientId);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void FoundIDPropertyOK()
        {
            ClsPatient Patient = new ClsPatient();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PatientId = 61;
            Found = Patient.Find(PatientId);
            if (Patient.PatientId != 61)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void FoundNamePropertyOK()
        {
            ClsPatient Patient = new ClsPatient();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PatientId = 61;
            Found = Patient.Find(PatientId);
            if (Patient.PatientName != "Can")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void FoundPatientDateBirthPropertyOK()
        {
            ClsPatient Patient = new ClsPatient();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PatientId = 61;
            Found = Patient.Find(PatientId);
            if (Patient.PatientDataBirth != Convert.ToDateTime("19/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FoundPatientNumberPropertOK()
        {
            ClsPatient Patient = new ClsPatient();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PatientId = 61;
            Found = Patient.Find(PatientId);
            if (Patient.PatientNumber != 1231231231)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FoundPatientAddress()
        {
            ClsPatient Patient = new ClsPatient();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PatientId = 61;
            Found = Patient.Find(PatientId);
            if (Patient.PatientAddress != "yyy yyy")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FoundPatientHistory()
        {
            ClsPatient Patient = new ClsPatient();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PatientId = 61;
            Found = Patient.Find(PatientId);
            if (Patient.PatientMedHistory != "EYES")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FoundAdminIDPropertyOK()
        {
            ClsPatient Patient = new ClsPatient();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PatientId = 61;
            Found = Patient.Find(PatientId);
            if (Patient.AdminID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsPatient AnPatient = new ClsPatient();
            String Error = "";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientNameLessOne()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientName = "";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PatientNameNoMin()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientName = "aaaaaa";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PatientNameMinPlusOne()
        {

            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientName = "aaaaaaaaaa";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientNameMaxLessOne()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientName = "aaaaaaaaa";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientNameMax()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientName = "aaaaaaaaa";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        public void PatientNameNoMax()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientName = "aaaaaaaaaaaaaaaaaaaa";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientNameMid()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientName = "aaaaaa";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientNameNoMaxPlusOne()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientNameExtremeMax()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientName = "";
            patientName = patientName.PadRight(500, 'a');
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientDateOfBirthExtremeMin()
        {
            ClsPatient AnPatient = new ClsPatient();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string patientDataBirth = TestDate.ToString();
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientDateOfBirthMinLessOne()
        {

            ClsPatient AnPatient = new ClsPatient();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string patientDataBirth = TestDate.ToString();
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, ""); ;
        }
        [TestMethod]
        public void PatientDateOfBirthMin()
        {
            ClsPatient AnPatient = new ClsPatient();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string patientDataBirth = TestDate.ToString();
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientExtremeMax()
        {
            ClsPatient AnPatient = new ClsPatient();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string patientDataBirth = TestDate.ToString();
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PatientNumberNoMin()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientNumber = "";
            patientNumber = patientNumber.PadRight(10, 'a');
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PatientNumberExteremeMin()
        {

            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientNumber = "";
            patientNumber = patientNumber.PadRight(11, 'a');
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]    
        public void PatientNumberNoMax()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientNumber = "";
            patientNumber = patientNumber.PadRight(10, 'a');
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PatientNumberMid()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientNumber = "";
            patientNumber = patientNumber.PadRight(10, 'a');
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]    
        public void PatientAddressExtremeMin()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientAddress = "LE1 5SP";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
          }
      
        [TestMethod]
        public void PatientAddressNoMin()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientAddress = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Vivamus suscipit tortor eget felis porttitor volutpat. Donec rutrum congue le";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientAddressNoMax()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientAddress = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Vivamus suscipit tortor eget felis porttitor volutpat. Donec rutrum congue le";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
       
        [TestMethod]
        public void PatientMedHistoryExtremeMin()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientMedHistory = "High blood pressure";            
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientMedHistoryNoMin()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientMedHistory = "High blood pressure ,History of diabetes";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientMedHistoryNoMax()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientMedHistory = "History of allergies to penicillin, History of asthma, History of heart disease, History of diabetes";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientMedHistoryExtremeMax()
        {
            ClsPatient AnPatient = new ClsPatient();
            string Error = "";
            string patientMedHistory = "Appendectomy in 2005, Broken arm in childhood, Allergic to shellfish, History of depression, Diabetes since 2010";
            Error = AnPatient.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            
        }
        [TestMethod]
        public void AdminIdExtremeMin()
        {
        
            ClsPatient ANAdmin = new ClsPatient();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string adminID = TestAdminID.ToString();
            Error = ANAdmin.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdExtremeMinlessOne()
        {

            ClsPatient ANAdmin = new ClsPatient();
            String Error = "";
            int TestAdminID;
            TestAdminID = 0;
            string adminID = TestAdminID.ToString();
            Error = ANAdmin.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMin()
        {

            ClsPatient ANAdmin = new ClsPatient();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string adminID = TestAdminID.ToString();
            Error = ANAdmin.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMinPlusOne()
        {

            ClsPatient ANAdmin = new ClsPatient();
            String Error = "";
            int TestAdminID;
            TestAdminID = 2;
            string adminID = TestAdminID.ToString();
            Error = ANAdmin.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMax()
        {

            ClsPatient ANAdmin = new ClsPatient();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string adminID = TestAdminID.ToString();
            Error = ANAdmin.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMaxLessOne()
        {

            ClsPatient ANAdmin = new ClsPatient();
            String Error = "";
            int TestAdminID;
            TestAdminID = 0;
            string adminID = TestAdminID.ToString();
            Error = ANAdmin.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMaxPlussOne()
        {

            ClsPatient ANAdmin = new ClsPatient();
            String Error = "";
            int TestAdminID;
            TestAdminID = 2;
            string adminID = TestAdminID.ToString();
            Error = ANAdmin.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AdminIdMid()
        {

            ClsPatient ANAdmin = new ClsPatient();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string adminID = TestAdminID.ToString();
            Error = ANAdmin.Valid(patientName, patientDataBirth, patientNumber, patientAddress, patientMedHistory, adminID);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StatStatisticsGroupByDate()
        {
            ClsPatient AnPatient = new ClsPatient();
            DataTable dt = AnPatient.StatisticsGroupByDate();
            int noOfRecord=4;
            Assert.AreEqual(noOfRecord, dt.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupByHistory()
        {
            ClsPatient AnPatient = new ClsPatient();
            DataTable dt = AnPatient.StatisticsGroupByHistory();
            int noOfRecord = 2;
            Assert.AreEqual(noOfRecord, dt.Rows.Count);
        }









    }

}
