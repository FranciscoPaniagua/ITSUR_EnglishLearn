using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Representa un verbo en su forma infinitiva y en todos los tiempos.
    /// Como atributos se tiene el identificador del verbo, el verbo en idioma español, el verbo en pasado simple y el verbo en pasado participio.
    /// </summary>
   public class Verbo
    {
        public int IdVerbo { get; set; }
        public String VerboTraduccion { get; set; }
        public String VerboPresenteSimple { get; set; }
        public String VerboPasadoSimple { get; set; }
        public String VerboPasadoParticipio { get; set; }

    }
}
