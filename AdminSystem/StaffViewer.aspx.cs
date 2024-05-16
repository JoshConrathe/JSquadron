using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        AnStaff = (clsStaff)Session["AnStaff"];
        Response.Write("StaffID: " + AnStaff.StaffId + "<br />");
        Response.Write("StaffName: " + AnStaff.StaffName + "<br />");
        Response.Write("StaffPosition: " + AnStaff.StaffPosition + "<br />");
        Response.Write("StaffContactNumber: " + AnStaff.StaffContactNumber + "<br />");
        Response.Write("StaffSalary: " + AnStaff.StaffSalary + "<br />");
        Response.Write("StaffAdmin: " + AnStaff.AdminID + "<br />");
    }
    
   

 
}