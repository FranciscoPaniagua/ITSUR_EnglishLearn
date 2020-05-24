using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Representa la relación de las preguntas que existen en cada tema.
    /// Los atributos necesarios para representar la relación, son el identificador de la pregunta, y el identificador del tema.
    /// </summary>
    public class PreguntaPorTema
    {
        public int IdPregunta { get; set; }
        public int IdTema { get; set; }
    }
}
