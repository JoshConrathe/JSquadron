<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link href="StyleSheet.css" rel="stylesheet" />
  <title>TeamMainMenu</title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="grid-container">
      <header class="header">
          <div class="menu-icon">
              <span> MENU</span>
          </div>
      </header>   
      <aside class="sidebar">
       <ul class="sidebar-list">
       <li class="sidebar-list-item" >
       <a href="Stafflist.aspx">Staff Registration</a>
       </li>
       <li class="sidebar-list-item" >  
       <a href="PatientList.aspx">Patient Registration</a>
       </li>
       <li class="sidebar-list-item" >
       <a href="ApplicationViewer.aspx">Job Application </a>
       </li>
       <li class="sidebar-list-item" >
        <a href="">Appointment</a>
        </li>
        <li class="sidebar-list-item" >
        <a href="">Payment</a>
         </li>
           <li class="sidebar-list-item" >
            <a href="TeamMainMenu.aspx">Dashboard</a>
             </li>
              </ul>    
      </aside>
  <main class="main-container">
  <div class="main-title">
    <h2>Dashboard</h2>
  </div>
  <div class="mainparts">
    <div class="part">
      <div class="part-inner">
        <h3><a href="StaffList.aspx">Staff Registration</a></h3>
      </div>
      <h1>249</h1>
    </div>

    <div class="part">
      <div class="part-inner">
        <h3><a href="PatientList.aspx">Patient Registration</a></h3>
      </div>
      <h1>25</h1>
    </div>

    <div class="part">
      <div class="part-inner">
        <h3><a href="ApplicationList.aspx">Job Application</a></h3>
      </div>
      <h1>1500</h1>
    </div>
      <div class="part">
      <div class="part-inner">
        <h3> <a href="">Appointment</a> </h3>
      </div>
      <h1>1500</h1>
    </div>

      <div class="part">
      <div class="part-inner">
        <h3><a href="">Payment</a></h3>
      </div>
      <h1>1500</h1>
    </div>
    </div>
        </main>
  </div>
   
    </form>
</body>
</html>
