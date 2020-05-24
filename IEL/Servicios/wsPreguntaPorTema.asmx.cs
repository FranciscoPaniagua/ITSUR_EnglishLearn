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
    /// Summary description for wsPreguntaPorTema
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsPreguntaPorTema : System.Web.Services.WebService
    {
        /// <summary>
        /// Obtine todos los registros de la tabla preguntaportema
        /// </summary>
        /// <returns>Retorna una cadena con todos los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            PreguntaPorTemaDAO dao = new PreguntaPorTemaDAO();
            List<PreguntaPorTema> lista = dao.getAll();
            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }
        //Agregado
        [WebMethod]
        public string getPreguntasPorTema(int idTema)
        {
            PreguntaPorTemaDAO dao = new PreguntaPorTemaDAO();
            List<PreguntaPorTema> lista = dao.getPreguntasPorTema(idTema);
            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Obtiene un registro de la tabla preguntaportema
        /// </summary>
        /// <param name="ID">id de la preguntaportema</param>
        /// <returns>Retorna una cadena con el registro en formato json</returns>
        [WebMethod]
        public String getPreguntaPorTemaByID(int ID)
        {
            PreguntaPorTemaDAO dao = new PreguntaPorTemaDAO();
            PreguntaPorTema res = dao.getPreguntaPorTemaByID(ID);
            String strJSON;
            strJSON = JsonConvert.SerializeObject(res, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Inseta un registro en la tabla preguntaportema
        /// </summary>
        /// <param name="idPregunta">id de la pregunta</param>
        /// <param name="idTema">id del tema</param>
        /// <returns>Retorna si se inserto el registro correctamente</returns>
        [WebMethod]
        public bool insert(int idPregunta,int idTema)
        {
            bool result = false;
            PreguntaPorTemaDAO dao = new PreguntaPorTemaDAO();
            PreguntaPorTema obj = new PreguntaPorTema() {IdPregunta=idPregunta,IdTema=idTema};
            result = dao.insert(obj);
            return result;
        }

        /// <summary>
        /// Elimna un registro de la tabla preguntaportema
        /// </summary>
        /// <param name="idPregunta">id de la preguntaportema</param>
        /// <returns>Retorna si se elimino el registro correctamente</returns>
        [WebMethod]
        public bool delete(int idPregunta)
        {
            bool result = false;
            PreguntaPorTemaDAO dao = new PreguntaPorTemaDAO();          
            result = dao.delete(idPregunta);
            return result;
        }

        /// <summary>
        /// Actualiza un registro de la tabla preguntapor tema
        /// </summary>
        /// <param name="idPregunta">id de la pregunta</param>
        /// <param name="idTema">id del tema</param>
        /// <returns>Retorna si se actualizo el registro correctamente</returns>
        [WebMethod]
        public bool update(int idPregunta,int idTema)
        {
            bool result = false;
            PreguntaPorTemaDAO dao = new PreguntaPorTemaDAO();
            PreguntaPorTema obj = new PreguntaPorTema() { IdPregunta=idPregunta,IdTema=idTema};
            result = dao.update(obj);
            return result;
        }
    }
}
