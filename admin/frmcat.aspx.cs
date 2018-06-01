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

    protected void btnsub_Click(object sender, EventArgs e)
    {
        nsuncarte.clscat obj = new nsuncarte.clscat();
        nsuncarte.clscatprp objprp = new nsuncarte.clscatprp();
        objprp.catnam = txtcat.Text;
        String s = filupl.PostedFile.FileName;
        if (s != "")
            s = s.Substring(s.LastIndexOf('.'));
        objprp.catban = s;
        Int32 a;
        if(btnsub.Text=="Submit")
            a=obj.save_rec(objprp);
        else
        {
            a = Convert.ToInt32(ViewState["cod"]);
            objprp.catcod = a;
            if (s== "")
                objprp.catban = ViewState["fil"].ToString();
            obj.upd_rec(objprp);
            btnsub.Text = "Submit";
        }
        if (s != "")
            filupl.PostedFile.SaveAs(Server.MapPath("../banners") + "//" + a.ToString() + s);
        txtcat.Text = String.Empty;
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsuncarte.clscat obj = new nsuncarte.clscat();
        nsuncarte.clscatprp objprp = new nsuncarte.clscatprp();
        objprp.catcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.del_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        nsuncarte.clscat obj = new nsuncarte.clscat();
        List<nsuncarte.clscatprp> k = obj.fnd_rec(a);
        txtcat.Text = k[0].catnam;
        btnsub.Text = "Update";
        ViewState["cod"] = a;
        ViewState["fil"] = k[0].catban;
        e.Cancel = true;

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        txtcat.Text = String.Empty;
        btnsub.Text = "Submit";
    }
}



