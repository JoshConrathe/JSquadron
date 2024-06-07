<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppointmentStatistics.aspx.cs" Inherits="_1_Statistics" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Statistics Page</title>
    <style>
        body{
            background-color:orange;
        }
        .header{
            text-align:center;
            font-size:42px;
            color:black;

        }
       #GridViewHistory , #GridViewDate{
           text-align:center;
       }
       #lblHistory,#lblDate{
           color:black;
           font-size:20px;
       }
       #Button1{
              border-radius:3rem;
              color:black;
              background-color:orange;
              border:2px solid black;
       }
       
       
       #Button5{
            border-radius:3rem;
            color:black;
            background-color:orange;
            border:2px solid black;
        }
        #Button1, #Button5:hover{
            background:black;
            color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="text-align: center;">
        <div class="header">Statistics Page</div>
        <br />
        <asp:Label ID="lblHistory" runat="server" Text="Appointment List - Grouped by HISTORY"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridViewHistory" runat="server" CellPadding="3" style="margin-left: 364px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2" Width="626px">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        <asp:Label ID="lblDate" runat="server" Text="Appointment List - Grouped by DATE"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridViewDate" runat="server" CellPadding="3" style="margin-left: 360px" Width="626px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2" height="171px">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" Width="179px" style="margin-left: 81px" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Back" Width="185px" style="margin-left: 30px" />
        </p>
    </form>
</body>
</html>
