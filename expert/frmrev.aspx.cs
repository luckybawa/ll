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

    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType==DataControlRowType.DataRow)
        {
            LinkButton lk1 = (LinkButton)(e.Row.FindControl("lk1"));
            Int32 sts = (Int32)(GridView1.DataKeys[e.Row.RowIndex][1]);
            if (sts == 0)
                lk1.Text = "Write Review";
            else
                lk1.Text = "Edit Review";
        }
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Response.Redirect("frmrevdet.aspx?pcod=" +
            GridView1.DataKeys[e.NewEditIndex][0]);
    }
}