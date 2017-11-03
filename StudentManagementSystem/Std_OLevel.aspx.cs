using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class O_Level : System.Web.UI.Page
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

            ExamType();
            LoadNoOfSittings();

            
        }

        protected void ExamType()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd = new SqlCommand("SELECT ExamID, ExamType FROM ExamTypeTable", conn);
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                examTypeList.DataSource = reader;
                examTypeList.DataValueField = "ExamID";
                examTypeList.DataTextField = "ExamType";
                examTypeList.DataBind();

                reader.Close();
            }
            catch
            { 
            }
            finally
            {
                conn.Close();
            }

        }


        protected void LoadNoOfSittings()
        {
            for (int i = 0; i <= 2; i++)
            {
                noOfSittingList.Items.Add(Convert.ToString(i));
            }
        }



        protected void submitButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated Security = true");
            SqlCommand comm = new SqlCommand("INSERT INTO Std_OLevelTable(StudentId, ExamType, NoOfSittings) VALUES (@StudentId, @ExamType, @NoOfSittings)", conn);

                try
            {
                //thirdSubList.AppendDataBoundItems = true;
                comm.Parameters.Add("@StudentId", System.Data.SqlDbType.Int);
                comm.Parameters["@StudentId"].Value = stdIdTextBox.Text;
                comm.Parameters.Add("@ExamType", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@ExamType"].Value = examTypeList.SelectedItem.Value;
                comm.Parameters.Add("@NoOfSittings", System.Data.SqlDbType.Int);
                comm.Parameters["@NoOfSittings"].Value = noOfSittingList.SelectedItem.Value;

                   
                conn.Open();
                comm.ExecuteNonQuery();
                Response.Redirect("Std_OLevel_Subjects.aspx");
              
                    //Clear controls
                    stdIdTextBox.Text="";
                    examTypeList.SelectedItem.Text="";
                    noOfSittingList.SelectedItem.Text="";

                
            }
            finally
            {
                conn.Close();
            }
        }
        }

        protected void previousButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("BioData.aspx");
        }

    }
}