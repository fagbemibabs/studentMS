using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class PaymentPortal : System.Web.UI.Page
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

            BankPayment();
            Load_LGA();
        }

        protected void BankPayment()
        {
            SqlDataReader myReader;
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("SELECT BankID, BankName FROM BankPayment", conn);

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                bankDropDownList.DataSource = myReader;
                bankDropDownList.DataValueField = "BankID";
                bankDropDownList.DataTextField = "BankName";
                bankDropDownList.DataBind();

                myReader.Close();
            }
            finally
            {
                conn.Close();
            }

        }

        protected void Load_LGA()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = HRMManager; Integrated Security = true");
            SqlCommand comm = new SqlCommand("SELECT StateID, LgaName FROM Lga", conn);
            SqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = comm.ExecuteReader();
                bankBranchDropDownList.DataSource = myReader;
                bankBranchDropDownList.DataValueField = "StateID";
                bankBranchDropDownList.DataTextField = "LgaName";
                bankBranchDropDownList.DataBind();

                myReader.Close();
            }

            finally
            {
                conn.Close();
            }

        }

        protected void submitButton_Click(object sender, EventArgs e)
           {
            if (Page.IsValid)
            { 
            //SqlDataReader reader;
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("INSERT INTO PaymentTable(PIN, TellerNumber, DateOfPayment, BankOfPayment, BranchOfPayment, BankServicePersonnel) VALUES (@PIN, @TellerNumber, @DateOfPayment, @BankOfPayment, @BranchOfPayment, @BankServicePersonnel)", conn);

           
                cmd.Parameters.Add("@PIN", System.Data.SqlDbType.NVarChar, 50);
                cmd.Parameters["@PIN"].Value = pinTextBox.Text;
                cmd.Parameters.Add("@TellerNumber", System.Data.SqlDbType.Int);
                cmd.Parameters["@TellerNumber"].Value = tellerNoTextBox.Text;
                cmd.Parameters.Add("@DateOfPayment", System.Data.SqlDbType.Date);
                cmd.Parameters["@DateOfPayment"].Value = datePaymentTextBox.Text;
                cmd.Parameters.Add("@BankOfPayment", System.Data.SqlDbType.NVarChar, 50);
                cmd.Parameters["@BankOfPayment"].Value = bankDropDownList.SelectedItem.Value;
                cmd.Parameters.Add("@BranchOfPayment", System.Data.SqlDbType.NVarChar, 50);
                cmd.Parameters["@BranchOfPayment"].Value = bankBranchDropDownList.SelectedItem.Value; 
                cmd.Parameters.Add("@BankServicePersonnel", System.Data.SqlDbType.NVarChar, 50);
                cmd.Parameters["@BankServicePersonnel"].Value = bankPersonnelTextBox.Text;

              try
                {
                conn.Open();
                cmd.ExecuteNonQuery();
                Response.Redirect("AmountEvaluator.aspx");

                  //Clear controls
                pinTextBox.Text = "";
                tellerNoTextBox.Text = "";
                datePaymentTextBox.Text = "";
                bankDropDownList.SelectedItem.Value = "";
                bankPersonnelTextBox.Text = "";
            }
            finally
            {
                conn.Close();
            }
            }
        }

        protected void previousButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Std_OLevel_Subjects.aspx");
        }

        protected void exitButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPortal.aspx");
        }

    }
}