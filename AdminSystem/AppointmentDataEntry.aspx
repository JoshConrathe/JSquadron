<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppointmentDataEntry.aspx.cs" Inherits="AppointmentDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title>AppointmentDataEntry</title>
    <style type="text/css">
        .auto-style1 {
            display: flex;
            align-items: center;
            margin-bottom: 10px;
            text-align: left;
        }
        .separator-container {
            width: 474px;
        }
        .separator-line {
            border: 0;
            height: 1px;
            background: #ccc;
            width: 100%;
            margin-top: 20px;
        }

        .left-box, .right-box {
            margin-top: 20px;
        }
        .left-box {
            margin-right: 20px;
            width: 525px;
            height: 529px;
        }
        .right-box {
            margin-left: 20px;
            height: 420px;
            width: 565px;
        }

        .flex-container {
          display: flex;
        }


    </style>
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css"
        integrity="sha512-z3gLpd7yknf1YoNbCzqRKc4qyor8gaKU1qmn+CShxbuBusANI9QpRohGBreCFkKxLhei6S9CQXFEbbKuqLg0DA=="
        crossorigin="anonymous"
        referrerpolicy="no-referrer"
    />
</head>
<body>
    <form id="form1" runat="server">
        <div class="grid-container">
            <header class="header">
                <div class="menu-icon">
                    <span> MENU</span>
                </div>
                <div class="header-right"></div>
            </header>
            <aside class="sidebar">
                <ul class="sidebar-list">
                    <li class="sidebar-list-item">
                        <a href="StaffList.aspx">Staff Registration</a>
                    </li>
                    <li class="sidebar-list-item">
                        <a href="PatientList.aspx">Patient Registration</a>
                    </li>
                    <li class="sidebar-list-item">
                        <a href="ApplicationViewer.aspx">Job Application </a>
                    </li>
                    <li class="sidebar-list-item">
                        <a href="AppointmentViewer.aspx">Appointment</a>
                    </li>
                    <li class="sidebar-list-item">
                        <a href="FinanceViewer.aspx">Payment</a>
                    </li>
                </ul>
            </aside>
            <main class="main-container">
                <div class="main-title">
                    <h2>Appointments</h2>
                </div>
                <div class="flex-container">
                    <div class="left-box">
                    <br />
                    <br />
                    <div class="auto-style1">
                        <asp:Label ID="AppointmentID1" runat="server" Text="AppointmentID" height="19px" width="94px"></asp:Label>
                        <asp:TextBox ID="txtAppointmentId" placeholder="Enter here" runat="server" style="margin-left: 127px" height="25px" width="250px"></asp:TextBox>
                    </div>
                    <div class="auto-style1" style="margin-top: 20px">
                        <asp:Button ID="Find" runat="server" style="margin-right: 20px" OnClick="Button1_Click" Text="Find" />
                    </div>
                    <div class="separator-container">
                        <hr class="separator-line" />
                    </div>
                    <br />
                    <div class="auto-style1">
                        <asp:Label ID="StaffID1" runat="server" Text="StaffID" height="19px" width="94px"></asp:Label>
                        <asp:TextBox ID="txtStaffId" placeholder="Enter here" runat="server" style="margin-left: 127px" height="25px" width="250px"></asp:TextBox>
                    </div>
                    <br />
                    <div class="auto-style1">
                        <asp:Label ID="PatientID1" runat="server" Text="PatientID" height="19px" width="94px"></asp:Label>
                        <asp:TextBox ID="txtPatientId" placeholder="Enter here" runat="server" style="margin-left: 127px" height="25px" width="250px"></asp:TextBox>
                    </div>
                    <br />
                    <div class="auto-style1">
                        <asp:Label ID="AdminId1" runat="server" Text="AdminID" height="19px" width="94px"></asp:Label>
                        <asp:TextBox ID="txtAdminId" placeholder="Enter here" runat="server" Height="25px" style="margin-left: 127px" Width="250px"></asp:TextBox>
                    </div>
                    <br />
                    <div class="auto-style1">
                        <asp:Label ID="Date1" runat="server" Text="Date" height="19px" width="94px"></asp:Label>
                        <asp:TextBox ID="txtDate" placeholder="Enter here" runat="server" style="margin-left: 127px" height="25px" width="250px"></asp:TextBox>
                    </div>
                    <br />
                    <div class="auto-style1">
                        <asp:Label ID="Time1" runat="server" Text="Time" height="19px" width="94px"></asp:Label>
                        <asp:TextBox ID="txtTime" placeholder="Enter here" runat="server" Height="25px" style="margin-left: 127px" Width="250px"></asp:TextBox>
                    </div>
                    <div class="auto-style1" style="margin-top: 20px">
                        <asp:Button ID="Add" runat="server" style="margin-right: 20px" OnClick="Button2_Click" Text="Add" />
                        <asp:Button ID="Update" runat="server" style="margin-right: 20px" OnClick="Button5_Click" Text="Update" />
                        <asp:Button ID="Clear" runat="server" style="margin-right: 20px" OnClick="Button6_Click" Text="Clear" />
                    </div>
                        <asp:Label ID="lblError" runat="server" Text="" height="100px" width="94px"></asp:Label>
                    </div>
                

                    <div class="right-box">
                        <br />
                        <asp:ListBox class="lstAppointment" ID="LstAppointmentList" runat="server" Height="400px" Width="350px" style="margin-right: 50px;"></asp:ListBox>
                        <div class="auto-style1" style="margin-top: 20px">
                            <asp:Button ID="Select" runat="server" style="margin-right: 20px" OnClick="Button3_Click" Text="Select" />
                            <asp:Button ID="Delete" runat="server" style="margin-right: 20px" OnClick="Button4_Click" Text="Delete" />
                            <asp:Button ID="Statistics" runat="server" style="margin-right: 20px" OnClick="Button7_Click" Text="Statistics" />
                        </div>
                    </div>
                </div>

            </main>
        </div>
    </form>
</body>
</html>
