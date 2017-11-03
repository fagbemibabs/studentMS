<%@ Page Title="Student O'Level Subjects" Language="C#" MasterPageFile="~/StudentManager.Master" AutoEventWireup="true" CodeBehind="Std_OLevel_Subjects.aspx.cs" Inherits="StudentManagementSystem.Std_OLevel_Subjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>O'Level Subject Portal</h1>

    <table>

         <tr>
                <td>Student ID:</td>
                <td><asp:TextBox ID="stdOLevelIdTextBox" runat="server" Width="200"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ID="stdOLevelIdTextBoxReq" ControlToValidate="stdOLevelIdTextBox" runat="server" ErrorMessage="Please enter your ID number!"></asp:RequiredFieldValidator>  </td>
        </tr>

        <tr>
                <td>Date of Examination:</td>
                <td><asp:DropDownList ID="examDateTypeList" runat="server" Width="200"></asp:DropDownList></td>
                <td><asp:RequiredFieldValidator ID="examDateTypeListReq" ControlToValidate="examDateTypeList" runat="server" ErrorMessage="Please SELECT your exam date!"></asp:RequiredFieldValidator>  </td>
        </tr>

        <tr>
            <td>&nbsp;</td>
        </tr>

       <tr>
            <td>Mathematics:</td>
            <td><asp:DropDownList ID="mathDropDownList" runat="server" Width="200"></asp:DropDownList></td>
            <td><asp:RequiredFieldValidator ID="mathDropDownListReq" runat="server" ControlToValidate="mathDropDownList" ErrorMessage="Plesae SELECT your GRADE for Maths!"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td>English Language:</td>
            <td><asp:DropDownList ID="englishLangList" runat="server" Width="200"></asp:DropDownList></td>
            <td><asp:RequiredFieldValidator ID="englishLangListReq" ControlToValidate="englishLangList" runat="server" ErrorMessage="Plesae SELECT your GRADE for English Lang.!"></asp:RequiredFieldValidator></td>
        </tr>

          <tr>
            <td><asp:DropDownList ID="Subject3NameList" runat="server" Width="200"></asp:DropDownList></td>
            <td><asp:DropDownList ID="Subject3GradeList" runat="server" Width="200"></asp:DropDownList></td>
            <td><asp:RequiredFieldValidator ID="Subject3NameListReq" runat="server" ControlToValidate="Subject3NameList" ErrorMessage="Plesae enter your third subject & GRADE!"></asp:RequiredFieldValidator></td>
        </tr>

          <tr>
            <td><asp:DropDownList ID="Subject4NameList" runat="server" Width="200"></asp:DropDownList></td>
             <td><asp:DropDownList ID="Subject4GradeList" runat="server" Width="200"></asp:DropDownList></td>
            <td><asp:RequiredFieldValidator ID="Subject4NameListReq" runat="server" ControlToValidate="Subject4NameList" ErrorMessage="Plesae enter your forth subject & GRADE!"></asp:RequiredFieldValidator></td>
        </tr>

          <tr>
            <td><asp:DropDownList ID="Subject5NameList" runat="server" Width="200"></asp:DropDownList></td>
             <td><asp:DropDownList ID="Subject5GradeList" runat="server" Width="200"></asp:DropDownList></td>
            <td><asp:RequiredFieldValidator ID="Subject5NameListReq" runat="server" ControlToValidate="Subject5NameList" ErrorMessage="Plesae enter your fifth subject & GRADE!"></asp:RequiredFieldValidator></td>
        </tr>

          <tr>
            <td><asp:DropDownList ID="Subject6NameList" runat="server" Width="200"></asp:DropDownList></td>
            <td><asp:DropDownList ID="Subject6GradeList" runat="server" Width="200"></asp:DropDownList></td>
            <td><asp:RequiredFieldValidator ID="Subject6NameListReq" runat="server" ControlToValidate="Subject6NameList" ErrorMessage="Plesae enter your sixth subject & GRADE!"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td><asp:Button ID="previousButton" runat="server" Text="<< Previous"  BorderStyle="Ridge" Width="100" Height="40" OnClick="previousButton_Click"/>
            <asp:Button ID="submitButton" runat="server" Text="Next"  BorderStyle="Ridge" Width="100" Height="40" OnClick="submitButton_Click"/></td>
        </tr>

    </table>

</asp:Content>
