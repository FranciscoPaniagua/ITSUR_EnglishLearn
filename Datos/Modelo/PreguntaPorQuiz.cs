using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{    
    /// <summary>
    /// Representa la relación de las preguntas que pertenecen a cada quiz. 
    /// Como atributos se tienen el id de la pregunta del quiz, el id de la pregunta, y el id del quiz.
    /// 
    /// </summary>
   public class PreguntaPorQuiz
    {        
        public int IdPreguntaQuiz { get; set; }
        public int IdPregunta { get; set; }
        public int IdQuiz { get; set; }
    }
}
