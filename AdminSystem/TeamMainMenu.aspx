<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link href="StyleSheet.css" rel="stylesheet" />
  <title>TeamMainMenu</title>>
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
                     <a href="4ConfirmDelete.aspx">Staff Registration</a>
                  </li>
                    <li class="sidebar-list-item" >
                        <a href="">Patient Registration</a>
                   </li>
                   <li class="sidebar-list-item" >
                         <a href="">Job Application </a>
                   </li>
                  <li class="sidebar-list-item" >
                      <a href="">Appointment</a>
                  </li>
                  <li class="sidebar-list-item" >
                      <a href="">Payment</a>
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
        <h3><a href="">Staff Registration</a></h3>
      </div>
      <h1>249</h1>
    </div>

    <div class="part">
      <div class="part-inner">
        <h3><a href="">Patient Registration</a></h3>
      </div>
      <h1>25</h1>
    </div>

    <div class="part">
      <div class="part-inner">
        <h3><a href="">Job Application</a></h3>
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
    </form>
</body>
</html>
