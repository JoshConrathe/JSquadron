
<style type="text/css">
    .BigApplyButton {
    }
</style>
﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplicationViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><title>Job Application</title>
    <link
      href="Application.css"
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
              <p>A receptionists will schedule appointments for patients, pick up deliveries and take care of administration tasks.
              </p>
            </div>
            <div class="application-container">
                <form runat="server" id="applicationForm">
                    <asp:Button CssClass="BigApplyButton" ID="ApplyButtonId" runat="server" Text="Apply for a position" OnClick="ApplyButtonId_Click" BackColor="#33CC33" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="124px" Width="301px" BorderStyle="None" />
                </form>
            </div>
        </div>
        
      </main>
    </div>
  </body>
</html>