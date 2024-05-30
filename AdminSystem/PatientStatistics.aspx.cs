using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PatientStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsPatient CLSPATIENT = new ClsPatient();
        DataTable dataTable = CLSPATIENT.StatisticsGroupByHistory();
        GridViewHistory.DataSource = dataTable;
        GridViewHistory.DataBind();
        GridViewHistory.HeaderRow.Cells[0].Text = " Total ";

        dataTable = CLSPATIENT.StatisticsGroupByDate();
        GridViewDate.DataSource = dataTable;
        GridViewDate.DataBind();
        GridViewDate.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("PatientList.aspx");
    }



    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}