<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplicationDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Job Application</title>
    <link
        href="Application.css"
        rel="stylesheet" />
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css"
        integrity="sha512-z3gLpd7yknf1YoNbCzqRKc4qyor8gaKU1qmn+CShxbuBusANI9QpRohGBreCFkKxLhei6S9CQXFEbbKuqLg0DA=="
        crossorigin="anonymous"
        referrerpolicy="no-referrer" />

    <style type="text/css">
        .applyButton {
            margin-left: 0px;
        }

        #txtPosition {
            width: 293px;
            height: 39px;
        }
    </style>

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
                <form id="jobApplicationForm" runat="server" style="z-index: 1">
                    <label for="staffId" style="width: 268px; height: 39px;">Staff Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
                    <input
                        type="text"
                        id="txtStaffId"
                        name="staffId"
                        runat="server"
                        required
                        placeholder="e.g. 3"
                        style="width: 293px; height: 39px;" />

                    <label for="fullName" style="width: 268px; height: 39px;">
                        <br />
                        <br />
                        Full Name:
                    </label>
                    <input
                        type="text"
                        id="txtFullName"
                        name="fullName"
                        runat="server"
                        required
                        placeholder="John Smith"
                        style="width: 293px; height: 39px;" />

                    <label for="txtEmail"
                        style="width: 268px; height: 39px;">
                        <br />
                        <br />
                        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </label>

                    <input
                        type="email"
                        id="txtEmail"
                        name="email"
                        runat="server"
                        required
                        placeholder="example@email.com"
                        style="width: 293px; height: 39px;" />
                    <label for="phone"
                        style="width: 268px; height: 39px;">
                        <br />
                        <br />
                        Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </label>
                    <input
                        type="tel"
                        id="txtPhone"
                        name="phone"
                        runat="server"
                        required
                        placeholder="+44 7658587877"
                        style="width: 293px; height: 39px;" />

                    <label for="position" style="width: 268px; height: 39px;">
                        <br />
                        <br />
                        Position:&nbsp;&nbsp;&nbsp;&nbsp;
                    </label>
                    <input
                        type="text"
                        id="txtPosition"
                        name="position"
                        runat="server"
                        required
                        placeholder="Doctor" />

                    <label for="resume" style="width: 268px; height: 39px;">
                        <br />
                        <br />
                        Resume:&nbsp;&nbsp;&nbsp;&nbsp;
                    </label>
                    <input
                        type="file"
                        id="txtResume"
                        name="resume"
                        runat="server"
                        accept=".pdf,.doc,.docx"
                        style="width: 293px; height: 39px;" />&nbsp;
                    <br />
                    <br />
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="FindButton" runat="server" UseSubmitBehavior="false" Text="Find" Width="80px" OnClick="FindButton_Click" BackColor="#F9F9F9" BorderColor="#5C5D5C" BorderStyle="Solid" ForeColor="#5C5D5C" Height="43px" Style="margin-bottom: 12px; margin-top: 12px;" CssClass="findButton" />

                    <br />
                    <asp:Button ID="SubmitButtonId" runat="server" UseSubmitBehavior="true" Text="Submit aplication" Width="254px" OnClick="SubmitButtonId_Click" BackColor="#009933" BorderColor="#009933" BorderStyle="Solid" CssClass="submitAppButton" Font-Bold="True" Height="43px" Font-Italic="False" ForeColor="White" />
                    <asp:Button ID="CancelButtonId" runat="server" UseSubmitBehavior="false" Text="Cancel" Width="154px" OnClick="CancelButtonId_Click" BackColor="#F9F9F9" BorderColor="#009933" BorderStyle="Solid" ForeColor="#009933" Height="43px" Style="margin-left: 28px; border-radius: 5px" />

                    <br />
                </form>
            </div>
        </main>
    </div>
</body>
</html>
