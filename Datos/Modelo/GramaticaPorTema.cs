using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Representa la relación de las gramáticas que puede tener cada tema. 
    /// Se representa con el identificador del tema y el identificador de la gramática.
    /// </summary>
  public  class GramaticaPorTema
    {
        public int IdTema { get; set; }
        public int IdGramatica { get; set; }
    }
}
