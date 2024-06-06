using System;
using System.Data;

namespace ClassLibrary
{
    public class clsApplication
    {
        private int mApplictaionId;
        private int mAdminId;
        private int mStaffId;
        private string mApplicantName;
        private string mContactNumber;
        private string mEmailAddress;
        private string mPositionApplied;
        private string mResume;
        // Fields
        public int ApplicationId { get { return mApplictaionId; } set { mApplictaionId = value; } }
        public int AdminId { get { return mAdminId; } set { mAdminId = value; } }
        public int StaffId { get { return mStaffId; } set { mStaffId = value; } }
        public string ApplicantName { get { return mApplicantName; } set { mApplicantName = value; } }
        public string ContactNumber { get { return mContactNumber; } set { mContactNumber = value; } }
        public string EmailAddress { get { return mEmailAddress; } set { mEmailAddress = value; } }
        public string PositionApplied { get { return mPositionApplied; } set { mPositionApplied = value; } }
        public string Resume { get { return mResume; } set { mResume = value; } }

        // Constructor

        public clsApplication()
        {
        }
        public clsApplication(string applicantName, string emailAddress, string positionApplied, string contactNumber, string resume = null)
        {
            ApplicantName = applicantName;
            EmailAddress = emailAddress;
            ContactNumber = contactNumber;
            PositionApplied = positionApplied;
            Resume = resume;
        }

        public bool Find(int StaffId)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("jobApplication_FilterByStaffId");

            if (DB.Count == 1)
            {
                mApplictaionId = (int)DB.DataTable.Rows[0]["ApplicationId"];
                mStaffId = StaffId;
                mAdminId = 1;
                mApplicantName = Convert.ToString(DB.DataTable.Rows[0]["ApplicantName"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mPositionApplied = Convert.ToString(DB.DataTable.Rows[0]["PositionApplied"]);

                if (DB.DataTable.Rows[0]["Resume"] != DBNull.Value)
                {
                    mResume = Convert.ToString(DB.DataTable.Rows[0]["Resume"]);
                }
                else
                {
                    mResume = null;
                }

                return true;
            }

            else
            {
                return false;
            }

        }

        public string Valid(int StaffId, string name, string contactNo, string email, string position, string resume)
        {
            String Error = "";

            if (name.Length == 0)
            {
                Error = Error + "Name may not be empty : ";
            }

            if (name.Length > 30)
            {
                Error = Error + "Name cannot be longer than 30 characters : ";
            }

            if (contactNo.Length == 0) 
            {
                Error = Error + "Contact number can not be blank : ";
            }

            if (contactNo.Length > 14)
            {
                Error = Error + "Contact Number cannot be longer than 14 characters : ";
            }

            if (email.Length == 0) 
            {
                Error = Error + "Email address cannot be blank : ";
            }

            if (email.Length > 30)
            {
                Error = Error + "Email cannot be longer than 30 characters : ";
            }

            if (position.Length == 0) 
            {
                Error = Error + "Position cannot be blank : ";
            }

            if ( position.Length > 15)
            {
                Error = Error + "Position cannot be longer than 15 characters : ";
            }

            if (!string.IsNullOrEmpty(resume))
            {
                if (resume.Length <= 0) 
                {
                    Error = Error + "Invalid resume length : ";
                }

                if (resume.Length > 100)
                {
                    Error = Error + "Resume length cannot exceed 100 : ";
                }
            }

            return Error;
        }

        public DataTable StatisticsGroupedByPosition()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("dbo.jobApplication_count_GroupByPosition");
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedByStaffId()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("dbo.jobApplication_count_GroupStaffId");
            return DB.DataTable;
        }
    }
}
