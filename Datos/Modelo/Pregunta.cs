using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Representa la estructura de una pregunta.
    /// Contiene un identificador de la pregunta, la respuesta correcta y tres respuestas incorrectas. 
    /// </summary>
   public class Pregunta
    {
        public int idPregunta { get; set; }
        public String pregunta { get; set; }
        public String RespuestaCorrecta { get; set; }
        public String RespuestaIncorrecta1 { get; set; }
        public String RespuestaIncorrecta2 { get; set; }
        public String RespuestaIncorrecta3 { get; set; }
    }
}
