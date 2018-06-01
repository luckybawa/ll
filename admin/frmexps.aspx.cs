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

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsuncarte.clsexp obj = new nsuncarte.clsexp();
        nsuncarte.clsexpprp objprp = new nsuncarte.clsexpprp();
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        objprp.expcod = a;
        obj.del_rec(objprp);
        e.Cancel = true;
                   
    }
}