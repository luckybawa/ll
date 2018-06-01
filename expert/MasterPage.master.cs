using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class expert_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lk_Click(object sender, EventArgs e)
    {
        if (Session["cod"] != null)
        {
            Session.Abandon();
            Response.Redirect("../index.aspx");
        }
    }
}
