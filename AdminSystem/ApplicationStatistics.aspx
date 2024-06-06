<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplicationStatistics.aspx.cs" Inherits="ApplicationStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Statistics Page</h1>

            <br />
            <br />
            <div>
                <h3>Applicatino List - Grouped by Position</h3>
                <br />
                <asp:GridView ID="GridGroupPosition" runat="server"></asp:GridView>
            </div>

            <br />
            <br />

            <div>
                <h3>Applicatino List - Grouped by Position</h3>
                <br />
                <asp:GridView ID="GridGroupStaffId" runat="server"></asp:GridView>
            </div>
            <br />
            <br />
            <asp:Button ID="backButton" runat="server" Text="Back" OnClick="BackButton_Click" />

        </div>
    </form>
</body>
</html>
