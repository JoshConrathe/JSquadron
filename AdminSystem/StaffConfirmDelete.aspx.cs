
﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStaffCollection staffdelete = new clsStaffCollection();
        staffdelete.ThisStaff.Find(StaffId);
        staffdelete.Delete();
        Response.Redirect("StaffList.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}