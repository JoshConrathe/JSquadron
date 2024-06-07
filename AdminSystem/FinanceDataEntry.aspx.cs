using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateAppointmentDates();
        }
    }

    private void PopulateAppointmentDates()
    {
        List<string> dates = new List<string>();
        DateTime startDate = DateTime.Today;
        DateTime endDate = DateTime.Today.AddMonths(3);

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            dates.Add(date.ToString("yyyy-MM-dd"));
        }

        Date.DataSource = dates;
        Date.DataBind();
    }

    protected void selectButtonClick(object sender, EventArgs e)
    {
        Response.Redirect("FinanceDataEntry.aspx");
    }

    protected void PayNowButtonClick(object sender, EventArgs e)
    {
        // Clear previous error messages
        lblPatientNameError.Text = "";
        lblCardNumberError.Text = "";
        lblCVVError.Text = "";
        lblMedicationRequiredError.Text = "";
        lblDoctorNameError.Text = "";
        lblUkResidentError.Text = "";

        bool isValid = true;

        // Validate Patient Name
        if (string.IsNullOrEmpty(PatientId.Text))
        {
            lblPatientNameError.Text = "Patient name is required.";
            isValid = false;
        }

        // Validate UK resident
        if (string.IsNullOrEmpty(Resident1.SelectedValue))
        {
            lblUkResidentError.Text = "Please answer if you are a current UK resident or not.";
            isValid = false;
        }

        // Validate Doctor Name
        if (string.IsNullOrEmpty(StaffId.Text))
        {
            lblDoctorNameError.Text = "Doctor name is required.";
            isValid = false;
        }

        // Validate Card Number
        string cardNumber = Time.Text.Replace(" ", ""); // Remove spaces for validation
        if (string.IsNullOrEmpty(cardNumber))
        {
            lblCardNumberError.Text = "Card number is required.";
            isValid = false;
        }
        else if (cardNumber.Length < 16 || cardNumber.Length > 19 || !cardNumber.All(char.IsDigit))
        {
            lblCardNumberError.Text = "Card number must be between 16 and 19 digits without spaces.";
            isValid = false;
        }

        // Validate CVV
        if (string.IsNullOrEmpty(CardCVV.Text))
        {
            lblCVVError.Text = "CVV is required.";
            isValid = false;
        }
        else if ((CardCVV.Text.Length != 3 && CardCVV.Text.Length != 4) || !CardCVV.Text.All(char.IsDigit))
        {
            lblCVVError.Text = "CVV must be 3 or 4 digits.";
            isValid = false;
        }

        // Validate Medication Required
        if (string.IsNullOrEmpty(RequiredMedication.SelectedValue))
        {
            lblMedicationRequiredError.Text = "Please select Yes or No for if medication required.";
            isValid = false;
        }

        if (isValid)
        {
            // Perform the payment processing here

            // Show success message
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowSuccessMessage", "showSuccessMessage();", true);
        }
    }

    protected void RequiredMedication_SelectedIndexChanged(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "toggleMedicationRequired", "toggleMedicationRequired();", true);
    }

    protected void Date_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FinanceStatistics.aspx");
    }
}
