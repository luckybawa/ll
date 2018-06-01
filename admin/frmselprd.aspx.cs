using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsuncarte.clsselprd obj = new nsuncarte.clsselprd();
        nsuncarte.clsselprdprp objprp = new nsuncarte.clsselprdprp();
        objprp.selprdprdcod = Convert.ToInt32(DropDownList3.SelectedValue);
        objprp.selprdselcod = Convert.ToInt32(Request.QueryString["scod"]);
        objprp.selprdprc = Convert.ToSingle(TextBox1.Text);
        objprp.selprdlnk = TextBox2.Text;
        if (Button1.Text == "Submit")
            obj.save_rec(objprp);
        else
        {
            objprp.selprdcod = Convert.ToInt32(ViewState["cod"]);
            obj.upd_rec(objprp);
            Button1.Text = "Submit";
        }
        TextBox1.Text = String.Empty;
        TextBox2.Text = String.Empty;
        GridView1.DataBind();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsuncarte.clsselprd obj = new nsuncarte.clsselprd();
        nsuncarte.clsselprdprp objprp = new nsuncarte.clsselprdprp();
        objprp.selprdcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.del_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 catcod, subcatcod, prdcod, selprdcod;
        selprdcod = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        catcod= Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][1]);
        subcatcod = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][2]);
        prdcod = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][3]);
        DropDownList1.DataBind();
        DropDownList1.SelectedIndex = -1;
        DropDownList1.Items.FindByValue(catcod.ToString()).Selected = true;
        DropDownList2.DataBind();
        DropDownList2.SelectedIndex = -1;
        DropDownList2.Items.FindByValue(subcatcod.ToString()).Selected = true;
        DropDownList3.DataBind();
        DropDownList3.SelectedIndex = -1;
        DropDownList3.Items.FindByValue(prdcod.ToString()).Selected = true;
        nsuncarte.clsselprd obj = new nsuncarte.clsselprd();
        List<nsuncarte.clsselprdprp> k = obj.fnd_rec(selprdcod);
        TextBox1.Text = k[0].selprdprc.ToString();
        TextBox2.Text = k[0].selprdlnk;
        ViewState["cod"] = selprdcod;
        Button1.Text = "Update";
        e.Cancel = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = string.Empty;
        TextBox2.Text = string.Empty;
        TextBox1.Focus();
        Button1.Text = "Submit";
    }
}