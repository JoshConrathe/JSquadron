using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButtonId_Click(object sender, EventArgs e)
    {
        clsApplication Application = new clsApplication();
        
        Console.WriteLine("Add button clicked");
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Application submittion was successful!')", true);
        Response.Redirect("ApplicationViewer.aspx");
    }

    protected void CancelButtonId_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Cancel button clicked");
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Application cancelled!')", true);
    }
}