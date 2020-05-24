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
    /// Summary description for wsPractica
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsPractica : System.Web.Services.WebService
    {
        /// <summary>
        /// Obtine todos los registros de la practica
        /// </summary>
        /// <returns>Retorna una cadena con todos los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            return "Hello World";
        }
        /// <summary>
        /// Obtine un registro de la tabla practica
        /// </summary>
        /// <param name="id">id de practica</param>
        /// <returns>Retorna un a cadena con el registro en formato json</returns>
        [WebMethod]
        public string getByID(int id)
        {
            return "";
        }

        /// <summary>
        /// Inserta un registro en la tabla practica
        /// </summary>
        /// <param name="id">id de la practica</param>
        /// <param name="correctas">respuestascorrectas de la practica</param>
        /// <param name="idtema">id del tema</param>
        /// <param name="user">user del usuario</param>
        /// <returns></returns>
        [WebMethod]
        public bool insert(int id, int correctas, int idtema, string user)
        {
            PracticaDAO dao = new PracticaDAO();
            Practica obj = new Practica() { IdPractica = id, Correctas = correctas, IdTema = idtema, User = user };
            return dao.insert(obj);
        }

        /// <summary>
        /// Actualiza un registro en la tabla practica
        /// </summary>
        /// <param name="id">id de la practica</param>
        /// <param name="correctas">respuestascorrectas de la practica</param>
        /// <param name="idtema">id del tema</param>
        /// <param name="user">user del usuario</param>
        /// <returns></returns>
        [WebMethod]
        public bool update(int id, int correctas, int idtema, string user)
        {
            return true;
        }

        /// <summary>
        /// Elimina un regsitro de la tabla practica
        /// </summary>
        /// <param name="idTema">id del tema</param>
        /// <returns>Rerorna si se elimino el registro correctamente</returns>
        [WebMethod]
        public bool delete(int id)
        {
            return true;
        }
        //AgregadoPaloma
        [WebMethod]
        public string getTotalPresenteByUser(String user)
        {
             PracticaDAO dao = new PracticaDAO();
            int total = dao.getTotalPresenteByUser(user);

            String strJSON = JsonConvert.SerializeObject(total, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }
        [WebMethod]
        public string getTotalPasadoByUser(String user)
        {
            PracticaDAO dao = new PracticaDAO();
            int total = dao.getTotalPasadoByUser(user);

            String strJSON = JsonConvert.SerializeObject(total, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }
        [WebMethod]
        public string getTotalVerbosByUser(String user)
        {
            PracticaDAO dao = new PracticaDAO();
            int total = dao.getTotalVerbosByUser(user);

            String strJSON = JsonConvert.SerializeObject(total, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }
        [WebMethod]
        public string getTotalVocabularioByUser(String user)
        {
            PracticaDAO dao = new PracticaDAO();
            int total = dao.getTotalVocabularioByUser(user);

            String strJSON = JsonConvert.SerializeObject(total, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

    }
}
