using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace IEL.Servicios
{
    /// <summary>
    /// Summary description for wsGramaticaPorTema
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsGramaticaPorTema : System.Web.Services.WebService
    {
        /// <summary>
        /// Obtine todos los registros de la gramaticaportema
        /// </summary>
        /// <returns>Retorna una cadena con todos los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            return "Hello World";
        }

        /// <summary>
        /// Obtine un registro de la tabla gramticaportema
        /// </summary>
        /// <param name="id">id de gramatica</param>
        /// <returns>Retorna un a cadena con el registro en formato json</returns>
        [WebMethod]
        public string getByID(int id)
        {
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idTema"></param>
        /// <param name="idGramtica"></param>
        /// <returns></returns>
        [WebMethod]
        public bool insert(int idTema,int idGramtica)
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idTema"></param>
        /// <param name="idGramtica"></param>
        /// <returns></returns>
        [WebMethod]
        public bool update(int idTema, int idGramtica)
        {
            return true;
        }

        /// <summary>
        /// Elimina un regsitro de la tabla practicaportema
        /// </summary>
        /// <param name="idTema">id del tema</param>
        /// <returns>Rerorna si se elimino el registro correctamente</returns>
        [WebMethod]
        public bool delete(int idTema)
        {
            return true;
        }
    }
}
