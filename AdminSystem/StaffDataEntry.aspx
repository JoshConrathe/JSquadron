<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
         <title>Staff Information Form</title>
        <style>


.container {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    height: 100vh;
    max-width: 1000px;
    margin: 0 auto;

}

.form-container {
    width: 100%;
    background-color: orange;
    padding: 20px;
    border-radius: 5px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                height: 975px;
            }

.input-group {
    display: flex;
    flex-direction: column;
    margin-bottom: 10px;
}

.input-group label {
    flex: 1;
}
h1{
    color:white;
}

.input-group input[type="text"],
.input-group input[type="date"] {
    padding: 8px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
                margin-left: 115px;
            }



input[type="submit"] {
        border-style: none;
            border-color: inherit;
            border-width: medium;
            padding: 10px;
            background-color: orange;
            color: black;
            cursor: pointer;
            border-radius: 4px;
            margin-left: 43px;
            margin-top: 3px;
        }

input[type="submit"]:hover {
    background-color: black;
    color:white;
}
#txtStaffID,#txtStaffName,#txtStaffPosition,#txtStaffSalary,#txtAdminID,#txtStaffNumber{
    border-radius:3rem;
                margin-left: 153px;
            }

.header-form{
    background-color:orange;
    margin-bottom:20px;
    border-radius:2rem;
    color:white;
    width:400px;
    font-size:14px;
    text-align:center;
                height: 51px;
                margin-top: 252px;
            }

#Search{
    border-radius:3rem;
    text-align:center;
}
#ADD,#DELETE,#FIND,#List,#DashBoard,#Clear{
    border-radius:3rem;
    border:2px solid black;
}

.label{
    color:black;
}

    </style>
        <link href="StyleSheet.css" rel="stylesheet" />
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
     <header class="header-menu">
     <div class="menu-icon">
     <span> MENU</span>
      </div>
     </header>
     <aside class="sidebar">
     <ul class="sidebar-list">
     <li class="sidebar-list-item" >
     <a href="StaffList.aspx">Staff Registration</a>
     </li>
       <li class="sidebar-list-item" >
       <a href="PatientList.aspx">Patient Registration</a>
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
           <li class="sidebar-list-item" >
   <a href="TeamMainMenu.aspx">Dashboard</a>
    </li>
        </ul>    
     </aside>
        <main class="main-container">
         <div class="main-title">
         <h2>Staff</h2>
        </div>
            <div class="container">
                <div class="header-form">
               <h1 style="color:white;">Staff Information Form</h1>
                    </div>
               <div class="form-container">
                   <div class="input-group">
                       &nbsp;<asp:Label class="label" ID="Label1" runat="server" Text="Staff ID :"></asp:Label>
                       <asp:TextBox ID="txtStaffID" runat="server" Width="831px" placeholder="Staff ID" OnTextChanged="txtStaffID_TextChanged"></asp:TextBox>
        </div>
                   <div class="input-group">
                       <asp:Label class="label" ID="Label2" runat="server" Text="Staff Name : "></asp:Label>
                       <asp:TextBox ID="txtStaffName" runat="server" Width="835px" placeholder="Name"></asp:TextBox>
                   </div>
                   <div class="input-group">
                       <asp:Label class="label" ID="Label3" runat="server" Text="Staff Position :"></asp:Label>
                         <asp:DropDownList ID="txtStaffPosition" runat="server" Width="848px" Height="38px">
                                <asp:ListItem Text="Select Position" Value="" />
                                <asp:ListItem Text="Doctor" Value="Manager" />
                                <asp:ListItem Text="Nurse" Value="Nurse" />
                                <asp:ListItem Text="Optometrist" Value="Optometrist" />
                                <asp:ListItem Text="Physical Therapist" Value="Physical Therapist" />
                                <asp:ListItem Text="Trauma Surgeon" Value="Trauma Surgeon" />
                            </asp:DropDownList>
                   </div>
                   <div class="input-group">
                       <asp:Label class="label" ID="Label4" runat="server" Text="Staff ContactNumber :"></asp:Label>
                       <asp:TextBox ID="txtStaffNumber" runat="server" Width="848px" placeholder="7*********"></asp:TextBox>
                   </div>
                   <div class="input-group">
                       <asp:Label class="label" ID="Label5" runat="server" Text="Staff Salary :"></asp:Label>
                       <asp:TextBox ID="txtStaffSalary" runat="server" Width="848px"  placeholder="Salary"></asp:TextBox>
                   </div>
                   <div class="input-group">
                       <asp:Label class="label" ID="Label6" runat="server" Text="Admin ID :"></asp:Label>
                       <asp:TextBox ID="txtAdminID" runat="server" Width="848px" placeholder="AdminId" ></asp:TextBox>

                       <asp:Label class="label" ID="lblError" runat="server" Text="EROR"></asp:Label>
                   </div>
                   <asp:Button ID="Clear" runat="server" Text="Clear" OnClick="Unnamed1_Click" Width="101px"></asp:Button>
                   <asp:Button ID="ADD" runat="server" OnClick="Button1_Click" Text="OK" Width="100px" />
                   <asp:Button ID="List" runat="server" Text="List" OnClick="Unnamed2_Click" Width="101px"></asp:Button>
                   <asp:Button ID="DashBoard" runat="server" OnClick="Button1_Click1" Text="DashBoard" Width="144px" />
                   <asp:Button ID="FIND" runat="server" Height="49px" Text="Find" Width="144px" OnClick="Button4_Click" />
                   <br />
                   <br />
                   <br />
                   <br />
                   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" DataKeyNames="StaffId" DataSourceID="SqlDataSource1" style="margin-left: 0px" Width="949px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
    <Columns>
        <asp:BoundField DataField="StaffId" HeaderText="StaffId" InsertVisible="False" ReadOnly="True" SortExpression="StaffId" />
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="Position" HeaderText="Position" SortExpression="Position" />
        <asp:BoundField DataField="ContactNumber" HeaderText="ContactNumber" SortExpression="ContactNumber" />
        <asp:TemplateField HeaderText="Salary">
            <ItemTemplate>
                <asp:Literal ID="litSalary" runat="server" Text='<%# string.Format("{0:C}", Eval("Salary")) %>'></asp:Literal>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="AdminId" HeaderText="AdminId" SortExpression="AdminId" />
    </Columns>
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
      </div>
      </div>
            </main>
      </div>
                 
                
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:p2729217ConnectionString %>" SelectCommand="SELECT * FROM [Staff]"></asp:SqlDataSource>
                
    </form>
</body>
</html>
