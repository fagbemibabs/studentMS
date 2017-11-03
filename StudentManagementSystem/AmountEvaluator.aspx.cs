using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class AmountEvaluator : System.Web.UI.Page
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

        protected void submitButton_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(amountTextBox.Text);
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("INSERT INTO PaymentEvaluator(PIN, AmountPaid) VALUES (@PIN, @AmountPaid)", conn);

            cmd.Parameters.Add("@PIN", System.Data.SqlDbType.NVarChar, 50);
            cmd.Parameters["@PIN"].Value = pinTextBox.Text;
            cmd.Parameters.Add("@AmountPaid", System.Data.SqlDbType.Real);
            cmd.Parameters["@AmountPaid"].Value = amount;
            //cmd.Parameters.Add("@SchoolFees", System.Data.SqlDbType.Real);
            //cmd.Parameters[].Value = amountTextBox.Text;

            try 
	            {	        
		            conn.Open();
                    cmd.ExecuteNonQuery();

                //Clear controls
                pinTextBox.Text="";
                amountTextBox.Text = "";

                // @ todo       call a new Web page to display balance of School Fees
                GetAvailableSchFeesBalance(25000L - amount);

                
	            }
                //catch 
                //{
		            
                //}
            finally
            {
                conn.Close();
            }
        }


        private void GetAvailableSchFeesBalance(double balance)
        {
            Session.Add("SessionBalance", balance);

            Response.Redirect("ShowBalance.aspx");
        }

        protected void previousButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaymentPortal.aspx");
        }

        protected void exitButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPortal.aspx");
        }

    }
}