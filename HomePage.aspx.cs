using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if (Session["LoginName"] != null)
                lblLoginName.Text = Session["LoginName"].ToString().ToUpper();
            else
                Response.Redirect("LoginPage.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(Request.Cookies["Login"]!=null)
        {
            var Cookie = Request.Cookies["Login"];

            Cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(Cookie);
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }
       
    }
}