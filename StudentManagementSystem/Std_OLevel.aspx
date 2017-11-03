<%@ Page Title="O'Level" Language="C#" MasterPageFile="~/StudentManager.Master" AutoEventWireup="true" CodeBehind="Std_OLevel.aspx.cs" Inherits="StudentManagementSystem.O_Level" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <h1>O'Level Result</h1>
    <table>
        <tr>
                <td>Student ID:</td>
                <td><asp:TextBox ID="stdIdTextBox" runat="server" Width="200"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ID="stdIdTextBoxReq" ControlToValidate="stdIdTextBox" runat="server" ErrorMessage="Please enter your ID number!"></asp:RequiredFieldValidator>  </td>
        </tr>

        <tr>
            <td>Exam Type::</td>
            <td><asp:DropDownList ID="examTypeList" runat="server" Width="200"></asp:DropDownList></td>
            <td><asp:RequiredFieldValidator ID="examTypeListReq" runat="server" ControlToValidate="examTypeList" ErrorMessage="Plesae SELECT the type of Exam!"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
                <td>Number of Sittings:</td>
                <td><asp:DropDownList ID="noOfSittingList" runat="server" Width="200"></asp:DropDownList></td>
                <td><asp:RequiredFieldValidator ID="Req" ControlToValidate="noOfSittingList" runat="server" ErrorMessage="Please SELECT the number of sittings!"></asp:RequiredFieldValidator>  </td>
        </tr>

        <tr>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td>&nbsp;</td>
             <td><asp:Button ID="previousButton" runat="server" Text="<< Previous"  BorderStyle="Ridge" Width="100" Height="40" OnClick="previousButton_Click"/>
             <asp:Button ID="submitButton" runat="server" Text="Next"  BorderStyle="Ridge" Width="100" Height="40" OnClick="submitButton_Click"/></td>
        </tr>
    </table>
            
</asp:Content>
