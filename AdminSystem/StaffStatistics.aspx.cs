using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff_Statistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff clsstaff = new clsStaff();
        DataTable dataTable = clsstaff.StatisticsGroupByPosition();
        GridViewPosition.DataSource = dataTable;
        GridViewPosition.DataBind();
        GridViewPosition.HeaderRow.Cells[0].Text = " Total ";

        dataTable = clsstaff.StatisticsGroupBySalary();
        GridViewSalary.DataSource = dataTable;
        GridViewSalary.DataBind();
        GridViewSalary.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}