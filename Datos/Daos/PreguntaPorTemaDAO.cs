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
    public class PreguntaPorTemaDAO
    {
        /// <summary>
        /// Obtiene todos los registros almacenados en la tabla PreguntaPorTema
        /// </summary>
        /// <returns>Una lista de tipo PreguntaPorTema</returns>
        public List<PreguntaPorTema> getAll()
        {
            List<PreguntaPorTema> lista = new List<PreguntaPorTema>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM PreguntaPorTema" + ";");
            DataTable dt = datos.Tables[0];
            PreguntaPorTema ppt;
            foreach (DataRow r in dt.Rows)
            {

                ppt = new PreguntaPorTema();

                ppt.IdPregunta = (int)r.ItemArray[0];
                ppt.IdTema = (int)r.ItemArray[1];
                lista.Add(ppt);
            }
            return lista;
        }

        //Agregado
        public List<PreguntaPorTema> getPreguntasPorTema(int idTema)
        {
            List<PreguntaPorTema> lista = new List<PreguntaPorTema>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM PreguntaPorTema where idTema=" +idTema+ ";");
            DataTable dt = datos.Tables[0];
            PreguntaPorTema ppt;
            foreach (DataRow r in dt.Rows)
            {

                ppt = new PreguntaPorTema();

                ppt.IdPregunta = (int)r.ItemArray[0];
                ppt.IdTema = (int)r.ItemArray[1];
                lista.Add(ppt);
            }
            return lista;
        }
        /// <summary>
        /// Obtiene una PreguntaPorTema por ID
        /// </summary>
        /// <param name="ID">ID del que se desea obtener su PreguntaPorTema</param>
        /// <returns>Una PreguntaPorTema del ID</returns>
        public PreguntaPorTema getPreguntaPorTemaByID(int ID)
        {
            PreguntaPorTema res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM PreguntaPorTema WHERE IdTema = " + ID + ";");
            DataTable dt = datos.Tables[0];
            res = new PreguntaPorTema();
            DataRow row = dt.Rows[0];
            res.IdPregunta = (int)row.ItemArray[0];
            res.IdTema = (int)row.ItemArray[1];
            return res;
        }
        /// <summary>
        /// Elimina el registro de la PreguntaPorTema en base al IdPregunta de la PreguntaPorTema introducida
        /// </summary>
        /// <param name="IdPregunta">El Id de la preguntaPorTema</param>
        /// <returns>Retorna true si se pudo eliminar el registro de lo contrario retorna false</returns>
        public bool delete(int IdPregunta)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM PreguntaPorTema WHERE" + " IdPregunta=" + IdPregunta + ";";
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
        /// Actualiza el registro de la PreguntaPorTema en base al Id de la PreguntaPorTema introducida
        /// </summary>
        /// <param name="p">Recibe una PreguntaPorTema con los nuevos datos a actualizar</param>
        /// <returns>Retorna true en caso de actualizar de lo contrario retorna false</returns>
        public bool update(PreguntaPorTema p)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "UPDATE PreguntaPorTema SET" +
                    " idPregunta=" + p.IdPregunta + ",idTema=" + p.IdTema + " WHERE idPregunta=" + p.IdPregunta + ";";
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
        /// Inserta un registro de PreguntaPorTema 
        /// </summary>
        /// <param name="p">La nueva PreguntaPorTema a insertar</param>
        /// <returns>Retorna true si se pudo insertar el registro de lo contrario retorna false</returns>
        public bool insert(PreguntaPorTema p)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO PreguntaPorTema (IdPregunta,IdTema) VALUES (@IdPregunta,@IdTema);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@IdPregunta", p.IdPregunta);
                sqlcom.Parameters.AddWithValue("@IdTema", p.IdTema);
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
