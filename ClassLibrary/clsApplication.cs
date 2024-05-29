﻿using System;

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
                mStaffId = StaffId;
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
    }
}