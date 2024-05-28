using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Testing4
{
    [TestClass]
    public class tstApplicationCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsApplicationCollection AllApplications = new clsApplicationCollection();
            Assert.IsNotNull(AllApplications);


            List<clsApplication> TestList = new List<clsApplication>();

            clsApplication TestItem = new clsApplication();
            TestItem.StaffId = 1;
            TestItem.ApplicantName = "Test";
            TestItem.ContactNumber = "Test";
            TestItem.EmailAddress = "Test";
            TestItem.PositionApplied = "Test";
            TestItem.Resume = null;
            
            TestList.Add(TestItem);
            AllApplications.ApplicationList = TestList;

            Assert.AreEqual(AllApplications.ApplicationList, TestList);
        }

        [TestMethod]
        public void ThisApplicationPropertyOK()
        {
            clsApplicationCollection AllApplications = new clsApplicationCollection();
            clsApplication TestApplication = new clsApplication();

            TestApplication.StaffId = 1;
            TestApplication.ApplicantName = "Test";
            TestApplication.ContactNumber = "Test";
            TestApplication.EmailAddress = "Test";
            TestApplication.PositionApplied = "Test";

            AllApplications.ThisApplication = TestApplication;
            Assert.AreEqual(AllApplications.ThisApplication, TestApplication);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsApplicationCollection AllApp = new clsApplicationCollection();

            List<clsApplication> TestList = new List<clsApplication>();
            clsApplication TestItem = new clsApplication();

            TestItem.StaffId = 1;
            TestItem.ApplicantName = "Test";
            TestItem.ContactNumber = "Test";
            TestItem.EmailAddress = "Test";
            TestItem.PositionApplied = "Test";
            
            TestList.Add(TestItem);
            AllApp.ApplicationList = TestList;
            Assert.AreEqual(AllApp.Count, TestList.Count);
        }

    }
}
