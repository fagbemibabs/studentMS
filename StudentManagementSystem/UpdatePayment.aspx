<%@ Page Title="Update Bank Payment" Language="C#" MasterPageFile="~/StudentManager.Master" AutoEventWireup="true" CodeBehind="UpdatePayment.aspx.cs" Inherits="StudentManagementSystem.UpdatePayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <h1>Update Payment</h1>

    <table>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Label ID="dbErrorLabel" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td>PIN:</td>
            <td><asp:TextBox ID="pinTextBox" runat="server" Width="300"></asp:TextBox></td>
        </tr>

          <tr>
            <td>Teller Number:</td>
            <td><asp:TextBox ID="tellerNoTextBox" runat="server" Width="300"></asp:TextBox></td>
              <td><asp:Button ID="selectButton" runat="server" Text="Select" OnClick="selectButton_Click" /></td><td> Must be INTEGER & not more than 8!</td>
              <td><asp:RequiredFieldValidator ID="tellerNoTextBoxReq" ControlToValidate="tellerNoTextBox" runat="server" ErrorMessage="Please enter an INTEGER value!"></asp:RequiredFieldValidator></td>
        </tr>

         <tr>
            <td>Date of Payment:</td>
            <td><asp:TextBox ID="datePaymentTextBox" runat="server" Width="300"></asp:TextBox></td>
        </tr>


        <tr>
            <td>&nbsp;</td>
            <td><asp:Button ID="updateButton" runat="server" Text="Update"  Width="90" Height="40" BorderStyle="Solid" OnClick="updateButton_Click"/>
            <asp:Button ID="deleteButton" runat="server" Text="Delete"  Width="90" Height="40" BorderStyle="Solid" OnClick="deleteButton_Click" />
            <asp:Button ID="exitButton" runat="server" Text="Quit"  Width="90" Height="40" BorderStyle="Solid" OnClick="exitButton_Click"/></td>
            
        </tr>
        </table>
</asp:Content>
