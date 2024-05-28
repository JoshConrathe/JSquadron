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



    protected void Unnamed1_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       clsStaff AnStaff = new clsStaff();   
        string StaffID = txtStaffID.Text;
        string StaffName = txtStaffName.Text;
        string StaffPosition = txtStaffPosition.Text;
        string StaffContactNumber = txtStaffNumber.Text;
        string StaffSalary = txtStaffSalary.Text;
        string AdminId = txtAdminID.Text;
        
        string Error = "";
        Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
        if (Error == "")
        {
            AnStaff.StaffId = Convert.ToInt32(txtStaffID.Text);
            AnStaff.StaffName = StaffName;
            AnStaff.StaffPosition = StaffPosition;
            AnStaff.StaffContactNumber = Convert.ToInt32(StaffContactNumber);
            AnStaff.StaffSalary = Convert.ToInt32(StaffSalary);
            AnStaff.AdminID = Convert.ToInt32(AdminId); ;
            Session["AnStaff"] = AnStaff;
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffID.Text);
        Found = AnStaff.Find(StaffId);
        if(Found == true)
        {
            txtStaffName.Text = AnStaff.StaffName;
            txtStaffPosition.Text = AnStaff.StaffPosition;
            txtStaffNumber.Text = AnStaff.StaffContactNumber.ToString();
            txtStaffSalary.Text = AnStaff.StaffSalary.ToString();
            txtAdminID.Text = AnStaff.AdminID.ToString();

        }
    }



    protected void txtStaffID_TextChanged(object sender, EventArgs e)
    {

    }
}