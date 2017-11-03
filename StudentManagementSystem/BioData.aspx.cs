using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class BioData : System.Web.UI.Page
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

            Load_Gender();
            //Load_State();
            //Load_LGA();

            if (IsPostBack == false)
            {
                //LoadStates();
                Load_State(); 
            }
            
        }

        //protected void Load_Gender()
        //{
        //    SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated Security = true");
        //    SqlCommand cmd = new SqlCommand("SELECT GenderID, GenderName FROM Gender", conn);
        //    SqlDataReader reader;

        //    try
        //        {
        //            conn.Open();
        //            reader = cmd.ExecuteReader();
        //            genderDropDownList.DataSource = reader;
        //            genderDropDownList.DataValueField = "GenderID";
        //            genderDropDownList.DataTextField = "GenderName";
        //            genderDropDownList.DataBind();

        //            reader.Close();
        //        }
        //        catch
        //        {
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
            
        //}
        private void Load_Gender()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = MealRequestSystem; Integrated security = true");
            SqlCommand comm = new SqlCommand("SELECT * FROM Gender", conn);
            SqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = comm.ExecuteReader();
                genderDropDownList.DataSource = myReader;
                genderDropDownList.DataValueField = "ID";
                genderDropDownList.DataTextField = "GenderName";
                genderDropDownList.DataBind();

                myReader.Close();
            }
            finally
            {
                conn.Close();
            }
        }


        private void Load_State()
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated Security = true");
            SqlCommand comm = new SqlCommand("SELECT ID, StateName FROM States", conn);
            SqlDataReader myReader;

            try
                {
                    conn.Open();
                    myReader = comm.ExecuteReader();
                    stateDropDownList.DataSource = myReader;
                    stateDropDownList.DataValueField = "ID";
                    stateDropDownList.DataTextField = "StateName";
                    stateDropDownList.DataBind();

                    myReader.Close();
                }
            finally
                    {
                        conn.Close();
                    }
        }


        private void Load_LGA(int stateID)
        {
            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated Security = true");
            SqlCommand comm = new SqlCommand("SELECT StateID, LgaName FROM Lga WHERE StateID=@StateID", conn);

            comm.Parameters.Add("@StateID", System.Data.SqlDbType.Int);
            comm.Parameters["@StateID"].Value = stateID;
            SqlDataReader myReader;

            try
                {
                    conn.Open();
                    myReader = comm.ExecuteReader();
                    lgaDropDownList.DataSource = myReader;
                    lgaDropDownList.DataValueField = "StateID";
                    lgaDropDownList.DataTextField = "LgaName";
                    lgaDropDownList.DataBind();

                    myReader.Close();
                }

            finally 
                {
                    conn.Close();
                }
            
        }

        protected void LoadStates()
        {
            stateDropDownList.Items.Add(new ListItem("SELECT State", "SELECT"));

            SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated security= true");
            string cmdText = "SELECT * FROM States";
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        }

        protected void submitButton_Click(object sender, EventArgs e)
            {
            if (Page.IsValid)
                {
                   // SqlDataReader reader;
                    SqlConnection conn = new SqlConnection("Server = localhost; Database = StudentManagementSystem; Integrated Security = true");
                    SqlCommand cmd = new SqlCommand("INSERT INTO BioData(Surname, FirstName, OtherName, PermanentAddress, Gender, DateOfBirth, Email, PhoneNumber, StateofOrigin, LGA, NameofNextofKin, PhoneOfNextOfKin, AddressOfNextOfKin, NextOfKinEmail, Passport) VALUES (@Surname, @FirstName, @OtherName, @PermanentAddress, @Gender, @DateOfBirth, @Email, @PhoneNumber, @StateofOrigin, @LGA, @NameofNextofKin, @PhoneOfNextOfKin, @AddressOfNextOfKin, @NextOfKinEmail, @Passport)", conn);
     
                        cmd.Parameters.Add("@Surname", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@Surname"].Value = surnameTextBox.Text;
                        cmd.Parameters.Add("@FirstName", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@FirstName"].Value = fNameTextBox.Text;
                        cmd.Parameters.Add("@OtherName", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@OtherName"].Value = otherNameTextBox.Text;
                        cmd.Parameters.Add("@PermanentAddress", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@PermanentAddress"].Value = addressTextBox.Text;
                        cmd.Parameters.Add("@Gender", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@Gender"].Value = genderDropDownList.SelectedItem.Text;
                        cmd.Parameters.Add("@DateOfBirth", System.Data.SqlDbType.Date);
                        cmd.Parameters["@DateOfBirth"].Value = dobTextBox.Text;
                        cmd.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@Email"].Value = emailTextBox.Text;
                        cmd.Parameters.Add("@PhoneNumber", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@PhoneNumber"].Value = phoneNumTextBox.Text;
                        cmd.Parameters.Add("@StateofOrigin", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@StateofOrigin"].Value = stateDropDownList.SelectedItem.Text;
                        cmd.Parameters.Add("@LGA", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@LGA"].Value = lgaDropDownList.SelectedItem.Text;
                        cmd.Parameters.Add("@NameofNextofKin", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@NameofNextofKin"].Value = nextKinTextBox.Text;
                        cmd.Parameters.Add("@PhoneOfNextOfKin", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@PhoneOfNextOfKin"].Value = nextKinPhoneTextBox.Text;
                        cmd.Parameters.Add("@AddressOfNextOfKin", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@AddressOfNextOfKin"].Value = nextkinAddressTextBox.Text;
                        cmd.Parameters.Add("@NextOfKinEmail", System.Data.SqlDbType.NVarChar, 50);
                        cmd.Parameters["@NextOfKinEmail"].Value = emailNextKinTextBox.Text;

                        cmd.Parameters.Add("@Passport", System.Data.SqlDbType.Binary);
                        cmd.Parameters["@Passport"].Value = passportFileUpload.FileBytes;


                        try
                         {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            Response.Redirect("Std_OLevel.aspx");
//                            string script = @"<script language="" javascript"">
//                            alert('Information saved successfully......!!!');
//                            </script>;";
//                            Page.ClientScript.RegisterStartupScript(this.GetType(), "myJScript", script);
                            
                            
                            //clear controls
                            surnameTextBox.Text = "";
                            fNameTextBox.Text = "";
                            otherNameTextBox.Text = "";
                            addressTextBox.Text = "";
                            genderDropDownList.SelectedItem.Text = "";
                            dobTextBox.Text = "";
                            emailTextBox.Text = "";
                            phoneNumTextBox.Text = "";
                            stateDropDownList.SelectedItem.Text = "";
                            lgaDropDownList.SelectedItem.Text = "";
                            nextKinTextBox.Text = "";
                            nextKinPhoneTextBox.Text = "";
                            nextkinAddressTextBox.Text = "";
                            emailNextKinTextBox.Text = "";
                        }
                        catch
                        {
                        }
                        finally
                        {
                            conn.Close();
                        }

                }
        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //open.Filter = "Images File(*.jpg; *.gif; *.bmp) | (*.jpg; *.jpeg; *.jpng; *.gif; *.bmp)";
            //if (open.ShowDialogResult == DialogResult == OK) {
            //    sudImage.Image = new Bitmap(Open.FileName);
            //    passportFileUpload.Text = open.FileName;
            //}
            //{
                
            //}


            if (passportFileUpload.HasFile)
            {
                string FileName = passportFileUpload.FileName;
                passportFileUpload.SaveAs(MapPath(FileName));
                uploadLabel.Text = "File: " + FileName + "Uploaded!";
            }

        }

        protected void stateDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lgaDropDownList.Items.Clear();
            if (stateDropDownList.SelectedIndex != 0)
            {
                lgaDropDownList.Items.Add(new ListItem("SELECT", "SELECT"));
                int stateId = int.Parse(stateDropDownList.SelectedValue);

                Load_LGA(stateId);

            }
        }

        protected void exitButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(" LoginPortal.aspx");
        }
    }
}