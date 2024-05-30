using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32  mStaffId;
        private String mStaffName;
        private String mStaffPosition;
        private Int64 mStaffContactNumber;
        private float mStaffSalary;
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

        public Int64 StaffContactNumber 
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
        public float StaffSalary
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
                mStaffContactNumber = Convert.ToInt64(DB.DataTable.Rows[0]["ContactNumber"]);
                mStaffSalary = (float)Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);
                mAdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminId"]);
                return true;

            }
            else
            {
                return false;
            }
            
        }

        public DataTable StatisticsGroupByPosition()
        {
           clsDataConnection DB = new clsDataConnection ();
            DB.Execute("sproc_Staff_Cound_GroupByPosition");
            return DB.DataTable;
        }

        public DataTable StatisticsGroupBySalary()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Staff_Cound_GroupBySalary");
            return DB.DataTable;
        }

        public string Valid(string staffName, string staffPosition, string staffContactNumber, string staffSalary, string adminId)
        {
            String Error = "";
            int adminID;
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
          
            try
            {
                if (staffContactNumber.Length > 10)
                {
                    Error = Error + "The Staff Number must be less than 10 numbers : ";
                }
                if (staffContactNumber.Length < 10)
                {
                    Error = Error + "The Staff Number must be more than 10 numbers : ";
                }
            }
            catch
            {
                if (!Regex.IsMatch(staffContactNumber, @"^\d+$"))

                {
                    Error = Error + "The Number may not be characket :";
                }
            }
           
           

            try
            {
                adminID = Convert.ToInt32(adminId);
                if (adminID == 0)
                {
                    Error = Error + "The Admin ID Not correct:";
                }
                if (adminID >= 2)
                {
                    Error = Error + "The Admin ID Not correct:";
                }

            }
            catch
            {
                if (adminId.Length == 0)
                {
                    Error = Error + "The admin may not be blank :";
                }
                if (!Regex.IsMatch(adminId, @"^\d+$"))

                {
                    Error = Error + "The admin may not be characket :";
                }
            }
            return Error;
            
        }
    }
}