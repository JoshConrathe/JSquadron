using System;
using System.Data;

namespace ClassLibrary
{
    public class clsPayments
    {
        private Int32 mFinanceId;
        private Int32 mAdminId;
        private Int32 mPatientId;
        private Int32 mAmount;
        private DateTime mDate;
        private String mPaymentMethod;

        public int FinanceId
        {
            get { return mFinanceId; }
            set { mFinanceId = value; }
        }

        public int AdminId
        {
            get { return mAdminId; }
            set { mAdminId = value; }
        }

        public int PatientId
        {
            get { return mPatientId; }
            set { mPatientId = value; }
        }

        public int Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }

        public DateTime Date
        { 
            get { return mDate; } 
            set {  mDate = value; } 
        }

        public String PaymentMethod
        {
            get { return mPaymentMethod; }
            set { mPaymentMethod = value; }
        }

        public bool Find(int FinanceID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FinanceID", FinanceID);
            DB.Execute("finance_selectAll");
            if (DB.Count == 1)
            {
                mFinanceId = Convert.ToInt32(DB.DataTable.Rows[0]["FinanceId"]);
                mAdminId = Convert.ToInt32(DB.DataTable.Rows[0]["AdminId"]);
                mPatientId = Convert.ToInt32(DB.DataTable.Rows[0]["PatientId"]);
                mAmount = Convert.ToInt32(DB.DataTable.Rows[0]["Amount"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["Date"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable StatisticsGroupBycard()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Finance_Cound_GroupByCard");
            return DB.DataTable;
        }

        public DataTable StatisticsGroupByMoney()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Finance_Cound_GroupByAmount");
            return DB.DataTable;
        }
      

        public string Valid(string adminId, string patientId, string amount, string date, string paymentMethod)
        {
            string Error = "";
            int adminID = Convert.ToInt32(adminId);
            int patientID = Convert.ToInt32(patientId);
            int amountTemp = Convert.ToInt32(amount);
            DateTime DateTemp = Convert.ToDateTime(date);
            DateTime DateComp = DateTime.Now.Date;

            if (adminID <= 0)
            {
                Error += "Admin ID must be a positive integer. ";
            }

            else if (adminID >= 2) 
            {
                Error += "Admin ID must be less than 2. ";
            }

            else if (adminId.Length == 0) 
            {
                Error += "Admin ID must not be empty. ";
            }

            if (patientID <= 0)
            {
                Error += "Patient ID must be a positive integer. ";
            }

            else if (patientID >= 500) 
            {
                Error += "Patient ID must be less than 500. ";
            }

            else if (patientId.Length == 0)
            {
                Error += "Patient ID must not be empty. ";
            }

            if (amountTemp <= 0)
            {
                Error += "Amount must be a positive integer. ";
            }

            else if (amountTemp > 100000) 
            {
                Error += "Amount must be less than or equal to 100000. ";
            }

            else if (amount.Length == 0)
            {
                Error += "amount must not be empty. ";
            }

            if (DateTemp > DateComp)
            {
                Error += "Date cannot be in the future. ";
            }

            else if (DateTemp < DateComp)
            {
                Error += "Date cannot be in the past. ";
            }

            else if (date.Length == 0)
            {
                Error += "Date cannot be empty. ";
            }

            string[] validMethods = { "Visa", "Visa Electron", "Maestro" , "Mastercard"};
            if (string.IsNullOrWhiteSpace(paymentMethod))
            {
                Error += "Payment method cannot be blank. ";
            }

            else if (!Array.Exists(validMethods, method => method.Equals(paymentMethod, StringComparison.OrdinalIgnoreCase)))
            {
                Error += $"Payment method must be one of the following: {string.Join(", ", validMethods)}. ";
            }

            return Error;
        }


    }
}
