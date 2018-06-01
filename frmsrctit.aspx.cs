using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        nsuncarte.clsprd obj = new nsuncarte.clsprd();
        DataList1.DataSource = obj.srcprdbytit("%"+ TextBox1.Text + "%");
        DataList1.DataBind();
    }
}