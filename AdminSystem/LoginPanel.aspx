<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPanel.aspx.cs" Inherits="LoginPanel" %>

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
                           <input type="text" required />
                           <label for="" >User ID</label>
                       </div>
                       <div class="inputbox">
                           <i class="fa-solid fa-lock"></i>
                           <input type="password" required />
                           <label for="" class="Password">Password</label>                                 
                       </div>
                       <button>Login</button>
       </section>
   </div>
    </form>
</body>
</html>
