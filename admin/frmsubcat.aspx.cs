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
        nsuncarte.clssubcat obj = new nsuncarte.clssubcat();
        nsuncarte.clssubcatprp objprp = new nsuncarte.clssubcatprp();
        objprp.subcatnam = TextBox1.Text;
        objprp.subcatcatcod = Convert.ToInt32(DropDownList1.SelectedValue);
        if (Button1.Text == "Submit")
            obj.save_rec(objprp);
        else
        {
            objprp.subcatcod = Convert.ToInt32(ViewState["cod"]);
            obj.upd_rec(objprp);
            Button1.Text = "Submit";

        }
        GridView1.DataBind();
        TextBox1.Text = String.Empty;
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsuncarte.clssubcat obj = new nsuncarte.clssubcat();
        nsuncarte.clssubcatprp objprp = new nsuncarte.clssubcatprp();
        objprp.subcatcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.del_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        nsuncarte.clssubcat obj = new nsuncarte.clssubcat();
        List<nsuncarte.clssubcatprp> x = obj.fnd_rec(Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]));
        DropDownList1.SelectedIndex = -1;
        DropDownList1.Items.FindByValue(x[0].subcatcatcod.ToString()).Selected = true;
        TextBox1.Text = x[0].subcatnam;
        ViewState["cod"] = x[0].subcatcod;
        Button1.Text = "Update";
        e.Cancel = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = String.Empty;
        Button1.Text = "Submit";
    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}