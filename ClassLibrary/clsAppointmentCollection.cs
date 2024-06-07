using ClassLibrary;
using System.Collections.Generic;
using System;

public class clsAppointmentCollection
{
    List<clsAppointment> mAppointmentList = new List<clsAppointment>();
    clsAppointment mThisAppointment = new clsAppointment();

    public List<clsAppointment> AppointmentList
    {
        get 
        { 
            return mAppointmentList; 
        }
        set 
        { 
            mAppointmentList = value; 
        }
    }

    public int Count
    {
        get 
        { 
            return mAppointmentList.Count; 
        }
    }

    public clsAppointment ThisAppointment
    {
        get 
        { 
            return mThisAppointment; 
        }
        set 
        { 
            mThisAppointment = value; }
    }

    public clsAppointmentCollection()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("appointment_selectAll");
        PopulateArray(DB);
    }

    void PopulateArray(clsDataConnection DB)
    {
        Int32 index = 0;
        Int32 RecordCount;
        RecordCount = DB.Count;
        mAppointmentList = new List<clsAppointment>();
        while (index < RecordCount)
        {
            clsAppointment apmtDetails = new clsAppointment();
            apmtDetails.AppointmentId = Convert.ToInt32(DB.DataTable.Rows[index]["AppointmentId"]);
            apmtDetails.AdminId = Convert.ToInt32(DB.DataTable.Rows[index]["AdminId"]);
            apmtDetails.PatientId = Convert.ToInt32(DB.DataTable.Rows[index]["PatientId"]);
            apmtDetails.StaffId = Convert.ToInt32(DB.DataTable.Rows[index]["StaffId"]);
            apmtDetails.AppointmentDate = Convert.ToDateTime(DB.DataTable.Rows[index]["Date"]);
            apmtDetails.AppointmentTime = Convert.ToDateTime(DB.DataTable.Rows[index]["Time"]);
            mAppointmentList.Add(apmtDetails);
            index++;
        }
    }

    public int Add()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@AdminId", mThisAppointment.AdminId);
        DB.AddParameter("@PatientId", mThisAppointment.PatientId);
        DB.AddParameter("@StaffId", mThisAppointment.StaffId);
        DB.AddParameter("@Date", mThisAppointment.AppointmentDate);
        DB.AddParameter("@Time", mThisAppointment.AppointmentTime);
        return DB.Execute("appointment_create");
    }

    public void Update()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@AppointmentID", mThisAppointment.AppointmentId);
        DB.AddParameter("@AdminId", mThisAppointment.AdminId);
        DB.AddParameter("@PatientId", mThisAppointment.PatientId);
        DB.AddParameter("@StaffId", mThisAppointment.StaffId);
        DB.AddParameter("@AppointmentDate", mThisAppointment.AppointmentDate);
        DB.AddParameter("@AppointmentTime", mThisAppointment.AppointmentTime);
        DB.AddParameter("@Status", mThisAppointment.Status);
        DB.Execute("sproc_Appointment_Update");
    }

    public void Delete()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@AppointmentID", mThisAppointment.AppointmentId);
        DB.Execute("sproc_Appointment_Delete");
    }

    public bool Find(int appointmentId)
    {
        return mThisAppointment.Find(appointmentId);
    }
}
