<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplicationDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Job Application</title>
    <link
      href="../Application.css"
      rel="stylesheet" />
    <link
      rel="stylesheet"
      href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css"
      integrity="sha512-z3gLpd7yknf1YoNbCzqRKc4qyor8gaKU1qmn+CShxbuBusANI9QpRohGBreCFkKxLhei6S9CQXFEbbKuqLg0DA=="
      crossorigin="anonymous"
      referrerpolicy="no-referrer" />

  </head>
  <body>
    <div class="grid-container">
      <header class="header">
        <div class="menu-icon">
          <span>MENUU-icon"</span>
          <span>MENU</span>
        </div>
        <div class="header-right">
          <a href=""><span>Account</span> </a>
        </div>
      </header>
      <aside class="sidebar">
        <ul class="sidebar-list">
          <li class="sidebar-list-item">
            <a href="4ConfirmDelete.aspx">Staff Registration</a>
          </li>
          <li class="sidebar-list-item">
            <a href="">Patient Registration</a>
          </li>
          <li class="sidebar-list-item">
            <a href="ApplicationViewer.aspx">Job Application </a>
          </li>
          <li class="sidebar-list-item">
            <a href="sdf">Appointment</a>
          </li>
          <li class="sidebar-list-item">
            <a href="">Payment</a>
          </li>
        </ul>
      </aside>
      <main class="main-container">
        <div class="main-title">
          <h2>Job Application</h2>
        </div>
        <h3>Jobs available</h3>
        <div class="mainparts">
          <div class="part">
            <div class="part-inner">
              <h3>Doctor</h3>
            </div>
            <p>
              A doctor will report to the hospital manager, see patients,
              perform daily checks on patients, perform surgeries and see
              patients.
            </p>
          </div>

          <div class="part">
            <div class="part-inner">
              <h3>Nurse</h3>
            </div>
            <p>
              A nurse will assist doctors, take care of patients, administer
              medication, and maintain patient records.
            </p>
          </div>

            <div class="part">
              <div class="part-inner">
                <h3>Receptionist</h3>
              </div>
              <p>
                A receptionists will schedule appointments for patients, pick up deliveries and take care of administration tasks.
              </p>
            </div>
        </div>

        <div class="application-container">
          <h3>Apply for a Job</h3>
          <form
            class="job-application-form"
            id="jobApplicationForm"
            runat="server">
            <label for="fullName">Full Name:</label>
            <input
              type="text"
              id="txtFullName"
              name="fullName"
              required placeholder="John Smith" />

            <label for="email">Email:</label>
            <input
              type="email"
              id="txtEmail"
              name="email"
              required placeholder="example@email.com" />

            <label for="phone">Phone:</label>
            <input
              type="tel"
              id="txtPhone"
              name="phone"
              required placeholder="+44 7658587877" />

            <label for="position">Position:</label>
            <input
              type="text"
              id="txtPosition"
              name="position"
              required placeholder="Doctor" />

            <label for="resume">Resume:</label>
            <input
              type="file"
              id="txtResume"
              name="resume"
              accept=".pdf,.doc,.docx"
              />&nbsp;
              <br />
              <asp:Button ID="SubmitButtonId" runat="server" Text="Submit aplication" Width="244px" OnClick="SubmitButtonId_Click" BackColor="#009933" BorderColor="#009933" BorderStyle="Solid" CssClass="applyButton" Font-Bold="True" />
              <asp:Button ID="CancelButtonId" runat="server" Text="Cancel" Width="128px" OnClick="CancelButtonId_Click" BackColor="#F9F9F9" BorderColor="#009933" BorderStyle="Solid" ForeColor="#009933" />
              </form>
        </div>
      </main>
    </div>
  </body>
</html>