<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffStatistics.aspx.cs" Inherits="Staff_Statistics" %>

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
    #GridViewPosition , #GridViewSalary{
        text-align:center;
    }
    #lblPosition,#lblSalary{
        color:black;
        font-size:20px;
            margin-left: 34px;
        }
    #Button1{
           border-radius:3rem;
           color:black;
           background-color:orange;
           border:2px solid black;
    }
    .lbl{
        text-align:center;
    }
    .btn{
        text-align:center;
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
    <form id="form1" runat="server">
         <div class="header">Statistics Page</div>
 <br />
        <div class="lbl">
          <asp:Label ID="lblPosition" runat="server" Text="Staff List - Grouped by POSITION"></asp:Label>
        </div>
        <br />
 <asp:GridView ID="GridViewPosition" runat="server" CellPadding="3" style="margin-left: 349px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2" Width="605px">
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
        <div class="lbl">
            <asp:Label ID="lblSalary" runat="server" Text="Staff List - Grouped by SALARY" width="346px"></asp:Label>
        </div>
        
        <br />
 <asp:GridView ID="GridViewSalary" runat="server" CellPadding="3" style="margin-left: 352px" Width="605px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
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
        <br />
        <div class="btn">
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" Width="179px" style="margin-left: 81px" Height="38px" />
         <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Dashboard" Width="179px" style="margin-left: 30px" Height="39px" />
        </div>
    </form>
</body>
</html>
