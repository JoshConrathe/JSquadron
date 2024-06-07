using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_Statistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsAppointment appointment = new clsAppointment();
        DataTable dataTable = appointment.StatisticsGroupByDateApp();
        GridViewDate.DataSource = dataTable;
        GridViewDate.DataBind();
        GridViewDate.HeaderRow.Cells[0].Text = " Total ";

        dataTable = appointment.StatisticsGroupByTimeapp();
        GridViewHistory.DataSource = dataTable;
        GridViewHistory.DataBind();
        GridViewHistory.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        Response.Redirect("AppointmentDataEntry.aspx");
    }



    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}