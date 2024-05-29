<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Confirm Delete</title>
    <style>
        body{
            text-align:center;
            background-color:orange;
            color:black;
            font-size:20px;
        }
      #Button1,#Button2{
          background-color:orange;
          color:black;
       }
        #Button2:hover{
         background-color:black;
         color:white;
         }
         #Button1:hover{
         background-color:black;
         color:white;
           }

       

        #form1 {
            height: 379px;
            margin-top: 235px;
        }
       

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="lbl"">
            Are you Sure you want to delete this record ?

        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" height="26px" style="margin-left: 0px" Text="Yes" width="93px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 47px" Text="No" Width="93px"  />
        </p>
    </form>
</body>
</html>
