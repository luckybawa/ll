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
        if(Page.IsPostBack ==false )
        {
            if (Request.QueryString["pcod"] == null)
            {
                TabContainer1.Tabs[1].Enabled = false;
                TabContainer1.Tabs[2].Enabled = false;
            }
            else
            {
                ViewState["cod"] = Request.QueryString["pcod"];
                bind();
                bind1();
                nsuncarte.clsprd obj = new nsuncarte.clsprd();
                List<nsuncarte.clsprdprp> k = obj.fnd_rec(Convert.ToInt32
                    (Request.QueryString["pcod"]));
                TextBox1.Text = k[0].prdtit;
                TextBox2.Text = k[0].prdreldat.ToShortDateString();
                TextBox3.Text = k[0].prdmrkprc.ToString();
                TextBox7.Text = k[0].prddsc;
                DropDownList1.DataBind();
                DropDownList1.SelectedIndex = -1;
                nsuncarte.clssubcat obj1 = new nsuncarte.clssubcat();
                List<nsuncarte.clssubcatprp> k1 = obj1.fnd_rec(k[0].prdsubcatcod);
                DropDownList1.Items.FindByValue(k1[0].subcatcatcod.ToString()).Selected = true;
                DropDownList2.DataBind();
                DropDownList2.SelectedIndex = -1;
                DropDownList2.Items.FindByValue(k[0].prdsubcatcod.ToString()).Selected = true;
                Button1.Text = "Update";
            }
            TabContainer1.ActiveTabIndex = 0;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsuncarte.clsprdprp objprp = new nsuncarte.clsprdprp();
        nsuncarte.clsprd obj = new nsuncarte.clsprd();
        objprp.prddsc = TextBox7.Text;
        objprp.prdmrkprc = Convert.ToSingle(TextBox3.Text);
        objprp.prdreldat = Convert.ToDateTime(TextBox2.Text);
        objprp.prdsubcatcod = Convert.ToInt32(DropDownList2.SelectedValue);
        objprp.prdtit = TextBox1.Text;
        if(Button1.Text == "Submit")
        {
            Int32 a = obj.save_rec(objprp);
            ViewState["cod"] = a;
            TabContainer1.Tabs[0].Enabled = false;
            TabContainer1.Tabs[1].Enabled = true;
            TabContainer1.Tabs[2].Enabled = true;
        }
        else
        {
            objprp.prdcod = Convert.ToInt32(ViewState["cod"]);
            obj.upd_rec(objprp);
        }
        TabContainer1.ActiveTabIndex = 1;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        nsuncarte.clsprdpic obj = new nsuncarte.clsprdpic();
        nsuncarte.clsprdpicprp objprp = new nsuncarte.clsprdpicprp();
        objprp.prdpicprdcod = Convert.ToInt32(ViewState["cod"]);
        objprp.prdpicdsc = TextBox4.Text;
        String s = FileUpload1.PostedFile.FileName;
        if (s != "")
            s = s.Substring(s.LastIndexOf('.'));
        objprp.prdpicpic = s;
        Int32 a = obj.save_rec(objprp);
        if(s!="")
        {
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../prdpic") + "//" +
                a.ToString() + s);
        }
        TextBox4.Text = String.Empty;
        bind();
    }
    private void bind()
    {
        nsuncarte.clsprdpic obj = new nsuncarte.clsprdpic();
List<nsuncarte.clsprdpicprp> k = obj.dsp_rec(Convert.ToInt32(ViewState["cod"]));
        DataList1.DataSource = k;
        DataList1.DataBind();
    }


    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        nsuncarte.clsprd obj = new nsuncarte.clsprd();
        nsuncarte.clsprdprp objprp = new nsuncarte.clsprdprp();
        objprp.prdcod = Convert.ToInt32(ViewState["cod"]);
        objprp.prdmanpiccod = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex]);
        obj.updmanpic(objprp);
    }

    protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        nsuncarte.clsprdpic obj = new nsuncarte.clsprdpic();
        nsuncarte.clsprdpicprp objprp = new nsuncarte.clsprdpicprp();
        objprp.prdpiccod = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex]);
        obj.del_rec(objprp);
        bind();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        nsuncarte.clsprdspc obj = new nsuncarte.clsprdspc();
        nsuncarte.clsprdspcprp objprp = new nsuncarte.clsprdspcprp();
        objprp.prdspcprdcod = Convert.ToInt32(ViewState["cod"]);
        objprp.prdspctit = TextBox5.Text;
        objprp.prdspcdsc = TextBox6.Text;
        if(Button5.Text=="Submit")
        obj.save_rec(objprp);
        else
        {
            objprp.prdspccod = Convert.ToInt32(ViewState["spccod"]);
            obj.upd_rec(objprp);
            Button5.Text = "Submit";
        }
        TextBox5.Text = String.Empty;
        TextBox6.Text = String.Empty;
        bind1();
    }

    private void bind1()
    {
        nsuncarte.clsprdspc obj = new nsuncarte.clsprdspc();
        GridView1.DataSource = obj.dsp_rec(Convert.ToInt32(ViewState["cod"]));
        GridView1.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        nsuncarte.clsprdspc obj = new nsuncarte.clsprdspc();
        List<nsuncarte.clsprdspcprp> k = obj.fnd_rec(a);
        TextBox5.Text = k[0].prdspctit;
        TextBox6.Text = k[0].prdspcdsc;
        Button5.Text= "Update";
        ViewState["spccod"] = a;
       
        e.Cancel = true;
    }



    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsuncarte.clsprdspc obj = new nsuncarte.clsprdspc();
        nsuncarte.clsprdspcprp objprp = new nsuncarte.clsprdspcprp();
        objprp.prdspccod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.del_rec(objprp);
        bind1();
        e.Cancel = true;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = string.Empty;
        TextBox2.Text = string.Empty;
        TextBox3.Text = string.Empty;
        TextBox7.Text = string.Empty;
        TextBox1.Focus();
        Button1.Text = "Submit";
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox4.Text = string.Empty;
        Button3.Text = "Submit";
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        TextBox5.Text = string.Empty;
        TextBox6.Text = string.Empty;
        TextBox5.Focus();
        Button5.Text = "Submit";
    }
}





