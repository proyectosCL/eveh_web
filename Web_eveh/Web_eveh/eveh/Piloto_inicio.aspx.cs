using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_eveh.eveh
{
    public partial class Piloto_inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cuenta = (string)(Session["session_usuario"]);
            lblpiloto.Text = "Bienvenido, " +cuenta;
        }
    }
}