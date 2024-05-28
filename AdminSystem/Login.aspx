<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Login</title>
    <link href="Login.css" rel="stylesheet"  />
     <link
    rel="stylesheet"
    href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css"
    integrity="sha512-z3gLpd7yknf1YoNbCzqRKc4qyor8gaKU1qmn+CShxbuBusANI9QpRohGBreCFkKxLhei6S9CQXFEbbKuqLg0DA=="
    crossorigin="anonymous"
    referrerpolicy="no-referrer"
  />
    <style>
        body {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    outline: none;
    border: none;
    text-decoration: none;
    text-transform: capitalize;
    transition: 0.2s ease;
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}

html {
    font-size: 12px;
    overflow-x: hidden;
    scroll-padding: 9rem;
    scroll-behavior: smooth;
}

body {
    background-color: black;
}

a {
    text-decoration: none;
    color: white;
}

.Login {
    margin-top: 4%;
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
    width: 100%;
    background-color: black;
}

.form-box {
    margin-top: 0px;
    position: relative;
    width: 400px;
    height: 450px;
    background: transparent;
    border: 2px solid #fff;
    border-radius: 20px;
    backdrop-filter: blur(5px);
    display: grid;
    justify-content: center;
    align-items: center;
}

h2 {
    font-size: 2em;
    color: #fff;
    text-align: center;
}

.inputbox {
    position: relative;
    margin: 30px 0;
    width: 310px;
    border-bottom: 2px solid #fff;
}

    .inputbox label {
        position: absolute;
        top: 50%;
        left: 5px;
        transform: translateY(-50%);
        color: #fff;
        font-size: 1em;
        pointer-events: none;
        transition: 0.5s;
        margin-top: 20px;
    }

input:focus ~ label,
input:valid ~ Password {
    top: -5px;
}

.inputbox input {
    width: 100%;
    height: 50px;
    background: transparent;
    border: none;
    outline: none;
    font-size: 20px;
    padding: 0 35px 0 5px;
    color: #fff;
    height: 60px;
}

.inputbox i {
    position: absolute;
    right: 8px;
    color: #fff;
    font-size: 1.2em;
    top: 20px;
    cursor: pointer;
}

button {
    width: 100%;
    height: 40px;
    border-radius: 40px;
    background: #fff;
    border: none;
    outline: none;
    cursor: pointer;
    font-size: 1em;
    font-weight: 600;
    margin-top: 15px;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
          <div>
       <section class="Login">

           <div class="form-box">

               <div class="form-value">
                   <formview action="">
                       <h2>Login Details</h2>
                       <div class="inputbox">
                           <i class="fa-solid fa-user"></i>
                           <asp:TextBox ID= "ID" runat="server"></asp:TextBox>
                           <label for="" >User ID</label>
                       </div>
                       <div class="inputbox">
                           <i class="fa-solid fa-lock"></i>
                          <asp:TextBox ID= "PASS" runat="server"></asp:TextBox>
                           <label for="" class="Password">Password</label>                                 
                       </div>
                       <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" Width="267px"> </asp:Button>
       </section>
   </div>
    </form>
</body>
</html>
