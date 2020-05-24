using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos.Modelo;
using Datos.Util;
using MySql.Data.MySqlClient;

namespace Datos.Daos
{
    public class UsuarioDAO
    {
        public List<Usuario> getAll()
        {
            /// <summary>
            /// Obtiene todos los registros almacenados en la tabla Usuario
            /// </summary>
            /// <returns>Una lista de tipo Usuario</returns>
            List<Usuario> lista = new List<Usuario>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM Usuario" + ";");
            DataTable dt = datos.Tables[0];
            Usuario e;
            foreach (DataRow r in dt.Rows)
            {

                e = new Usuario();
                e.User = (string)r.ItemArray[0];
                e.Password = (string)r.ItemArray[1];
                e.Nombre = (string)r.ItemArray[2];
                e.ApellidoPaterno = (string)r.ItemArray[3];
                e.ApellidoMaterno = (string)r.ItemArray[4];
                e.Correo = (string)r.ItemArray[5];
                e.Foto = (string)r.ItemArray[6];
                e.Privilegio = (string)r.ItemArray[7];
                lista.Add(e);
            }
            return lista;
        }
        /// <summary>
        /// Obtiene un Usuario por Usuario
        /// </summary>
        /// <param name="User">Usuario del que se desea obtener su Usuario</param>
        /// <returns>Un Usuario del Usuario</returns>
        public Usuario getUsuarioByUser(string User)
        {
            Usuario res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM Usuario WHERE User like '" + User + "';");
            DataTable dt = datos.Tables[0];
            res = new Usuario();
            DataRow row = dt.Rows[0];
            res.User = (string)row.ItemArray[0];
            res.Password = (string)row.ItemArray[1];
            res.Nombre = (string)row.ItemArray[2];
            res.ApellidoPaterno = (string)row.ItemArray[3];
            res.ApellidoMaterno = (string)row.ItemArray[4];
            res.Correo = (string)row.ItemArray[5];
            res.Foto = (string)row.ItemArray[6];
            res.Privilegio = (string)row.ItemArray[7];
            return res;
        }

        public Usuario getUsuarioByUser(string User, string password)
        {
            Usuario res;
            Conexion conexion = new Conexion();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText="select * from usuario where user=@user and password=sha2(@pass,512);";
            cmd.Parameters.AddWithValue("@user", User);
            cmd.Parameters.AddWithValue("@pass", password);
            DataSet datos = conexion.LLenaComboGrid(cmd);
            DataTable dt = datos.Tables[0];
            res = new Usuario();
            DataRow row = dt.Rows[0];
            res.User = (string)row.ItemArray[0];
            res.Password = (string)row.ItemArray[1];
            res.Nombre = (string)row.ItemArray[2];
            res.ApellidoPaterno = (string)row.ItemArray[3];
            res.ApellidoMaterno = (string)row.ItemArray[4];
            res.Correo = (string)row.ItemArray[5];
            res.Foto = (string)row.ItemArray[6];
            res.Privilegio = (string)row.ItemArray[7];
            return res;
        }

        public bool getUsuario(string User, string password)
        {
            try
            {
                Usuario res;
                Conexion conexion = new Conexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "select * from usuario where user=@user and password=sha2(@pass,512);";
                cmd.Parameters.AddWithValue("@user", User);
                cmd.Parameters.AddWithValue("@pass", password);
                DataSet datos = conexion.LLenaComboGrid(cmd);
                DataTable dt = datos.Tables[0];
                res = new Usuario();
                DataRow row = dt.Rows[0];
                res.User = (string)row.ItemArray[0];
                res.Password = (string)row.ItemArray[1];
                res.Nombre = (string)row.ItemArray[2];
                res.ApellidoPaterno = (string)row.ItemArray[3];
                res.ApellidoMaterno = (string)row.ItemArray[4];
                res.Correo = (string)row.ItemArray[5];
                res.Foto = (string)row.ItemArray[6];
                res.Privilegio = (string)row.ItemArray[7];
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Elimina el registro del Usuario en base al User del Usuario introducido
        /// </summary>
        /// <param name="t">El Usuario a eliminar</param>
        /// <returns>Retorna true si se pudo eliminar el registro de lo contrario retorna false</returns>
        public bool delete(string User)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM Usuario WHERE" + " User like '" + User + "';";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        /// <summary>
        /// Actualiza el registro del Usuario en base al User del Usuario introducido
        /// </summary>
        /// <param name="e">Recibe un Usuario con los nuevos datos a actualizar</param>
        /// <returns>Retorna true en caso de actualizar de lo contrario retorna false</returns>
        public bool update(Usuario e)
        {
            Conexion conexion = new Conexion();

            String SQL;
            try
            {
                if (e.Password.Equals("igual"))
                {
                    SQL = "UPDATE Usuario SET" +
                   " User='" + e.User + "',Nombre='" + e.Nombre + "',ApellidoPaterno='" + e.ApellidoPaterno + "',ApellidoMaterno='" + e.ApellidoMaterno + "',Correo='" + e.Correo + "',Foto='" + e.Foto + "',Privilegio='" + e.Privilegio + "'" +
                   " WHERE User like '" + e.User + "';";
                }
                else
                {
                    SQL = "UPDATE Usuario SET" +
                   " User='" + e.User + "',Password=sha2('" + e.Password + "',512),Nombre='" + e.Nombre + "',ApellidoPaterno='" + e.ApellidoPaterno + "',ApellidoMaterno='" + e.ApellidoMaterno + "',Correo='" + e.Correo + "',Foto='" + e.Foto + "',Privilegio='" + e.Privilegio + "'" +
                   " WHERE User like '" + e.User + "';";
                }
              
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        /// <summary>
        /// Inserta un Usuario 
        /// </summary>
        /// <param name="i">El nuevo Usuario a insertar</param>
        /// <returns>Retorna true si se pudo insertar el registro de lo contrario retorna false</returns>
        public bool insert(Usuario i)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO usuario (User,Password,Nombre,ApellidoPaterno,ApellidoMaterno,Correo,Foto,Privilegio) VALUES (@User,sha2(@Password, 512),@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Correo,@Foto,@Privilegio);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@User", i.User);
                sqlcom.Parameters.AddWithValue("@Password", i.Password);
                sqlcom.Parameters.AddWithValue("@Nombre", i.Nombre);
                sqlcom.Parameters.AddWithValue("@ApellidoPaterno", i.ApellidoPaterno);
                sqlcom.Parameters.AddWithValue("@ApellidoMaterno", i.ApellidoMaterno);
                sqlcom.Parameters.AddWithValue("@Correo", i.Correo);
                sqlcom.Parameters.AddWithValue("@Foto", i.Foto);
                sqlcom.Parameters.AddWithValue("@Privilegio", i.Privilegio);
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool cambiarPassword(string User,string newpassword)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "UPDATE usuario Set Password = sha2('" + newpassword + "',512) where User like '" + User + "';";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool cambiarImagen(string User,string nuevaimagen)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "UPDATE usuario Set Foto = '"+nuevaimagen+"' where User like '"+User+"';";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
