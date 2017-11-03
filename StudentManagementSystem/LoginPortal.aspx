<%@ Page Title="Login Portal" Language="C#" MasterPageFile="~/StudentManager.Master" AutoEventWireup="true" CodeBehind="LoginPortal.aspx.cs" Inherits="StudentManagementSystem.LoginPortal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <table>
        <tr>
            <td style="width:120px">&nbsp;</td>
            <td><h2>Login</h2></td>
        </tr>
        <tr>
            <td style="width:120px">&nbsp;</td>
            <td>Username:</td>
            <td><asp:TextBox ID="usernameTextBox" runat="server" Width="200"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="usernameTextBoxReq" runat="server" ControlToValidate="usernameTextBox" ErrorMessage="Please enter your Username"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td style="width:120px">&nbsp;</td>
            <td>Password:</td>
            <td><asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" Width="200"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="passwordTextBoxReq" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="Please enter your Password!"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td style="width:120px">&nbsp;</td>
            <td>&nbsp;</td>
            <td><asp:Button ID="loginButton" runat="server" Text="Log In"  Width="120" OnClick="loginButton_Click"/></td>
        </tr>
    </table>
</asp:Content>
