using System;
using System.CodeDom.Compiler;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;

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
                mStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Status"]);
                
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
    }
}