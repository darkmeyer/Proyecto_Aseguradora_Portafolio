using Seguro.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seguro.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Rut = Login1.UserName;
            cli.Pass = Login1.Password;

            cli.Leer();

            if (cli.validarCliente())
            {
                e.Authenticated = true;
            }
            else
            {
                e.Authenticated = false;
            }
        }
    }
}