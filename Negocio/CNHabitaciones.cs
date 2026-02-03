using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CNHabitaciones
    {
        CDHabitaciones CDHabitaciones = new CDHabitaciones();

        public DataTable ObtenerHabitacionesN()
        {
            return CDHabitaciones.ObtenerHabitaciones();
        }
    }
}
