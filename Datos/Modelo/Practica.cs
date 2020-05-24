using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Representa las prácticas que puede realizar el usuario en el sitio.
    /// Tiene como atributos el identificador de la práctica, la cantidad de respuestas correctas del usuario, el tema al que pertenece, y el usuario que realizó la práctica.
    /// </summary>
   public class Practica
    {
        
        public int IdPractica { get; set; }
        public int Correctas { get; set; }
        public int IdTema { get; set; }
        public String User { get; set; }
    }
}
