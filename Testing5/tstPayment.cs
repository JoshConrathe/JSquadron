using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace tstPayment
{
    [TestClass]
    public class tstPayments
    {
        string AdminId = "1";
        string PatientId = "1";
        string Amount = "100";
        string Date = "06/06/2024";
        string PaymentMethod = "Visa";

        [TestMethod]
        public void InstanceOK()
        {
            clsPayments payment = new clsPayments();
            Assert.IsNotNull(payment);
        }

        [TestMethod]
        public void FinanceIdPropertyOK()
        {
            clsPayments payment = new clsPayments();
            int testData = 1;
            payment.AdminId = testData;
            Assert.AreEqual(payment.AdminId, testData);
        }

        [TestMethod]
        public void PatientIdPropertyOK()
        {
            clsPayments payment = new clsPayments();
            int testData = 1;
            payment.PatientId = testData;
            Assert.AreEqual(payment.PatientId, testData);
        }

        [TestMethod]
        public void AmountPropertyOK()
        {
            clsPayments payment = new clsPayments();
            int testData = 100;
            payment.Amount = testData;
            Assert.AreEqual(payment.Amount, testData);
        }

        [TestMethod]
        public void DatePropertyOK()
        {
            clsPayments payment = new clsPayments();
            DateTime testData = DateTime.Now;
            payment.Date = testData;
            Assert.AreEqual(payment.Date, testData);
        }

        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            clsPayments payment = new clsPayments();
            string testData = "Mastercard";
            payment.PaymentMethod = testData;
            Assert.AreEqual(payment.PaymentMethod, testData);
        }

        //*************** FIND METHOD ***************//

        [TestMethod]
        public void FindMethodOK()
        {
            clsPayments payment = new clsPayments();
            bool found = false;
            Int32 FinanceId = 1;
            found = payment.Find(FinanceId);
            Assert.IsTrue(found);
        }

        //************* FOUND METHOD ****************//

        [TestMethod]
        public void TestFinanceIdFound()
        {
            clsPayments payment = new clsPayments();
            bool found = false;
            bool OK = true;
            Int32 FinanceId = 1;
            found = payment.Find(FinanceId);
            if (payment.FinanceId != FinanceId)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAdminIdFound()
        {
            clsPayments payment = new clsPayments();
            bool found = false;
            bool OK = true;
            Int32 FinanceId = 1;
            found = payment.Find(FinanceId);
            if (payment.AdminId != Convert.ToInt32(AdminId))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPatientIdFound()
        {
            clsPayments payment = new clsPayments();
            bool found = false;
            bool OK = true;
            Int32 FinanceId = 1;
            found = payment.Find(FinanceId);
            if (payment.PatientId != Convert.ToInt32(PatientId))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAmountFound()
        {
            clsPayments payment = new clsPayments();
            bool found = false;
            bool OK = true;
            Int32 FinanceId = 1;
            found = payment.Find(FinanceId);
            if (payment.Amount != Convert.ToInt32(Amount))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateFound()
        {
            clsPayments payment = new clsPayments();
            bool found = false;
            bool OK = true;
            Int32 FinanceId = 1;
            found = payment.Find(FinanceId);
            if (payment.Date != Convert.ToDateTime(Date))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentMethodFound()
        {
            clsPayments payment = new clsPayments();
            bool found = false;
            bool OK = true;
            Int32 FinanceId = 1;
            found = payment.Find(FinanceId);
            if (payment.PaymentMethod != PaymentMethod)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //***************** VALID METHOD ******************//

        [TestMethod]
        public void ValidMethodOK()
        {
            clsPayments payment = new clsPayments();
            string error = "";
            error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AdminIdExtremeMin()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string AdminId = TestAdminID.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AdminIdExtremeMinlessOne()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAdminID;
            TestAdminID = 0;
            string AdminId = TestAdminID.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AdminIdMin()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string AdminId = TestAdminID.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AdminIdMinPlusOne()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAdminID;
            TestAdminID = 2;
            string AdminId = TestAdminID.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AdminIdMax()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string AdminId = TestAdminID.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AdminIdMaxLessOne()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAdminID;
            TestAdminID = 2;
            string AdminId = TestAdminID.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AdminIdMaxPlussOne()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAdminID;
            TestAdminID = 2;
            string AdminId = TestAdminID.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AdminIdMid()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAdminID;
            TestAdminID = 1;
            string AdminId = TestAdminID.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PatientIdExtremeMin()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            int TestPatientId;
            TestPatientId = 1;
            string PatientId = TestPatientId.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PatientIdExtremeMinlessOne()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestPatientId;
            TestPatientId = 0;
            string PatientId = TestPatientId.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PatientIdMin()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestPatientId;
            TestPatientId = 1;
            string PatientId = TestPatientId.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PatientIdMinPlusOne()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestPatientId;
            TestPatientId = 0;
            string PatientId = TestPatientId.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PatientIdMax()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestPatientId;
            TestPatientId = 499;
            string PatientId = TestPatientId.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PatientIdMaxLessOne()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestPatientId;
            TestPatientId = 500;
            string PatientId = TestPatientId.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PatientIdMaxPlussOne()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestPatientId;
            TestPatientId = 500;
            string PatientId = TestPatientId.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PatientIdMid()
        {

            clsPayments payment = new clsPayments();
            String Error = "";
            int TestPatientId;
            TestPatientId = 250;
            string PatientId = TestPatientId.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AmountExtremeMin()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAmount;
            TestAmount = 1;
            string Amount = TestAmount.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountExtremeMinlessOne()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAmount;
            TestAmount = 0;
            string Amount = TestAmount.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AmountMin()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAmount;
            TestAmount = 1;
            string Amount = TestAmount.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMinPlusOne()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAmount;
            TestAmount = 2;
            string Amount = TestAmount.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMax()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAmount;
            TestAmount =99999;
            string Amount = TestAmount.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMaxLessOne()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAmount;
            TestAmount = 99998;
            string Amount = TestAmount.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMaxPlusOne()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAmount;
            TestAmount = 100000;
            TestAmount++;
            string Amount = TestAmount.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AmountMid()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            int TestAmount;
            TestAmount = 50000;
            string Amount = TestAmount.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateExtremeMin()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string Date = TestDate.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateMinLessOne()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string Date = TestDate.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateMin()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string Date = TestDate.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateExtremeMax()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string Date = TestDate.ToString();
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodBlank()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            string PaymentMethod = "";
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.IsTrue(Error.Contains("Payment method cannot be blank."));
        }

        [TestMethod]
        public void PaymentMethodValid()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            string PaymentMethod = "Visa";
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.IsFalse(Error.Contains("Payment method must be one of the following"));
        }

        [TestMethod]
        public void PaymentMethodInvalid()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            string PaymentMethod = "InvalidMethod";
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.IsTrue(Error.Contains("Payment method must be one of the following"));
        }

        [TestMethod]
        public void PaymentMethodCaseInsensitive()
        {
            clsPayments payment = new clsPayments();
            String Error = "";
            string PaymentMethod = "visa";
            Error = payment.Valid(AdminId, PatientId, Amount, Date, PaymentMethod);
            Assert.IsFalse(Error.Contains("Payment method must be one of the following"));
        }
        [TestMethod]
        public void StatStatisticsGroupByPosition()
        {
            clsStaff anstaff = new clsStaff();
            DataTable dt = anstaff.StatisticsGroupByPosition();
            int noOfRecord = 10;
            Assert.AreEqual(noOfRecord, dt.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupBySalary()
        {
            clsStaff anstaff = new clsStaff();
            DataTable dt = anstaff.StatisticsGroupBySalary();
            int noOfRecord = 10;
            Assert.AreEqual(noOfRecord, dt.Rows.Count);
        }



    }
}