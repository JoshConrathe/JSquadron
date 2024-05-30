<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
      <style>
      body{
        background-color:orange;
                          
      }
      .Button{
           background-color:orange;
           color:white;
           border-radius:3rem;
           font-size:20px;
           border:2px solid black;

      }
      .Button:hover{
          background-color:black;
          color:white;
      }
      .txtbox{
           border-radius:3rem;
           color:black;
           background-color: white;
           text-align:center;
      }
      .header{
          text-align:center; 
      }
      .headerlabel{
          background-color:orange;
          color:black;
          font-size:40px;


      }
      .label{
          background-color:orange;
          color:black;
          font-size:20px;
      }
      .lststaff{
          border:3px solid black;
          text-align:center;
          padding-top:20px;
          background-color:orange;
          color:black;
      }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
         <asp:Label class="headerlabel" ID="Label1" runat="server" Text="Staff List"></asp:Label>
         <br />
         <br />
         </div>
        <asp:ListBox class="lststaff" ID="LstStaffList" runat="server" Height="431px" Width="526px" style="margin-left: 437px"></asp:ListBox>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
            <asp:Button class="Button" ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 339px" Text="ADD" Width="93px" />
            <asp:Button class="Button" ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 28px" Text="EDIT" Width="83px" />
            <asp:Button  class="Button" ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 20px" Text="DELETE" Width="100px" />
            <asp:Button  class="Button" ID="Button6" runat="server" OnClick="Button6_Click" style="margin-left: 24px" Text="Statistics Page" Width="160px" />
            <asp:Button class="Button" ID="Button7" runat="server" OnClick="Button7_Click" style="margin-left: 20px" Text="Dashboard" Width="119px" />

        </p>
         <p>
             <asp:Label class="label" ID="Label2" runat="server" Text=" Enter a Post Code :"></asp:Label>
             <asp:TextBox  class="txtbox" ID="txtposition" runat="server" Height="16px" style="margin-left: 40px; margin-top: 8px" Width="144px"></asp:TextBox>
 </p>
 <p>
     <asp:Button class="Button" ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 40px" Text="Apply Filter" Width="113px" />
     <asp:Button class="Button" ID="Button5" runat="server" OnClick="Button5_Click" style="margin-left: 55px" Text="Clear Filter" Width="113px" />
 </p>
    </form>
</body>
</html>
