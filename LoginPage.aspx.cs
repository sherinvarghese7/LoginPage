using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginPage : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        ServiceReference1.ServiceClient sClient = new ServiceReference1.ServiceClient();

        if (!IsPostBack)
        {
            
            if(Request.Cookies["Login"]!=null)
            {
                var cookie = Request.Cookies["Login"].Values;
                if(sClient.checkLogin(cookie.Get("LoginName"),cookie.Get("Password")))
                {
                    Session["LoginName"] = cookie.Get("LoginName");
                    Session["Password"] = cookie.Get("Password");
                  Response.Redirect("HomePage.aspx");
                }
                
            }
        }
    }

    //protected bool checkLogin(string LoginName,string Password)
    //{
    //    SqlConnection con = new SqlConnection();
    //    con.ConnectionString = @"Data Source=(LocalDb)\MSSqlLocalDb;Initial Catalog=DotNet;Integrated Security=True;Pooling=False";
    //    SqlCommand cmd = new SqlCommand();
    //    cmd.Connection = con;
    //    cmd.CommandType = CommandType.Text;
    //    cmd.CommandText = "select count(*) from UserMaster where LoginName='"+LoginName+"'and Password='"+Password+"'";
    //    con.Open();
    //     int is_v=(int)cmd.ExecuteScalar();
    //    con.Close();
    //    return is_v == 1;
    //}

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceClient sClient = new ServiceReference1.ServiceClient();

        if (sClient.checkLogin(txtLoginName.Text,txtPassword.Text))
        {
            if(chkRemember.Checked)
            {

                HttpCookie cookie = new HttpCookie("Login");
                    cookie["LoginName"]= txtLoginName.Text;
                    cookie["Password"] = txtPassword.Text;
                    Session["LoginName"] = txtLoginName.Text;
                    Session["Password"] = txtPassword.Text;
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);
                //Response.SetCookie(cookie);
               
            }
            
            Response.Redirect("HomePage.aspx");
        }  
        else
        {
            lblCredential1.Text = "Please Enter The Valid Credentials";
        }
    }
}