using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffLIST
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }

        public clsStaff ThisStaff { get; set; }

        public clsStaffCollection()
        {


            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("staff_selectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff ANStaff= new clsStaff();
                ANStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                ANStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ANStaff.StaffPosition = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                ANStaff.StaffContactNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["ContactNumber"]);
                ANStaff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["Salary"]);
                ANStaff.AdminID = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminId"]);
                mStaffList.Add(ANStaff);
                Index++;

            }


        }
    }
}