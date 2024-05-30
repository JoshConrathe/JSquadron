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

    protected void Button4_Click(object sender, EventArgs e)
    {
        ClsPatient ANpatient = new ClsPatient();
        Int32 PatientId;
        Boolean Found = false;
        PatientId =Convert.ToInt32(txtPatientID.Text);
        Found = ANpatient.Find(PatientId);
        if (Found == true)
        {
            txtPatientName.Text = ANpatient.PatientName;
            txtPatientDBO.Text = ANpatient.PatientDataBirth.ToShortDateString();
            txtPatientNumber.Text = ANpatient.PatientNumber.ToString();
            txtPatientAddress.Text= ANpatient.PatientAddress;
            txtPatientHistory.Text = ANpatient.PatientMedHistory;
            txtAdminID.Text= ANpatient.AdminID.ToString();

        }
    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {

    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ClsPatient Patient = new ClsPatient();
        string PatientId = txtPatientID.Text;
        string PatientName = txtPatientName.Text;
        string PatientDataBirth = txtPatientDBO.Text;
        string PatientNumber = txtPatientNumber.Text;
        string PatientAddress = txtPatientAddress.Text;
        string PatientMedHistory = txtPatientHistory.Text;
        string AdminID = txtAdminID.Text;
        string Error = "";
        Error = Patient.Valid(PatientName, PatientDataBirth, PatientNumber, PatientAddress, PatientMedHistory, AdminID);
        if(Error== "")
        {
            Patient.PatientId=Convert.ToInt32(txtPatientID.Text);
            Patient.PatientName = PatientName;
            Patient.PatientDataBirth = Convert.ToDateTime(DateTime.Now);
            Patient.PatientNumber = Convert.ToInt32 (PatientNumber);
            Patient.PatientAddress = PatientAddress;
            Patient.PatientMedHistory = PatientMedHistory;
            Patient.AdminID = Convert.ToInt32(AdminID);
            Session["Patient"] = Patient;
            Response.Redirect("PatientViewer.aspx");
        }
        else
        {
            lblError.Text= Error;
        }
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}