using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsApplicationCollection
    {
        List<clsApplication> mApplicationList = new List<clsApplication>();
        public List<clsApplication> ApplicationList 
        {
            get
            {
                return mApplicationList;
            }
            set
            {
                mApplicationList = value;
            }
        }
        public int Count
        { 
            get
            {
                return mApplicationList.Count;
            }
                
            set
            {
                
            }
        }
        public clsApplication ThisApplication { get; set; }

        /*public clsApplicationCollection()
        {
            clsApplication TestItem = new clsApplication();

            TestItem.StaffId = 1;
            TestItem.ApplicantName = "Test";
            TestItem.EmailAddress = "Test";
            TestItem.ContactNumber = "Test";
            TestItem.PositionApplied = "Test";

            mApplicationList.Add(TestItem);
            TestItem = new clsApplication(); 

            TestItem.StaffId = 1;
            TestItem.ApplicantName= "Test";
            TestItem.ContactNumber= "Test";
            TestItem.EmailAddress= "Test";
            TestItem.PositionApplied= "Test";
            mApplicationList.Add(TestItem);
        }*/

        public clsApplicationCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("dbp.jobApplication_selectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsApplication AnApplication = new clsApplication();
                AnApplication.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnApplication.ApplicantName = Convert.ToString(DB.DataTable.Rows[Index]["ApplicantName"]);
                AnApplication.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                AnApplication.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AnApplication.PositionApplied = Convert.ToString(DB.DataTable.Rows[Index]["PositionApplied"]);

                mApplicationList.Add(AnApplication);
                Index++;
            }
        }

    }
}