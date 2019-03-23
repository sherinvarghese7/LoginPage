using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if(Session["LoginName"]!=null)
            {
                lblLoginName.Text = Session["LoginName"].ToString();

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDb)\MSSqlLocalDb;Initial Catalog=DotNet;Integrated Security=True;Pooling=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from UserMaster where LoginName='" + Session["LoginName"].ToString() + "'and Password='" + Session["Password"].ToString() + "'";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {

                    txtEmailId.Text = reader["EmailId"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    ddlCity.SelectedValue=reader["CityId"].ToString();
                    ddlPaymentMode.SelectedValue= reader["PaymentModeId"].ToString();
                }


                con.Close();



            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(LocalDb)\MSSqlLocalDb;Initial Catalog=DotNet;Integrated Security=True;Pooling=False";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "update UserMaster set EmailId='"+txtEmailId.Text+"',Address='"+txtAddress.Text+"',CityId='"+ddlCity.SelectedValue+"',PaymentModeId='"+ddlPaymentMode.SelectedValue+"'where LoginName='"+Session["LoginName"].ToString()+"'";
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}