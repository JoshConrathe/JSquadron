<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Patient List</title>
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
        .lstpatient{
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
            <asp:Label class="headerlabel" ID="Label1" runat="server" Text="Patient List"></asp:Label>
            <br />
            <br />
        </div>
        
        <asp:ListBox class="lstpatient" ID="LstPatientList" runat="server" Height="431px" Width="526px" style="margin-left: 437px"></asp:ListBox>
        <p>
            <asp:Button class="Button"  ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="95px" style="margin-left: 372px" />
            <asp:Button class="Button"  ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 16px" Text="Edit" Width="100px" /><asp:Button class="Button" runat="server" Text="Delete" OnClick="Unnamed1_Click1" style="margin-left: 22px" Width="92px"></asp:Button>
            <asp:Button class="Button" ID ="Button5" runat="server" style="margin-left: 16px" Text="Statistics Page" Width="154px" OnClick="Button5_Click" />
            <asp:Button class="Button" ID="Button6" runat="server" OnClick="Button6_Click" style="margin-left: 20px" Text="Dashboard" Width="119px" />
        </p>
        <asp:Label class="label" ID="lblEror" runat="server" Text="Error"></asp:Label>
        <p>
            <asp:Label class="label" ID="Label2" runat="server" Text=" Enter a Post Code :"></asp:Label>
           <asp:TextBox class="txtbox" ID="txtPostCodeFilter" runat="server" Height="16px" style="margin-left: 11px; margin-top: 8px" Width="144px"></asp:TextBox>
        </p>
        <p>
            <asp:Button  class="Button" ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 40px" Text="Apply Filter" Width="128px" />
            <asp:Button class="Button" ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 55px" Text="Clear Filter" Width="135px" />
        </p>
        <p>
&nbsp;</p>
        </form>
</body>
</html>
