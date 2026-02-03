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
    }
}