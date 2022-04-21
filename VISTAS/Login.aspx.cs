using MODELOS;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
   
namespace VISTAS
{
    public partial class Login : System.Web.UI.Page
    {
        UsuarioService servicioUsuario;
        //Constructor de clase
        public Login()
        {
            servicioUsuario = new UsuarioService();
        }
           
        protected void Page_Load(object sender, EventArgs e)
        {
            lbErrores.Text = "";
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {/*
            UsuarioModel usuario = new UsuarioModel();
            usuario.USUARIO = txtuser.Text;
            usuario.PASSWORD = txtpass.Text;

            string respuesta = servicioUsuario.UsuarioLogin(usuario);

            if (respuesta !="") lbErrores.Text = $"{respuesta}";
            else lbErrores.Text = "BIENVENIDO";
           */
            string user = txtuser.Text;
            string password = txtpass.Text;
            string userName = "juan";
            string passName = "juan";
            if (user.Equals(userName) && password.Equals(passName))
            {
                Response.Write("<script>alert('USUARIO CORRECTO')</script>");
                Response.Redirect("PanelGeneral.aspx");
            }
            else
            {
                Response.Write("<script>alert('USUARIO INCORRECTO')</script>");
            }
        }

        protected void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}