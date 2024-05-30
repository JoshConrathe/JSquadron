<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
     <title>Patient Information Form</title>
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
}

.input-group {
    display: flex;
    flex-direction: column;
    margin-bottom: 10px;
}

.input-group label {
    flex: 1;
}

.input-group input[type="text"],
.input-group input[type="date"] {
    padding: 8px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
                margin-left: 91px;
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
            margin-left: 41px;
            margin-top: 8px;
        }

input[type="submit"]:hover {
    background-color: black;
    color:white;
}
#txtPatientID,#txtPatientName,#txtPatientDBO,#txtPatientNumber,#txtPatientHistory,#txtPatientAddress,#txtAdminID{
    border-radius:3rem;
                margin-left: 117px;
            }
#GridView1{
    margin-left:61px;
    margin-bottom:100px;
    
}
.header-form{
    background-color:orange;
    margin-bottom:20px;
    border-radius:2rem;
    color:black;
    width:400px;
    font-size:14px;
    text-align:center;
}

#Search{
    border-radius:3rem;
    text-align:center;
}
#Button1,#Button2, #Button3, #Button4, #Button5,#Clear{
    border-radius:3rem;
    border:2px solid black;
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
        <div class="container">
                <div class="header-form">
               <h1>Patient Information Form</h1>
                    </div>
               <div class="form-container">
  
                   <div class="input-group">
                       <asp:Label ID="Label1" runat="server" Text="Patient ID :"></asp:Label>
                       <label for="patient_id"><asp:TextBox ID="txtPatientID" runat="server" Width="715px" placeholder="Patient ID"></asp:TextBox></label>
            
        </div>
       
        <div class="input-group">
            <asp:Label ID="Label2" runat="server" Text="Patient Name :"></asp:Label>
           <asp:TextBox ID="txtPatientName" runat="server" Width="715px" placeholder="Name"></asp:TextBox>
            
        </div>
       
        <div class="input-group">
            
            <asp:Label ID="Label3" runat="server" Text="Patient Date :"></asp:Label>
            
            <asp:TextBox ID="txtPatientDBO" runat="server" placeholder="Date" Width="715px"></asp:TextBox>

        </div>
       
        <div class="input-group">
            <asp:Label ID="Label4" runat="server" Text="Patient Number :"></asp:Label>
           <asp:TextBox ID="txtPatientNumber" runat="server" Width="712px" placeholder="PhoneNumber" height="34px" TextMode="Number"></asp:TextBox>
            
        </div>
       
        <div class="input-group">
           
            <asp:Label ID="Label5" runat="server" Text="Post Code :"></asp:Label>
           
    <asp:TextBox ID="txtPatientAddress" runat="server" Width="715px" placeholder="Address"></asp:TextBox>
            
        </div>
       
        <div class="input-group">
          
            <asp:Label ID="Label6" runat="server" Text="Patient History :"></asp:Label>
          
            <asp:TextBox ID="txtPatientHistory" runat="server" Width="715px" placeholder="History"></asp:TextBox>
        </div>
       
        <div class="input-group">
            
            <asp:Label ID="Label7" runat="server" Text="Admin ID :"></asp:Label>
            
    <asp:TextBox ID="txtAdminID" runat="server" Width="715px" placeholder="AdminId" ></asp:TextBox>
            
           
            <asp:Label ID="lblError" runat="server" Text="EROR"></asp:Label>
            
           
        </div>
                    <asp:Button ID="Clear"  runat="server" Text="Clear" OnClick="Unnamed1_Click" Width="101px"></asp:Button>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" Width="190px" />
                   <asp:Button ID="Button3" runat="server" Text="List" OnClick="Unnamed2_Click" Width="101px"></asp:Button>
                   <asp:Button ID="Button4" runat="server" Height="37px" Text="Find" Width="185px" OnClick="Button4_Click" />
                   <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Dashboard" Width="185px" />
         <div>
        </div>
        <br />
        <br />
     
      </div>
</div>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PatientID" DataSourceID="SqlDataSource2" Width="952px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateSelectButton="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
        <Columns>
            <asp:BoundField DataField="PatientID" HeaderText="PatientID" ReadOnly="True" SortExpression="PatientID" InsertVisible="False" />
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="PatientDate" HeaderText="PatientDate" SortExpression="PatientDate" />
            <asp:BoundField DataField="number" HeaderText="number" SortExpression="number" />
            <asp:BoundField DataField="PostCode" HeaderText="PostCode" SortExpression="PostCode" />
            <asp:BoundField DataField="medhistory" HeaderText="medhistory" SortExpression="medhistory" />
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
         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Patient]"></asp:SqlDataSource>
      </main>
        </div>       
    </form>
</body>
</html>
