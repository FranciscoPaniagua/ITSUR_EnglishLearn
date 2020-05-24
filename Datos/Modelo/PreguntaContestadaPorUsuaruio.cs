using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Representa la relación entre las preguntas que el usuario contestó y si contestó de manera correcta o incorrecta.
    /// </summary>
   public class PreguntaContestadaPorUsuaruio
    {
        public String User { get; set; }
        public int IdPregunta { get; set; }
        public String  Contesto { get; set; }
    }
}
