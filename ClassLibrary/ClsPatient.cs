using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class ClsPatient
    {
        private Int32 mPatientId;
        private String mPatientName;
        private Int32 mPatientNumber;
        private DateTime mStartDate;
        private String mPatientAddress;
        private String mPatientHistory;
        private Int32 mAdminId;
       

        public Int32 PatientId
        {
            get
            {
                return mPatientId;
            }
            set
            {
                mPatientId = value;
            }
        }

        public string PatientName {
            get
            {
                return mPatientName;
            }
            set 
            {
                mPatientName= value;
            }
        
        }

        public DateTime PatientDataBirth 
        {
            get
            {   
                return mStartDate;
            }
            set 
            {
                mStartDate = value;
            } 
        }
        public int PatientNumber 
        {
            get 
            {
                return mPatientNumber;

            }
            set 
            {
                mPatientNumber = value;
            }
        }
        public string PatientAddress
        {
            get
            {
                return mPatientAddress;
            }
            set 
            { 
                mPatientAddress = value;
            }
        }
        public string PatientMedHistory 
        {
            get 
            {
                return mPatientHistory;
            }
            set 
            {
                mPatientHistory = value;
            } 
        }
        public int AdminID {
            get 
            {
                return mAdminId;
            }
            set 
            {
                mAdminId = value;
            }
        }

        

        public bool Find(int patientId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@patientId", patientId);
            DB.Execute("sprac_tblPatient_FilterByPatientId");
            if (DB.Count == 1)
            {
                mPatientId = Convert.ToInt32(DB.DataTable.Rows[0]["PatientID"]);
                mPatientName = Convert.ToString(DB.DataTable.Rows[0]["name"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PatientDate"]);
                mPatientNumber = Convert.ToInt32(DB.DataTable.Rows[0]["number"]);
                mPatientAddress = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mPatientHistory = Convert.ToString(DB.DataTable.Rows[0]["medhistory"]);
                mAdminId = Convert.ToInt32(DB.DataTable.Rows[0]["AdminId"]);
                return true;
            }
            else
            {
                return false;
            }
        }

     

        public string Valid(string patientName, string patientDataBirth, string patientNumber, string patientAddress, string patientMedHistory, string adminID)
        {
            String Error = "";
            DateTime DateTemp;
            int adminId;

            if (patientName.Length == 0)
            {
                Error = Error + "The PatientName may not be blank : ";
            }
            if (patientName.Length > 20)
            {
                Error = Error + "The PatientName must be less than 20 characters : ";
            }
            DateTime DateComp = DateTime.Now.Date;
            try
            {

                DateTemp = Convert.ToDateTime(patientDataBirth);
                if (DateTemp < DateComp)
                {

                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateComp)
                {

                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {

                Error = Error + "The date was not a valid date : ";
            }

            if (patientNumber.Length > 10)
            {

                Error = Error + "The PatientNumber must be less than 10 characters : ";


            }
            if (patientNumber.Length < 10)
            {

                Error = Error + "The PatientNumber must be less than 10 characters : ";


            }

            adminId = Convert.ToInt32(adminID);
            if (adminId == 0)
            {
                Error = Error + "The Admin ID Not correct:";
            }
            if (adminId >= 2)
            {
                Error = Error + "The Admin ID Not correct:";
            }
            return Error;
        }
        public DataTable StatisticsGroupByDate()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Patient_Cound_GroupByDate");
            return DB.DataTable;
        }

        public DataTable StatisticsGroupByHistory()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Patient_Cound_GroupByHistory");
            return DB.DataTable;
        }
    }
}