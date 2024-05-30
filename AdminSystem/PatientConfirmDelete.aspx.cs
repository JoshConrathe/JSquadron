using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 PatientId;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        
            PatientId = Convert.ToInt32(Session["PatientID"]);
        
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsPatientCollection patientdelete = new clsPatientCollection();
        patientdelete.ThisPatient.Find(PatientId);
        patientdelete.Delete();
        Response.Redirect("PatientList.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("PatientList.aspx");
    }
}