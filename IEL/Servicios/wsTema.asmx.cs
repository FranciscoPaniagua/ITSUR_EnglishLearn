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
    /// Summary description for wsTema
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsTema : System.Web.Services.WebService
    {
        /// <summary>
        /// Obtine todos los registros de la tabla tema
        /// </summary>
        /// <returns>Retorna una cadena con todos los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            TemaDAO dao = new TemaDAO();
            List<Tema> lista = dao.getAll();
            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Obtiene un registro de la tabla tema
        /// </summary>
        /// <param name="ID">id del tema</param>
        /// <returns>Retorna una cadena con el registro en formato json</returns>
        [WebMethod]
        public String getTemaByID(int ID)
        {
            TemaDAO dao = new TemaDAO();
            Tema res = dao.getTemaByID(ID);
            String strJSON;
            strJSON = JsonConvert.SerializeObject(res, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Inserta un registro de la tabla tema
        /// </summary>
        /// <param name="NombreTraduccion">nombreTraduccion del tema</param>
        /// <param name="NombreIngles">nombreIngles del tema</param>
        /// <param name="ContenidoTraduccion">Contenidotraducion del tema</param>
        /// <param name="ContenidoIngles">ContenidoIngles del tema</param>
        /// <param name="Dificultad">Dificultad del tema</param>
        /// <returns>Retorna si se inserto registro correctamente </returns>
        [WebMethod]
        public bool insert(String NombreTraduccion, String NombreIngles, 
            String ContenidoTraduccion, String ContenidoIngles, int Dificultad)
        {
            bool result = false;
            TemaDAO dao = new TemaDAO();
            Tema obj = new Tema() {NombreTraduccion=NombreTraduccion,NombreIngles=NombreIngles,
                ContenidoIngles =ContenidoIngles,ContenidoTraduccion=ContenidoTraduccion,Dificultad=Dificultad };
            result = dao.insert(obj);
            return result;
        }
        
        /// <summary>
        /// Elimina un registro de la tabla tema
        /// </summary>
        /// <param name="idTema">Id del tema</param>
        /// <returns>Retorna si se elimino el registro correctamente</returns>
        [WebMethod]
        public bool delete(int idTema)
        {
            bool result = false;
            TemaDAO dao = new TemaDAO();
            result = dao.delete(idTema);
            return result;
        }

        /// <summary>
        /// Actualiza un registro de la tabla tema
        /// </summary>
        /// <param name="idTema">Id del tema</param>
        /// <param name="NombreTraduccion">nombreTraduccion del tema</param>
        /// <param name="NombreIngles">nombreIngles del tema</param>
        /// <param name="ContenidoTraduccion">Contenidotraducion del tema</param>
        /// <param name="ContenidoIngles">ContenidoIngles del tema</param>
        /// <param name="Dificultad">Dificultad del tema</param>
        /// <returns>Retorna si se actualizo registro correctamente </returns>
        [WebMethod]
        public bool update(int idTema, String NombreTraduccion, String NombreIngles, 
            String ContenidoTraduccion, String ContenidoIngles, int Dificultad)
        {
            bool result = false;
            TemaDAO dao = new TemaDAO();
            Tema obj = new Tema() { IdTema = idTema, NombreTraduccion = NombreTraduccion, NombreIngles = NombreIngles,
                ContenidoIngles = ContenidoIngles, ContenidoTraduccion = ContenidoTraduccion, Dificultad = Dificultad };
            result = dao.update(obj);
            return result;
        }
    }
}
