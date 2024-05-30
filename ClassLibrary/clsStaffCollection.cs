using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
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

        public clsStaff ThisStaff 
        {
            get 
            {
                return mThisStaff;
            } set 
            {
                mThisStaff = value;
            } 
        }



        public clsStaffCollection()
        {


            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("staff_selectAll");
            PopulateArray(DB);


        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList =new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff ANStaff = new clsStaff();
                ANStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                ANStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ANStaff.StaffPosition = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                ANStaff.StaffContactNumber = Convert.ToInt64(DB.DataTable.Rows[Index]["ContactNumber"]);
                ANStaff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["Salary"]);
                ANStaff.AdminID = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminId"]);
                mStaffList.Add(ANStaff);
                Index++;

            }
        }

        public int Add()
        {
           clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffPosition", mThisStaff.StaffPosition);
            DB.AddParameter("@ContactNumber", mThisStaff.StaffContactNumber);
            DB.AddParameter("@Salary", mThisStaff.StaffSalary);
            DB.AddParameter("@AdminId", mThisStaff.AdminID);
            return DB.Execute("sproc_Staff_Insert");
            

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffPosition", mThisStaff.StaffPosition);
            DB.AddParameter("@ContactNumber", mThisStaff.StaffContactNumber);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@AdminId", mThisStaff.AdminID);
            DB.Execute("sproc_Staff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.Execute("sproc_Staff_Delete");
        }

        public void ReportByPosition(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffName", Name);
            DB.Execute("sproc_Staff_FilterByName");
            PopulateArray(DB);
        }
    }
}
