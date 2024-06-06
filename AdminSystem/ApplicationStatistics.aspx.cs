using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ApplicationStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsApplication app = new clsApplication();

        DataTable dT = app.StatisticsGroupedByPosition();

        GridGroupPosition.DataSource = dT;
        GridGroupPosition.DataBind();

        GridGroupPosition.HeaderRow.Cells[0].Text = " Total ";

        dT = app.StatisticsGroupedByStaffId();

        GridGroupStaffId.DataSource = dT;
        GridGroupStaffId.DataBind();

        GridGroupStaffId.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void BackButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("ApplicationList.aspx");
    }
}