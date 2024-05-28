using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AppointmentViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindTableData();
        }
    }

    private void BindTableData()
    {
        clsAppointment appointment = new clsAppointment();
        String[,] tableValues = appointment.SelectViewerPage();

        DataTable dt = new DataTable();
        dt.Columns.Add("StaffId");
        dt.Columns.Add("Date");
        dt.Columns.Add("Time");

        for (int i = 0; i < tableValues.GetLength(0); i++)
        {
            DataRow row = dt.NewRow();
            row["StaffId"] = tableValues[i, 0];
            row["Date"] = tableValues[i, 1];
            row["Time"] = tableValues[i, 2];
            dt.Rows.Add(row);
        }

        appointmentsTable.DataSource = dt;
        appointmentsTable.DataBind();
    }

    protected void selectButtonClick(object sender, EventArgs e)
    {
        Response.Redirect("AppointmentDataEntry.aspx");
    }
}