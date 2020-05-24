using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos.Util;
using Datos.Modelo;
using MySql.Data.MySqlClient;

namespace Datos.Daos
{
    public class PracticaDAO
    {
        /// <summary>
        /// Obtiene todos los registros almacenados en la tabla Practica
        /// </summary>
        /// <returns>Una lista de tipo Practica</returns>
        public List<Practica> getAll()
        {
            List<Practica> lista = new List<Practica>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM Practica"+";");
            DataTable dt = datos.Tables[0];
            Practica e;
            foreach (DataRow r in dt.Rows)
            {

                e = new Practica();
                e.IdPractica = (int)r.ItemArray[0];
                e.Correctas = (int)r.ItemArray[1];
                e.IdTema = (int)r.ItemArray[2];
                e.User = (string)r.ItemArray[3];
                lista.Add(e);
            }
            return lista;
        }
        /// <summary>
        /// Obtiene una Practica por ID
        /// </summary>
        /// <param name="ID">ID del que se desea obtener su Practica</param>
        /// <returns>Una Practica del Usuario</returns>
        public Practica getPracticaByID(int ID)
        {
            Practica res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("SELECT * FROM Practica WHERE IdPractica = " + ID+";");
            DataTable dt = datos.Tables[0];
            res = new Practica();
            DataRow row = dt.Rows[0];
            res.IdPractica = (int)row.ItemArray[0];
            res.Correctas = (int)row.ItemArray[1];
            res.IdTema = (int)row.ItemArray[2];
            res.User = (string)row.ItemArray[3];
            return res;
        }
        /// <summary>
        /// Elimina el registro de la Practica en base al Id de la Practica introducida
        /// </summary>
        /// <param name="t">La Practica a eliminar</param>
        /// <returns>Retorna true si se pudo eliminar el registro de lo contrario retorna false</returns>
        public bool delete(Practica t)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "DELETE FROM Practica WHERE" + " IdPractica=" + t.IdPractica + ";";
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
        /// Actualiza el registro de la Practica en base al Id de la Practica introducida
        /// </summary>
        /// <param name="e">Recibe una Practica con los nuevos datos a actualizar</param>
        /// <returns>Retorna true en caso de actualizar de lo contrario retorna false</returns>
        public bool update(Practica e)
        {
            Conexion conexion = new Conexion();


            try
            {
                String SQL = "UPDATE Practica SET" +
                    " IdPractica=" + e.IdPractica + ",Correctas=" + e.Correctas + ",IdTema=" + e.IdTema + ",User=" + e.User +
                    " WHERE IdPractica=" + e.IdPractica + ";";
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
        /// Inserta un registro de Practica 
        /// </summary>
        /// <param name="i">La nueva Practica a insertar</param>
        /// <returns>Retorna true si se pudo insertar el registro de lo contrario retorna false</returns>
        public bool insert(Practica i)
        {
            try
            {
                Conexion conexion = new Conexion();
                String SQL = "INSERT INTO Practica (IdPractica,Correctas,IdTema,User) VALUES (null,@Correctas,@IdTema,@User);";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                //sqlcom.Parameters.AddWithValue("@IdPractica", "null");
                sqlcom.Parameters.AddWithValue("@Correctas", i.Correctas);
                sqlcom.Parameters.AddWithValue("@IdTema", i.IdTema);
                sqlcom.Parameters.AddWithValue("@User", i.User);
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //Código de Paloma para estadísticas
        public int getTotalPresenteByUser(String user)
        {
            Practica res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("select max(correctas) as correctas from practica where user like '"+user+"' and idTema=1;");
            DataTable dt = datos.Tables[0];
            res = new Practica();
            DataRow row = dt.Rows[0];
            int total = (int)row.ItemArray[0];
            return total;
        }
        public int getTotalPasadoByUser(String user)
        {
            Practica res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("select max(correctas) as correctas from practica where user like '" + user + "' and idTema=2;");
            DataTable dt = datos.Tables[0];
            res = new Practica();
            DataRow row = dt.Rows[0];
            int total = (int)row.ItemArray[0];
            return total;
        }
        public int getTotalVerbosByUser(String user)
        {
            Practica res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("select max(correctas) as correctas from practica where user like '" + user + "' and idTema=3;");
            DataTable dt = datos.Tables[0];
            res = new Practica();
            DataRow row = dt.Rows[0];
            int total = (int)row.ItemArray[0];
            return total;
        }
        public int getTotalVocabularioByUser(String user)
        {
            Practica res;
            Conexion conexion = new Conexion();
            DataSet datos = conexion.LLenaComboGrid("select max(correctas) as correctas from practica where user like '" + user + "' and idTema=4;");
            DataTable dt = datos.Tables[0];
            res = new Practica();
            DataRow row = dt.Rows[0];
            int total = (int)row.ItemArray[0];
            return total;
        }


    }
}
