using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Representa los temas de aprendizaje para los usuarios.
    /// Para cada tema se tiene un identificador, el nombre del tema en español, el nombre del tema en inglés.
    /// </summary>
   public class Tema
    {
        public int IdTema { get; set; }
        public String NombreTraduccion { get; set; }
        public String NombreIngles { get; set; }
        public String ContenidoTraduccion { get; set; }
        public String ContenidoIngles { get; set; }
        public int Dificultad { get; set; }
    }
}
