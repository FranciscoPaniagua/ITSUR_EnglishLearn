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
    /// Summary description for wsVerbo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsVerbo : System.Web.Services.WebService
    {
        /// <summary>
        /// Obtine todos los registros de la tabla verbo
        /// </summary>
        /// <returns>Retorna una cadena con todos los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            VerboDAO dao = new VerboDAO();
            List<Verbo> lista = dao.getAll();
            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Obtine un registro de la tabla vervo
        /// </summary>
        /// <param name="IdVerbo">id del verbo</param>
        /// <returns>Retorna una cadena con el registros en formato json</returns>
        [WebMethod]
        public String getVerboByID(int  IdVerbo)
        {
            VerboDAO dao = new VerboDAO();
            Verbo res = dao.getVerboByID(IdVerbo);
            String strJSON;
            strJSON = JsonConvert.SerializeObject(res, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Inserta un registro en la tabla verbo
        /// </summary>
        /// <param name="VerboTraduccion">traduccion del verbo</param>
        /// <param name="VerboPresenteSimple">Presente simple del verbo</param>
        /// <param name="VerboPasadoSimple">Pasado simple del verbo</param>
        /// <param name="VerboPasadoParticipio">Pasado participio del verbo</param>
        /// <returns>Retorna si el registro se inserto correctamente</returns>
        [WebMethod]
        public bool insert(String VerboTraduccion,String VerboPresenteSimple,
            String VerboPasadoSimple,String VerboPasadoParticipio)
        {
            bool result = false;
            VerboDAO dao = new VerboDAO();
            Verbo obj = new Verbo() {VerboTraduccion=VerboTraduccion,
                VerboPresenteSimple =VerboPresenteSimple,VerboPasadoSimple=VerboPasadoSimple,
                VerboPasadoParticipio =VerboPasadoParticipio};
            result = dao.insert(obj);
            return result;
        }

        /// <summary>
        /// Elimina un registro de la tabla verbo
        /// </summary>
        /// <param name="IdVerbo"></param>
        /// <returns></returns>
        [WebMethod]
        public bool delete(int IdVerbo)
        {
            bool result = false;
            VerboDAO dao = new VerboDAO();
            result = dao.delete(IdVerbo);
            return result;
        }

        /// <summary>
        /// Actualiza un registro de la tabla vervo
        /// </summary>
        /// <param name="IdVerbo">id del verbo</param>
        /// <param name="VerboTraduccion">traduccion del verbo</param>
        /// <param name="VerboPresenteSimple">Presente simple del verbo</param>
        /// <param name="VerboPasadoSimple">Pasado simple del verbo</param>
        /// <param name="VerboPasadoParticipio">Pasado participio del verbo</param>
        /// <returns>Retorna si el registro se inserto correctamente</returns>
        [WebMethod]
        public bool update(int IdVerbo, String VerboTraduccion, String VerboPresenteSimple,
            String VerboPasadoSimple, String VerboPasadoParticipio)
        {
            bool result = false;
            VerboDAO dao = new VerboDAO();
            Verbo obj = new Verbo() { IdVerbo = IdVerbo, VerboTraduccion = VerboTraduccion,
                VerboPresenteSimple = VerboPresenteSimple, VerboPasadoSimple = VerboPasadoSimple,
                VerboPasadoParticipio = VerboPasadoParticipio };
            result = dao.update(obj);
            return result;
        }
    }
}
