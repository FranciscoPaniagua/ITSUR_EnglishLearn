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
    public class TemaDAO
    {
        /// <summary>
        /// Obtiene todos los registros almacenados en la tabla Tema
        /// </summary>
        /// <returns>Una lista de tipo Tema</returns>
        public List<Tema> getAll()
        {
            List<Tema> lista = new List<Tema>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM Tema" + ";");
            DataTable dt = datos.Tables[0];
            Tema t;
            foreach (DataRow r in dt.Rows)
            {

                t = new Tema();
                t.IdTema = (int)r.ItemArray[0];
                t.NombreTraduccion = (String)r.ItemArray[1];
                t.NombreIngles = (String)r.ItemArray[2];
                t.ContenidoTraduccion = (String)r.ItemArray[3];
                t.ContenidoIngles = (String)r.ItemArray[4];
                t.Dificultad = (int)r.ItemArray[5];
                lista.Add(t);
            }
            return lista;
        }
        /// <summary>
        /// Obtiene un Tema por Id
        /// </summary>
        /// <param name="Id">Id del que se desea obtener su Tema</param>
        /// <returns>Un Tema del Id</returns>
        public Tema getTemaByID(int Id)
        {
            Tema t;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM Tema where IdTema = " + Id + ";");
            DataTable dt = datos.Tables[0];
            t = new Tema();
            DataRow row = dt.Rows[0];
            t = new Tema();
            t.IdTema = (int)row.ItemArray[0];
            t.NombreTraduccion = (String)row.ItemArray[1];
            t.NombreIngles = (String)row.ItemArray[2];
            t.ContenidoTraduccion = (String)row.ItemArray[3];
            t.ContenidoIngles = (String)row.ItemArray[4];
            t.Dificultad = (int)row.ItemArray[5];
            return t;
        }
        /// <summary>
        /// Elimina el registro del Tema en base al Id del Tema introducido
        /// </summary>
        /// <param name="IdTema">El Tema a eliminar</param>
        /// <returns>Retorna true si se pudo eliminar el registro de lo contrario retorna false</returns>
        public bool delete(int  IdTema)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM Tema WHERE" + " IdTema=" + IdTema + ";";
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
        /// Actualiza el registro del Tema en base al Id del Tema introducido
        /// </summary>
        /// <param name="t">Recibe un Tema con los nuevos datos a actualizar</param>
        /// <returns>Retorna true en caso de actualizar de lo contrario retorna false</returns>
        public bool update(Tema t)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "UPDATE Tema SET "+ "NombreTraduccion='" + t.NombreTraduccion + "',NombreIngles='" + t.NombreIngles +
                    "',ContenidoTraduccion='" + t.ContenidoTraduccion + "', ContenidoIngles='" + t.ContenidoIngles + "', Dificultad=" + t.Dificultad +
                    " WHERE IdTema=" + t.IdTema + ";";
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
        /// Inserta un registro de Tema 
        /// </summary>
        /// <param name="t">El nueva Tema a insertar</param>
        /// <returns>Retorna true si se pudo insertar el registro de lo contrario retorna false</returns>
        public bool insert(Tema t)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO Tema (IdTema,NombreTraduccion,NombreIngles,ContenidoTraduccion,ContenidoIngles,Dificultad)" +
                    " VALUES (@IdTema,@NombreTraduccion,@NombreIngles,@ContenidoTraduccion,@ContenidoIngles,@Dificultad);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@IdTema", t.IdTema);
                sqlcom.Parameters.AddWithValue("@NombreTraduccion", t.NombreTraduccion);
                sqlcom.Parameters.AddWithValue("@NombreIngles", t.NombreIngles);
                sqlcom.Parameters.AddWithValue("@ContenidoTraduccion", t.ContenidoTraduccion);
                sqlcom.Parameters.AddWithValue("@ContenidoIngles", t.ContenidoIngles);
                sqlcom.Parameters.AddWithValue("@Dificultad", t.Dificultad);
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
