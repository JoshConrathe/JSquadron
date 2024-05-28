
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing1
{
    [TestClass]
    public class tstAppointment
    {
        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            clsAppointment appointment = new clsAppointment();
            Assert.IsNotNull(appointment);    
        }

        [TestMethod]

        /******************PROPERTY OK TESTS******************/

        public void StatusPropertyOK()
        {
            clsAppointment appointment = new clsAppointment();
            Boolean testData = true;
            appointment.Status = testData;
            Assert.AreEqual(appointment.Status, testData);
        }

        [TestMethod]
        public void AppointmentDatePropertyOK()
        {
            clsAppointment appointment = new clsAppointment();
            DateTime TestData = DateTime.Now.Date;
            appointment.AppointmentDate = TestData;
            Assert.AreEqual(appointment.AppointmentDate, TestData);
        }

        [TestMethod]
        public void AppointmentTimePropertyOK()
        {
            clsAppointment appointment = new clsAppointment();
            DateTime TestData = DateTime.Now;
            appointment.AppointmentTime = TestData;
            Assert.AreEqual(appointment.AppointmentTime, TestData);
        }

        [TestMethod]
        public void AppointmentIdPropertyOK()
        {
            clsAppointment appointment = new clsAppointment();
            Int32 TestData = 11;
            appointment.AppointmentId = TestData;
            Assert.AreEqual(appointment.AppointmentId, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsAppointment appointment = new clsAppointment();
            Int32 TestData = 3;
            appointment.StaffId = TestData;
            Assert.AreEqual(appointment.StaffId, TestData);
        }

        [TestMethod]
        public void AdminIdPropertyOK()
        {
            clsAppointment appointment = new clsAppointment();
            Int32 TestData = 1;
            appointment.AdminId = TestData;
            Assert.AreEqual(appointment.AdminId, TestData);
        }

        [TestMethod]
        public void PatientIdPropertyOK()
        {
            clsAppointment appointment = new clsAppointment();
            Int32 TestData = 61;
            appointment.PatientId = TestData;
            Assert.AreEqual(appointment.PatientId, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            clsAppointment appointment = new clsAppointment();
            Boolean Found = false;
            Int32 AppointmentId = 11;
            Found = appointment.Find(AppointmentId);
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/

        [TestMethod]
        public void TestAppointmentIdFound()
        {
            clsAppointment appointment = new clsAppointment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AppointmentId = 11;
            Found = appointment.Find(AppointmentId);

            if (appointment.AppointmentId != 11)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAdminIdFound()
        {
            clsAppointment appointment = new clsAppointment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AppointmentId = 11;
            Found = appointment.Find(AppointmentId);

            if (appointment.AdminId != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPatientIdFound()
        {
            clsAppointment appointment = new clsAppointment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AppointmentId = 11;
            Found = appointment.Find(AppointmentId);

            if (appointment.PatientId != 61)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsAppointment appointment = new clsAppointment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AppointmentId = 11;
            Found = appointment.Find(AppointmentId);

            if (appointment.StaffId != 3)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAppointmentDateFound()
        {
            clsAppointment appointment = new clsAppointment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AppointmentId = 11;
            Found = appointment.Find(AppointmentId);

            if (appointment.AppointmentDate != Convert.ToDateTime("25/05/2024"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAppointmentTimeFound()
        {
            clsAppointment appointment = new clsAppointment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AppointmentId = 11;
            Found = appointment.Find(AppointmentId);

            TimeSpan expectedTime = new TimeSpan(15, 30, 0); 
            TimeSpan actualTime = appointment.AppointmentTime.TimeOfDay;

            if (actualTime != expectedTime)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            clsAppointment appointment = new clsAppointment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AppointmentId = 11;
            Found = appointment.Find(AppointmentId);

            if (appointment.Status != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        /******************VALIDATION TESTS******************/

       




    }
}
