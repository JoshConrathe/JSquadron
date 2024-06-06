<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplicationStatistics.aspx.cs" Inherits="ApplicationStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Job Application Statistics</title>
     <style type="text/css">
     .statisticsBackButton {
         border-radius: 5px;
         background-color:lightgray;
         color:black;
         cursor: pointer;
     }
     .statisticsBackButton:hover {
         color:white;
         background-color: lightslategray;
         cursor: pointer;
     }

 </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Statistics Page</h1>

            <br />
            <br />
            <div>
                <h3>Application List - Grouped by Position</h3>
                <br />
                <asp:GridView ID="GridGroupPosition" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="183px" Width="462px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </div>

            <br />
            <br />
            <br />
            <br />

            <div>
                <h3>Application List - Grouped by Position</h3>
                <br />
                <asp:GridView ID="GridGroupStaffId" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="178px" Width="440px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </div>
            <br />
            <br />
            <asp:Button ID="backButton" runat="server" Text="Return" OnClick="BackButton_Click" Height="34px" Width="143px" />

        </div>
    </form>
</body>
</html>
