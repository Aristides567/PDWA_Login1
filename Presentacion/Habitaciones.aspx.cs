using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        CNHabitaciones habitaciones = new CNHabitaciones();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();

            }
        }

        protected void CargarGrid()
        {
            dgvHabitaciones.DataSource = habitaciones.ObtenerHabitacionesN();
            dgvHabitaciones.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string descripcion = txtDescripcion.Text;
            int cantidad = Convert.ToInt32(txtCant.Text);

            bool correcto = habitaciones.AgregarHabitacionesN(numero, descripcion, cantidad);
            if (correcto)
            {
                Response.Write("<script>alert('Habitación agregada correctamente');</script>");
                CargarGrid();

            }
            else
            {
                Response.Write("<script>alert('Error al agregar la habitación');</script>");
            }
        }

        protected void dgvHabitaciones_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dgvHabitaciones.EditIndex = e.NewEditIndex;
            CargarGrid();
        }

        protected void dgvHabitaciones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgvHabitaciones.EditIndex = -1;
            CargarGrid();
        }

        protected void dgvHabitaciones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(dgvHabitaciones.DataKeys[e.RowIndex].Value);
            if (habitaciones.EliminarHabitaciones(id))
            {
                CargarGrid();
                Response.Write("<script>alert('Habitación eliminada correctamente');</script>");
                CargarGrid();
            }
            else
            {
                Response.Write("<script>alert('Error al eliminar la habitación');</script>");
            }
        }

        protected void dgvHabitaciones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(dgvHabitaciones.DataKeys[e.RowIndex].Value);

            GridViewRow row = dgvHabitaciones.Rows[e.RowIndex];

            int numero = int.Parse((row.Cells[1].Controls[0] as System.Web.UI.WebControls.TextBox).Text);
            string descripcion = (row.Cells[2].Controls[0] as System.Web.UI.WebControls.TextBox).Text;
            int cantidad = int.Parse((row.Cells[3].Controls[0] as System.Web.UI.WebControls.TextBox).Text);

            if (habitaciones.ModifcarHabtiaciones(id, numero, descripcion, cantidad))
            {
                dgvHabitaciones.EditIndex = -1;
                CargarGrid();
                Response.Write("<script>alert('Habitación modificada correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al modificar la habitación');</script>");
            }
        }
    }
}