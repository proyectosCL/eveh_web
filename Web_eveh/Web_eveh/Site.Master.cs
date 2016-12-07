using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_eveh
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["session_usuario"] == null)
            {
                Response.Redirect("~/inicio.aspx");
            }
            else
            {
                lblusuario.Text = Session["session_usuario"]+"";
                lbllink.Visible = true;
            }

        }
    }
}