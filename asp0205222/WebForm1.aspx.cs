using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp0205222
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("Klik op VERSTUUR om te versturen!");
            }

            else
            {
                Response.Write("Je hebt reeds op VERSTUUR geklikt!");
            }
        }

        protected void Button(object sender, EventArgs e)
        {



        }
    }
}