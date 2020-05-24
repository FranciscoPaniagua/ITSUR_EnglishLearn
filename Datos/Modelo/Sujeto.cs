using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Representa cada uno de los sujetos gramaticales.
    /// Cada registro cuenta con un identificador del sujeto, el sujeto en idioma español, el sujeto en idioma inglés,
    /// el objeto correspondiente al sujeto, el posesivo correspondiente al sujeto y el sucesivo correspondiente al sujeto.
    /// </summary>
  public  class Sujeto
    {
        public int IdSujeto { get; set; }
        public String SujetoTraducido { get; set; }
        public String sujeto { get; set; }
        public String Objeto { get; set; }
        public String Posesivo { get; set; }
        public String Sucesivo { get; set; }
        public string ser { get; set; }
    }
}
