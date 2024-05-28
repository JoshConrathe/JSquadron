<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppointmentDataEntry.aspx.cs" Inherits="AppointmentDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link href="StyleSheet.css" rel="stylesheet" />
  <title>AppointmentDataEntry</title>
      <style type="text/css">          .auto-style1 {
              display: flex;
              align-items: center;
              margin-bottom: 10px;
              text-align: left;
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
                 <a href=""><span>Account</span> </a>
              </div>
      </header>
      <aside class="sidebar">
              <ul class="sidebar-list">
                  <li class="sidebar-list-item" >
                     <a href="StaffViewer.aspx">Staff Registration</a>
                  </li>
                    <li class="sidebar-list-item" >
                        <a href="PatientViewer.aspx">Patient Registration</a>
                   </li>
                   <li class="sidebar-list-item" >
                         <a href="ApplicationViewer.aspx">Job Application </a>
                   </li>
                  <li class="sidebar-list-item" >
                      <a href="AppointmentViewer.aspx">Appointment</a>
                  </li>
                  <li class="sidebar-list-item" >
                      <a href="">Payment</a>
                  </li>
              </ul>    
      </aside>
<main class="main-container">
  <div class="main-title">
    <h2>Appointments</h2>
  </div>
    <br />
  <div class="auto-style1">
    <asp:Label ID="AppointmentID1" runat="server" Text="AppointmentID" height="19px" width="94px"></asp:Label>
    <asp:TextBox ID="AppointmentID" placeholder="Leave Empty for Add" runat="server" style="margin-left: 113px" height="25px" width="426px"></asp:TextBox>
  </div>
      <br />
  <div class="auto-style1">
    <asp:Label ID="StaffID1" runat="server" Text="StaffID" height="19px" width="94px"></asp:Label>
    <asp:TextBox ID="StaffID" placeholder="Leave Empty for Find" runat="server" style="margin-left: 127px" height="25px" width="412px"></asp:TextBox>
     
  </div>
     <br />
  <div class="auto-style1">
    <asp:Label ID="PatientID1" runat="server" Text="PatientID" height="19px" width="94px"></asp:Label>
    <asp:TextBox ID="PatientID" placeholder="Leave Empty for Find" runat="server" style="margin-left: 127px" height="25px" width="412px"></asp:TextBox>
  </div>
    <br />
  <div class="auto-style1">
    <asp:Label ID="Date1" runat="server" Text="Date" height="19px" width="94px"></asp:Label>
    <asp:TextBox ID="Date" placeholder="Leave Empty for Find" runat="server" style="margin-left: 127px" height="25px" width="412px"></asp:TextBox>
     
  </div>
     <br />
  <div class="auto-style1">
    <asp:Label ID="Time1" runat="server" Text="Time" height="19px" width="94px"></asp:Label>
    <asp:TextBox ID="Time" placeholder="Leave Empty for Find" runat="server" Height="25px" style="margin-left: 127px" Width="412px"></asp:TextBox>
  </div>

  <div class="auto-style1" style="margin-top: 20px">
    <asp:Button ID="Add" runat="server" style="margin-right: 20px" OnClick="selectButtonClick" Text="Add" />
      <asp:Button ID="Delete" runat="server" style="margin-right: 20px" OnClick="selectButtonClick" Text="Delete" />
      <asp:Button ID="Edit" runat="server" style="margin-right: 20px" OnClick="selectButtonClick" Text="Edit" />
      <asp:Button ID="Find" runat="server" style="margin-right: 20px" OnClick="selectButtonClick" Text="Find" />
  </div>

</main>
  </div>
    </form>
</body>
</html>

