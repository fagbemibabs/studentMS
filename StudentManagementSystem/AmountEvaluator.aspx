<%@ Page Title="Amount Evaluator Balancer" Language="C#" MasterPageFile="~/StudentManager.Master" AutoEventWireup="true" CodeBehind="AmountEvaluator.aspx.cs" Inherits="StudentManagementSystem.AmountEvaluator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <h1>Payment Evaluator System</h1>

    <table>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Label ID="dbErrorLabel" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td>PIN:</td>
            <td><asp:TextBox ID="pinTextBox" runat="server" Width="200"></asp:TextBox></td>
        </tr>

          <tr>
            <td>Amount Paid:</td>
            <td><asp:TextBox ID="amountTextBox" runat="server" Width="200"></asp:TextBox></td>
              <td><asp:RequiredFieldValidator ID="amountTextBoxReq" ControlToValidate="amountTextBox" runat="server" ErrorMessage="Please enter your payment value!"></asp:RequiredFieldValidator></td>
        </tr>

         <tr>
            <td>School Fees:</td>
            <td><asp:TextBox ID="schFeesTextBox" runat="server" Width="200" Enabled="false"></asp:TextBox></td>
        </tr>


        <tr>
            <td>&nbsp;</td>
            <td><asp:Button ID="previousButton" runat="server" Text="<< Back"  Width="100" Height="40" BorderStyle="Solid" OnClick="previousButton_Click"/>
            <asp:Button ID="submitButton" runat="server" Text="Final Submission"  Width="120" Height="40" BorderStyle="Solid" OnClick="submitButton_Click" />
            <asp:Button ID="exitButton" runat="server" Text="Quit"  Width="120" Height="40" BorderStyle="Solid" OnClick="exitButton_Click"/></td>            
        </tr>
        </table>
    
</asp:Content>
