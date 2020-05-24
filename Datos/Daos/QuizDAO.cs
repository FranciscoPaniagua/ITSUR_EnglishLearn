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
    public  class QuizDAO
    {
        /// <summary>
        /// Obtiene todos los registros almacenados en la tabla Quiz
        /// </summary>
        /// <returns>Una lista de tipo Quiz</returns>
        public List<Quiz> getAll()
        {
            List<Quiz> lista = new List<Quiz>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM Quiz" + ";");
            DataTable dt = datos.Tables[0];
            Quiz q;
            foreach (DataRow r in dt.Rows)
            {

                q = new Quiz();
                q.idQuiz = (int)r.ItemArray[0];
                q.Nombre = (String)r.ItemArray[1];
                lista.Add(q);
            }
            return lista;
        }
        /// <summary>
        /// Obtiene un Quiz por ID
        /// </summary>
        /// <param name="ID">ID del que se desea obtener su Quiz</param>
        /// <returns>Un Quiz</returns>

        public Quiz getQuizByID(int ID)
        {
            Quiz res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM Quiz WHERE idQuiz = " + ID + ";");
            DataTable dt = datos.Tables[0];
            res = new Quiz();
            DataRow row = dt.Rows[0];
            res.idQuiz = (int)row.ItemArray[0];
            res.Nombre = (String)row.ItemArray[1];
            return res;
        }
        /// <summary>
        /// Elimina el registro del Quiz en base al IdQuiz del Quiz introducido
        /// </summary>
        /// <param name="idQuiz">El Quiz a eliminar</param>
        /// <returns>Retorna true si se pudo eliminar el registro de lo contrario retorna false</returns>
        public bool delete(int idQuiz)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM Quiz WHERE" + " idQuiz=" + idQuiz + ";";
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
        /// Actualiza el registro del Quiz en base al Id del Quiz introducido
        /// </summary>
        /// <param name="e">Recibe un Quiz con los nuevos datos a actualizar</param>
        /// <returns>Retorna true en caso de actualizar de lo contrario retorna false</returns>
        public bool update(Quiz q)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "UPDATE Quiz SET " + "Nombre='" + q.Nombre + "' WHERE idQuiz=" + q.idQuiz + ";";
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
        /// Inserta un Quiz 
        /// </summary>
        /// <param name="i">El nuevo Quiz a insertar</param>
        /// <returns>Retorna true si se pudo insertar el registro de lo contrario retorna false</returns>
        public bool insert(Quiz q)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO Quiz (idQuiz,Nombre) VALUES (@idQuiz,@Nombre);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@idQuiz", q.idQuiz);
                sqlcom.Parameters.AddWithValue("@Nombre", q.Nombre);

                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Pregunta> preguntas()
        {
            List<Pregunta> lista = new List<Pregunta>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("select p.idPregunta, p.Pregunta, p.RespuestaCorrecta, p.RespuestaIncorrecta1, p.RespuestaIncorrecta2, p.RespuestaIncorrecta3 from pregunta p, quiz q,preguntaporquiz pr where pr.IdQuiz=q.idQuiz and pr.idPregunta=p.idPregunta" + ";");
            DataTable dt = datos.Tables[0];
            Pregunta q;
            foreach (DataRow r in dt.Rows)
            {

                q = new Pregunta();
                q.idPregunta = (int)r.ItemArray[0];
                q.pregunta = (string)r.ItemArray[1];
                q.RespuestaCorrecta = (string)r.ItemArray[2];
                q.RespuestaIncorrecta1 = (string)r.ItemArray[3];
                q.RespuestaIncorrecta2 = (string)r.ItemArray[4];
                q.RespuestaIncorrecta3 = (string)r.ItemArray[5];
                lista.Add(q);
            }
            return lista;
        }

        public bool insertRespuesta(PreguntaContestadaPorUsuaruio i)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO PreguntaContestadaPorUsuaruio (User,IdPregunta,Contesto) VALUES (@User,@IdPregunta,@Contesto);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                sqlcom.Parameters.AddWithValue("@User", i.User);
                sqlcom.Parameters.AddWithValue("@IdPregunta", i.IdPregunta);
                sqlcom.Parameters.AddWithValue("@Contesto", i.Contesto);
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
