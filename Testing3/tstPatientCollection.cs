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
            TestItem.PatientDataBirth = DateTime.Now;
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
            TestPatient.PatientDataBirth = DateTime.Now;
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
            TestItem.PatientDataBirth = DateTime.Now;
            TestItem.PatientNumber = 1111111111;
            TestItem.PatientAddress = "LE1 5SP";
            TestItem.PatientMedHistory = "Diabetes";
            TestItem.AdminID = 1;
            TestList.Add(TestItem);
            AllPatient.PatientList = TestList;
            Assert.AreEqual(AllPatient.Count, TestList.Count);
        }
      
  

    }
}
