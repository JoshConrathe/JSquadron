using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.IO;
using System.Net.Mail;

namespace Testing4
{
    [TestClass]
    public class tstApplication
    {
        int staffID = 2;
        string name = "NameTest";
        string contactNo = "ContactTest";
        string email = "example@test.com";
        string position = "PositionTest";
        string resume = null;

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

        /*************************************************************
         * 
         * 
         *                      Find Method tests
         * 
         * 
         * 
         *************************************************************/

        [TestMethod]
        /*public void TestApplicantNameFound()
        {
            clsApplication jobApp = new clsApplication();
            Boolean Found = false;
            Boolean OK = true;
            int staffId = 2;
            Found = jobApp.Find(staffId);
            string Name = "Test";


            if (jobApp.ApplicantName != Name)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }*/
        public void TestApplicantNameFound()
        {
            // Arrange
            clsApplication jobApp = new clsApplication();
            int staffId = 2;
            bool Found = jobApp.Find(staffId);

            // Act
            string Name = jobApp.ApplicantName;

            // Assert
            Assert.IsTrue(Found);
            Assert.AreEqual(name, Name);
        }

        [TestMethod]
        public void TestPositionFound()
        {
            clsApplication jobApp = new clsApplication();
            Boolean Found = false;
            Boolean OK = true;

            int staffId = 2;
            Found = jobApp.Find(staffId);

            if (jobApp.PositionApplied != "Test")
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
            string Email = "Test";
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
            string Contact = "Test";
            int staffId = 2;
            Found = jobApp.Find(staffId);

            if (jobApp.ContactNumber != "Test")
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

        /*************************************************************
         * 
         * 
         *                      Validation Tests
         * 
         * 
         * 
         *************************************************************/



        /*
         * Full name validation tests 
         */

        [TestMethod]
        public void NameMinLessOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String nameTest = "";
            Error = jobApp.Valid(staffID, nameTest, contactNo, email, position, resume);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String nameTest = "A";
            Error = jobApp.Valid(staffID, nameTest, contactNo, email, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String nameTest = "Aa";
            Error = jobApp.Valid(staffID, nameTest, contactNo, email, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            //29 characters
            String nameTest = "";
            nameTest = nameTest.PadRight(29, 'a');
            Error = jobApp.Valid(staffID, nameTest, contactNo, email, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            // 30 characters
            String nameTest = "";
            nameTest = nameTest.PadRight(30, 'a');
            Error = jobApp.Valid(staffID, nameTest, contactNo, email, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String nameTest = "";
            nameTest = nameTest.PadRight(31, 'a');
            Error = jobApp.Valid(staffID, nameTest, contactNo, email, position, resume);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String nameTest = "";
            nameTest = nameTest.PadRight(15, 'a');
            Error = jobApp.Valid(staffID, nameTest, contactNo, email, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String nameTest = "";
            nameTest = nameTest.PadRight(100, 'a');
            Error = jobApp.Valid(staffID, nameTest, contactNo, email, position, resume);
            Assert.AreNotEqual(Error, "");
        }

        /*
         * Contact Number validation tests
         */

        [TestMethod]
        public void ContactNoMinLessOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String contactTest = "";
            Error = jobApp.Valid(staffID, name, contactTest, email, position, resume);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNoMin()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String contactTest = "+";
            Error = jobApp.Valid(staffID, name, contactTest, email, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNoMinPlusOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String contactTest = "+4";
            Error = jobApp.Valid(staffID, name, contactTest, email, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNoMaxLessOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            //13 characters
            String contactTest = "+447546293123";
            Error = jobApp.Valid(staffID, name, contactTest, email, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNoMax()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            //14 characters
            String contactTest = "+4475421648754";
            Error = jobApp.Valid(staffID, name, contactTest, email, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNoMaxPlusOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            //15 characters
            String contactTest = "+44789765129876";
            Error = jobApp.Valid(staffID, name, contactTest, email, position, resume);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNoMid()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String contactTest = "+447652";
            Error = jobApp.Valid(staffID, name, contactTest, email, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNoExtremeMax()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String contactTest = "";
            contactTest = contactTest.PadRight(150, '4');
            Error = jobApp.Valid(staffID, name, contactTest, email, position, resume);
            Assert.AreNotEqual(Error, "");
        }

        /*
         *  Emaill Address Validation Tests
         */

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string emailTest = "";

            Error = jobApp.Valid(staffID, name, contactNo, emailTest, position, resume);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string emailTest = "e";

            Error = jobApp.Valid(staffID, name, contactNo, emailTest, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string emailTest = "ex";

            Error = jobApp.Valid(staffID, name, contactNo, emailTest, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string emailTest = "";
            emailTest = emailTest.PadRight(29, 'x');

            Error = jobApp.Valid(staffID, name, contactNo, emailTest, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string emailTest = "";
            emailTest = emailTest.PadRight(30, 'x');
            Error = jobApp.Valid(staffID, name, contactNo, emailTest, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string emailTest = "";
            emailTest = emailTest.PadRight(31, 'x');
            Error = jobApp.Valid(staffID, name, contactNo, emailTest, position, resume);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string emailTest = "";
            emailTest = emailTest.PadRight(15, 'x');
            Error = jobApp.Valid(staffID, name, contactNo, emailTest, position, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string emailTest = "";
            emailTest = emailTest.PadRight(300, 'x');
            Error = jobApp.Valid(staffID, name, contactNo, emailTest, position, resume);
            Assert.AreNotEqual(Error, "");
        }

        /*
         * PositionApplied Validation tests
         */

        [TestMethod]
        public void PositionMinLessOne() 
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string positionTest = "";

            Error = jobApp.Valid(staffID, name, contactNo, email, positionTest, resume);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMin()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string positionTest = "N";

            Error = jobApp.Valid(staffID, name, contactNo, email, positionTest, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMinPlusOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string positionTest = "Nu";

            Error = jobApp.Valid(staffID, name, contactNo, email, positionTest, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxLessOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            //14 characters
            string positionTest = "SpecialOPNurse";

            Error = jobApp.Valid(staffID, name, contactNo, email, positionTest, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMax()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            //15 characters
            string positionTest = "";
            positionTest = positionTest.PadRight(15, 'n');

            Error = jobApp.Valid(staffID, name, contactNo, email, positionTest, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxPlusOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string positionTest = "";
            positionTest = positionTest.PadRight(16, 'n');

            Error = jobApp.Valid(staffID, name, contactNo, email, positionTest, resume);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMid()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string positionTest = "";
            positionTest = positionTest.PadRight(7, 'n');

            Error = jobApp.Valid(staffID, name, contactNo, email, positionTest, resume);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionExtremeMax()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            string positionTest = "";
            positionTest = positionTest.PadRight(60, 'n');

            Error = jobApp.Valid(staffID, name, contactNo, email, positionTest, resume);
            Assert.AreNotEqual(Error, "");
        }

        /*
         * Resume Validation tests if not null
         */

        [TestMethod]

        public void ResumeMaxLessOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String ResumeTest = "";
            ResumeTest = ResumeTest.PadRight(99, 'h');

            Error = jobApp.Valid(staffID, name, contactNo, email, position, ResumeTest);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ResumeMax()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String ResumeTest = "";
            ResumeTest = ResumeTest.PadRight(100, 'h');

            Error = jobApp.Valid(staffID, name, contactNo, email, position, ResumeTest);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ResumeMaxPlusOne()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String ResumeTest = "";
            ResumeTest = ResumeTest.PadRight(101, 'h');

            Error = jobApp.Valid(staffID, name, contactNo, email, position, ResumeTest);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ResumeMid()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String ResumeTest = "";
            ResumeTest = ResumeTest.PadRight(50, 'h');

            Error = jobApp.Valid(staffID, name, contactNo, email, position, ResumeTest);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ResumeExtremeMax()
        {
            clsApplication jobApp = new clsApplication();
            String Error = "";
            String ResumeTest = "";
            ResumeTest = ResumeTest.PadRight(400, 'h');

            Error = jobApp.Valid(staffID, name, contactNo, email, position, ResumeTest);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StatStatisticsGroupedByPosition()
        {
            clsApplication jobApp = new clsApplication();
            DataTable dT = jobApp.StatisticsGroupedByPosition();
            int noOfRecord = 7;

            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatStatisticsGroupedByStaffId()
        {
            clsApplication jobApp = new clsApplication();
            DataTable dT = jobApp.StatisticsGroupedByStaffId();
            int noOfRecord = 2;

            Assert.AreEqual(noOfRecord , dT.Rows.Count);
            
        }
    }
}
