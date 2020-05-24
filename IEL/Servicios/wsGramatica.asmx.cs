using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Datos.Daos;
using Newtonsoft.Json;

namespace IEL.Servicios
{
    
    /// <summary>
    /// Summary description for wsGramatica
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsGramatica : System.Web.Services.WebService
    {
        
        /// <summary>
        /// Obtine todos los registros de la gramatica
        /// </summary>
        /// <returns>Retorna una cadena con todos los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            return "Hello World";
        }

        [WebMethod]
        public string getByTema(int tema)
        {
            GramaticaDAO dao = new GramaticaDAO();
            string json= JsonConvert.SerializeObject(dao.getByTema(tema),
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return json;
        }

        /// <summary>
        /// Obtine un registro de la tabla gramatica
        /// </summary>
        /// <param name="id">id de pgramatica</param>
        /// <returns>Retorna un a cadena con el registro en formato json</returns>
        [WebMethod]
        public string getByID(int id)
        {
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sujeto"></param>
        /// <param name="verbo"></param>
        /// <param name="complemento"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        [WebMethod]
        public bool insert(int id, string sujeto,string verbo,string complemento,string tipo )
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sujeto"></param>
        /// <param name="verbo"></param>
        /// <param name="complemento"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        [WebMethod]
        public bool update(int id, string sujeto, string verbo, string complemento, string tipo)
        {
            return true;
        }

        /// <summary>
        /// Elimina un regsitro de la tabla gramatica
        /// </summary>
        /// <param name="idTema">id del gramatica</param>
        /// <returns>Rerorna si se elimino el registro correctamente</returns>
        [WebMethod]
        public bool delete(int id)
        {
            return true;
        }

    
    }
}
