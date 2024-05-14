using System;

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

        public bool Find(string position)
        {
            mPositionApplied = "doctor";
            mEmailAddress = "example@gmail.com";
            mApplicantName = "John Smith";
            mResume = "resume example";
            mContactNumber = "+44854261723";

            return true;
        }
    }
}
