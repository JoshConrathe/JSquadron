using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32  mStaffId;
        private String mStaffName;
        private String mStaffPosition;
        private Int32 mStaffContactNumber;
        private Int32 mStaffSalary;
        private Int32 mAdminID;

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
        public string StaffName 
        {
            get 
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            } 
        }
        public string StaffPosition
        { 
            get
            {
                return mStaffPosition;
            } 
            set 
            {
                mStaffPosition = value;
            } 
        }

        public int StaffContactNumber 
        {
            get 
            {
                return mStaffContactNumber;
            }
            set
            {
                mStaffContactNumber = value;
            } 
        }
        public int StaffSalary
        {
            get 
            {
                return mStaffSalary;
            } 
            set 
            {
                mStaffSalary = value;
            }
        }
        public int AdminID {
            get 
            {
                    return mAdminID;
            } 
            set 
            {
                mAdminID = value;

            } }

        public bool Find(int staffID)
        {
           clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", staffID);
            DB.Execute("sproc_staff_FilterByStaffId");
            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mStaffPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mStaffContactNumber = Convert.ToInt32(DB.DataTable.Rows[0]["ContactNumber"]);
                mStaffSalary = (int)Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);
                mAdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminId"]);
                return true;

            }
            else
            {
                return false;
            }
            
        }

        public string Valid(string staffName, string staffPosition, string staffContactNumber, string staffSalary, string adminId)
        {
            String Error = "";
            int ADMINID;
            if (staffName.Length == 0)
            {
                Error = Error + "The Staff Name may not be blank : ";
            }
            if (staffName.Length > 20)
            {
                Error = Error + "The Staff Name must be less than 20 characters : ";
            }
            if (staffPosition.Length == 0)
            {
                Error = Error + "The Staff Position may not be blank : ";
            }
            if (staffPosition.Length > 50)
            {
                Error = Error + "The Staff Position must be less than 50 characters : ";
            }
            if (staffContactNumber.Length > 10)
            {
                Error = Error + "The Staff Number must be less than 10 characters : ";
            }
            if (staffContactNumber.Length < 10)
            { 
                Error = Error + "The Staff Number must be less than 10 characters : ";
            }
            ADMINID = Convert.ToInt32(adminId);
            if (ADMINID == 0)
            {
                Error = Error + "The Admin ID Not correct:";
            }
            if (ADMINID >= 2)
            {
                Error = Error + "The Admin ID Not correct:";
            }
            return Error;
            
        }
    }
}