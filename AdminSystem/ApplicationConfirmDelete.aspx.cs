using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 ApplicationId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ApplicationId = Convert.ToInt32(Session["ApplicationId"]);
    }

    protected void ConfirmButton_Click(object sender, EventArgs e)
    {
        clsApplicationCollection apps = new clsApplicationCollection();
        apps.ThisApplication.Find(ApplicationId);
        apps.Delete();
        Response.Redirect("ApplicationList.aspx");
    }

    protected void CancelButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("ApplicationList.aspx");
    }




}