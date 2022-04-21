<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VISTAS.Login" %>

<!DOCTYPE html>

<html style="background: black;"  xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">

   <!-- Standard Meta -->
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

        <!-- Site Properties -->

    <title>Acceso al sistema de Tickets</title>

     <!-- Stylesheets -->

   <%-- <link href="//maxcdn.bootstrapcdn.com/3.2.0./css/bootstrap.min.css" rel="stylesheet" type="text/css"/>--%>
    <link href="//cndjs.cloudflare.com/ajax/libs/font-awesome/4.1.0/css/font-awesome.min.css"  rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"/>
     <link href="css/login.css" rel="stylesheet" />
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />

  

</head>
<body style="background: #ffffff00;">
    
    <iframe id="background-video" src="https://www.youtube.com/embed/74FR5rzIV-I?controls=0&amp;showinfo=0&amp;rel=0&amp;autoplay=1&amp;mute=1&amp;loop=1&amp;playlist=74FR5rzIV-I" frameborder="0" allowfullscreen="" auto=""></iframe>
   <%-- <div class="form-box" id="login">
        
       <div class="header">Iniciar Sesión</div>--%>
<div class="jumbotron loginbox">
    <form id="form1" runat="server">
        <div class="panel panel-default">
            <div class="panel-heading text-center">
                <br >
                <img src="img/logo png_Mesa de trabajo 1.png" alt="" width="140" height="75"/>
                <br />
                <br>
                 <FONT FACE="Georgia"><p style="color:#ffffff";>TICKETS</p></FONT>
                  <FONT FACE="Georgia"><p style="color:#ffffff";>COORDINADORA DE TANQUES S.A.S.</p></FONT>

                <h4><asp:Label ID="lblempresa" runat="server"></asp:Label></h4>
            </div>
            <div class="panel-body">

                <FONT FACE="Georgia"><h4>Usuario:</h4></FONT>
                <asp:TextBox ID="txtuser" placeholder="usuario" CssClass="form-control" runat="server" MaxLength="10" OnTextChanged="txtuser_TextChanged" ></asp:TextBox>
                <br>
                <FONT FACE="Georgia"><h4>Contraseña:</h4></FONT>
                <asp:TextBox ID="txtpass" type="password" placeholder="Password" CssClass="form-control" runat="server" TextMode="Password" ></asp:TextBox><br/>
                           
                            <asp:Label ID="lblmensaje" runat="server" ForeColor="Red"></asp:Label>
                <br>
                <div class="text-center">
                        <asp:Button ID="btnIngresar" runat="server" CssClass="btn btn-primary" Text="Ingresar" OnClick="btnIngresar_Click"/>
                </div>
                <h5><asp:Label ID="lbErrores" runat="server" ForeColor="Red"></asp:Label></h5>
            </div>
            <div class="panel-footer">
                
                <h6> © Todos los derechos reservados </h6>
                 
            </div>
        </div>
       

         </form>
     
   
 </div>       
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</body>
</html>

