using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Daos;

namespace IEL.Vistas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string contrasenia = txtPassword.Value;
            string usuario = txtUser.Value;
            if (contrasenia.Equals("") || usuario.Equals(""))
            {
                Response.Write("<script>alert('Ingrese todos los campos');</script>");
            }else
            {
                UsuarioDAO dao = new UsuarioDAO();
                if (dao.getUsuario(usuario, contrasenia))
                {
                    Session["usuario"] = usuario;
                                   
                    Response.Redirect("Principal.aspx");
                }else
                {
                    Response.Write("<script>alert('El usuario y la contraseña no coincide');</script>");
                }             
            }
        }
    }
}