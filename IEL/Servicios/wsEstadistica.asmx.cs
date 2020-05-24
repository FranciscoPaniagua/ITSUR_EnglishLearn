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
    /// Summary description for wsEstadistica
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsEstadistica : System.Web.Services.WebService
    {
        /// <summary>
        /// Inserta un registro de la tabla estadistica
        /// </summary>
        /// <param name="id">Id de la estadistica</param>
        /// <param name="usuario">Usuario de la estadistica</param>
        /// <param name="dia">Dia de la estadistica</param>
        /// <param name="mes">Mes de la estadistica</param>
        /// <param name="anio">Año de la estadistica</param>
        /// <param name="nivel">Nivel de la estadistica</param>
        /// <returns>Retorna si se inserto correctamente</returns>
        [WebMethod]
        public bool Insert(int id, string usuario,int dia, int mes, int anio,int nivel)
        {
            EstadisticaDAO dao = new EstadisticaDAO();
            Estadistica obj = new Estadistica()
            {
                IdEstadistica = id,
                User = usuario,
                Nivel = nivel,
                FechaInicio = new DateTime(anio, mes, dia)
            };
            return dao.insert(obj);
        }
        /// <summary>
        /// Actualiza un registro de la tabla estadistica
        /// </summary>
        /// <param name="id">Id de la estadistica</param>
        /// <param name="usuario">Usuario de la estadistica</param>
        /// <param name="dia">Dia de la estadistica</param>
        /// <param name="mes">Mes de la estadistica</param>
        /// <param name="anio">Año de la estadistica</param>
        /// <param name="nivel">Nivel de la estadistica</param>
        /// <returns>Retorna si se actualizo correctamente</returns>
        [WebMethod]
        public bool update(int id, string usuario, int dia, int mes, int anio, int nivel)
        {
            EstadisticaDAO dao = new EstadisticaDAO();
            Estadistica obj = new Estadistica()
            {
                IdEstadistica = id,
                User = usuario,
                Nivel = nivel,
                FechaInicio = new DateTime(anio, mes, dia)
            };
            return dao.update(obj);
        }


        /// <summary>
        /// Elimina un registro de la tabla estadistica
        /// </summary>
        /// <param name="id">Id de la estadistica</param>
        /// <returns>Retorna si se elimino correctamente</returns>
        [WebMethod]
        public bool delete(int id)
        {
            EstadisticaDAO dao = new EstadisticaDAO();
            Estadistica obj = new Estadistica()
            {
                IdEstadistica = id
            };
            return dao.delete(obj);
        }

        /// <summary>
        /// Selecciona una estadistica de acuerdo al usuario
        /// </summary>
        /// <param name="user">Usuario</param>
        /// <returns>Retorna una cadena en json con la estadistica</returns>
        [WebMethod]
        public string getEstadisticaByUser(string user)
        {
            EstadisticaDAO dao = new EstadisticaDAO();
            string json = JsonConvert.SerializeObject(dao.getEstadisticaByUser(user), 
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return json;
        }

    }
}
