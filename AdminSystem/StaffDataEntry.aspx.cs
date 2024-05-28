using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            if (StaffId != -1)
            {
                DisplayPatientsS();
            }

        }

    }
    void DisplayPatientsS()
    {
        clsStaffCollection staff = new clsStaffCollection();
        staff.ThisStaff.Find(StaffId);
        txtStaffID.Text = staff.ThisStaff.StaffId.ToString();
        txtStaffName.Text = staff.ThisStaff.StaffName;
        txtStaffPosition.Text = staff.ThisStaff.StaffPosition;
        txtStaffNumber.Text = staff.ThisStaff.StaffContactNumber.ToString();
        txtStaffSalary.Text = staff.ThisStaff.StaffSalary.ToString();
        txtAdminID.Text = staff.ThisStaff.AdminID.ToString();




    }



    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        clsStaff anstaf= new clsStaff();
        txtStaffID.Text = " ";
        txtStaffName.Text = " ";
        txtStaffPosition.Text = " ";
        txtStaffSalary.Text = " ";
        txtAdminID.Text = " ";

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        string STAFFID = txtStaffID.Text;
        string StaffName = txtStaffName.Text;
        string StaffPosition = txtStaffPosition.Text;
        string StaffContactNumber = txtStaffNumber.Text;
        string StaffSalary = txtStaffSalary.Text;
        string AdminId = txtAdminID.Text;

        // Validate the input fields
        string Error = AnStaff.Valid(StaffName, StaffPosition, StaffContactNumber, StaffSalary, AdminId);
        if (Error == "")
        {
            int StaffId;
            // Try parsing the STAFFID, default to -1 if parsing fails
            if (!int.TryParse(STAFFID, out StaffId))
            {
                StaffId = -1;
            }

            // Assign values to AnStaff object
            AnStaff.StaffId = StaffId;
            AnStaff.StaffName = StaffName;
            AnStaff.StaffPosition = StaffPosition;
            AnStaff.StaffContactNumber = Convert.ToInt64(StaffContactNumber);
            AnStaff.StaffSalary = (float)Convert.ToDouble(StaffSalary);
            AnStaff.AdminID = Convert.ToInt32(AdminId);

            clsStaffCollection StaffList = new clsStaffCollection();
            if (StaffId == -1)
            {
                // Add new staff
                StaffList.ThisStaff = AnStaff;
                StaffList.Add();
            }
            else
            {
                // Update existing staff
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();
            }

            // Redirect to StaffList page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            // Display validation error
            lblError.Text = Error;
        }
    }





    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
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

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
  


}