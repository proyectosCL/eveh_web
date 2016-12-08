using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_eveh.BD;

namespace Web_eveh.eveh
{
	public partial class horas_piloto_avion : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            lblHoras.Text =Consultas.mostrar_horas_piloto_avion((string)(Session["session_usuario"]));

        }
	}
}