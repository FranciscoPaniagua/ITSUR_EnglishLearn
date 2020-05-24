using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Se tiene los atributos básicos que identifican a cada quiz, como su identificador y el nombre.
    /// </summary>
   public class Quiz
    {
        public int idQuiz { get; set; }
        public String Nombre { get; set; }
    }
}
