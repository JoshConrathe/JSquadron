using ClassLibrary;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaffLIST();
        }


    }
    void DisplayStaffLIST()
    {
        clsStaffCollection STAFF = new clsStaffCollection();
        LstStaffList.DataSource = STAFF.StaffLIST;
        LstStaffList.DataValueField = "StaffId";
        LstStaffList.DataTextField = "StaffName";
        LstStaffList.DataBind();
    }
}