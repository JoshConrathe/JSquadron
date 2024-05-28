using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AppointmentDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void selectButtonClick(object sender, EventArgs e)
    {
        Response.Redirect("AppointmentDataEntry.aspx");
    }
}