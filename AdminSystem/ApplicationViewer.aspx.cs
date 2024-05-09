using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ApplyButton_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Add button clickewd");
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Application submittion was successful!')", true);
    }
}