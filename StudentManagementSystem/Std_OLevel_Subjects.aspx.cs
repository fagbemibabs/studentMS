using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class Std_OLevel_Subjects : System.Web.UI.Page
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

            LoadMathematicsGrade();
            LoadEnglishGrade();
            LoadSubject3();
            LoadSubject3Grade();
            LoadSubject4();
            LoadSubject4Grade();
            LoadSubject5();
            LoadSubject5Grade();
            LoadSubject6();
            LoadSubject6Grade();
            LoadExamYear();
            
        }

        protected void LoadExamYear()
        {
            for (int i= 1990; i <= DateTime.Now.Year; i++)
            {
                examDateTypeList.Items.Add(Convert.ToString(i));
            }
        }

        protected void LoadSubject3()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd1 = new SqlCommand("SELECT SubjectID, SubjectName FROM SubjectTable", conn);
            SqlDataReader reader1;

            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                Subject3NameList.DataSource = reader1;
                Subject3NameList.DataValueField = "SubjectID";
                Subject3NameList.DataTextField = "SubjectName";
                Subject3NameList.DataBind();

                reader1.Close();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }

        }

        protected void LoadSubject4()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd1 = new SqlCommand("SELECT SubjectID, SubjectName FROM SubjectTable", conn);
            SqlDataReader reader1;

            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                Subject4NameList.DataSource = reader1;
                Subject4NameList.DataValueField = "SubjectID";
                Subject4NameList.DataTextField = "SubjectName";
                Subject4NameList.DataBind();

                reader1.Close();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }

        }

        protected void LoadSubject5()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd1 = new SqlCommand("SELECT SubjectID, SubjectName FROM SubjectTable", conn);
            SqlDataReader reader1;

            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                Subject5NameList.DataSource = reader1;
                Subject5NameList.DataValueField = "SubjectID";
                Subject5NameList.DataTextField = "SubjectName";
                Subject5NameList.DataBind();

                reader1.Close();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }

        }

        protected void LoadSubject6()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd1 = new SqlCommand("SELECT SubjectID, SubjectName FROM SubjectTable", conn);
            SqlDataReader reader1;

            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                Subject6NameList.DataSource = reader1;
                Subject6NameList.DataValueField = "SubjectID";
                Subject6NameList.DataTextField = "SubjectName";
                Subject6NameList.DataBind();

                reader1.Close();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }

        }


        protected void LoadMathematicsGrade()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd1 = new SqlCommand("SELECT SubjectID, SubjectName FROM GradeTable", conn);
            SqlDataReader reader1;

            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                mathDropDownList.DataSource = reader1;
                mathDropDownList.DataValueField = "SubjectID";
                mathDropDownList.DataTextField = "SubjectName";
                mathDropDownList.DataBind();

                reader1.Close();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }

        }

        protected void LoadEnglishGrade()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd1 = new SqlCommand("SELECT SubjectID, SubjectName FROM GradeTable", conn);
            SqlDataReader reader1;

            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                englishLangList.DataSource = reader1;
                englishLangList.DataValueField = "SubjectID";
                englishLangList.DataTextField = "SubjectName";
                englishLangList.DataBind();

                reader1.Close();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }

        }


        protected void LoadSubject3Grade()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd1 = new SqlCommand("SELECT SubjectID, SubjectName FROM GradeTable", conn);
            SqlDataReader reader1;

            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                Subject3GradeList.DataSource = reader1;
                Subject3GradeList.DataValueField = "SubjectID";
                Subject3GradeList.DataTextField = "SubjectName";
                Subject3GradeList.DataBind();

                reader1.Close();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }

        }


        protected void LoadSubject4Grade()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd1 = new SqlCommand("SELECT SubjectID, SubjectName FROM GradeTable", conn);
            SqlDataReader reader1;

            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                Subject4GradeList.DataSource = reader1;
                Subject4GradeList.DataValueField = "SubjectID";
                Subject4GradeList.DataTextField = "SubjectName";
                Subject4GradeList.DataBind();

                reader1.Close();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }

        }


        protected void LoadSubject5Grade()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd1 = new SqlCommand("SELECT SubjectID, SubjectName FROM GradeTable", conn);
            SqlDataReader reader1;

            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                Subject5GradeList.DataSource = reader1;
                Subject5GradeList.DataValueField = "SubjectID";
                Subject5GradeList.DataTextField = "SubjectName";
                Subject5GradeList.DataBind();

                reader1.Close();
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }

        }


        protected void LoadSubject6Grade()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
            SqlCommand cmd1 = new SqlCommand("SELECT SubjectID, SubjectName FROM GradeTable", conn);
            SqlDataReader reader1;

            try
            {
                conn.Open();
                reader1 = cmd1.ExecuteReader();
                Subject6GradeList.DataSource = reader1;
                Subject6GradeList.DataValueField = "SubjectID";
                Subject6GradeList.DataTextField = "SubjectName";
                Subject6GradeList.DataBind();

                reader1.Close();
            }
            catch
            {
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
                SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security = true");
                SqlCommand comm = new SqlCommand("INSERT INTO Std_OLevel_Subjects (Std_OLevelId, DateOfExam, MathsGrade, EnglishGrade, Subject3Name, Subject3Grade, Subject4Name, Subject4Grade, Subject5Name, Subject5Grade, Subject6Name, Subject6Grade) VALUES (@Std_OLevelId, @DateOfExam, @MathsGrade, @EnglishGrade, @Subject3Name, @Subject3Grade, @Subject4Name, @Subject4Grade, @Subject5Name, @Subject5Grade, @Subject6Name, @Subject6Grade)", conn);

                //comm.Parameters.Add("@StudentId", System.Data.SqlDbType.Int);
                //comm.Parameters["@StudentId"].Value = stdIdTextBox.Text;  Std_OLevelId
                comm.Parameters.Add("@Std_OLevelId", System.Data.SqlDbType.Int);
                comm.Parameters["@Std_OLevelId"].Value = stdOLevelIdTextBox.Text;
                comm.Parameters.Add("@DateOfExam", System.Data.SqlDbType.Text);
                comm.Parameters["@DateOfExam"].Value = examDateTypeList.SelectedItem.Text;

                comm.Parameters.Add("@MathsGrade", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@MathsGrade"].Value = mathDropDownList.SelectedItem.Text;
                comm.Parameters.Add("@EnglishGrade", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@EnglishGrade"].Value = englishLangList.SelectedItem.Text;
                comm.Parameters.Add("@Subject3Name", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Subject3Name"].Value = Subject3NameList.SelectedItem.Text;
                comm.Parameters.Add("@Subject3Grade", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Subject3Grade"].Value = Subject3GradeList.SelectedItem.Text;
                comm.Parameters.Add("@Subject4Name", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Subject4Name"].Value = Subject4NameList.SelectedItem.Text;
                comm.Parameters.Add("@Subject4Grade", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Subject4Grade"].Value = Subject4GradeList.SelectedItem.Text;
                comm.Parameters.Add("@Subject5Name", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Subject5Name"].Value = Subject5NameList.SelectedItem.Text;
                comm.Parameters.Add("@Subject5Grade", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Subject5Grade"].Value = Subject5GradeList.SelectedItem.Text;
                comm.Parameters.Add("@Subject6Name", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Subject6Name"].Value = Subject6NameList.SelectedItem.Text;
                comm.Parameters.Add("@Subject6Grade", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Subject6Grade"].Value = Subject6GradeList.SelectedItem.Text;

                try
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                    Response.Redirect("PaymentPortal.aspx");
                    //Std_OLevelId, DateOfExam, MathsGrade, EnglishGrade, Subject3Name, Subject3Grade, Subject4Name, Subject4Grade, Subject5Name, Subject5Grade, Subject6Name, Subject6Grade
                    //stdIdTextBox.Text = "";
                    
                    examDateTypeList.SelectedItem.Text = "";
                    mathDropDownList.SelectedItem.Text = "";
                    englishLangList.SelectedItem.Text = "";
                    Subject3NameList.SelectedItem.Text = "";
                    Subject3GradeList.SelectedItem.Text = "";
                    Subject4NameList.SelectedItem.Text = "";
                    Subject4GradeList.SelectedItem.Text = "";
                    Subject5NameList.SelectedItem.Text = "";
                    Subject5GradeList.SelectedItem.Text = "";
                    Subject6NameList.SelectedItem.Text = "";
                    Subject6GradeList.SelectedItem.Text = "";

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        protected void previousButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Std_OLevel.aspx");
        }
    }
}