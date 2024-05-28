using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstPatientCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPatientCollection AllPatient = new clsPatientCollection();
            Assert.IsNotNull(AllPatient);
        }
        [TestMethod]
        public void PatientlistOK()
        {
            clsPatientCollection AllPatient = new clsPatientCollection();  
            List<ClsPatient> TestList = new List<ClsPatient>();     
            ClsPatient TestItem = new ClsPatient();
            TestItem.PatientId = 24;
            TestItem.PatientName = "Can";
            TestItem.PatientDate = DateTime.Now;
            TestItem.PatientNumber = 1111111111;
            TestItem.PatientAddress = "LE1 5SP";
            TestItem.PatientMedHistory = "Diabetes";
            TestItem.AdminID = 1;
            TestList.Add(TestItem);
            AllPatient.PatientList=TestList;
            Assert.AreEqual(AllPatient.PatientList, TestList);
        }
      
    
        [TestMethod]
        public void ThisPatientPropertyOK()
        {
            clsPatientCollection AllPatient = new clsPatientCollection();
            ClsPatient TestPatient = new ClsPatient();
            TestPatient.PatientId = 24;
            TestPatient.PatientName = "Can";
            TestPatient.PatientDate = DateTime.Now;
            TestPatient.PatientNumber = 1111111111;
            TestPatient.PatientAddress = "LE1 5SP";
            TestPatient.PatientMedHistory = "Diabetes";
            TestPatient.AdminID = 1;
            AllPatient.ThisPatient= TestPatient;
            Assert.AreEqual(AllPatient.ThisPatient, TestPatient);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsPatientCollection AllPatient = new clsPatientCollection();
            List<ClsPatient> TestList = new List<ClsPatient>();
            ClsPatient TestItem = new ClsPatient();
            TestItem.PatientId = 24;
            TestItem.PatientName = "Can";
            TestItem.PatientDate = DateTime.Now;
            TestItem.PatientNumber = 1111111111;
            TestItem.PatientAddress = "LE1 5SP";
            TestItem.PatientMedHistory = "Diabetes";
            TestItem.AdminID = 1;
            TestList.Add(TestItem);
            AllPatient.PatientList = TestList;
            Assert.AreEqual(AllPatient.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOk() { 
        clsPatientCollection AllPatient = new clsPatientCollection();
            ClsPatient TestItem = new ClsPatient();
            Int32 PrimaryKey = 0;
            TestItem.PatientId = 48;
            TestItem.PatientName = "Can";
            TestItem.PatientDate = DateTime.Now;
            TestItem.PatientNumber = 1231231231;
            TestItem.PatientAddress = "LE1 5SP";
            TestItem.PatientMedHistory = "EYES";
            TestItem.AdminID = 1;
            AllPatient.ThisPatient = TestItem;
            PrimaryKey = AllPatient.Add();
            AllPatient.ThisPatient.Find(PrimaryKey);
            Assert.AreEqual(AllPatient.ThisPatient, TestItem);

        }
        [TestMethod ]
        public void UpdateMethodOK()
        {
            clsPatientCollection AllPatient = new clsPatientCollection();
            ClsPatient TestItem = new ClsPatient();
            Int32 PrimaryKey = 0;
            TestItem.PatientId = 48;
            TestItem.PatientName = "Can";
            TestItem.PatientDate = DateTime.Now;
            TestItem.PatientNumber = 1111111111;
            TestItem.PatientAddress = "LE1 5SP";
            TestItem.PatientMedHistory = "EYES";
            TestItem.AdminID = 1;
            AllPatient.ThisPatient = TestItem;
            PrimaryKey = AllPatient.Add();
            TestItem.PatientId = PrimaryKey;
            TestItem.PatientName = "Can";
            TestItem.PatientDate = DateTime.Now;
            TestItem.PatientNumber = 1111111111;
            TestItem.PatientAddress = "LE1 5SP";
            TestItem.PatientMedHistory = "EYES";
            TestItem.AdminID = 1;
            AllPatient.ThisPatient = TestItem;
            AllPatient.Update();
            AllPatient.ThisPatient.Find(PrimaryKey);
            Assert.AreEqual(AllPatient.ThisPatient, TestItem);



        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsPatientCollection AllPatient = new clsPatientCollection();
            ClsPatient TestItem = new ClsPatient();
            Int32 PrimaryKey = 0;
            TestItem.PatientId = 48;
            TestItem.PatientName = "Can";
            TestItem.PatientDate = DateTime.Now;
            TestItem.PatientNumber = 1231231231;
            TestItem.PatientAddress = "LE1 5SP";
            TestItem.PatientMedHistory = "EYE";
            TestItem.AdminID = 1;
            AllPatient.ThisPatient = TestItem;
            PrimaryKey = AllPatient.Add();
            TestItem.PatientId = PrimaryKey;
            AllPatient.ThisPatient.Find(PrimaryKey);
            AllPatient.Delete();
            Boolean Found = AllPatient.ThisPatient.Find(PrimaryKey);
            Assert.IsFalse( Found);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            clsPatientCollection ALLpatient = new clsPatientCollection();
            clsPatientCollection FilterePatient = new clsPatientCollection();
            FilterePatient.ReportByAddress("");
            Assert.AreEqual(ALLpatient.Count, FilterePatient.Count);
        }
        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            clsPatientCollection FilterePatient = new clsPatientCollection();
            FilterePatient.ReportByAddress("xxx xxx");
            Assert.AreEqual(0, FilterePatient.Count);
        }
        [TestMethod]
        public void ReportByPostCodeTestDataFound() 
        {
            clsPatientCollection FilterePatient= new clsPatientCollection();
            Boolean OK = true;
            FilterePatient.ReportByAddress("yyy yyy");
            if (FilterePatient.Count == 2)
            {
                if (FilterePatient.PatientList[0].PatientId !=61)
                {
                    OK = false;
                }
                if (FilterePatient.PatientList[1].PatientId !=63)
                {
                    OK=false;
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
