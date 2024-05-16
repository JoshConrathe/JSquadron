using System;
using System.Collections.Generic;



namespace ClassLibrary

{

    public class clsPatientCollection
    {
        List<ClsPatient> mPatientList = new List<ClsPatient>(); 
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
        public ClsPatient ThisPatient { get; set; }
    public clsPatientCollection() { 
            

           Int32 Index = 0;
           Int32 RecordCount = 0;
           clsDataConnection DB = new clsDataConnection();
          DB.Execute("sproc_Patient_selectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                ClsPatient ANPatient = new ClsPatient();
                ANPatient.PatientId = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientID"]);
                ANPatient.PatientName = Convert.ToString(DB.DataTable.Rows[Index]["name"]);
                ANPatient.PatientDataBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                ANPatient.PatientNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["number"]);
                ANPatient.PatientAddress = Convert.ToString(DB.DataTable.Rows[Index]["address"]);
                ANPatient.PatientMedHistory = Convert.ToString(DB.DataTable.Rows[Index]["medhistory"]);
                ANPatient.AdminID = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminId"]);
                mPatientList.Add(ANPatient);
                Index++;

            }

            
        }
    }
}