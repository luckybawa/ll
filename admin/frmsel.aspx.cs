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
        Int32 a = 0;
        nsuncarte.clssel obj = new nsuncarte.clssel();
        nsuncarte.clsselprp objprp = new nsuncarte.clsselprp();
        objprp.selnam = TextBox1.Text;
        objprp.seltrm = TextBox2.Text;
        string s = FileUpload1.PostedFile.FileName;
        if(s!="")
            s = s.Substring(s.LastIndexOf("."));
        objprp.sellog = s;
        if (Button1.Text == "Submit")
            a = obj.save_rec(objprp);
        else
        {
            a = Convert.ToInt32(ViewState["cod"]);
            objprp.selcod = a;
            if(s=="")
                objprp.sellog = ViewState["fil"].ToString();
            obj.upd_rec(objprp);
            Button1.Text = "Submit";
        }
        if(s!="")
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../selpics") +"//"+ a.ToString() + s);
        TextBox1.Text = string.Empty;
        TextBox2.Text = string.Empty;
        GridView1.DataBind();
    }

  
     protected  void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        nsuncarte.clssel obj = new nsuncarte.clssel();
        List<nsuncarte.clsselprp> k = obj.fnd_rec(a);
        TextBox1.Text = k[0].selnam;
        TextBox2.Text = k[0].seltrm;
        Button1.Text = "Update";
        ViewState["cod"] = a;
        ViewState["fil"] = k[0].sellog;
        e.Cancel = true;
    }



    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsuncarte.clssel obj = new nsuncarte.clssel();
        nsuncarte.clsselprp objprp = new nsuncarte.clsselprp();
        objprp.selcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.del_rec(objprp);
        GridView1.DataBind();
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