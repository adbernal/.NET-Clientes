using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clientes_Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_user.Text == "usuario" && txt_pass.Text == "123")
            {
                Response.Redirect("Menu.aspx");
                
            }else
            {
                lbl_error.Text = "ERROR DE USUARIO";
            }
        }
    }
}