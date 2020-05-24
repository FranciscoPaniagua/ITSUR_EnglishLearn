using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Datos.Daos;
using Newtonsoft.Json;

using Datos.Modelo;
namespace IEL.Servicios
{
    /// <summary>
    /// Summary description for wsPreguntaContestadaPorUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    //To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class wsPreguntaContestadaPorUsuario : System.Web.Services.WebService
    {
        /// <summary>
        /// Obtine todos los registros de la preguntascontestadosporusuario
        /// </summary>
        /// <returns>Retorna una cadena con todos los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            return "Hello World";
        }

        /// <summary>
        /// Obtine un registro de la tabla preguntascontestadosporusuario
        /// </summary>
        /// <param name="id">id de preguntascontestadosporusuario</param>
        /// <returns>Retorna un a cadena con el registro en formato json</returns>
        [WebMethod]
        public string getByID(int id)
        {
            return "";
        }

        /// <summary>
        /// Inserta un registro de la tabla preguntascontestadosporusuario
        /// </summary>
        /// <param name="idTema">id del tema</param>
        /// <param name="idGramtica">id de la gramatica</param>
        /// <returns>Retorna si se inserto el registro correctamente</returns>
        [WebMethod]
        public bool insert(string User,int idPregunta, string Contesto)
        {
            bool result = false;
            PreguntaContestadaPorUsuaruioDAO dao = new PreguntaContestadaPorUsuaruioDAO();
            PreguntaContestadaPorUsuaruio obj = new PreguntaContestadaPorUsuaruio() { User=User,IdPregunta=idPregunta,Contesto=Contesto };
            result = dao.insert(obj);
            return result;
        }

        /// <summary>
        /// Actualiza un registro de la tabla preguntascontestadosporusuario
        /// </summary>
        /// <param name="idTema">id del tema</param>
        /// <param name="idGramtica">id de la gramatica</param>
        /// <returns>Retorna si se actualizo el registro correctamente</returns>
        [WebMethod]
        public bool update(int idTema, int idGramtica)
        {
            return true;
        }

        /// <summary>
        /// Elimina un regsitro de la tabla preguntascontestadasportema
        /// </summary>
        /// <param name="idTema">is del tema</param>
        /// <returns>Rerorna si se elimino el registro</returns>
        [WebMethod]
        public bool delete(int idTema)
        {
            return true;
        }

        [WebMethod]
        public string getPreguntasCorrectasPresenteSimple(String user)
        {
            PreguntaContestadaPorUsuaruioDAO dao = new PreguntaContestadaPorUsuaruioDAO();
            List<PreguntaContestadaPorUsuaruio> lista = dao.getPreguntasCorrectasPresenteSimple(user);

            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }
        [WebMethod]
        public string getPreguntasCorrectasPasadoSimple(String user)
        {
            PreguntaContestadaPorUsuaruioDAO dao = new PreguntaContestadaPorUsuaruioDAO();
            List<PreguntaContestadaPorUsuaruio> lista = dao.getPreguntasCorrectasPasadoSimple(user);

            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }
        [WebMethod]
        public string getPreguntasCorrectasVerbos(String user)
        {
            PreguntaContestadaPorUsuaruioDAO dao = new PreguntaContestadaPorUsuaruioDAO();
            List<PreguntaContestadaPorUsuaruio> lista = dao.getPreguntasCorrectasVerbos(user);

            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }
        [WebMethod]
        public string getPreguntasCorrectasVocabulario(String user)
        {
            PreguntaContestadaPorUsuaruioDAO dao = new PreguntaContestadaPorUsuaruioDAO();
            List<PreguntaContestadaPorUsuaruio> lista = dao.getPreguntasCorrectasVocabulario(user);

            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }
       
    }
}
