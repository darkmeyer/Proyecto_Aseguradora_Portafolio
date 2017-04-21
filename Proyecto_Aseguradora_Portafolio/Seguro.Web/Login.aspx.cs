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
            ServicioSeguro.ServicioSeguroClient seguro = new ServicioSeguro.ServicioSeguroClient();

            Cliente cli = new Cliente()
            {
                Rut = Login1.UserName,
                Pass = Login1.Password
            };

            string xml = cli.Serializar();
            xml = seguro.leerCliente(xml);

            if (cli.validarCliente())
            {
                Session["cliente"] = new Cliente(xml);
                e.Authenticated = true;
            }
            else
            {
                e.Authenticated = false;
            }
        }
    }
}