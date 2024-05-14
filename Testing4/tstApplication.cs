using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Mail;

namespace Testing4
{
    [TestClass]
    public class tstApplication
    {
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
            string Name = "John Smith";

            Found = jobApp.Find(Name);

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
            string Position = "DoCtOr";

            Found = jobApp.Find(Position);

            if (jobApp.PositionApplied != Position.ToLower())
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
            string Email = "example@gmail.com";

            Found = jobApp.Find(Email);

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
            string Contact = "+44854261723";

            Found = jobApp.Find(Contact);

            if (jobApp.ContactNumber != Contact)
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
            string Resume = "resume example";

            Found = jobApp.Find(Resume);

            if (jobApp.Resume != Resume)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
