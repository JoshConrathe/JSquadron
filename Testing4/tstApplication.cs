using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Mail;

namespace Testing4
{
    [TestClass]
    public class tstApplication
    {
        string name = "John Smith";
        string contactNo = "+4476536212";
        string email = "example@test.com";
        string position = "doctor";
        string resume = "localhost/public/saved/resume.pdf";

        [TestMethod]
        public void instanceConstructorOk()
        {
            clsApplication jobApplication = new clsApplication();
            Assert.IsNotNull(jobApplication);
        }

        [TestMethod]
        public void instanceConstructorWithPropertiesOk()
        {
            String applicantName = "TestName";
            String emailAddress = "testEmail";
            String contactNumber = "test0762318";
            String poistionApplied = "testPosition";

            clsApplication jobApplication = new clsApplication(applicantName, emailAddress, contactNumber, poistionApplied);

            Assert.IsNotNull(jobApplication);
        }
        [TestMethod]
        public void appIdPropertyMethodOk()
        {
            clsApplication jobApp = new clsApplication();
            int TestId = 643;

            jobApp.ApplicationId = TestId;
            Assert.AreEqual(jobApp.ApplicationId, TestId);
        }

        [TestMethod]
        public void adminIdPropertyMethodOk()
        {
            clsApplication jobApp = new clsApplication();
            int TestId = 661;

            jobApp.AdminId = TestId;
            Assert.AreEqual(jobApp.AdminId, TestId);
        }

        [TestMethod]
        public void staffIdPropertyMethodOk()
        {
            clsApplication jobApp = new clsApplication();
            int TestId = 3123;

            jobApp.StaffId = TestId;
            Assert.AreEqual(jobApp.StaffId, TestId);
        }


        [TestMethod]
        public void namePropertyMethodOk()
        {
            clsApplication jobApp = new clsApplication();
            String TestName = "Przemek";

            jobApp.ApplicantName = TestName;
            Assert.AreEqual(jobApp.ApplicantName, TestName);
        }

        [TestMethod]
        public void emailPropertyMethodOk()
        {
            clsApplication jobApp = new clsApplication();
            String TestEmail = "Przemek@gmail.com";

            jobApp.EmailAddress = TestEmail;
            Assert.AreEqual(jobApp.EmailAddress, TestEmail);
        }

        [TestMethod]
        public void contactPropertyMethodOk()
        {
            clsApplication jobApp = new clsApplication();
            String TestContact = "076534192";

            jobApp.ContactNumber = TestContact;
            Assert.AreEqual(jobApp.ContactNumber, TestContact);
        }

        [TestMethod]
        public void positionPropertyMethodOk()
        {
            clsApplication jobApp = new clsApplication();
            String TestPosition = "Doctor";

            jobApp.PositionApplied = TestPosition;
            Assert.AreEqual(jobApp.PositionApplied, TestPosition);
        }

        [TestMethod]
        public void TestApplicantNameFound()
        {
            clsApplication jobApp = new clsApplication();
            Boolean Found = false;
            Boolean OK = true;
            int staffId = 2;
            Found = jobApp.Find(staffId);
            string Name = "NameTest";
            

            if (jobApp.ApplicantName != Name)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPositionFound()
        {
            clsApplication jobApp = new clsApplication();
            Boolean Found = false;
            Boolean OK = true;
            
            int staffId = 2;
            Found = jobApp.Find(staffId);

            if (jobApp.PositionApplied != "PositionTest")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            clsApplication jobApp = new clsApplication();
            Boolean Found = false;
            Boolean OK = true;
            string Email = "example@test.com";
            int staffId = 2;
            Found = jobApp.Find(staffId);

            if (jobApp.EmailAddress != Email)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactNumberFound()
        {
            clsApplication jobApp = new clsApplication();
            Boolean Found = false;
            Boolean OK = true;
            string Contact = "NumberTest";
            int staffId = 2;
            Found = jobApp.Find(staffId);

            if (jobApp.ContactNumber != "ContactTest")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestResumeFound()
        {
            clsApplication jobApp = new clsApplication();
            Boolean Found = false;
            Boolean OK = true;
            string Resume = null;
            int staffId = 2;
            Found = jobApp.Find(staffId);

            if (jobApp.Resume != null)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            Error = jobApp.Valid(contactNo, email, position, resume);

            Assert.AreEqual(Error, "");
        }

    }
}
