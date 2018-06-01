using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Windows.Forms;
public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
      
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
            nsuncarte.clsusr obj = new nsuncarte.clsusr();
        Int32 cod;
        char rol;
        cod = obj.logincheck(txteml.Text, txtpwd.Text, out rol);
            if (cod == -1)
            {

            }
            else
            {
                FormsAuthenticationTicket tk = new FormsAuthenticationTicket
                      (1, txteml.Text, DateTime.Now, DateTime.Now.AddHours(2),
                      false, rol.ToString());
                String s = FormsAuthentication.Encrypt(tk);
                HttpCookie ck = new HttpCookie(
                    FormsAuthentication.FormsCookieName, s);
                Response.Cookies.Add(ck);
                Session["cod"] = cod;
                if (rol == 'A')
                {
                    Response.Redirect("admin/frmcat.aspx");

                }
                else if (rol == 'E')
                    Response.Redirect("expert/frmrev.aspx");
                else if (rol == 'U')
                {

                
            }
        }
    }
}
