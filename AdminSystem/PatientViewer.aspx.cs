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
        ClsPatient Patient = new ClsPatient();
        Patient = (ClsPatient)Session["Patient"];
        Response.Write("PatientId: " + Patient.PatientId + "<br />");
        Response.Write("PatientName: " + Patient.PatientName + "<br />");
        Response.Write("PatientData: " + Patient.PatientDate + "<br />");
        Response.Write("PatientNumber: " + Patient.PatientNumber + "<br />");
        Response.Write("PatientAddress: " + Patient.PatientAddress + "<br />");
        Response.Write("PatientMedHistory: " + Patient.PatientMedHistory + "<br />");
        Response.Write("AdminID: " + Patient.AdminID + "<br />");

    }



}