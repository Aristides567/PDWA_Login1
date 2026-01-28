<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="Content/styles.css" 
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Iniciar Sesión</h2>
            
            <div class="form-group">
                <label for="txtUsuario" class="required">Usuario:</label>
                <asp:TextBox ID="txtUsuario" runat="server" 
                    CssClass="form-control" 
                    placeholder="Ingrese su usuario"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label for="txtClave" class="required">Contraseña:</label>
                <asp:TextBox ID="txtClave" runat="server" 
                    TextMode="Password" 
                    CssClass="form-control" 
                    placeholder="Ingrese su contraseña"></asp:TextBox>
            </div>
            
            <asp:Button ID="btnLogin" runat="server" 
                Text="Ingresar al Sistema" 
                OnClick="btnLogin_Click" 
                CssClass="btn-login" />
            
            <asp:Label ID="lblMensaje" runat="server" 
                CssClass="mensaje-error" 
                Visible="false"
                EnableViewState="false"></asp:Label>
        </div>
    </form>
</body>
</html>
