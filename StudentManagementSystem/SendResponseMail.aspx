<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendResponseMail.aspx.cs" Inherits="StudentManagementSystem.SendResponseMail" %>


<%@ Import Namespace="System.Net.Mail" %>

<!DOCTYPE html>

<script runat="server">
    protected void SendEmail(object sender, EventArgs e)
            {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage message = new MailMessage();
            try
             {
                 MailAddress fromAddress = new MailAddress("from@example.com", "From Me");
                 MailAddress toAddress = new MailAddress("to@example.com", "To You");
                 message.From = fromAddress;
                 message.To.Add(toAddress);
                 message.Subject = "Testing!";
                 message.Body = "This is the body of a sample message";
                 smtpClient.Host = "mailserver.example.com";
                 smtpClient.Credentials = new System.Net.NetworkCredential("username", "password");
                 smtpClient.Send(message);
                 statusLabel.Text = "Email sent.";
            }
            catch 
                {
                    statusLabel.Text = "Coudn't send the message!";
                }
            }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
        <title>Sending Email with ASP.Net</title>
    </head>
    <body>
        <form id="form1" runat="server">
        <div>
            <asp:Button ID="sendEmailButton" runat="server" Text="Send Email!" OnClick="SendEmail" />
            <br />
            <asp:Label ID="statusLabel" runat="server" />
        </div>
        </form>
    </body>
</html>

