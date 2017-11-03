using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class ShowBalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionBalance"] == null)
            {
                Response.Redirect("AmountEvaluator.aspx");
            }
            else
            {
                double balance = double.Parse(Session["SessionBalance"].ToString());
                balanceLabel.Text = "Your balance is: " +balance;
            }
        }

        protected void exitButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPortal.aspx");
        }
    }
}