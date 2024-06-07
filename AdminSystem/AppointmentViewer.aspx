<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppointmentViewer.aspx.cs" Inherits="AppointmentViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link href="StyleSheet.css" rel="stylesheet" />
  <title>AppointmentViewer</title>
      <style type="text/css">
          
          table {
              font-family: arial, sans-serif;
              border-collapse: collapse;
              width: 100%;
          }

          td, th {
              border: 1px solid #dddddd;
              text-align: left;
              padding: 8px;
            }

          tr:nth-child(even) {
              background-color: #dddddd;
            }
          .auto-style4 {
              z-index: 1;
              left: 279px;
              top: 442px;
              position: absolute;
              width: 143px;
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
                     <a href="StaffList.aspx">Staff Registration</a>
                  </li>
                    <li class="sidebar-list-item" >
                        <a href="PatientList.aspx">Patient Registration</a>
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
  <div class="table">
    <asp:GridView ID="appointmentsTable" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="StaffId" HeaderText="Staff ID" />
            <asp:BoundField DataField="Date" HeaderText="Date" />
            <asp:BoundField DataField="Time" HeaderText="Time" />
            <asp:TemplateField HeaderText="Select">
                <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_Check" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
  </div>
      <br />
    <asp:Button ID="selectButton" runat="server" CssClass="auto-style4" OnClick="selectButtonClick" Text="Select" />

       </main>
         </div>
    </form>
</body>
</html>
