<%@ Page Title=" School fees Balance" Language="C#" MasterPageFile="~/StudentManager.Master" AutoEventWireup="true" CodeBehind="ShowBalance.aspx.cs" Inherits="StudentManagementSystem.ShowBalance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr>
            <td style="width:200px">&nbsp;</td>
            <td><asp:Label ID="balanceLabel" runat="server"></asp:Label></td>
        </tr>

        <tr>
            <td>&nbsp;</td>
        </tr>

                <tr>
            <td>&nbsp;</td>
        </tr>

         <tr>
            <td style="width:200px">&nbsp;</td>
            <td><asp:Button ID="exitButton" runat="server" Text="Finish" Width="100" OnClick="exitButton_Click"/></td>
        </tr>
    </table>


</asp:Content>
