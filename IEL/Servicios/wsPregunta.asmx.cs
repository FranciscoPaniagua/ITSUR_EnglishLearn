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
    /// Summary description for wsPregunta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsPregunta : System.Web.Services.WebService
    {

        /// <summary>
        /// Obtiene todos los registros de la tabla pregunta
        /// </summary>
        /// <returns>Retorna una cadena donde se encuentan las preguntas en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            PreguntaDAO dao = new PreguntaDAO();
            List<Pregunta> lista = dao.getAll();
            String strJSON = JsonConvert.SerializeObject(lista, 
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }
        
        /// <summary>
        /// Obtiene un registro de la tabla pregunta
        /// </summary>
        /// <param name="idPregunta">Id de la pregunta a retornar</param>
        /// <returns>Retorna una acadena donde se encuentra la pregunta en formato json</returns>
        [WebMethod]
        public String getPreguntaByID(int idPregunta)
        {
            PreguntaDAO dao = new PreguntaDAO();
            Pregunta res = dao.getPreguntaByID(idPregunta);
            String strJSON;
            strJSON = JsonConvert.SerializeObject(res, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Inserta un registro en la tabla pregunta
        /// </summary>
        /// <param name="pregunta">La pregunta</param>
        /// <param name="RespuestaCorrecta"> La respuesta correcta</param>
        /// <param name="RespuestaIncorrecta1">La respuesta incorrecta1</param>
        /// <param name="RespuestaIncorrecta2">La respuesta incorrecta2</param>
        /// <param name="RespuestaIncorrecta3">La respuesta incorrecta3</param>
        /// <returns>Retorna si la pregunta se inserto correctamente</returns>
        [WebMethod]
        public bool insert(String pregunta, String RespuestaCorrecta, 
            String RespuestaIncorrecta1, String RespuestaIncorrecta2, String RespuestaIncorrecta3)
        {
            bool result = false;
            PreguntaDAO dao = new PreguntaDAO();
            Pregunta obj = new Pregunta() { pregunta=pregunta,
                RespuestaCorrecta =RespuestaCorrecta,RespuestaIncorrecta1=RespuestaIncorrecta1,
                RespuestaIncorrecta2 =RespuestaIncorrecta2,RespuestaIncorrecta3=RespuestaIncorrecta3};
            result = dao.insert(obj);
            return result;
        }

        /// <summary>
        /// Elimina un registro de la tabla de pregunta
        /// </summary>
        /// <param name="idPregunta">Id de la pregunta</param>
        /// <returns>Retorna si la pregunta se elimino correctamente</returns>
        [WebMethod]
        public bool delete(int idPregunta)
        {
            bool result = false;
            PreguntaDAO dao = new PreguntaDAO();        
            result = dao.delete(idPregunta);
            return result;
        }

        /// <summary>
        /// Actualiza un registro de la tabla pregunta
        /// </summary>
        /// <param name="idPregunta">id de lapregunta</param>
        /// <param name="pregunta">La pregunta</param>
        /// <param name="RespuestaCorrecta"> La respuesta correcta</param>
        /// <param name="RespuestaIncorrecta1">La respuesta incorrecta1</param>
        /// <param name="RespuestaIncorrecta2">La respuesta incorrecta2</param>
        /// <param name="RespuestaIncorrecta3">La respuesta incorrecta3</param>
        /// <returns>Retorna si la pregunta se inserto correctamente</returns>
        [WebMethod]
        public bool update(int idPregunta,String pregunta, String RespuestaCorrecta,
            String RespuestaIncorrecta1, String RespuestaIncorrecta2, String RespuestaIncorrecta3)
        {
            bool result = false;
            PreguntaDAO dao = new PreguntaDAO();
            Pregunta obj = new Pregunta() { idPregunta=idPregunta,pregunta = pregunta,
                RespuestaCorrecta = RespuestaCorrecta, RespuestaIncorrecta1 = RespuestaIncorrecta1,
                RespuestaIncorrecta2 = RespuestaIncorrecta2,
                RespuestaIncorrecta3 = RespuestaIncorrecta3 };
            result = dao.update(obj);
            return result;
        }
    }
}
