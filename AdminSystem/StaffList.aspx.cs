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

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (LstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(LstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (LstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(LstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        clsStaffCollection anstaff = new clsStaffCollection();
        anstaff.ReportByPosition(txtposition.Text);
        LstStaffList.DataSource = anstaff .StaffLIST;
        LstStaffList.DataValueField = "StaffId";
        LstStaffList.DataTextField = "StaffPosition";
        LstStaffList.DataBind();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        
        clsStaffCollection anstaff = new clsStaffCollection();
        anstaff.ReportByPosition("");
        txtposition.Text = "";
        LstStaffList.DataSource = anstaff .StaffLIST;
        LstStaffList.DataValueField = "StaffId";

        LstStaffList.DataTextField = "StaffPosition";

        LstStaffList.DataBind();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffStatistics.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
    }