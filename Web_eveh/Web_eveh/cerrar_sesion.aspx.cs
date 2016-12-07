using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_eveh
{
    public partial class cerrar_sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["session_usuario"] = null;
            Response.Redirect("~/inicio.aspx");

        }
    }
}