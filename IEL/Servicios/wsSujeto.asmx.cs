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
    /// Summary description for wsSujeto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsSujeto : System.Web.Services.WebService
    {
        /// <summary>
        /// Obtine todos los registros de la tabla sujeto
        /// </summary>
        /// <returns>Retorna una cadena con todos los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            SujetoDAO dao = new SujetoDAO();
            List<Sujeto> lista = dao.getAll();
            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore});
            return strJSON;
        }

        /// <summary>
        /// Obtine un registro de la tabla sujeto
        /// </summary>
        /// <param name="ID">Id del sujeto</param>
        /// <returns>Retorna una cadena con el registro en formato json</returns>
        [WebMethod]
        public String getSujetoByID(int ID)
        {
            SujetoDAO dao = new SujetoDAO();
            Sujeto res = dao.getSujetoByID(ID);
            String strJSON;
            strJSON = JsonConvert.SerializeObject(res, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Inserta un registro en la tabla sujeto
        /// </summary>
        /// <param name="Objeto">Objeto del sujeto</param>
        /// <param name="Posesivo">Posesivo del sujeto</param>
        /// <param name="Sucesivo">Sucesivo del sujeto</param>
        /// <param name="sujeto">Sujeto del sujeto</param>
        /// <param name="sujetoTraducido">Sujetotraducido dle sujeto</param>
        /// <returns>Retorna si se inserto en registro correctamente</returns>
        [WebMethod]
        public bool insert(String Objeto, String Posesivo, String Sucesivo,String sujeto,String sujetoTraducido)
        {
            bool result = false;
            SujetoDAO dao = new SujetoDAO();
            Sujeto obj = new Sujeto() { Objeto=Objeto,Posesivo=Posesivo,Sucesivo=Sucesivo,sujeto=sujeto,SujetoTraducido=sujetoTraducido};
            result = dao.insert(obj);
            return result;
        }

        /// <summary>
        /// Elimna un registro de la tabla sujeto
        /// </summary>
        /// <param name="idSujeto">Id del sujeto</param>
        /// <returns>Retorna si se elimino el registro correctamente</returns>
        [WebMethod]
        public bool delete(int idSujeto)
        {
            bool result = false;
            SujetoDAO dao = new SujetoDAO();
            result = dao.delete(idSujeto);
            return result;
        }

        /// <summary>
        /// Actualiza un registro de la tabla sujeto
        /// </summary>
        /// <param name="idSujeto">Id del sijeto</param>
        /// <param name="Objeto">Objeto del sujeto</param>
        /// <param name="Posesivo">Posesivo del sujeto</param>
        /// <param name="Sucesivo">Sucesivo del sujeto</param>
        /// <param name="sujeto">Sujeto del sujeto</param>
        /// <param name="sujetoTraducido">Sujetotraducido dle sujeto</param>
        /// <returns>Retorna si se actualizo en registro correctamente</returns>       
        [WebMethod]
        public bool update(int idSujeto, String Objeto, String Posesivo, String Sucesivo, String sujeto, String sujetoTraducido)
        {
            bool result = false;
            SujetoDAO dao = new SujetoDAO();
            Sujeto obj = new Sujeto() { IdSujeto = idSujeto, Objeto = Objeto, Posesivo = Posesivo, Sucesivo = Sucesivo,
                sujeto = sujeto, SujetoTraducido = sujetoTraducido };
            result = dao.update(obj);
            return result;
        }
    }
}
