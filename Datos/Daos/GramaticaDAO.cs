using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Datos.Modelo;
using Datos.Util;

namespace Datos.Daos

{
   public class GramaticaDAO
    {
        /*/// <summary>
        /// Obtiene todos los registros almacenados en la tabla Gramatica
        /// </summary>
        /// <returns>Una lista de tipo Gramatica</returns>
        public List<Gramatica> getAll()
        {
            List<Gramatica> lista = new List<Gramatica>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM Gramatica"+";");
            DataTable dt = datos.Tables[0];
            Gramatica e;
            foreach (DataRow r in dt.Rows)
            {

                e = new Gramatica();
                e.IdGramatica = (int)r.ItemArray[0];
                e.Sujeto = (string)r.ItemArray[1];
                e.Verbo = (string)r.ItemArray[2];
                e.Complemento = (string)r.ItemArray[3];
                lista.Add(e);
            }
            return lista;
        }
        /// <summary>
        /// Obtiene una Gramatica por Id
        /// </summary>
        /// <param name="ID">Id de la que se desea obtener su Gramatica</param>
        /// <returns>Una Gramatica en base al Id</returns>
        public Gramatica getGramaticaByID(int ID)
        {
            Gramatica res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM Gramatica WHERE IdGramatica = " + ID+";");
            DataTable dt = datos.Tables[0];
            res = new Gramatica();
            DataRow row = dt.Rows[0];
            res.IdGramatica = (int)row.ItemArray[0];
            res.Sujeto = (string)row.ItemArray[1];
            res.Verbo = (string)row.ItemArray[2];
            res.Complemento = (string)row.ItemArray[3];
            return res;
        }
        /// <summary>
        /// Elimina el registro de la Gramatica en base al Id de la Gramatica introducida
        /// </summary>
        /// <param name="t">La Gramatica a eliminar</param>
        /// <returns>Retorna true si se pudo eliminar el registro de lo contrario retorna false</returns>
        public bool delete(Gramatica t)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM Gramatica WHERE" + " IdGramatica=" + t.IdGramatica + ";";
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
        /// Actualiza el registro de la Gramatica en base al Id de la Gramatica introducida
        /// </summary>
        /// <param name="e">Recibe una Gramatica con los nuevos datos a actualizar</param>
        /// <returns>Retorna true en caso de actualizar de lo contrario retorna false</returns>
        public bool update(Gramatica e)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "UPDATE Gramatica SET" +
                    " IdGramatica=" + e.IdGramatica + ",Sujeto=" + e.Sujeto + ",Verbo=" + e.Verbo + ",Complemento=" + e.Complemento +
                    " WHERE IdGramatica=" + e.IdGramatica + ";";
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
        /// Inserta un registro de Gramatica 
        /// </summary>
        /// <param name="i">La nueva Gramatica a insertar</param>
        /// <returns>Retorna true si se pudo insertar el registro de lo contrario retorna false</returns>
        public bool insert(Gramatica i)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO Gramatica (IdGramatica,Sujeto,Verbo,Complemento) VALUES (@IdGramatica,@Sujeto,@Verbo,@Complemento);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@IdGramatica", i.IdGramatica);
                sqlcom.Parameters.AddWithValue("@Sujeto", i.Sujeto);
                sqlcom.Parameters.AddWithValue("@Verbo", i.Verbo);
                sqlcom.Parameters.AddWithValue("@Complemento", i.Complemento);
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        */
        public List<Gramatica> getByTema(int tema)
        {
            List<Gramatica> lista = new List<Gramatica>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("select * from gramatica natural join gramaticaportema where idTema ="+tema+";");
            DataTable dt = datos.Tables[0];
            Gramatica e;
            foreach (DataRow r in dt.Rows)
            {

                e = new Gramatica();
                e.IdGramatica = (int)r.ItemArray[0];
                e.Formula = (string)r.ItemArray[1];
                e.Tipo = (string)r.ItemArray[2];
                e.Voz = (string)r.ItemArray[3];
                e.TerceraPersona = (Boolean)r.ItemArray[4];
                lista.Add(e);
            }
            return lista;
        }
    }
}
