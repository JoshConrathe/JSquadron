using System;
using System.Collections.Generic;



namespace ClassLibrary

{

    public class clsPatientCollection
    {
        List<ClsPatient> mPatientList = new List<ClsPatient>(); 
        ClsPatient mThisPatient =new ClsPatient();
        public List<ClsPatient> PatientList
        {
            get
            {
                return mPatientList;
            }
            set
            {
                mPatientList = value;   
            }
        }
        public int Count 
        { 
            get
            {
                return mPatientList.Count;
            }
            set
            {

            }
        }
        public ClsPatient ThisPatient
        {
            get
            {
                    return mThisPatient;
            }
            set 
            {
                mThisPatient = value;
            }
        }

        public clsPatientCollection() { 
            

         
           clsDataConnection DB = new clsDataConnection();
           DB.Execute("sproc_Patient_selectAll");
           PopulateArray(DB);
         
            

            
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount ;
            RecordCount = DB.Count;
            mPatientList= new List<ClsPatient> ();
            while (Index < RecordCount)
            {
                ClsPatient ANPatient = new ClsPatient();
                ANPatient.PatientId = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientID"]);
                ANPatient.PatientName = Convert.ToString(DB.DataTable.Rows[Index]["name"]);
                ANPatient.PatientDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PatientDate"]);
                ANPatient.PatientNumber = Convert.ToInt64(DB.DataTable.Rows[Index]["number"]);
                ANPatient.PatientAddress = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ANPatient.PatientMedHistory = Convert.ToString(DB.DataTable.Rows[Index]["medhistory"]);
                ANPatient.AdminID = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminId"]);
                mPatientList.Add(ANPatient);
                Index++;

            }
        }

        public int Add()
        {
           clsDataConnection DB =new clsDataConnection();
            DB.AddParameter("@PatientName", mThisPatient.PatientName);
            DB.AddParameter("@PatientDate", mThisPatient.PatientDate);
            DB.AddParameter("@ContactNumber", mThisPatient.PatientNumber);
            DB.AddParameter("@PostCode", mThisPatient.PatientAddress);
            DB.AddParameter("@MedicalHistory", mThisPatient.PatientMedHistory);
            DB.AddParameter("@AdminId", mThisPatient.AdminID);
            return DB.Execute("sproc_Patient_Insert");


        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PatientId", mThisPatient.PatientId);
            DB.AddParameter("@PatientName", mThisPatient.PatientName);
            DB.AddParameter("@PatientDate", mThisPatient.PatientDate);
            DB.AddParameter("@ContactNumber", mThisPatient.PatientNumber);
            DB.AddParameter("@PostCode", mThisPatient.PatientAddress);
            DB.AddParameter("@MedicalHistory", mThisPatient.PatientMedHistory);
            DB.AddParameter("@AdminId", mThisPatient.AdminID);
            DB.Execute("sproc_Patient_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PatientId", mThisPatient.PatientId);
            DB.Execute("sproc_Patient_Delete");
        }

        public void ReportByAddress(string PostCode)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PostCode", PostCode);
            DB.Execute("sproc_Patient_FilterByAddress");
            PopulateArray(DB);
        }
    }
}