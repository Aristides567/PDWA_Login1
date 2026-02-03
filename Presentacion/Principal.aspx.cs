using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["usuario"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                lblUsuario.Text = Session["usuario"].ToString();
            }
        }

        protected void btnOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("index.aspx");
        }

        protected void btnHabitaciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("Habitaciones.aspx");
        }
    }
}