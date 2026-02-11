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

        public bool AgregarHabitacionesN(int numero, string descripcion, int cantidad)
        {
            return CDHabitaciones.AgregarHabitaciones(numero, descripcion, cantidad);
        }

        public bool ModifcarHabtiaciones(int id, int numero, string descripcion, int cantidad)
        {
            return CDHabitaciones.ModificarHabitaciones(id, numero, descripcion, cantidad);
        }

        public bool EliminarHabitaciones(int id)
        {
            return CDHabitaciones.EliminarHabitaciones(id);
        }
    }
}
