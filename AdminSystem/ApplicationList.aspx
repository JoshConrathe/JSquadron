<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplicationList.aspx.cs" Inherits="_1_List" %>

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
    <form id="form1" runat="server">
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
            <h3>Current job applications</h3>
            <div class="application-container">
                <asp:ListBox ID="lstApplicationList" runat="server" Height="146px" Width="428px" CssClass="listApplication"></asp:ListBox>
                <br />
                <br />
                <asp:Button ID="lstAddButton" runat="server" Text="Add" Width="90px" Height="32px" CssClass="listAddButton" OnClick="btnAdd_Click" />

                <asp:Button ID="lstEditButton" runat="server" Height="32px" Width="90px" CssClass="listAddButton" OnClick="EditButton_Click" Text="Edit" />

                <asp:Button ID="lstDeleteButton" runat="server" Height="32px" Width="90px" CssClass="listDeleteButton" OnClick="DeleteButton_Click" Text="Delete" />

                &nbsp;

                <asp:Button ID="lstBackButton" runat="server" Height="32px" Text="Back" Width="90px" CssClass="listBackButton" OnClick="BackButton_Click" />
                <br />
                <br />
                <p>Enter a Position</p>
                <asp:TextBox runat="server" id="filterInput" Text="eg. Doctor" ></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="applyFilter" runat="server" Height="32px" Text="Apply Filter" Width="90px" CssClass="findButton" OnClick="FilterButton_Click" />
                <asp:Button ID="clearFilter" runat="server" Height="32px" Text="Clear Filter" Width="90px" CssClass="findButton" OnClick="ClearButton_Click" />
                <asp:Button ID="statisticsButton" runat="server" Height="32px" Text="Statistics" Width="90px" CssClass="findButton" OnClick="StatisticsButton_Click" />

            </div>
        </main>

        </div>
        <asp:Label ID="lblErrorList" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
