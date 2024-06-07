using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Testing1
{
    [TestClass]
    public class tstAppointmentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAppointmentCollection appointments = new clsAppointmentCollection();
            Assert.IsNotNull(appointments);
        }

        [TestMethod]
        public void AppointmentListOK()
        {
            clsAppointmentCollection appointments = new clsAppointmentCollection();
            List<clsAppointment> testList = new List<clsAppointment>();
            clsAppointment testAppointment = new clsAppointment();
            testAppointment.AppointmentId = 12;
            testAppointment.StaffId = 1;
            testAppointment.PatientId = 63;
            testAppointment.AdminId = 1;
            testAppointment.AppointmentDate = Convert.ToDateTime("21/08/2024");
            testAppointment.AppointmentTime = Convert.ToDateTime("12:03");
            testList.Add(testAppointment);
            appointments.AppointmentList = testList;
            Assert.AreEqual(appointments.AppointmentList, testList);
        }

        [TestMethod]
        public void ThisAppointmentPropertyOK()
        {
            clsAppointmentCollection appointments = new clsAppointmentCollection();
            clsAppointment testAppointment = new clsAppointment();
            testAppointment.AppointmentId = 12;
            testAppointment.StaffId = 1;
            testAppointment.PatientId = 63;
            testAppointment.AdminId = 1;
            testAppointment.AppointmentDate = Convert.ToDateTime("21/08/2024");
            testAppointment.AppointmentTime = Convert.ToDateTime("12:03");
            appointments.ThisAppointment = testAppointment;
            Assert.AreEqual(appointments.ThisAppointment, testAppointment);
        }

        [TestMethod]
        public void CountOK()
        {
            clsAppointmentCollection appointments = new clsAppointmentCollection();
            List<clsAppointment> testList = new List<clsAppointment>();
            clsAppointment testAppointment = new clsAppointment();
            testAppointment.AppointmentId = 12;
            testAppointment.StaffId = 1;
            testAppointment.PatientId = 63;
            testAppointment.AdminId = 1;
            testAppointment.AppointmentDate = Convert.ToDateTime("21/08/2024");
            testAppointment.AppointmentTime = Convert.ToDateTime("12:03");
            testList.Add(testAppointment);
            appointments.AppointmentList = testList;
            Assert.AreEqual(appointments.Count, testList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsAppointmentCollection appointments = new clsAppointmentCollection();
            clsAppointment testAppointment = new clsAppointment();
            Int32 primaryKey = 0;
            testAppointment.AppointmentId = 12;
            testAppointment.StaffId = 1;
            testAppointment.PatientId = 63;
            testAppointment.AdminId = 1;
            testAppointment.AppointmentDate = Convert.ToDateTime("21/08/2024");
            testAppointment.AppointmentTime = Convert.ToDateTime("12:03");
            appointments.ThisAppointment = testAppointment;
            primaryKey = appointments.Add();
            testAppointment.AppointmentId = primaryKey;
            appointments.ThisAppointment.Find(primaryKey);
            Assert.AreEqual(appointments.ThisAppointment, testAppointment);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsAppointmentCollection appointments = new clsAppointmentCollection();
            clsAppointment testAppointment = new clsAppointment();
            Int32 primaryKey = 0;
            testAppointment.AppointmentId = 12;
            testAppointment.StaffId = 1;
            testAppointment.PatientId = 63;
            testAppointment.AdminId = 1;
            testAppointment.AppointmentDate = Convert.ToDateTime("21/08/2024");
            testAppointment.AppointmentTime = Convert.ToDateTime("12:03");
            appointments.ThisAppointment = testAppointment;
            primaryKey = appointments.Add();
            testAppointment.AppointmentId = primaryKey;
            testAppointment.StaffId = 1;
            testAppointment.PatientId = 63;
            testAppointment.AdminId = 1;
            testAppointment.AppointmentDate = Convert.ToDateTime("21/08/2024");
            testAppointment.AppointmentTime = Convert.ToDateTime("12:03");
            appointments.ThisAppointment = testAppointment;
            appointments.Update();
            appointments.ThisAppointment.Find(primaryKey);
            Assert.AreEqual(appointments.ThisAppointment, testAppointment);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsAppointmentCollection appointments = new clsAppointmentCollection();
            clsAppointment testAppointment = new clsAppointment();
            testAppointment.AppointmentId = 12;
            testAppointment.StaffId = 1;
            testAppointment.PatientId = 63;
            testAppointment.AdminId = 1;
            testAppointment.AppointmentDate = Convert.ToDateTime("21/08/2024");
            testAppointment.AppointmentTime = Convert.ToDateTime("12:03");
            appointments.ThisAppointment = testAppointment;
            int primaryKey = appointments.Add();
            appointments.Find(primaryKey);
            appointments.Delete();
            Assert.IsFalse(appointments.Find(primaryKey));
        }

    }
}