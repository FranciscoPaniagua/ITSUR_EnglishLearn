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
    /// Summary description for wsQuiz
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsQuiz : System.Web.Services.WebService
    {
        [WebMethod]
        public string getAllPreguntas()
        {
            QuizDAO dao = new QuizDAO();
            List<Pregunta> lista = dao.preguntas();
            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }


        /// <summary>
        /// Obtine todos los registros de la tabla quiz
        /// </summary>
        /// <returns>Retorna una cadena con los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            QuizDAO dao = new QuizDAO();
            List<Quiz> lista = dao.getAll();
            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Obtine un registro de la tabla quiz
        /// </summary>
        /// <param name="ID">Id del quiz</param>
        /// <returns>Retorna una cadena con el registro en formato json</returns>
        [WebMethod]
        public String getQuizByID(int ID)
        {
            QuizDAO dao = new QuizDAO();
            Quiz res = dao.getQuizByID(ID);
            String strJSON;
            strJSON = JsonConvert.SerializeObject(res, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Inserta un registro en la tabla quiz
        /// </summary>
        /// <param name="Nombre">nombre del quiz</param>
        /// <returns>Retorna si se inserto el registro correctamente</returns>
        [WebMethod]
        public bool insert(String Nombre)
        {
            bool result = false;
            QuizDAO dao = new QuizDAO();
            Quiz obj = new Quiz() { Nombre=Nombre};
            result = dao.insert(obj);
            return result;
        }

        [WebMethod]
        public bool insertPregunta(string User, int idPregunta, string Contesto)
        {
            bool result = false;
            PreguntaContestadaPorUsuaruioDAO dao = new PreguntaContestadaPorUsuaruioDAO();
            PreguntaContestadaPorUsuaruio obj = new PreguntaContestadaPorUsuaruio() { User = User, IdPregunta = idPregunta, Contesto = Contesto };
            result = dao.insert(obj);
            return result;
        }

        /// <summary>
        /// Elimina un registro de la tabla quiz
        /// </summary>
        /// <param name="idQuiz">Id del quiz</param>
        /// <returns>Retorna si se elimino el registro correctamente</returns>
        [WebMethod]
        public bool delete(int idQuiz)
        {
            bool result = false;
            QuizDAO dao = new QuizDAO();           
            result = dao.delete(idQuiz);
            return result;
        }

        /// <summary>
        /// Actualiza un registro de la tabla quiz
        /// </summary>
        /// <param name="idQuiz"></param>
        /// <param name="Nombre">nombre del quiz</param>
        /// <returns>Retorna si se actualizo el registro correctamente</returns>
        [WebMethod]
        public bool update(int idQuiz,String Nombre)
        {
            bool result = false;
            QuizDAO dao = new QuizDAO();
            Quiz obj = new Quiz() { idQuiz=idQuiz,Nombre=Nombre};
            result = dao.update(obj);
            return result;
        }
    }
}
