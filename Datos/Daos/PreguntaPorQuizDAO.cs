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
    public class PreguntaPorQuizDAO
    {
        /// <summary>
        /// Obtiene todos los registros almacenados en la tabla Pregunta por Quiz
        /// </summary>
        /// <returns>Una lista de tipo Pregunta por Quiz</returns>
        public List<PreguntaPorQuiz> getAll()
        {
            List<PreguntaPorQuiz> lista = new List<PreguntaPorQuiz>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM PreguntaPorQuiz" + ";");
            DataTable dt = datos.Tables[0];
            PreguntaPorQuiz e;
            foreach (DataRow r in dt.Rows)
            {

                e = new PreguntaPorQuiz();
                e.IdPreguntaQuiz = (int)r.ItemArray[0];
                e.IdPregunta = (int)r.ItemArray[1];
                e.IdQuiz = (int)r.ItemArray[2];               
                lista.Add(e);
            }
            return lista;
        }
        /// <summary>
        /// Obtiene una Pregunta por Quiz por ID
        /// </summary>
        /// <param name="ID">ID del que se desea obtener su Pregunta por Quiz</param>
        /// <returns>Una Pregunta por Quiz del ID</returns>
        public PreguntaPorQuiz getPreguntaPorQuizByID(int ID)
        {
            PreguntaPorQuiz res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM PreguntaPorQuiz WHERE IdPreguntaQuiz = " + ID + ";");
            DataTable dt = datos.Tables[0];
            res = new PreguntaPorQuiz();
            DataRow row = dt.Rows[0];
            res.IdPreguntaQuiz = (int)row.ItemArray[0];
            res.IdPregunta = (int)row.ItemArray[1];
            res.IdQuiz = (int)row.ItemArray[2];          
            return res;
        }
        /// <summary>
        /// Elimina el registro de la Pregunta Quiz en base al IdPreguntaQuiz de la Pregunta Quiz introducida
        /// </summary>
        /// <param name="IdPreguntaQuiz">El Id de la pregunta Quiz</param>
        /// <returns>Retorna true si se pudo eliminar el registro de lo contrario retorna false</returns>
        public bool delete(int IdPreguntaQuiz)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM PreguntaPorQuiz WHERE" + " IdPreguntaQuiz=" + IdPreguntaQuiz + ";";
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
        /// Actualiza el registro de la Pregunta Quiz en base a la PreguntaQuiz introducida
        /// </summary>
        /// <param name="e">Recibe una PreguntaQuiz con los nuevos datos a actualizar</param>
        /// <returns>Retorna true en caso de actualizar de lo contrario retorna false</returns>
        public bool update(PreguntaPorQuiz e)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "UPDATE PreguntaPorQuiz SET " + "IdPregunta=" + e.IdPregunta + ",IdQuiz=" + e.IdQuiz +
                    " WHERE IdPreguntaQuiz=" + e.IdPreguntaQuiz + ";";
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
        /// Inserta un registro de preguntaPorQuiz 
        /// </summary>
        /// <param name="i">La nueva PreguntaPorQuiz a insertar</param>
        /// <returns>Retorna true si se pudo insertar el registro de lo contrario retorna false</returns>
        public bool insert(PreguntaPorQuiz i)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO PreguntaPorQuiz (IdPreguntaQuiz,IdPregunta,IdQuiz) VALUES (@IdPreguntaQuiz,@IdPregunta,@IdQuiz);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@IdPreguntaQuiz", i.IdPreguntaQuiz);
                sqlcom.Parameters.AddWithValue("@IdPregunta", i.IdPregunta);
                sqlcom.Parameters.AddWithValue("@IdQuiz", i.IdQuiz);                
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
