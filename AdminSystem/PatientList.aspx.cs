using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
      if(IsPostBack == false)
        {
      
                DisplayPatientslist();
          

        }

         
    }
    void DisplayPatientslist()
    {
        clsPatientCollection patient = new clsPatientCollection();
        LstPatientList.DataSource = patient.PatientList;
        LstPatientList.DataValueField = "PatientID";
        LstPatientList.DataTextField = "PatientName";
        LstPatientList.DataBind();  

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["PatientID"] = -1;
        Response.Redirect("PatientDataEntry.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Int32 PatientId;
        if (LstPatientList.SelectedIndex != -1)
        {
            PatientId = Convert.ToInt32(LstPatientList.SelectedValue);
            Session["PatientID"] = PatientId;
            Response.Redirect("PatientDataEntry.aspx");
        }
        else 
        {
            lblEror.Text = "Please select a record from the list to edit";
        }
                
                
                
                
                
                
    }


    protected void Unnamed1_Click1(object sender, EventArgs e)
    {
        Int32 PatientId;
        if (LstPatientList.SelectedIndex != -1)
        {
            PatientId = Convert.ToInt32(LstPatientList.SelectedValue);
            Session["PatientID"] = PatientId;
            Response.Redirect("PatientConfirmDelete.aspx");

        }
        else
        {
            lblEror.Text = "Please select a record from the list to delete";
        }

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        clsPatientCollection anpatient = new clsPatientCollection();
        anpatient.ReportByAddress(txtPostCodeFilter.Text);
        LstPatientList.DataSource = anpatient.PatientList;
        LstPatientList.DataValueField = "PatientID";
        LstPatientList.DataTextField = "PatientAddress";
        LstPatientList.DataBind();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        clsPatientCollection anpatient = new clsPatientCollection();
        anpatient.ReportByAddress("");
        txtPostCodeFilter.Text = "";
        LstPatientList.DataSource= anpatient.PatientList;
        LstPatientList.DataValueField = "PatientID";
       
        LstPatientList.DataTextField = "PatientAddress";

        LstPatientList.DataBind();

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("PatientStatistics.aspx");
    }
}