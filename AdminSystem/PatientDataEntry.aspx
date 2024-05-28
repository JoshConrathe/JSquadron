<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Patient Information Form</title>
        <style>

body {
    font-family: Arial, sans-serif;
    background-color: #f0f0f0;
    margin: 0;
    padding: 0;
    
}

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
    background-color: #1C5E55;
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
                margin-left: 89px;
            }



input[type="submit"] {
        border-style: none;
            border-color: inherit;
            border-width: medium;
            padding: 10px;
            background-color: #4CAF50;
            color: white;
            cursor: pointer;
            border-radius: 4px;
            margin-left: 41px;
            margin-top: 8px;
        }

input[type="submit"]:hover {
    background-color: #45a049;
}
#PatientID{
    border-radius:3rem;
}
#PatientName{
    border-radius:3rem;
}
#PatientDBO{
    border-radius:3rem;
}
#PatientNumber{
    border-radius:3rem;
}
#PatientAddress{
    border-radius:3rem;
}
#PatientHistory{
    border-radius:3rem;
}
#AdminID{
    border-radius:3rem;
}
#GridView1{
    margin-left:200px;
    margin-bottom:100px;
    
}
.header{
    background-color:#1C5E55;
    margin-bottom:20px;
    border-radius:2rem;
    color:#fff;
    width:400px;
    font-size:14px;
    text-align:center;
}
span{
    color:black;
                z-index: 1;
                left: 12px;
                top: 676px;
                position: absolute;
                height: 29px;
                width: 130px;
            }
#Search{
    border-radius:3rem;
    text-align:center;
}
#Button1{
    border-radius:3rem;
}
#Button2{
    border-radius:3rem;
}
#Button3{
    border-radius:3rem;
}
#Button4{
    border-radius:3rem;
}


    </style>
</head>
<body>
    <form id="form1" runat="server">
               <div class="container">
                    <div class="header">
                   <h1>Patient Information Form</h1>
                        </div>
                   <div class="form-container">
      
                       <div class="input-group">
                           <label for="patient_id"><asp:TextBox ID="txtPatientID" runat="server" Width="715px" placeholder="Patient ID"></asp:TextBox></label>
                
            </div>
           
            <div class="input-group">
               <asp:TextBox ID="txtPatientName" runat="server" Width="715px" placeholder="Name"></asp:TextBox>
                
            </div>
           
            <div class="input-group">
                
                <asp:TextBox ID="txtPatientDBO" runat="server" placeholder="Date" Width="715px"></asp:TextBox>

            </div>
           
            <div class="input-group">
               <asp:TextBox ID="txtPatientNumber" runat="server" Width="715px" placeholder="PhoneNumber"></asp:TextBox>
                
            </div>
           
            <div class="input-group">
               
        <asp:TextBox ID="txtPatientAddress" runat="server" Width="715px" placeholder="Address"></asp:TextBox>
                
            </div>
           
            <div class="input-group">
              
                <asp:TextBox ID="txtPatientHistory" runat="server" Width="715px" placeholder="History"></asp:TextBox>
            </div>
           
            <div class="input-group">
                
        <asp:TextBox ID="txtAdminID" runat="server" Width="715px" placeholder="AdminId" ></asp:TextBox>
                
               
                <asp:Label ID="lblError" runat="server" Text="EROR"></asp:Label>
                
               
            </div>
        <asp:Button runat="server" Text="Clear" OnClick="Unnamed1_Click" Width="101px"></asp:Button>
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="190px" />
           
            
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" Width="190px" />  <asp:Button ID="Button3" runat="server" Text="Update" Width="190px" OnClick="Button3_Click" />
             <div>
      <asp:Button runat="server" Text="Next Record" OnClick="Unnamed2_Click" Width="101px"></asp:Button>
            </div>
            <br />
            <br />
         
     <asp:Button ID="Button4" runat="server" Height="37px" Text="Find" Width="185px" OnClick="Button4_Click" />
          </div>
    </div>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PatientID" DataSourceID="SqlDataSource1" Width="952px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateSelectButton="True">
            <Columns>
                <asp:BoundField DataField="PatientID" HeaderText="PatientID" ReadOnly="True" SortExpression="PatientID" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="number" HeaderText="number" SortExpression="number" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="medhistory" HeaderText="medhistory" SortExpression="medhistory" />
                <asp:BoundField DataField="AdminId" HeaderText="AdminId" SortExpression="AdminId" />
            </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Patient]"></asp:SqlDataSource>

    </form>
</body>
</html>
