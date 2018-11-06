using Microsoft.Azure.KeyVault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace aslsoft
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var keyvault = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(keyvaultservice.GetToken));
            var dbcon = keyvault.GetSecretAsync(System.Configuration.ConfigurationManager.AppSettings["dbConnectionSecretUri"]).Result;
            string dbconnection = dbcon.Value;
            LoadDataToGv(dbconnection);
        }
        
        protected void ProductGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LoadDataToGv(string dbconnectionstring)
        {
            try
            {
                SqlConnection scon = new SqlConnection(dbconnectionstring);
                SqlCommand scommand = new SqlCommand("Select * from tblProduct", scon);
                SqlDataAdapter sdataadap = new SqlDataAdapter(scommand);
                DataSet ds = new DataSet();
                sdataadap.Fill(ds);
                ProductGridView.DataSource = ds;
                ProductGridView.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void ProductGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void ProductGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
    }
}