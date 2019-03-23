using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisterPage : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceClient sClient = new ServiceReference1.ServiceClient();

        if (!(sClient.checkLogin(txtLoginName.Text,txtPassword.Text)))
        {
            if (txtPassword.Text == txtCfPassword.Text)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDb)\MSSqlLocalDb;Initial Catalog=DotNet;Integrated Security=True;Pooling=False";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertUserMaster";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@LoginName", txtLoginName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@EmailId", txtEmailId.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@CityId", ddlCity.SelectedValue);
                cmd.Parameters.AddWithValue("@PaymentModeId", ddlPaymentMode.SelectedValue);
                con.Open();
                int i= cmd.ExecuteNonQuery();
                con.Close();
                lblAlradyExist.Text ="User Registered SuccessFully..";
            }
        }
        else
        {
            lblAlradyExist.Text = "User Alreday Exist..";
        }
    }
}