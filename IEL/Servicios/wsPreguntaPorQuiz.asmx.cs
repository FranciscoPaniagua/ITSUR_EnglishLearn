using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Datos.Daos;
using Datos.Modelo;
using Newtonsoft.Json;
namespace IEL.Servicios
{
    /// <summary>
    /// Summary description for wsPreguntaPorQuiz
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsPreguntaPorQuiz : System.Web.Services.WebService
    {
        /// <summary>
        /// Obtine todos los registros de la tabla preguntaporquiz
        /// </summary>
        /// <returns>Retorna una cadena con todos los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            PreguntaPorQuizDAO dao = new PreguntaPorQuizDAO();
            List<PreguntaPorQuiz> lista = dao.getAll();
            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Obtiene un registro de la tabla preguntaquiz
        /// </summary>
        /// <param name="IdPreguntaQuiz">id de la preguntaquiz</param>
        /// <returns>Retorna una cadena con el registro en formato json</returns>
        [WebMethod]
        public String getPreguntaPorQuizByID(int IdPreguntaQuiz)
        {
            PreguntaPorQuizDAO dao = new PreguntaPorQuizDAO();
            PreguntaPorQuiz res = dao.getPreguntaPorQuizByID(IdPreguntaQuiz);
            String strJSON;
            strJSON = JsonConvert.SerializeObject(res, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Inserta un registro en la tabla preguntaquiz
        /// </summary>
        /// <param name="idPregunta">id de la pregunta</param>
        /// <param name="idQuiz">id del quiz</param>
        /// <returns>Retorna si se inserto el registro correctamente</returns>
        [WebMethod]
        public bool insert(int idPregunta,int idQuiz)
        {
            bool result = false;
            PreguntaPorQuizDAO dao = new PreguntaPorQuizDAO();
            PreguntaPorQuiz obj = new PreguntaPorQuiz() {IdPregunta=idPregunta,IdQuiz=idQuiz};
            result = dao.insert(obj);
            return result;
        }

        /// <summary>
        /// Elimina un registro de la tabla preguntaquiz
        /// </summary>
        /// <param name="IdPreguntaQuiz">id de la preguntaquiz</param>
        /// <returns>Retorna si se elimino el registro correctamente</returns>
        [WebMethod]
        public bool delete(int IdPreguntaQuiz)
        {
            bool result = false;
            PreguntaPorQuizDAO dao = new PreguntaPorQuizDAO();
            //Verbo obj = new Verbo() { IdVerbo = IdVerbo, VerboTraduccion = VerboTraduccion, VerboPresenteSimple = VerboPresenteSimple, VerboPasadoSimple = VerboPasadoSimple, VerboPasadoParticipio = VerboPasadoParticipio };
            result = dao.delete(IdPreguntaQuiz);
            return result;
        }

        /// <summary>
        /// Actualiza un registro de la tabla preguntaquiz
        /// </summary>
        /// <param name="IdPreguntaQuiz"></param>
        /// <param name="idPregunta">id de la pregunta</param>
        /// <param name="idQuiz">id del quiz</param>
        /// <returns>Retorna si se actualizo el registro correctamente</returns>
        [WebMethod]
        public bool update(int IdPreguntaQuiz,int IdPregunta,int IdQuiz)
        {
            bool result = false;
            PreguntaPorQuizDAO dao = new PreguntaPorQuizDAO();
            PreguntaPorQuiz obj = new PreguntaPorQuiz() { IdPreguntaQuiz=IdPreguntaQuiz,IdPregunta=IdPregunta,IdQuiz=IdQuiz};
            result = dao.update(obj);
            return result;
        }
    }
}
