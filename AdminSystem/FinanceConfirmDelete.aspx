<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FinanceConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
    <h2>Payments</h2>
  </div>


</main>
  </div>
    </form>
</body>
</html>
