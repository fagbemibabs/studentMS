<%@ Page Title="School Payment Portal" Language="C#" MasterPageFile="~/StudentManager.Master" AutoEventWireup="true" CodeBehind="PaymentPortal.aspx.cs" Inherits="StudentManagementSystem.PaymentPortal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Make Payment</h1>
    <table>
        <tr>
            <td>PIN:</td>
            <td><asp:TextBox ID="pinTextBox" runat="server" Width="200"></asp:TextBox></td>
        </tr>

          <tr>
            <td>Teller Number:</td>
            <td><asp:TextBox ID="tellerNoTextBox" runat="server" Width="200"></asp:TextBox> Must be INTEGER & not more than 8!</td>
              <td><asp:RequiredFieldValidator ID="tellerNoTextBoxReq" ControlToValidate="tellerNoTextBox" runat="server" ErrorMessage="Please enter an INTEGER value!"></asp:RequiredFieldValidator></td>
              <%--<asp:CompareValidator ID="tellerNoCheck" ControlToValidate="tellerNoTextBox" runat="server" Operator="DataTypeCheck" Type="Integer" ErrorMessage="Please enter an INTEGER value!"></asp:CompareValidator>--%>
        </tr>

         <tr>
            <td>Date of Payment:</td>
            <td><asp:TextBox ID="datePaymentTextBox" runat="server" Width="200"></asp:TextBox></td>
        </tr>

          <tr>
            <td>Bank of Payment:</td>
            <td><asp:DropDownList ID="bankDropDownList" runat="server" Width="200"></asp:DropDownList></td>
        </tr>

         <tr>
            <td>Branch of Payment:</td>
            <td>
                <asp:DropDownList ID="bankBranchDropDownList" runat="server" Width="200"></asp:DropDownList></td>
        </tr>

         <tr>
            <td>Bank Service Personnel:</td>
            <td><asp:TextBox ID="bankPersonnelTextBox" runat="server" Width="200"></asp:TextBox></td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td><asp:Button ID="previousButton" runat="server" Text="<<Previous Step"  Width="120" Height="40" BorderStyle="Solid" OnClick="previousButton_Click"/>
            <asp:Button ID="submitButton" runat="server" Text="Submit"  Width="120" Height="40" BorderStyle="Solid" OnClick="submitButton_Click"/>
            <asp:Button ID="exitButton" runat="server" Text="Quit"  Width="120" Height="40" BorderStyle="Solid" OnClick="exitButton_Click"/></td>
        </tr>
    </table>
</asp:Content>
 