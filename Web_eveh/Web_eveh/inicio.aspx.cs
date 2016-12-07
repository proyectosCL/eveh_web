using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_eveh.BD;

namespace Web_eveh
{
    public partial class inicio : System.Web.UI.Page
    {


        public string md5(string password)
        {
            //Declaraciones
            System.Security.Cryptography.MD5 md5;
            md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            //Conversion
            Byte[] encodedBytes = md5.ComputeHash(ASCIIEncoding.Default.GetBytes(password));  //genero el hash a partir de la password original

            //Resultado

            //return BitConverter.ToString(encodedBytes);      //esto, devuelve el hash con "-" cada 2 char
            return System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(encodedBytes).ToLower(), @"-", "");     //devuelve el hash continuo y en minuscula. (igual que en php)
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string pas = md5(txtConstraseña.Text);
            string user = txtUsuario.Text;
            USUARIOS usu;






            try
                {
                    usu = Consultas.autentificarUsuario(user,pas);
                    if (usu==null)
                    {
                        Label1.Text = "no enttro";
                        Response.Write("<script LANGUAGE='JavaScript' >alert('No se Pudo iniciar sesión, intente nuevamente')</script>");


                    }
                    else
                    {
                        Session["session_usuario"] = usu.CUENTA;
                        Response.Redirect("~/eveh/Piloto_inicio.aspx");
                    }

                }
                catch (Exception ex)
                {

                    txtUsuario.Text = ex.Message;
                }

            

            
        }
    }
}