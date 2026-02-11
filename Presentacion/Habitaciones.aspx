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
            <h2>Agregar habitaciones</h2>
        <asp:Label ID="lblNumero" runat="server" Text="Numero de la habitacion"></asp:Label><br />
        <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox><br />
		<asp:Label ID="lblDescripcion" runat="server" Text="Descripcion general"></asp:Label><br />
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox><br />
		<asp:Label ID="lblCant" runat="server" Text="Cantidad de huespedes permitidos"></asp:Label><br />
        <asp:TextBox ID="txtCant" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Height="26px" /> 
        </div>
        <hr />
        	<asp:GridView ID="dgvHabitaciones" runat="server"
				AutoGenerateColumns="false"
				BackColor="#CCCCCC"
				DataKeyNames="id_habitaciones"
                OnRowEditing="dgvHabitaciones_RowEditing" 
				OnRowUpdating="dgvHabitaciones_RowUpdating"
                DataCancelingEdit="dvgHabitaciones_RowCancelEditing"
                OnRowCancelingEdit="dgvHabitaciones_RowCancelingEdit" 
				OnRowDeleting="dgvHabitaciones_RowDeleting"  >
                <Columns>
                <asp:BoundField DataField="id_habitaciones" HeaderText="ID" />
                <asp:BoundField DataField="numero" HeaderText="Numero" />
                <asp:BoundField DataField="descripcion" HeaderText="Descripcion" DataFormatString="{0:C}" />
                <asp:BoundField DataField="cant_huespedes" HeaderText="Cantidad de Huespedes" />

                <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" EditText="Editar" />
                <asp:CommandField ShowDeleteButton="true" DeleteText="Eliminar" />
            </Columns>
			</asp:GridView>

    </form>
</body>
</html>
