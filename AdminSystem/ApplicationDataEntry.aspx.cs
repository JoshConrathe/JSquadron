using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 ApplicationId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ApplicationId = Convert.ToInt32(Session["ApplicationId"]);
        if (IsPostBack == false)
        {
            if(ApplicationId != -1)
            {
                DisplayApp();
            }
        }
    }

    protected void SubmitButtonId_Click(object sender, EventArgs e)
    {
        clsApplication Application = new clsApplication();

        int staffId = 0;
        int.TryParse(Request.Form["txtStaffId"], out staffId);
        int adminId = 0;
        string fullName = String.Format("{0}", Request.Form["txtFullName"]);
        string contactNumber = String.Format("{0}", Request.Form["txtPhone"]);
        string positionApplied = String.Format("{0}", Request.Form["txtPosition"]);
        string emailAddress = String.Format("{0}", Request.Form["txtEmail"]);
        string resume = String.Format("{0}", Request.Form["txtResume"]);

        string Error = "";
        Error = Application.Valid(staffId, fullName, contactNumber, positionApplied, emailAddress, resume);

        if (Error == "")
        {
                Application.ApplicationId = ApplicationId;
                Application.StaffId = staffId;
                Application.AdminId = 1;
                Application.ApplicantName = fullName;
                Application.ContactNumber = contactNumber;
                Application.PositionApplied = positionApplied;
                Application.EmailAddress = emailAddress;
                if (!string.IsNullOrEmpty(resume))
                {
                    Application.Resume = resume;
                }
                else
                {
                    Application.Resume = null;
                }

                clsApplicationCollection ApplicationList = new clsApplicationCollection();
                
                if(ApplicationId == -1)
                {
                     ApplicationList.ThisApplication = Application;
                     ApplicationList.Add();
                }
                else
                {
                    ApplicationList.ThisApplication.Find(ApplicationId);
                    ApplicationList.ThisApplication = Application;
                    ApplicationList.Update();
                }

                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Application submittion was successful!')", true);
                Response.Redirect("ApplicationList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

        
    }

    void DisplayApp()
    {
        clsApplicationCollection apps = new clsApplicationCollection();
        bool found = apps.ThisApplication.Find(ApplicationId);

        if (found && apps.ThisApplication != null)
        {
            txtStaffId.Value = apps.ThisApplication.StaffId.ToString();
            txtFullName.Value = apps.ThisApplication.ApplicantName.ToString();
            txtPhone.Value = apps.ThisApplication.ContactNumber.ToString();
            txtEmail.Value = apps.ThisApplication.EmailAddress;
            txtResume.Value = apps.ThisApplication.Resume ?? string.Empty;
        }
    }

    protected void CancelButtonId_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Cancel button clicked");
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Application cancelled!')", true);
        Response.Redirect("ApplicationViewer.aspx");
    }

    protected void FindButton_Click(object sender, EventArgs e)
    {
     
        clsApplication jobApp = new clsApplication();
        Int32 StaffId;
        Boolean Found = false;
        if (txtStaffId != null)
        {
            StaffId = Convert.ToInt32(txtStaffId.Value);

            Found = jobApp.Find(StaffId);

            if (Found == true)
            {
                txtFullName.Value = jobApp.ApplicantName;
                txtEmail.Value = jobApp.EmailAddress;
                txtPhone.Value = jobApp.ContactNumber;
                txtPosition.Value = jobApp.PositionApplied;
                if (jobApp.Resume != null)
                {
                    txtResume.Value = jobApp.Resume;
                }

            }
        }
        

       
    }
}