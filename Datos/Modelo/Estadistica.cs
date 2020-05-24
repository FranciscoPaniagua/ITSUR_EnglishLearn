using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Permite crear las estadísticas del usuario, de manera que se muestre el nivel que tiene el usuario desde la fecha que inició hasta la actualidad.
    /// Se tienen los atributos: 
    /// Identificador de la estadistica por usuario, nombre de usuario a quien pertenece la estaddistica, fecha de inicio del usuario en el sitio, nivel actual de aprendizaje del usuario.
    /// </summary>
   public class Estadistica
    {
        public int IdEstadistica { get; set; }
        public string User { get; set; }
        public DateTime FechaInicio { get; set; }
        public int Nivel { get; set; }

        /// <summary>
        /// Obtiene la fecha en que el usuario inicio el proceso de aprendizaje.
        /// </summary>
        /// <returns>Fecha en formato aceptable por mySQL.</returns>
        public string getFechaFormatoSQL()
        {
            return FechaInicio.Year + "-" + FechaInicio.Month + "-" + FechaInicio.Day;
        }
        
    }
}
