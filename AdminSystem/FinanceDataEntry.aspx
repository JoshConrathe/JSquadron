<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FinanceDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title>AppointmentDataEntry</title>
    <style type="text/css">
        .auto-style1 {
            display: flex;
            align-items: center;
            margin-bottom: 10px;
            text-align: left;
        }
    </style>
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css"
        integrity="sha512-z3gLpd7yknf1YoNbCzqRKc4qyor8gaKU1qmn+CShxbuBusANI9QpRohGBreCFkKxLhei6S9CQXFEbbKuqLg0DA=="
        crossorigin="anonymous"
        referrerpolicy="no-referrer"
    />
    <script type="text/javascript">
        function formatCardNumber(input) {
            var value = input.value.replace(/\D/g, ''); // Remove all non-digit characters
            value = value.match(/.{1,4}/g); // Split into groups of 4 numbers
            if (value) {
                input.value = value.join(' '); // Join the groups with a space
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="grid-container">
            <header class="header">
                <div class="menu-icon">
                    <span> MENU</span>
                </div>
                <div class="header-right">
                    <a href=""><span>Account</span></a>
                </div>
            </header>
            <aside class="sidebar">
                <ul class="sidebar-list">
                    <li class="sidebar-list-item">
                        <a href="StaffList.aspx">Staff Registration</a>
                    </li>
                    <li class="sidebar-list-item">
                        <a href="PatientList.aspx">Patient Registration</a>
                    </li>
                    <li class="sidebar-list-item">
                        <a href="ApplicationViewer.aspx">Job Application </a>
                    </li>
                    <li class="sidebar-list-item">
                        <a href="AppointmentViewer.aspx">Appointment</a>
                    </li>
                    <li class="sidebar-list-item">
                        <a href="FinanceViewer.aspx">Payment</a>
                    </li>
                </ul>
            </aside>
            <main class="main-container">
                <div class="main-title">
                    <h2>Payments</h2>
                </div>
                <br />
                <div class="auto-style1">
                    <asp:Label ID="PatientName" runat="server" Text="Patient Name" height="19px" width="94px"></asp:Label>
                    <asp:TextBox ID="PatientId" placeholder="Insert Name of appointed patient" runat="server" style="margin-left: 127px" height="25px" width="412px"></asp:TextBox>
                    <asp:Label ID="lblPatientNameError" runat="server" ForeColor="Red"></asp:Label>
                </div>
                <br />
                <div class="auto-style1">
                    <asp:Label ID="AppointmentDate" runat="server" Text="Appointment Date" height="19px" width="94px"></asp:Label>
                    <asp:DropDownList ID="Date" placeholder="Leave Empty for Find" runat="server" style="margin-left: 127px" height="25px" width="412px"></asp:DropDownList>
                </div>
                <br />
                <div class="auto-style1">
                    <asp:Label ID="StaffId1" runat="server" Text="Doctor Name" height="19px" width="94px"></asp:Label>
                    <asp:TextBox ID="StaffId" placeholder="Name of your Doctor" runat="server" style="margin-left: 127px" height="25px" width="412px"></asp:TextBox>
                    <asp:Label ID="lblDoctorNameError" runat="server" ForeColor="Red"></asp:Label>
                </div>
                <br />
                <div class="auto-style1">
                    <asp:Label ID="RequiredMedicationID" runat="server" Text="Medication required?" height="19px" width="130px"></asp:Label>
                    <asp:DropDownList ID="RequiredMedication" runat="server" style="margin-left: 91px" placeholder="Leave empty for find" Height="25px" Width="412px" OnSelectedIndexChanged="RequiredMedication_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Text="" Value=""></asp:ListItem>
                        <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                        <asp:ListItem Text="No" Value="No"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="lblMedicationRequiredError" runat="server" ForeColor="Red"></asp:Label>
                </div>
                <br />
                <div class="auto-style1" id="MedicationRequiredDiv" style="display:none; margin-top:10px">
                    <asp:Label ID="Medication" runat="server" Text="Insert Medication Name" height="19px" width="120px"></asp:Label>
                    <asp:TextBox ID="RequiredMedication1" placeholder="Name of your Medication" runat="server" style="margin-left: 101px" height="25px" width="412px"></asp:TextBox>
                </div>
                <br />

                <asp:Label ID="Finance" runat="server" Text="Amount" height="19px" width="94px"></asp:Label>
    <asp:TextBox ID="Amount" placeholder="Leave Empty for Find" runat="server" style="margin-left: 127px" height="23px" width="412px"></asp:TextBox>
     <br />
   
             <br />
                <div class="auto-style1">
                    <asp:Label ID="CardNumber" runat="server" Text="Card Number" height="19px" width="94px"></asp:Label>
                    <asp:TextBox ID="Time" placeholder="16-digit card number" runat="server" style="margin-left: 127px" height="25px" width="412px" MaxLength="19" OnKeyUp="formatCardNumber(this)"></asp:TextBox>
                    <asp:Label ID="lblCardNumberError" runat="server" ForeColor="Red"></asp:Label>
                </div>

                <asp:Label ID="CardType1" runat="server" Text="Card Type" height="19px" width="94px"></asp:Label>
      <asp:DropDownList ID="PaymentMethod"  runat="server" Height="25px" style="margin-left: 127px; margin-bottom: 0px;" Width="412px">
      <asp:ListItem>Visa</asp:ListItem>
       <asp:ListItem>Visa Electron</asp:ListItem>
       <asp:ListItem>Mastercard</asp:ListItem>
       <asp:ListItem>Maestro</asp:ListItem>
      </asp:DropDownList>

             <br />
             <br />
                <br />
                <div class="auto-style1">
                    <asp:Label ID="CVV" runat="server" Text="CVV" height="19px" width="94px"></asp:Label>
                    <asp:TextBox ID="CardCVV" placeholder="Card CVV" runat="server" style="margin-left: 127px" height="25px" width="412px" MaxLength="4"></asp:TextBox>
                    <asp:Label ID="lblCVVError" runat="server" ForeColor="Red"></asp:Label>
                </div>
                <br />
                <div class="auto-style1">
                    <asp:Label ID="Resident" runat="server" Text="Current UK Resident?" height="19px" width="130px"></asp:Label>
                    <asp:DropDownList ID="Resident1" runat="server" style="margin-left: 91px" placeholder="Leave empty for find" Height="25px" Width="412px">
                        <asp:ListItem Text="" Value=""></asp:ListItem>
                        <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                        <asp:ListItem Text="No" Value="No"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="lblUkResidentError" runat="server" ForeColor="Red"></asp:Label>
                </div>
                <br />
                <div class="auto-style1" style="margin-top: 20px">
                    <asp:Button ID="PayNow" runat="server" style="margin-right: 20px" OnClick="PayNowButtonClick" Text="Pay Now" />
                    <asp:Button ID="DeleteCancel" runat="server" style="margin-right: 20px" OnClick="selectButtonClick" Text="Cancel" />
                    <asp:Button ID="Edit" runat="server" style="margin-right: 20px" OnClick="selectButtonClick" Text="Edit" />
                    <asp:Button ID="Find" runat="server" style="margin-right: 20px" OnClick="selectButtonClick" Text="Find" />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Statistics" />
                </div>
                <asp:Label ID="SuccessMessage" runat="server" Text="Payment Successful! Thank you for your payment." ForeColor="Green" Style="display:none; margin-top:50px;" />
                <script type="text/javascript">
                    function showSuccessMessage() {
                        var successMessage = document.getElementById('<%= SuccessMessage.ClientID %>');
                        successMessage.style.display = "block";
                    }
                </script>
                <script type="text/javascript">
                    function toggleMedicationRequired() {
                        var requiredMedication = document.getElementById('<%= RequiredMedication.ClientID %>');
                        var medicationRequiredDiv = document.getElementById('MedicationRequiredDiv');
                        if (requiredMedication.value === 'Yes') {
                            medicationRequiredDiv.style.display = 'flex';
                        } else {
                            medicationRequiredDiv.style.display = 'none';
                        }
                    }
                </script>
            </main>
        </div>
    </form>
</body>
</html>
