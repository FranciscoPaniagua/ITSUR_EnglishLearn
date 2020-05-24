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
    /// Summary description for wsUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsUsuario : System.Web.Services.WebService
    {
        /// <summary>
        /// Obtine todos los registros de la tabla usuario
        /// </summary>
        /// <returns>Retorna una cadena con todos los registros en formato json</returns>
        [WebMethod]
        public string getAll()
        {
            UsuarioDAO dao = new UsuarioDAO();
            List<Usuario> lista = dao.getAll();
            String strJSON = JsonConvert.SerializeObject(lista, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Obtine un registro de la tabla usurio
        /// </summary>
        /// <param name="User">user del usuario</param>
        /// <returns>Retorna una cadena con el registro en formato json</returns>
        [WebMethod]
        public String getUsuarioByID(string User)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario res = dao.getUsuarioByUser(User);
            String strJSON;
            strJSON = JsonConvert.SerializeObject(res, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        /// <summary>
        /// Inserta un registro en la tabla usurio
        /// </summary>
        /// <param name="User">user del usuario</param>
        /// <param name="Password">password del del usuario</param>
        /// <param name="Nombre">nombre del usurio</param>
        /// <param name="ApellidoPaterno">apellido paterno del usuario</param>
        /// <param name="ApellidoMaterno">apellido materno del usuario</param>
        /// <param name="Correo">correo del usuario</param>
        /// <param name="Foto">Direcccion de la foto del usuario</param>
        /// <param name="Privilegio">privilegio del usurio</param>
        /// <returns>Retorna si el registro fue insertado correctamente</returns>
        [WebMethod]
        public bool insert(String User, String Password, String Nombre, String ApellidoPaterno,
            String ApellidoMaterno, String Correo,String Foto,String Privilegio)
        {
            bool result = false;
            UsuarioDAO dao = new UsuarioDAO();
            Usuario obj = new Usuario() {User=User,Password=Password,Nombre=Nombre,
                ApellidoPaterno =ApellidoPaterno,ApellidoMaterno=ApellidoMaterno,Correo=Correo,
                Foto =Foto,Privilegio=Privilegio};
            result = dao.insert(obj);
            return result;
        }

        /// <summary>
        /// Elimina un registro de la tabla usuario
        /// </summary>
        /// <param name="User">user del usuario</param>
        /// <returns>Retorna si el registro se elimino correctamente</returns>
        [WebMethod]
        public bool delete(String User)
        {
            bool result = false;
            UsuarioDAO dao = new UsuarioDAO();          
            result = dao.delete(User);
            return result;
        }

        /// <summary>
        /// Actualiza un registro de la tabla usuario
        /// </summary>
        /// <param name="User">user del usuario</param>
        /// <param name="Password">password del del usuario</param>
        /// <param name="Nombre">nombre del usurio</param>
        /// <param name="ApellidoPaterno">apellido paterno del usuario</param>
        /// <param name="ApellidoMaterno">apellido materno del usuario</param>
        /// <param name="Correo">correo del usuario</param>
        /// <param name="Foto">Direcccion de la foto del usuario</param>
        /// <param name="Privilegio">privilegio del usurio</param>
        /// <returns>Retorna si el registro fue insertado correctamente</returns>
        [WebMethod]
        public bool update(String User, String Password, String Nombre, String ApellidoPaterno, 
            String ApellidoMaterno, String Correo, String Foto, String Privilegio)
        {
            bool result = false;
            UsuarioDAO dao = new UsuarioDAO();
            Usuario obj = new Usuario() { User = User, Password = Password, Nombre = Nombre,
                ApellidoPaterno = ApellidoPaterno, ApellidoMaterno = ApellidoMaterno, Correo = Correo,
                Foto = Foto, Privilegio = Privilegio };
            result = dao.update(obj);
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="User"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [WebMethod]
        public String getUsuarioByUserPassword(string User,string password)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario res = dao.getUsuarioByUser(User,password);
            String strJSON;
            strJSON = JsonConvert.SerializeObject(res, new JsonSerializerSettings
            { NullValueHandling = NullValueHandling.Ignore });
            return strJSON;
        }

        [WebMethod]
        public bool getUsuario(string user,string password)
        {
            UsuarioDAO dao = new UsuarioDAO();
            return dao.getUsuario(user,password);
        }

        [WebMethod]
        public bool cambiarPassword(string User, string newpassword)
        {
            UsuarioDAO dao = new UsuarioDAO();
            return dao.cambiarPassword(User, newpassword);
        }

        [WebMethod]
        public bool cambiarImagen(string User,string nuevaImagen)
        {
            UsuarioDAO dao = new UsuarioDAO();
            return dao.cambiarImagen(User, nuevaImagen);
        }
    }
}
