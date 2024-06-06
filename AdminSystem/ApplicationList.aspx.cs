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
        if (IsPostBack == false)
        {
            DisplayApplications();
        }
    }

    void DisplayApplications()
    {
        clsApplicationCollection apps = new clsApplicationCollection();
        lstApplicationList.DataSource = apps.ApplicationList;
        lstApplicationList.DataValueField = "ApplicationId";
        lstApplicationList.DataTextField = "PositionApplied";
        lstApplicationList.DataBind();
    }

    public void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ApplicationId"] = -1;
        Response.Redirect("ApplicationDataEntry.aspx");
    }

    protected void BackButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("ApplicationDataEntry.aspx");
    }

    protected void EditButton_Click(object sender, EventArgs e)
    {
        Int32 ApplicationId;

        if (lstApplicationList.SelectedIndex != -1)
        {
            ApplicationId = Convert.ToInt32(lstApplicationList.SelectedValue);
            Session["ApplicationId"] = ApplicationId;
            Response.Redirect("ApplicationDataEntry.aspx");
        }
        else
        {
            lblErrorList.Text = "Please select a record from the list to edit";
        }
    }

    protected void DeleteButton_Click(object sender, EventArgs e)
    {
        Int32 ApplicationId;

        if (lstApplicationList.SelectedIndex != -1 )
        {
            ApplicationId = Convert.ToInt32(lstApplicationList.SelectedValue);
            Session["ApplicationId"] = ApplicationId;
            Response.Redirect("ApplicationConfirmDelete.aspx");
        }
        else
        {
            lblErrorList.Text = "Please select a record from the list to delete";
        } 
           
        
    }
        protected void FilterButton_Click(object sender, EventArgs e)
        {
            clsApplicationCollection app = new clsApplicationCollection();
            app.ReportByPosition(filterInput.Text);

            lstApplicationList.DataSource = app.ApplicationList;
            lstApplicationList.DataValueField = "ApplicationId";
            lstApplicationList.DataTextField = "PositionApplied";

            lstApplicationList.DataBind();
        }

    protected void ClearButton_Click(object sender, EventArgs e)
    {
        clsApplicationCollection app = new clsApplicationCollection();
        app.ReportByPosition("");

        filterInput.Text = "";

        lstApplicationList.DataSource = app.ApplicationList;
        lstApplicationList.DataValueField = "ApplicationId";
        lstApplicationList.DataTextField = "PositionApplied";
        lstApplicationList.DataBind();
    }

    protected void StatisticsButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("ApplicationStatistics.aspx");
    }
}