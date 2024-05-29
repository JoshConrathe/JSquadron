using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 PatientId;
    protected void Page_Load(object sender, EventArgs e)
    {


        PatientId = Convert.ToInt32(Session["PatientID"]);
        if (IsPostBack == false)
        {
            if (PatientId != -1)
            {
                DisplayPatientsS();
            }

        }
    }
    void DisplayPatientsS()
    {
        clsPatientCollection patient = new clsPatientCollection();
        patient.ThisPatient.Find(PatientId);
        txtPatientID.Text = patient.ThisPatient.PatientId.ToString();
        txtPatientName.Text = patient.ThisPatient.PatientName;
        txtPatientDBO.Text = patient.ThisPatient.PatientDate.ToString();
        txtPatientNumber.Text = patient.ThisPatient.PatientNumber.ToString();
        txtPatientAddress.Text = patient.ThisPatient.PatientAddress;
        txtPatientHistory.Text = patient.ThisPatient.PatientMedHistory;
        txtAdminID.Text = patient.ThisPatient.AdminID.ToString();
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
            txtPatientDBO.Text = ANpatient.PatientDate.ToShortDateString();
            txtPatientNumber.Text = ANpatient.PatientNumber.ToString();
            txtPatientAddress.Text= ANpatient.PatientAddress;
            txtPatientHistory.Text = ANpatient.PatientMedHistory;
            txtAdminID.Text= ANpatient.AdminID.ToString();

        }
    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {

        Response.Redirect("PatientList.aspx");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        // Creating a new instance of ClsPatient
        ClsPatient Patient = new ClsPatient();

        // Retrieving values from the text boxes
        string PatientIdString = txtPatientID.Text;
        string PatientName = txtPatientName.Text;
        string PatientDate = txtPatientDBO.Text; 
        string PatientNumber = txtPatientNumber.Text;
        string PatientAddress = txtPatientAddress.Text;
        string PatientMedHistory = txtPatientHistory.Text;
        string AdminID = txtAdminID.Text;

        // Validating patient data
        string Error = Patient.Valid(PatientName, PatientDate, PatientNumber, PatientAddress, PatientMedHistory, AdminID);

        if (Error == "")
        {
            // Parsing PatientIdString to an integer
            int PatientId;
            if (!int.TryParse(PatientIdString, out PatientId))
            {
                PatientId = -1; // Default to -1 if PatientId is not a valid integer
            }

            // Setting properties of the ClsPatient object
            Patient.PatientId = PatientId;
            Patient.PatientName = PatientName;
            Patient.PatientDate = Convert.ToDateTime(PatientDate);
            Patient.PatientNumber = Convert.ToInt64(PatientNumber);
            Patient.PatientAddress = PatientAddress;
            Patient.PatientMedHistory = PatientMedHistory;
            Patient.AdminID = Convert.ToInt32(AdminID);

            // Creating a new instance of clsPatientCollection
            clsPatientCollection PatientList = new clsPatientCollection();
            if (PatientId == -1)
            {
                // Adding new patient
                PatientList.ThisPatient = Patient;
                PatientList.Add(); // Ensure that the Add method in clsPatientCollection is correctly implemented
            }
            else
            {
                // Updating existing patient
                PatientList.ThisPatient.Find(PatientId);
                PatientList.ThisPatient = Patient;
                PatientList.Update(); // Ensure that the Update method in clsPatientCollection is correctly implemented
            }
            // Redirecting to PatientList.aspx after addition or update
            Response.Redirect("PatientList.aspx");
        }
        else
        {
            // Displaying error message if validation fails
            lblError.Text = Error;
        }
    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        ClsPatient anpatient =new ClsPatient();
        txtPatientID.Text = " ";
        txtPatientName.Text = " ";
        txtPatientAddress.Text = " ";
        txtPatientDBO.Text = " ";
        txtPatientHistory.Text = " ";
        txtAdminID.Text = " ";
    }
}