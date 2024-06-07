using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 AppointmentId;
    protected void Page_Load(object sender, EventArgs e)
    {
        AppointmentId = Convert.ToInt32(Session["AppointmentId"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsAppointmentCollection appointmentDelete = new clsAppointmentCollection();
        appointmentDelete.ThisAppointment.Find(AppointmentId);
        appointmentDelete.Delete();
        Response.Redirect("AppointmentDataEntry.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AppointmentDataEntry.aspx");
    }
}