using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Daos;
using Datos.Modelo;

namespace IEL.Vistas
{
    public partial class AreaDePractica : System.Web.UI.Page
    {
        //private int tema;
        //private string usuario;
        //private Tematica[] preguntas = new Tematica[10];
        //public class Tematica
        //{
        //    public string Oracion { get; set; }
        //    public string Buena { get; set; }
        //    public string mala1 { get; set; }
        //    public string mala2 { get; set; }
        //    public string Respuesta { get; set; }
        //    override
        //    public string ToString()
        //    {
        //        string cadena;
        //        cadena = Oracion + "#" + Buena+"#"+mala1+"#"+mala2+"#"+Respuesta;
        //        return cadena;
        //    }
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["usuario"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}else
            //{
            //    if (Session["flag"]==null)
            //    {
            //        Session["posicion"] = 0;
            //        usuario = Session["usuario"].ToString();
            //        //Cambiar por la session
            //        tema = 1;
            //        GramaticaDAO dao = new GramaticaDAO();
            //        List<Gramatica> lista = dao.getByTema(tema);
            //        Gramatica gramatica = lista[new Random().Next(0, lista.Count)];
            //        string[] arr = gramatica.Formula.Split('_');
            //        //10 preguntas

            //        SujetoDAO sujetoDao = new SujetoDAO();
            //        List<Sujeto> sujetos = sujetoDao.getAll();
            //        VerboDAO verboDao = new VerboDAO();
            //        List<Verbo> verbos = verboDao.getAll();
            //        int no, nov;
            //        for (int i = 0; i < 10; i++)
            //        {
            //            Tematica tmt = new Tematica();

            //            no = new Random().Next(0, sujetos.Count);                       
            //            nov = new Random().Next(0, verbos.Count-10);
            //            nov += i;
            //            for (int j = 0; j < arr.Length; j++)
            //            {
            //                switch (arr[j])
            //                {
            //                    case "sujeto":
            //                        tmt.Oracion = sujetos[no].sujeto + " ";
            //                        break;
            //                    case "tobe":
            //                        tmt.Oracion += "   ";
            //                        tmt.Buena = sujetos[no].ser;
            //                        if (tmt.Buena.Equals("am"))
            //                        {
            //                            tmt.mala1 = "are";
            //                            tmt.mala2 = "is";
            //                        }
            //                        else if (tmt.Buena.Equals("is"))
            //                        {
            //                            tmt.mala1 = "are";
            //                            tmt.mala2 = "am";
            //                        }
            //                        else
            //                        {
            //                            tmt.mala1 = "am";
            //                            tmt.mala2 = "is";
            //                        }
            //                        break;
            //                    case "verbopresentesimple":
            //                        if (gramatica.TerceraPersona)
            //                        {
            //                            tmt.Oracion += verbos[nov].VerboPresenteSimple + "s ";
            //                        }
            //                        else
            //                        {
            //                            tmt.Oracion += verbos[nov].VerboPresenteSimple + " ";
            //                        }
            //                        break;
            //                    case "not":
            //                        tmt.Oracion += "not ";
            //                        break;
            //                    case "complemento":
            //                        tmt.Oracion += "in the school";
            //                        break;
            //                    default:
            //                        break;
            //                }
            //            }
            //            preguntas[i] = tmt;
            //        }
            //        string cadena="";
            //        for(int i=0; i<10; i++)
            //        {
            //            cadena += preguntas[i].ToString();
            //            if (i < 9)
            //            {
            //                cadena += "$";
            //            }
            //        }
            //        Session["flag"] = cadena;
            //        txtPregunta.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Oracion;
            //        int mun = new Random().Next(0, 3);
            //        if (mun == 0)
            //        {
            //            rdbA.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Buena;
            //            rdbB.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala1;
            //            rdbC.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala2;
            //        }
            //        else if (mun == 1)
            //        {
            //            rdbA.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala1;
            //            rdbB.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Buena;
            //            rdbC.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala2;
            //        }
            //        else if (mun == 2)
            //        {
            //            rdbA.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala1;
            //            rdbB.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala2;
            //            rdbC.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Buena;

            //        }
            //    }
            //    else
            //    {
            //        string[] des = Session["flag"].ToString().Split('$');
            //        for(int i=0; i<des.Length; i++)
            //        {
            //            string[] der = des[i].Split('#');
            //            preguntas[i] = new Tematica() { Oracion=der[0],Buena=der[1],mala1=der[2],mala2=der[3],Respuesta=der[4]};
            //        }
            //    }
            //}
            
        }

      

    
        //protected void btnAnterior_Click(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt32(Session["posicion"].ToString()) > 0)
        //    {
        //        Session["posicion"] = Convert.ToInt32(Session["posicion"].ToString())-1;
        //        txtPregunta.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Oracion;
        //        int mun = new Random().Next(0, 3);
        //        if (mun == 0)
        //        {
        //            rdbA.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Buena;
        //            rdbB.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala1;
        //            rdbC.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala2;
        //        }
        //        else if (mun == 1)
        //        {
        //            rdbA.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala1;
        //            rdbB.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Buena;
        //            rdbC.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala2;
        //        }
        //        else if (mun == 2)
        //        {
        //            rdbA.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala1;
        //            rdbB.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala2;
        //            rdbC.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Buena;

        //        }
        //    }
        //}

        //protected void btnSiguiente_Click(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt32(Session["posicion"].ToString()) < 9)
        //    {
        //        Session["posicion"] = Convert.ToInt32(Session["posicion"].ToString()) + 1;
        //        txtPregunta.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Oracion;
        //        int mun = new Random().Next(0, 3);
        //        if (mun == 0)
        //        {
        //            rdbA.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Buena;
        //            rdbB.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala1;
        //            rdbC.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala2;
        //        }
        //        else if (mun == 1)
        //        {
        //            rdbA.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala1;
        //            rdbB.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Buena;
        //            rdbC.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala2;
        //        }
        //        else if (mun == 2)
        //        {
        //            rdbA.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala1;
        //            rdbB.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].mala2;
        //            rdbC.Text = preguntas[Convert.ToInt32(Session["posicion"].ToString())].Buena;

        //        }
        //    }
        //}

        //protected void rdbA_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdbA.Checked == true)
        //    {
        //        preguntas[Convert.ToInt32(Session["posicion"].ToString())].Respuesta = rdbA.Text;
        //        rdbB.Checked = false;
        //        rdbC.Checked = false;
        //    }
        //}
        //protected void rdbB_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdbB.Checked == true)
        //    {
        //        preguntas[Convert.ToInt32(Session["posicion"].ToString())].Respuesta = rdbB.Text;
        //        rdbA.Checked = false;
        //        rdbC.Checked = false;
        //    }
        //}
        //protected void rdbC_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdbC.Checked == true)
        //    {
        //        preguntas[Convert.ToInt32(Session["posicion"].ToString())].Respuesta = rdbC.Text;
        //        rdbB.Checked = false;
        //        rdbA.Checked = false;
        //    }
        //}
    }
}