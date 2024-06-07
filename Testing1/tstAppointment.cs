
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;


namespace Testing1
{
    [TestClass]
    public class tstAppointment
    { 
            string StaffId = "2";
            string PatientId = "25";
            string AdminId = "1";
            string Date = "15/06/2024";
            string Time = "18:30";

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


        /******************VALIDATION TESTS******************/

        [TestMethod]
        public void ValidMethodOK()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        /******************ADMINID TESTS******************/

        [TestMethod]
        public void AdminIdExtremeMin()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int AdminID;
            AdminID = 1;
            string AdminId = AdminID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminIdExtremeMinlessOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int AdminID;
            AdminID = 0;
            string AdminId = AdminID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminIdMin()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int AdminID;
            AdminID = 1;
            string AdminId = AdminID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminIdMinPlusOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int AdminID;
            AdminID = 2;
            string AdminId = AdminID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminIdMax()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int AdminID;
            AdminID = 1;
            string AdminId = AdminID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminIdMaxLessOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int AdminID;
            AdminID = 0;
            string AdminId = AdminID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminIdMaxPlusOne()
        {

            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int AdminID;
            AdminID = 2;
            string AdminId = AdminID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AdminIdMid()
        {

            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int AdminID;
            AdminID = 1;
            string AdminId = AdminID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AdminExtremeIdMax()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int AdminID;
            AdminID = 1;
            string AdminId = AdminID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }



        /******************STAFFID TESTS******************/

        [TestMethod]
        public void StaffIdExtremeMin()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int StaffID;
            StaffID = 1;
            StaffId = StaffID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdExtremeMinlessOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int StaffID;
            StaffID = 0;
            StaffId = StaffID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMin()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int StaffID;
            StaffID = 1;
            StaffId = StaffID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinPlusOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int StaffID;
            StaffID = 2;
            StaffId = StaffID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMax()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int StaffID;
            StaffID = 99;
            StaffId = StaffID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMaxLessOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int StaffID;
            StaffID = 98;
            StaffId = StaffID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMaxPlusOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int StaffID;
            StaffID = 100;
            StaffId = StaffID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMid()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int StaffID;
            StaffID = 50;
            StaffId = StaffID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        /******************PATIENTID TESTS******************/

        [TestMethod]
        public void PatientIdExtremeMin()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int PatientID;
            PatientID = 1;
            PatientId = PatientID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIdExtremeMinlessOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int PatientID;
            PatientID = 0;
            PatientId = PatientID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientIdMin()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int PatientID;
            PatientID = 1;
            PatientId = PatientID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIdMinPlusOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int PatientID;
            PatientID = 2;
            PatientId = PatientID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIdMax()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int PatientID;
            PatientID = 99;
            PatientId = PatientID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIdMaxLessOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int PatientID;
            PatientID = 98;
            PatientId = PatientID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIdMaxPlusOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int PatientID;
            PatientID = 100;
            PatientId = PatientID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientIdMid()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            int PatientID;
            PatientID = 50;
            PatientId = PatientID.ToString();

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        /******************DATE TESTS******************/

        [TestMethod]
        public void DateExtremeMin()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);

            string Date = TestDate.ToString();
            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMinLessOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);

            string Date = TestDate.ToString();
            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, ""); ;
        }

        [TestMethod]
        public void DateMin()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;

            string Date = TestDate.ToString();
            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateExtremeMax()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);

            string Date = TestDate.ToString();
            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMax()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddMonths(3);

            string Date = TestDate.ToString();
            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMid()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddMonths(1);

            string Date = TestDate.ToString();
            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        /******************TIME TESTS******************/

        [TestMethod]
        public void TimeExtremeMin()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            string Time = "00:00";

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TimeMinLessOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            string Time = "-01:00";

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TimeMin()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            string Time = "00:01";

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TimeExtremeMax()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            string Time = "24:00";

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TimeMaxPlusOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            string Time = "24:01";

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TimeLessOne()
        {
            clsAppointment appointment = new clsAppointment();
            String Error = "";
            string Time = "";

            Error = appointment.Valid(StaffId, PatientId, AdminId, Date, Time);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StatStatisticsGroupByDate()
        {
            clsAppointment AnPatient = new clsAppointment();
            DataTable dt = AnPatient.StatisticsGroupByDateApp();
            int noOfRecord = 3;
            Assert.AreEqual(noOfRecord, dt.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupByTime()
        {
            clsAppointment AnPatient = new clsAppointment();
            DataTable dt = AnPatient.StatisticsGroupByTimeapp();
            int noOfRecord = 2;
            Assert.AreEqual(noOfRecord, dt.Rows.Count);
        }
    }
}
