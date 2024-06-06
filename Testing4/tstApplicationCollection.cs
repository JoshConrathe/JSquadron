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
        public void ThisApplicatioListOK()
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
        public void ThisApplicationPropertyOK()
        {
            clsApplicationCollection allApps = new clsApplicationCollection();  
            clsApplication TestApplication = new clsApplication();

            TestApplication.StaffId = 1;
            TestApplication.AdminId = 1;
            TestApplication.ApplicantName = "Test";
            TestApplication.ContactNumber = "Test";
            TestApplication.EmailAddress = "Test";
            TestApplication.PositionApplied = "Test";
            allApps.ThisApplication = TestApplication;
            Assert.AreEqual(allApps.ThisApplication, TestApplication);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsApplicationCollection AllApp = new clsApplicationCollection();

            List<clsApplication> TestList = new List<clsApplication>();
            clsApplication TestItem = new clsApplication();

            TestItem.StaffId = 1;
            TestItem.AdminId = 1;
            TestItem.ApplicantName = "Test";
            TestItem.ContactNumber = "Test";
            TestItem.EmailAddress = "Test";
            TestItem.PositionApplied = "Test";
            
            TestList.Add(TestItem);
            AllApp.ApplicationList = TestList;
            Assert.AreEqual(AllApp.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsApplicationCollection apps = new clsApplicationCollection();
            clsApplication TestItem = new clsApplication();
            Int32 PrimaryKey = 0;

            TestItem.StaffId = 1;
            TestItem.AdminId = 1;
            TestItem.ApplicantName = "TestAdd";
            TestItem.ContactNumber = "TestAdd";
            TestItem.EmailAddress = "TestAdd";
            TestItem.PositionApplied = "TestAdd";
            TestItem.Resume = null;

            apps.ThisApplication = TestItem;

            PrimaryKey = apps.Add();
            TestItem.StaffId = PrimaryKey;
            apps.ThisApplication.Find(PrimaryKey);
            
            Assert.AreEqual(apps.ThisApplication, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsApplicationCollection apps = new clsApplicationCollection(); apps.ThisApplication = null;
            clsApplication TestItem = new clsApplication();
            Int32 PrimaryKey = 0;

            TestItem.StaffId = 1;
            TestItem.AdminId = 1;
            TestItem.ApplicantName = "TestUpdate";
            TestItem.ContactNumber = "TestUpdate";
            TestItem.EmailAddress = "TestUpdate";
            TestItem.PositionApplied = "TestUpdate";
            
            apps.ThisApplication = TestItem;

            PrimaryKey = apps.Add();

            TestItem.ApplicationId = PrimaryKey;
            TestItem.StaffId = 2;
            TestItem.ApplicantName = "TestUpdate2";
            TestItem.ContactNumber = "TestUpdate2";
            TestItem.EmailAddress = "TestUpdate2";
            TestItem.PositionApplied = "TestUpdate2";
            
            apps.ThisApplication = TestItem;

            apps.Update();
            apps.ThisApplication.Find(PrimaryKey);

            Assert.AreEqual(apps.ThisApplication, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsApplicationCollection apps = new clsApplicationCollection();
            clsApplication TestItem = new clsApplication();
            Int32 PrimaryKey = 0;

            TestItem.StaffId = 2;
            TestItem.AdminId = 1;
            TestItem.ApplicantName = "TestDelete";
            TestItem.ContactNumber = "TestDelete";
            TestItem.EmailAddress = "TestDelete";
            TestItem.PositionApplied = "TestDelete";
            apps.ThisApplication = TestItem;

            PrimaryKey = apps.Add();

            TestItem.ApplicationId = PrimaryKey;

            apps.ThisApplication.Find(PrimaryKey);
            apps.Delete();

            Boolean Found = apps.ThisApplication.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPositionMethodOK()
        {
            clsApplicationCollection applications = new clsApplicationCollection();
            clsApplicationCollection filteredApps = new clsApplicationCollection();

            filteredApps.ReportByPosition("");

            Assert.AreEqual(applications.Count, filteredApps.Count);
        }

        [TestMethod]
        public void ReportByPositionNoneFound()
        {
            clsApplicationCollection FilteredApps = new clsApplicationCollection();
            FilteredApps.ReportByPosition("astronaut");

            Assert.AreEqual(0, FilteredApps.Count);
        }

        [TestMethod]
        public void ReportByPositionTestDataFound()
        {
            clsApplicationCollection FilteredApps = new clsApplicationCollection();

            Boolean OK = true;

            FilteredApps.ReportByPosition("TestAdd2");

            if (FilteredApps.Count == 2)
            {
                if (FilteredApps.ApplicationList[0].ApplicationId != 46)
                {
                    OK = false;
                }

                if (FilteredApps.ApplicationList[1].ApplicationId != 47)
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
