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
    public class GramaticaPorTemaDAO
    {
        /// <summary>
        /// Obtiene todos los registros almacenados en la tabla GramaticaPorTema
        /// </summary>
        /// <returns>Una lista de tipo Gramatica por Tema</returns>
        public List<GramaticaPorTema> getAll()
        {
            List<GramaticaPorTema> lista = new List<GramaticaPorTema>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM GramaticaPorTema" + ";");
            DataTable dt = datos.Tables[0];
            GramaticaPorTema e;
            foreach (DataRow r in dt.Rows)
            {

                e = new GramaticaPorTema();
                e.IdTema = (int)r.ItemArray[0];
                e.IdGramatica = (int)r.ItemArray[1];               
                lista.Add(e);
            }
            return lista;
        }
        /// <summary>
        /// Obtiene una Gramatica por tema por ID
        /// </summary>
        /// <param name="ID">ID del que se desea obtener su Gramatica por tema</param>
        /// <returns>Una Gramatica por tema</returns>
        public GramaticaPorTema getGramaticaPorTemaByID(int ID)
        {
            GramaticaPorTema res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM GramaticaPorTema WHERE IdGramatica = " + ID + ";");
            DataTable dt = datos.Tables[0];
            res = new GramaticaPorTema();
            DataRow row = dt.Rows[0];
            res.IdTema = (int)row.ItemArray[0];
            res.IdGramatica = (int)row.ItemArray[1];           
            return res;
        }
        /// <summary>
        /// Actualiza el registro de la Gramatica por tema en base al Id de la Gramatica por tema introducida
        /// </summary>
        /// <param name="e">Recibe una Gramatica por tema con los nuevos datos a actualizar</param>
        /// <returns>Retorna true en caso de actualizar de lo contrario retorna false</returns>
        public bool update(GramaticaPorTema e)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "UPDATE GramaticaPorTema SET" +
                    " IdTema=" + e.IdTema + ",IdGramatica=" + e.IdGramatica + 
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
        /// Elimina el registro de la Gramatica por tema en base al Id de la Gramatica por tema introducida
        /// </summary>
        /// <param name="t">La Gramatica por tema a eliminar</param>
        /// <returns>Retorna true si se pudo eliminar el registro de lo contrario retorna false</returns>
        public bool delete(GramaticaPorTema t)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM GramaticaPorTema WHERE" + " IdGramatica=" + t.IdGramatica + ";";
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
        /// Inserta un registro de Gramatica por tema 
        /// </summary>
        /// <param name="i">La nueva gramatica por tema a insertar</param>
        /// <returns>Retorna true si se pudo insertar el registro de lo contrario retorna false</returns>
        public bool insert(GramaticaPorTema i)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO GramaticaPorTema (IdTema,IdGramatica) VALUES (@IdTema,@IdGramatica);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@IdTema", i.IdTema);
                sqlcom.Parameters.AddWithValue("@IdGramatica", i.IdGramatica);                
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
