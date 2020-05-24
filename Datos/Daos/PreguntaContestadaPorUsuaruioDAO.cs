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
    public class PreguntaContestadaPorUsuaruioDAO
    {
        /// <summary>
        /// Obtiene todos los registros almacenados en la tabla Pregunta contestada por usuario
        /// </summary>
        /// <returns>Una lista de tipo pregunta contestada por usuario</returns>
        public List<PreguntaContestadaPorUsuaruio> getAll()
        {
            List<PreguntaContestadaPorUsuaruio> lista = new List<PreguntaContestadaPorUsuaruio>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM PreguntaContestadaPorUsuaruio" + ";");
            DataTable dt = datos.Tables[0];
            PreguntaContestadaPorUsuaruio e;
            foreach (DataRow r in dt.Rows)
            {

                e = new PreguntaContestadaPorUsuaruio();
                e.User = (string)r.ItemArray[0];
                e.IdPregunta = (int)r.ItemArray[1];
                e.Contesto = (string)r.ItemArray[2];               
                lista.Add(e);
            }
            return lista;
        }
        /// <summary>
        /// Obtiene una Estadistica por ID
        /// </summary>
        /// <param name="ID">ID de la Pregunta contestada por el usuario</param>
        /// <returns>Una Pregunta contestada del Usuario</returns>
        public PreguntaContestadaPorUsuaruio getPreguntaContestadaPorUsuaruioByID(int ID)
        {
            PreguntaContestadaPorUsuaruio res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM PreguntaContestadaPorUsuaruio WHERE IdPregunta = " + ID + ";");
            DataTable dt = datos.Tables[0];
            res = new PreguntaContestadaPorUsuaruio();
            DataRow row = dt.Rows[0];
            res.User = (string)row.ItemArray[0];
            res.IdPregunta = (int)row.ItemArray[1];
            res.Contesto = (string)row.ItemArray[2];            
            return res;
        }


        //Agregado
        public List<PreguntaContestadaPorUsuaruio> getPreguntasCorrectasPresenteSimple(String user)
        {
            List<PreguntaContestadaPorUsuaruio> lista = new List<PreguntaContestadaPorUsuaruio>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("select pcu.user, pcu.idPregunta, pcu.Contesto from preguntacontestadaporusuaruio pcu, preguntaportema pt "+
                "where pcu.idPregunta = pt.idPregunta and pt.IdTema = 1  and pcu.user like '"+user+ "' and pcu.contesto ='Correcto';");
            DataTable dt = datos.Tables[0];
            PreguntaContestadaPorUsuaruio e;
            foreach (DataRow r in dt.Rows)
            {

                e = new PreguntaContestadaPorUsuaruio();
                e.User = (string)r.ItemArray[0];
                e.IdPregunta = (int)r.ItemArray[1];
                e.Contesto = (string)r.ItemArray[2];
                lista.Add(e);
            }
            return lista;
        }
        public List<PreguntaContestadaPorUsuaruio> getPreguntasCorrectasPasadoSimple(String user)
        {
            List<PreguntaContestadaPorUsuaruio> lista = new List<PreguntaContestadaPorUsuaruio>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("select pcu.user, pcu.idPregunta, pcu.Contesto from preguntacontestadaporusuaruio pcu, preguntaportema pt " +
                "where pcu.idPregunta = pt.idPregunta and pt.IdTema = 2  and pcu.user like '" + user + "' and pcu.contesto ='Correcto';");
            DataTable dt = datos.Tables[0];
            PreguntaContestadaPorUsuaruio e;
            foreach (DataRow r in dt.Rows)
            {

                e = new PreguntaContestadaPorUsuaruio();
                e.User = (string)r.ItemArray[0];
                e.IdPregunta = (int)r.ItemArray[1];
                e.Contesto = (string)r.ItemArray[2];
                lista.Add(e);
            }
            return lista;
        }
        public List<PreguntaContestadaPorUsuaruio> getPreguntasCorrectasVerbos(String user)
        {
            List<PreguntaContestadaPorUsuaruio> lista = new List<PreguntaContestadaPorUsuaruio>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("select pcu.user, pcu.idPregunta, pcu.Contesto from preguntacontestadaporusuaruio pcu, preguntaportema pt " +
                "where pcu.idPregunta = pt.idPregunta and pt.IdTema = 3  and pcu.user like '" + user + "' and pcu.contesto ='Correcto';");
            DataTable dt = datos.Tables[0];
            PreguntaContestadaPorUsuaruio e;
            foreach (DataRow r in dt.Rows)
            {

                e = new PreguntaContestadaPorUsuaruio();
                e.User = (string)r.ItemArray[0];
                e.IdPregunta = (int)r.ItemArray[1];
                e.Contesto = (string)r.ItemArray[2];
                lista.Add(e);
            }
            return lista;
        }
        public List<PreguntaContestadaPorUsuaruio> getPreguntasCorrectasVocabulario(String user)
        {
            List<PreguntaContestadaPorUsuaruio> lista = new List<PreguntaContestadaPorUsuaruio>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("select pcu.user, pcu.idPregunta, pcu.Contesto from preguntacontestadaporusuaruio pcu, preguntaportema pt " +
                "where pcu.idPregunta = pt.idPregunta and pt.IdTema = 4  and pcu.user like '" + user + "' and pcu.contesto ='Correcto';");
            DataTable dt = datos.Tables[0];
            PreguntaContestadaPorUsuaruio e;
            foreach (DataRow r in dt.Rows)
            {

                e = new PreguntaContestadaPorUsuaruio();
                e.User = (string)r.ItemArray[0];
                e.IdPregunta = (int)r.ItemArray[1];
                e.Contesto = (string)r.ItemArray[2];
                lista.Add(e);
            }
            return lista;
        }
        /// <summary>
        /// Elimina el registro de la Pregunta en base al Id de la Pregunta contestada por el usuario
        /// </summary>
        /// <param name="t">La pregunta contestada por el usuario</param>
        /// <returns>Retorna true si se pudo eliminar el registro de lo contrario retorna false</returns>
        public bool delete(PreguntaContestadaPorUsuaruio t)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM PreguntaContestadaPorUsuaruio WHERE" + " IdPregunta=" + t.IdPregunta + ";";
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
        /// Actualiza el registro de la Pregunta en base al Id de la Pregunta contestada por el usuario
        /// </summary>
        /// <param name="e">Recibe una Pregunta contestada por el usuario con los nuevos datos a actualizar</param>
        /// <returns>Retorna true en caso de actualizar de lo contrario retorna false</returns>
        public bool update(PreguntaContestadaPorUsuaruio e)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "UPDATE PreguntaContestadaPorUsuaruio SET" +
                    " User=" + e.User + ",IdPregunta=" + e.IdPregunta + ",Contesto=" + e.Contesto +
                    " WHERE IdPregunta=" + e.IdPregunta + ";";
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
        /// Inserta un registro de Pregunta contestada por usuario 
        /// </summary>
        /// <param name="i">La nueva Pregunta contestada por el usuario a insertar</param>
        /// <returns>Retorna true si se pudo insertar el registro de lo contrario retorna false</returns>
        public bool insert(PreguntaContestadaPorUsuaruio i)
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
