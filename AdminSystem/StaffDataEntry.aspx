<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
                margin-left: 242px;
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
                z-index: 1;
                left: 180px;
                top: 619px;
                position: absolute;
                height: 128px;
                width: 618px;
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
                left: 17px;
                top: 575px;
                position: absolute;
                height: 29px;
                width: 130px;
            }
#Search{
    border-radius:3rem;
    text-align:center;
}
#ADD{
    border-radius:3rem;
}
#DELETE{
    border-radius:3rem;
}
#FIND{
    border-radius:3rem;
}
#Update{
    border-radius:3rem;
}


    </style>
</head>
<body>
    <form id="form1" runat="server">
                   <div class="container">
                <div class="header">
               <h1>Staff Information Form</h1>
                    </div>
               <div class="form-container">
  
                   <div class="input-group">
                       &nbsp;<asp:TextBox ID="txtStaffID" runat="server" Width="715px" placeholder="Staff ID" OnTextChanged="txtStaffID_TextChanged"></asp:TextBox>
            
        </div>
                   <div class="input-group">
                       <asp:TextBox ID="txtStaffName" runat="server" Width="715px" placeholder="Name"></asp:TextBox>
                   </div>
                   <div class="input-group">
                       <asp:TextBox ID="txtStaffPosition" runat="server" placeholder="Position" Width="715px"></asp:TextBox>
                   </div>
                   <div class="input-group">
                       <asp:TextBox ID="txtStaffNumber" runat="server" Width="715px" placeholder="ContactNumber"></asp:TextBox>
                   </div>
                   <div class="input-group">
                       <asp:TextBox ID="txtStaffSalary" runat="server" Width="715px"  placeholder="Salary"></asp:TextBox>
                   </div>
                   <div class="input-group">
                       <asp:TextBox ID="txtAdminID" runat="server" Width="715px" placeholder="AdminId" ></asp:TextBox>
                   </div>
                   <asp:Button runat="server" Text="Clear" OnClick="Unnamed1_Click" Width="101px"></asp:Button>
                   <asp:Button ID="ADD" runat="server" OnClick="Button1_Click" Text="Add" Width="190px" />
                   <asp:Button ID="DELETE" runat="server" OnClick="Button2_Click" Text="Delete" Width="190px" />
                   <asp:Button ID="Update" runat="server" Text="Update" Width="190px" OnClick="Button3_Click" />
                   <div>
                       <asp:Button runat="server" Text="Next Record" OnClick="Unnamed2_Click" Width="101px"></asp:Button>
                   </div>
                   <br />
                   <br />
                   <asp:Button ID="FIND" runat="server" Height="37px" Text="Find" Width="185px" OnClick="Button4_Click" />
      </div>
            
           
            <asp:Label ID="lblError" runat="server" Text="EROR"></asp:Label>
            
           
</div>

    </form>
</body>
</html>
