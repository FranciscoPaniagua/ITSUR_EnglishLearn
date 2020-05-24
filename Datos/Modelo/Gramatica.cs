using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Representa la estructura de las gramáticas almacenadas en la base de datos. 
    /// Tiene como atributos el identificador de la gramática, el sujeto que se utiliza para la gramática, el tiempo en el que está el verbo,
    /// el complemento que puede ser utilizado para esa gramática, y el tipo.
    /// </summary>
   public class Gramatica
    {
        public int IdGramatica { get; set; }
        public string Formula { get; set; }
        public string Voz { get; set; }
        public Boolean TerceraPersona { get; set; }
        public String Tipo { get; set; }
    }
}
