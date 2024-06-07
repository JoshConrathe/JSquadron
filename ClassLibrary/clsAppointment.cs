using System;
using System.CodeDom.Compiler;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class clsAppointment
    {
        private Int32 mAppointmentId;
        public int AppointmentId
        {
            get
            {
                return mAppointmentId;
            }

            set
            {
                mAppointmentId = value;
            }
        }

        private Int32 mAdminId;
        public int AdminId
        {
            get
            {
                return mAdminId;
            }

            set
            {
                mAdminId = value;
            }
        }

        private Int32 mPatientId;
        public int PatientId
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

        private Int32 mStaffId;
        public int StaffId
        {
            get
            {
                return mStaffId;
            }

            set
            {
                mStaffId = value;
            }
        }

        private bool mStatus;
        public bool Status
        {
            get
            {
                return mStatus;
            }

            set
            {
                mStatus = value;
            }
        }

        private DateTime mAppointmentDate;
        public DateTime AppointmentDate
        {
            get
            {
                return mAppointmentDate;
            }

            set
            {
                mAppointmentDate = value;
            }
        }

        private DateTime mAppointmentTime;
        public DateTime AppointmentTime
        {
            get
            {
                return mAppointmentTime;
            }

            set
            {
                mAppointmentTime = value;
            }
        }

        public string FormattedDateTime
        {
            get
            {
                return $"{mAppointmentDate.ToString("dd/MM/yyyy")} {mAppointmentTime.ToString("HH:mm")}";
            }
        }

        /****** FIND METHOD ******/

        public bool Find(int AppointmentId)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@AppointmentId", AppointmentId);

            DB.Execute("sproc_tblAppointment_FilterByAppointmentId");

            if (DB.Count == 1)
            {

                mAppointmentId = Convert.ToInt32(DB.DataTable.Rows[0]["AppointmentId"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mPatientId = Convert.ToInt32(DB.DataTable.Rows[0]["PatientId"]);
                mAdminId = Convert.ToInt32(DB.DataTable.Rows[0]["AdminId"]);
                mAppointmentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mAppointmentTime = Convert.ToDateTime(DB.DataTable.Rows[0]["Time"]);
                
                return true;
            }
            else
            {
                return false;
            }

        }

        public String[,] SelectViewerPage()
        {

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblAppointment_SelectViewerPage");

            int rowCount = DB.DataTable.Rows.Count;
            int columnCount = 3;

            String[,] values = new String[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                DateTime date = Convert.ToDateTime(DB.DataTable.Rows[i]["Date"]);
                DateTime time = Convert.ToDateTime(DB.DataTable.Rows[i]["Time"]);
                string timeString = time.ToString(@"hh\:mm");

                values[i, 0] = Convert.ToString(DB.DataTable.Rows[i]["StaffId"]);
                values[i, 1] = date.ToString("dd/MM/yyyy");
                values[i, 2] = timeString;
            }

            return values;
        }

        public string Valid(string StaffId, string PatientId, string AdminId, string Date, string Time)
        {
            String Error = "";
            int StaffID;
            int PatientID;
            int AdminID;
            DateTime DateTemp;

            try
            {
                AdminID = Convert.ToInt32(AdminId);
                if (AdminID == 0)
                {
                    Error = Error + "Admin ID is not valid : ";
                }
                if (AdminID >= 2)
                {
                    Error = Error + "Admin ID is not valid : ";
                }

            }
            catch
            {
                if (AdminId.Length == 0)
                {
                    Error = Error + "AdminID may not be blank :";
                }
                if (!Regex.IsMatch(AdminId, @"^\d+$"))

                {
                    Error = Error + "AdminID may not have characters :";
                }
            }

            try
            {
                StaffID = Convert.ToInt32(StaffId);
                if (StaffID < 1)
                {
                    Error = Error + "StaffID is not valid : ";
                }
                if (StaffID >= 100)
                {
                    Error = Error + "StaffID is not valid : ";
                }

            }
            catch
            {
                if (StaffId.Length == 0)
                {
                    Error = Error + "StaffID may not be blank : ";
                }
                if (!Regex.IsMatch(StaffId, @"^\d+$"))

                {
                    Error = Error + "StaffID may not have characters : ";
                }
            }

            try
            {
                PatientID = Convert.ToInt32(PatientId);
                if (PatientID < 1)
                {
                    Error = Error + "PatientID is not valid : ";
                }
                if (PatientID >= 100)
                {
                    Error = Error + "PatientID is not valid : ";
                }

            }
            catch
            {
                if (PatientId.Length == 0)
                {
                    Error = Error + "PatientID may not be blank : ";
                }
                if (!Regex.IsMatch(StaffId, @"^\d+$"))

                {
                    Error = Error + "PatientID may not have characters : ";
                }
            }

            DateTime DateComp = DateTime.Now.Date;
            try
            {
                DateTemp = Convert.ToDateTime(Date);
                if (DateTemp < DateComp)
                {
                    Error = Error + "Date cannot be in the past : ";
                }

                if (DateTemp > DateComp.AddMonths(3))
                {
                    Error = Error + "Date cannot be past 3 months : ";
                }
            }
            catch
            {
                Error = Error + "Date is not valid : ";
            }

            try
            {
                if (!Regex.IsMatch(Time, @"^(?:[01]\d|2[0-3]):[0-5]\d$"))
                {
                    Error += "Time is not valid : ";
                }
            }
            catch
            {
                if (Time.Length == 0)
                {
                    Error += "Time may not be blank : ";
                }
            }

            return Error;
        }
    }
}
