<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FinanceViewer.aspx.cs" Inherits="_1Viewer" %>

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

        .welcome-container {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            height: 100%;
            text-align: center;
        }
        
        .welcome-message {
            font-size: 24px;
            margin-bottom: 20px;
            color: black;
        }
        
        .continue-button {
            padding: 10px 20px;
            font-size: 16px;
            color: white;
            background-color: orange;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            text-decoration: none;
        }

        .continue-button:hover {
            background-color: darkorange;
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
                <div class="header-right">
                    <a href=""><span>Account</span></a>
                </div>
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
                    <h2>Payments</h2>
                </div>
                <br />
                <div class="welcome-container">
                    <div class="welcome-message">Welcome to Payments</div>
                    <a href="FinanceDataEntry.aspx" class="continue-button">Click to continue</a>
                </div>
                
            </main>
        </div>
    </form>
</body>
</html>
