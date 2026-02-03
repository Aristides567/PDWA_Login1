<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Habitaciones.aspx.cs" Inherits="Presentacion.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:GridView ID="dgvHabitaciones" runat="server" AutoGenerateColumns="false">
                <Columns>
                <asp:BoundField DataField="id_habitaciones" HeaderText="ID" />
                <asp:BoundField DataField="numero" HeaderText="Numero" />
                <asp:BoundField DataField="descripcion" HeaderText="Descripcion" DataFormatString="{0:C}" />
                <asp:BoundField DataField="cant_huespedes" HeaderText="Cantidad de Huespedes" />
            </Columns>
			</asp:GridView>
        </div>
    </form>
</body>
</html>
