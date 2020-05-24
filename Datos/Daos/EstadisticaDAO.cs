using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using MySql.Data.MySqlClient;
using Datos.Util;
using System.Data;

namespace Datos.Daos
{
    public class EstadisticaDAO
    {
        /// <summary>
        /// Obtiene todos los registros almacenados en la tabla Estadistica
        /// </summary>
        /// <returns>Una lista de tipo Estadistica</returns>
        public List<Estadistica> getAll()
        {
            List<Estadistica> lista = new List<Estadistica>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM Estadistica"+";");
            DataTable dt = datos.Tables[0];
            Estadistica e;
            foreach (DataRow r in dt.Rows) 
            {

                e = new Estadistica();
                e.IdEstadistica = (int)r.ItemArray[0];
                e.User = (string)r.ItemArray[1];
                e.FechaInicio = (DateTime)r.ItemArray[2];
                e.Nivel = (int)r.ItemArray[3];
                lista.Add(e);
            }
            return lista;
        }
        /// <summary>
        /// Obtiene una Estadistica por Usuario
        /// </summary>
        /// <param name="User">Usuario del que se desea obtener su estadistica</param>
        /// <returns>Una Estadistica del Usuario</returns>
        public Estadistica getEstadisticaByUser(string User)
        {
            Estadistica res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM Estadistica WHERE User like '"+User+"';");
            DataTable dt = datos.Tables[0];
            res = new Estadistica();
            DataRow row = dt.Rows[0];
            res.IdEstadistica = (int)row.ItemArray[0];
            res.User = (string)row.ItemArray[1];
            res.FechaInicio = (DateTime)row.ItemArray[2];
            res.Nivel = (int)row.ItemArray[3];
            return res;
        }
        /// <summary>
        /// Actualiza el registro de la Estadistica en base al Id de la estadistica introducida
        /// </summary>
        /// <param name="e">Recibe una Estadistica con los nuevos datos a actualizar</param>
        /// <returns>Retorna true en caso de actualizar de lo contrario retorna false</returns>
        public bool update(Estadistica e)
        {
            Conexion conexion = new Conexion();

            
            try
            {
                String SQL = "UPDATE Estadistica SET User=@user,FechaInicio=@fecha,Nivel=@nivel WHERE IdEstadistica=@id;";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@user", e.User);
                sqlcom.Parameters.AddWithValue("@fecha", e.getFechaFormatoSQL());
                sqlcom.Parameters.AddWithValue("@nivel", e.Nivel);
                sqlcom.Parameters.AddWithValue("@id", e.IdEstadistica);
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception )
            {

                return false;
            }

        }
        /// <summary>
        /// Elimina el registro de la estadistica en base al Id de la estadistica introducida
        /// </summary>
        /// <param name="t">La estadistica a eliminar</param>
        /// <returns>Retorna true si se pudo eliminar el registro de lo contrario retorna false</returns>
        public bool delete(Estadistica t)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM Estadistica WHERE IdEstadistica=@id;";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@id",t.IdEstadistica);
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        /// <summary>
        /// Inserta un registro de estadistica 
        /// </summary>
        /// <param name="i">La nueva estadistica a insertar</param>
        /// <returns>Retorna true si se pudo insertar el registro de lo contrario retorna false</returns>
        public bool insert(Estadistica i)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO Estadistica (IdEstadistica,User,FechaInicio,Nivel) VALUES (@IdEstadistica,@User,@FechaInicio,@Nivel);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@IdEstadistica", i.IdEstadistica);
                sqlcom.Parameters.AddWithValue("@User", i.User);
                sqlcom.Parameters.AddWithValue("@FechaInicio", i.FechaInicio);
                sqlcom.Parameters.AddWithValue("@Nivel", i.Nivel);
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

