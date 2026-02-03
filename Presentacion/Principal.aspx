<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Presentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Bienvenido</h1>
            <h3>Usuario: <asp:Label ID="lblUsuario" runat="server"></asp:Label>
			</h3>
            <asp:Button ID="btnOut" runat="server" OnClick="btnOut_Click" Text="Cerrar Sesion" />
        	
        	<asp:Button ID="btnHabitaciones" runat="server" OnClick="btnHabitaciones_Click" Text="Habitaciones" />
        	
        </div>
    </form>
</body>
</html>
