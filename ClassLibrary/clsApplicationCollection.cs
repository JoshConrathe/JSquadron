using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsApplicationCollection
    {
        List<clsApplication> mApplicationList = new List<clsApplication>();
        clsApplication mThisApplication = new clsApplication();
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
        public clsApplication ThisApplication { 
            get
            {
                return mThisApplication;
            }
            set
            {
                mThisApplication = value;
            }
        }

        public clsApplication ThisAddress {
            get
            {
                return mThisApplication;
            }
            set
            {
                mThisApplication = value;
            }
        } 


        public clsApplicationCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("dbo.jobApplication_selectAll");

            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffId", mThisApplication.StaffId);
            DB.AddParameter("@AdminId", 1);
            DB.AddParameter("@ApplicantName", mThisApplication.ApplicantName);
            DB.AddParameter("@ContactNumber", mThisApplication.ContactNumber);
            DB.AddParameter("@EmailAddress", mThisApplication.EmailAddress);
            DB.AddParameter("@PositionApplied", mThisApplication.PositionApplied);
            
            if (string.IsNullOrEmpty(mThisApplication.Resume))
            {
                DB.AddParameter("@Resume", DBNull.Value);

            }
            else
            {
                DB.AddParameter("@Resume", mThisApplication.Resume);
            }

            return DB.Execute("dbo.jobApplication_create");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ApplicationId", mThisApplication.ApplicationId);
            DB.AddParameter("@AdminId", mThisApplication.AdminId);
            DB.AddParameter("@StaffId", mThisApplication.StaffId);
            DB.AddParameter("@ApplicantName", mThisApplication.ApplicantName);
            DB.AddParameter("@ContactNumber", mThisApplication.ContactNumber);
            DB.AddParameter("@EmailAddress", mThisApplication.EmailAddress);
            DB.AddParameter("@PositionApplied", mThisApplication.PositionApplied);
            if (mThisApplication.Resume == null)
            {
                DB.AddParameter("@Resume", DBNull.Value);
            }
            else
            {
                DB.AddParameter("@Resume", mThisApplication.Resume);
            }

            DB.Execute("dbo.jobApplication_update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ApplicationId", mThisApplication.ApplicationId);
            DB.Execute("dbo.jobApplication_delete");
        }

        public void ReportByPosition(string PositionApplied)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PositionApplied", PositionApplied);
            DB.Execute("dbo.jobApplication_filterByPosition");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;

            mApplicationList = new List<clsApplication>();

            while (Index < RecordCount)
            {
                clsApplication application = new clsApplication();

                application.ApplicationId = Convert.ToInt32(DB.DataTable.Rows[Index]["ApplicationId"]);
                application.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                application.AdminId = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminId"]);
                application.ApplicantName = Convert.ToString(DB.DataTable.Rows[Index]["ApplicantName"]);
                application.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                application.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                application.PositionApplied = Convert.ToString(DB.DataTable.Rows[Index]["PositionApplied"]);
                application.ApplicantName = Convert.ToString(DB.DataTable.Rows[Index]["ApplicantName"]);

                mApplicationList.Add(application);
                Index++;
            }
        }
    }
}