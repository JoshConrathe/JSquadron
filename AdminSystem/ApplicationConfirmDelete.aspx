<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplicationConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Job Application</title>
    <link
        href="Application.css"
        rel="stylesheet" />
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css"
        integrity="sha512-z3gLpd7yknf1YoNbCzqRKc4qyor8gaKU1qmn+CShxbuBusANI9QpRohGBreCFkKxLhei6S9CQXFEbbKuqLg0DA=="
        crossorigin="anonymous"
        referrerpolicy="no-referrer" />

    <style type="text/css">
        .applyButton {
            margin-left: 0px;
        }

        #txtPosition {
            width: 293px;
            height: 39px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <main>
            <div class="delete_page_container">
                <div class="delete_confirm_container">
                   <p>Are you sure you want to delete this record?</p>
                    <div>
                        <asp:Button ID="deleteConfirm" runat="server" Height="32px" Width="90px" CssClass="listDeleteButton" OnClick="ConfirmButton_Click" Text="Yes" />
                        <asp:Button ID="deleteCancel" runat="server" Height="32px" Width="90px" CssClass="findButton" OnClick="CancelButton_Click" Text="No" />
                    </div>
                </div>
            </div>
        </main>
    </form>
</body>
</html>
