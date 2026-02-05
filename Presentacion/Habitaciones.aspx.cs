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
            if(!IsPostBack)
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
            if(correcto)
            {
                Response.Write("<script>alert('Habitación agregada correctamente');</script>");
                CargarGrid();

            }
            else 
            {
                Response.Write("<script>alert('Error al agregar la habitación');</script>");
            }        
        }


    }
}