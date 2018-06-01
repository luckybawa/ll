using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class expert_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack ==false )
        {
            if (Request.QueryString["pcod"] == null)
                Response.Redirect("frmrev.aspx");
            else
            {
                nsuncarte.clsprd obj = new nsuncarte.clsprd();
                List<nsuncarte.clsprdprp> k = obj.fnd_rec(Convert.ToInt32(
                    Request.QueryString["pcod"]));
                Label1.Text = "Review For " + k[0].prdtit;
                nsuncarte.clsprdrev obj1 = new nsuncarte.clsprdrev();
         List<nsuncarte.clsprdrevprp> k1 = obj1.fnd_rec(Convert.ToInt32
      (Request.QueryString["pcod"]), Convert.ToInt32(Session["cod"]));
                if(k1.Count>0)
                {
                    TextBox1.Text = k1[0].prdrevtit;
                    TextBox2.Text = k1[0].prdrevdsc;
                    ViewState["cod"] = k1[0].prdrevcod;
                    Button1.Text = "Update";
                }
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsuncarte.clsprdrev obj = new nsuncarte.clsprdrev();
        nsuncarte.clsprdrevprp objprp = new nsuncarte.clsprdrevprp();
        objprp.prdrevdat = DateTime.Now;
        objprp.prdrevdsc = TextBox2.Text;
        objprp.prdrevexpcod = Convert.ToInt32(Session["cod"]);
        objprp.prdrevprdcod = Convert.ToInt32(Request.QueryString["pcod"]);
        objprp.prdrevtit = TextBox1.Text;
        if (Button1.Text == "Submit")
            obj.save_rec(objprp);
        else
        {
            objprp.prdrevcod = Convert.ToInt32(ViewState["cod"]);
            obj.upd_rec(objprp);
        }
        Response.Redirect("frmrev.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = string.Empty;
        TextBox2.Text = string.Empty;
        TextBox1.Focus();
        Button1.Text = "Submit";
    }
}