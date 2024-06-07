using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AppointmentDataEntry : System.Web.UI.Page
{
    Int32 AppointmentId;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (IsPostBack == false)
        {
            DisplayAppointmentLIST();
            if (AppointmentId != -1)
            {
                DisplayAppointmentsTEXT();
            }
            DisplayTableVALUES();
        }


    }
    void DisplayAppointmentLIST()
    {
        clsAppointmentCollection APPOINTMENT = new clsAppointmentCollection();
        LstAppointmentList.DataSource = APPOINTMENT.AppointmentList;
        LstAppointmentList.DataValueField = "AppointmentId";
        LstAppointmentList.DataTextField = "FormattedDateTime";
        LstAppointmentList.DataBind();
    }

    void DisplayAppointmentsTEXT()
    {
        clsAppointmentCollection APPOINTMENT = new clsAppointmentCollection();
        APPOINTMENT.ThisAppointment.Find(AppointmentId);
        //txtAppointmentId.Text = APPOINTMENT.ThisAppointment.AppointmentId.ToString();
        txtStaffId.Text = APPOINTMENT.ThisAppointment.StaffId.ToString();
        txtAdminId.Text = APPOINTMENT.ThisAppointment.AdminId.ToString();
        txtPatientId.Text = APPOINTMENT.ThisAppointment.PatientId.ToString();
        txtDate.Text = APPOINTMENT.ThisAppointment.AppointmentDate.ToString(@"dd\/MM\/yyyy");
        txtTime.Text = APPOINTMENT.ThisAppointment.AppointmentTime.ToString(@"hh\:mm");
    }

    void DisplayTableVALUES()
    {
            txtStaffId.Text = Session["StaffId"].ToString();
            txtDate.Text = Session["Date"].ToString();
            txtTime.Text = Session["Time"].ToString();
    }

    void addupdateMech()
    {
        clsAppointment Appointment = new clsAppointment();

        string AppointmentIdString = txtAppointmentId.Text;
        string AdminId = txtAdminId.Text;
        string PatientId = txtPatientId.Text;
        string StaffId = txtStaffId.Text;
        string AppointmentDate = txtDate.Text;
        string AppointmentTime = txtTime.Text;

        string Error = Appointment.Valid(StaffId, PatientId, AdminId, AppointmentDate, AppointmentTime);

        if (Error == "")
        {
            int AppointmentId;
            if (!int.TryParse(AppointmentIdString, out AppointmentId))
            {
                AppointmentId = -1;
            }

            Appointment.AppointmentId = AppointmentId;
            Appointment.AdminId = Convert.ToInt32(AdminId);
            Appointment.PatientId = Convert.ToInt32(PatientId);
            Appointment.StaffId = Convert.ToInt32(StaffId);
            Appointment.AppointmentDate = Convert.ToDateTime(AppointmentDate);
            Appointment.AppointmentTime = Convert.ToDateTime(AppointmentTime);

            clsAppointmentCollection AppointmentList = new clsAppointmentCollection();
            if (AppointmentId == -1)
            {
                AppointmentList.ThisAppointment = Appointment;
                AppointmentList.Add();
            }

            else
            {
                AppointmentList.ThisAppointment.Find(AppointmentId);
                AppointmentList.ThisAppointment = Appointment;
                AppointmentList.Update();
            }
            Response.Redirect("AppointmentDataEntry.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsAppointment APPOINTMENT = new clsAppointment();
        Int32 AppointmentId;
        Boolean Found = false;
        AppointmentId = Convert.ToInt32(txtAppointmentId.Text);
        Found = APPOINTMENT.Find(AppointmentId);
        if (Found == true)
        {
            txtAppointmentId.Text = APPOINTMENT.AppointmentId.ToString();
            txtStaffId.Text = APPOINTMENT.StaffId.ToString();
            txtPatientId.Text = APPOINTMENT.PatientId.ToString();
            txtAdminId.Text = APPOINTMENT.AdminId.ToString();
            txtDate.Text = APPOINTMENT.AppointmentDate.ToString(@"dd\/MM\/yyyy");
            txtTime.Text = APPOINTMENT.AppointmentTime.ToString(@"hh\:mm");

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["AppointmentId"] = -1;
        addupdateMech();
        Response.Redirect("AppointmentDataEntry.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Int32 AppointmentId;
        clsAppointment APPOINTMENT = new clsAppointment();
        Boolean Found = false;
        if (LstAppointmentList.SelectedIndex != -1)
        {
            AppointmentId = Convert.ToInt32(LstAppointmentList.SelectedValue);
            Session["AppointmentId"] = AppointmentId;
            Found = APPOINTMENT.Find(AppointmentId);
            if (Found == true)
            {
                txtAppointmentId.Text = APPOINTMENT.AppointmentId.ToString();
                txtStaffId.Text = APPOINTMENT.StaffId.ToString();
                txtPatientId.Text = APPOINTMENT.PatientId.ToString();
                txtAdminId.Text = APPOINTMENT.AdminId.ToString();
                txtDate.Text = APPOINTMENT.AppointmentDate.ToString(@"dd\/MM\/yyyy");
                txtTime.Text = APPOINTMENT.AppointmentTime.ToString(@"hh\:mm");
            }
        }
        else
        {
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Int32 AppointmentId;
        clsAppointment APPOINTMENT = new clsAppointment();
        if (LstAppointmentList.SelectedIndex != -1)
        {
            AppointmentId = Convert.ToInt32(LstAppointmentList.SelectedValue);
            Session["AppointmentId"] = AppointmentId;
            Response.Redirect("AppointmentConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        addupdateMech();
        Response.Redirect("AppointmentDataEntry.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        txtAppointmentId.Text = " ";
        txtStaffId.Text = " ";
        txtPatientId.Text = " ";
        txtAdminId.Text = " ";
        txtDate.Text = " ";
        txtTime.Text = " ";
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        addupdateMech();
        Response.Redirect("AppointmentStatistics.aspx");
    }
}