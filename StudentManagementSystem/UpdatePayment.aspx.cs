using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class UpdatePayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/scripts/jquery-1.7.2.min.js",
                DebugPath = "~/scripts/jquery-1.7.2.min.js",
                CdnPath = "http://ajax.aspnnetcdn.com/ajax/jQuery/jquery-1.4.1.min.js",
                CdnDebugPath = "http://ajax.aspnnetcdn.com/ajax/jQuery/jquery-1.4.1.js"
            });
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand command = new SqlCommand("UPDATE PaymentTable SET PIN = @PIN, TellerNumber=@TellerNumber, DateOfPayment=@DateOfPayment WHERE TellerNumber=@TellerNumber", conn);
            SqlDataReader myReader;

            command.Parameters.Add("@PIN", System.Data.SqlDbType.NVarChar, 50);
            command.Parameters["@PIN"].Value = pinTextBox.Text;
            command.Parameters.Add("@TellerNumber", System.Data.SqlDbType.Int);
            command.Parameters["@TellerNumber"].Value = tellerNoTextBox.Text;
            command.Parameters.Add("@DateOfPayment", System.Data.SqlDbType.Date);
            command.Parameters["@DateOfPayment"].Value = datePaymentTextBox.Text;

            try
            {
                conn.Open();
                command.ExecuteNonQuery();

                Response.Redirect("PaymentPortal.aspx");
                //pinTextBox.Text= "";
                //tellerNoTextBox.Text = "";
                //datePaymentTextBox.Text = "";
            }
            catch 
            {
                dbErrorLabel.Text = "Error Updating Payment detail!";
            }
            
            conn.Close();
        }

        protected void selectButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd = new SqlCommand("SELECT PIN, TellerNumber, DateOfPayment FROM PaymentTable WHERE TellerNumber=@TellerNumber", conn);
            SqlDataReader myReader;

            cmd.Parameters.Add("@TellerNumber", System.Data.SqlDbType.Int);
            cmd.Parameters["@TellerNumber"].Value= tellerNoTextBox.Text;
            try 
	          {	        
		        conn.Open();
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
	                {
		                pinTextBox.Text= myReader["PIN"].ToString();
                        tellerNoTextBox.Text=myReader["TellerNumber"].ToString();
                        datePaymentTextBox.Text = myReader["DateOfPayment"].ToString();
	                }
                myReader.Close();
                updateButton.Enabled = true;
                deleteButton.Enabled=true;
	           }
	        catch 
	           {
                   dbErrorLabel.Text = "Error Loading Payment details!";
	           }
            finally{
                conn.Close();
                    }
           }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand comm = new SqlCommand("DELETE FROM PaymentTable WHERE TellerNumber=@TellerNumber", conn);

            comm.Parameters.Add("@TellerNumber", System.Data.SqlDbType.Int);
            comm.Parameters["@TellerNumber"].Value = tellerNoTextBox.Text;

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();

                Response.Redirect("PaymentPortal.aspx");

                //Clear control
                pinTextBox.Text = "";
                tellerNoTextBox.Text = "";
                datePaymentTextBox.Text = "";
            }
            catch
            {
                dbErrorLabel.Text = "Error DELECT payment details in Database Table!";
            }
            finally
            {
                conn.Close();
            }
        }

        protected void exitButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPortal.aspx");
        }
      }
}