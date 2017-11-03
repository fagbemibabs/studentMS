<%@ Page Title="Student Management Portal" Language="C#" MasterPageFile="~/StudentManager.Master" AutoEventWireup="true" CodeBehind="BioData.aspx.cs" Inherits="StudentManagementSystem.BioData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
            <tr>
                 <td>&nbsp;</td>
                 <td colspan="2"><h1>Bio Data Page</h1></td>
                 <td style="width:200px">&nbsp;</td>
            </tr>

            <tr>
                <td style= "width:150px">Registration Number:</td>
                <td><asp:TextBox ID="regTextBox" runat="server" Enabled="false" Width="200"></asp:TextBox></td>        
                <td style="width:10px">&nbsp;</td>
                <td style="width:200px">&nbsp;</td>
                <td rowspan="2"><asp:Image ID="sudImage"  Width="150" Height="150" runat="server" BorderWidth="2" /></td>
            </tr>

            <tr>
                    <td style= "width:150px">Surname:</td>
                    <td><asp:TextBox ID="surnameTextBox" runat="server" Width="200"></asp:TextBox></td>
                    <td>&nbsp;</td>
                    <td><asp:RequiredFieldValidator ID="surnameTextBoxReq" ControlToValidate="surnameTextBox" runat="server" ErrorMessage="Please enter your surname!"></asp:RequiredFieldValidator></td>
            </tr>


            <tr>
                    <td style= "width:150px">First Name:</td>
                    <td><asp:TextBox ID="fNameTextBox" runat="server" Width="200"></asp:TextBox></td>
                    <td>&nbsp;</td>
                    <td><asp:RequiredFieldValidator ID="fNameTextBoxReq" ControlToValidate="fNameTextBox" runat="server" ErrorMessage="Please enter your first name!"></asp:RequiredFieldValidator></td>
                    <td><asp:FileUpload ID="passportFileUpload" runat="server" /></td>   
            </tr>

            <tr>
                <td style= "width:150px">Other Name:</td>
                <td><asp:TextBox ID="otherNameTextBox" runat="server" Width="200"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="otherNameTextBoxReq" ControlToValidate="otherNameTextBox" runat="server" ErrorMessage="Please enter your other names"></asp:RequiredFieldValidator></td>
                <td><asp:Button ID="uploadButton" runat="server" Text="Upload Passport" OnClick="uploadButton_Click" /></td>  
            </tr>

            <tr>
                <td style= "width:150px">Permanent Address:</td>
                <td><asp:TextBox ID="addressTextBox" TextMode="MultiLine" runat="server" Width="200"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="addressTextBoxReq"  runat="server" ControlToValidate="addressTextBox" ErrorMessage="Please enter your Permanent Home address!" ></asp:RequiredFieldValidator></td>
                <asp:Label ID="uploadLabel" runat="server"></asp:Label>
            </tr>

            <tr>
                <td style="width:150px">Gender:</td>
                <td><asp:DropDownList ID="genderDropDownList" runat="server" Width="200"></asp:DropDownList></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="genderDropDownListReq" ControlToValidate="genderDropDownList" runat="server" ErrorMessage="Please SELECT your Gender!"></asp:RequiredFieldValidator></td>         
                <td><asp:RequiredFieldValidator ID="passportFileUploadReq" ControlToValidate="passportFileUpload" runat="server" ErrorMessage="Please upload a passport photograph!"></asp:RequiredFieldValidator></td>
</tr>

            <tr>
                <td style="width:150px">Date of Birth:</td>
                <td><asp:TextBox ID="dobTextBox" runat="server" Width="200"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td><asp:CompareValidator ID="dobCheck" Operator="DataTypeCheck" Type="Date" runat="server" ControlToValidate="dobTextBox" ErrorMessage="You must enter your D.O.B in the valid format!" SetFocusOnError="true" Display="Dynamic"></asp:CompareValidator></td>
            </tr>

            <tr>
                <td style="width:150px">Email:</td>
                <td><asp:TextBox ID="emailTextBox" runat="server" Width="200"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="emailTextBoxReq" ControlToValidate="emailTextBox" runat="server" ErrorMessage="Please enter your email address!"></asp:RequiredFieldValidator></td>
                <td><asp:RegularExpressionValidator ID="emailValidator" ControlToValidate="emailTextBox" ValidationExpression="^\S+@\S+\.\S+$" runat="server" ErrorMessage="Invalid email address!" SetFocusOnError="true"></asp:RegularExpressionValidator></td>
            </tr>

            <tr>
                <td style="width:150px">Phone number:</td>
                <td><asp:TextBox ID="phoneNumTextBox" runat="server" Width="200"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="phoneNumTextBoxReq" ControlToValidate="phoneNumTextBox" runat="server" ErrorMessage="Please enter a phone number of lenght 11 digits!"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td style="width:150px">State of Origin:</td>
                <td><asp:DropDownList ID="stateDropDownList" AppendDataBoundItems="true" runat="server" Width="200" AutoPostBack="true" OnSelectedIndexChanged="stateDropDownList_SelectedIndexChanged">
                    <asp:ListItem>SELECT</asp:ListItem>
                    </asp:DropDownList></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="stateDropDownListReq" runat="server" ControlToValidate="stateDropDownList" ErrorMessage="Please select your State of Origin!"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td style="width:150px">L.G.A:</td>
                <td><asp:DropDownList ID="lgaDropDownList" runat="server" Width="200"></asp:DropDownList></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="lgaDropDownListReq" runat="server" ControlToValidate="lgaDropDownList" ErrorMessage="Please SELECT your L.G.A!"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td style="width:150px">Name of Next of Kin:</td>
                <td><asp:TextBox ID="nextKinTextBox" runat="server" Width="200"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="nextKinTextBoxReq" runat="server" ControlToValidate="nextKinTextBox" ErrorMessage="Please enter the name of your next of kin!"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td style="width:150px">Phone number of Next of Kin:</td>
                <td><asp:TextBox ID="nextKinPhoneTextBox" runat="server" Width="200"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="nextKinPhoneTextBoxReq" runat="server" ControlToValidate="nextKinPhoneTextBox" ErrorMessage="Please enter a phone number for next of kin!"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td style="width:150px">Address of Next of Parent:</td>
                <td><asp:TextBox ID="nextkinAddressTextBox" TextMode="MultiLine" runat="server" Width="200"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="nextkinAddressTextBoxReq" runat="server" ControlToValidate="nextkinAddressTextBox" ErrorMessage="Please enter the address of your next of kin!"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td style="width:150px">Email address of Parent:</td>
                <td><asp:TextBox ID="emailNextKinTextBox" runat="server" Width="200"></asp:TextBox></td>
                <td>&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="emailNextKinTextBoxReq" ControlToValidate="emailNextKinTextBox" runat="server" ErrorMessage="Please enter email address for next of kin!"></asp:RequiredFieldValidator></td>
                <td><asp:RegularExpressionValidator id="emailNextKinValidator" runat="server" ControlToValidate="emailNextKinTextBox" ValidationExpression="^\S+@\S+\.\S+$" ErrorMessage="You must enter a valid email address!" /></td>
            </tr>


            <tr>
                <td style="width:150px">&nbsp;</td>
                <td><asp:Button ID="submitButton" runat="server" Text="Next >>" Width="120px" Height="40px" Font-Bold="true" BackColor="#ff66cc" OnClick="submitButton_Click"/></td>
                <td><asp:Button ID="exitButton" runat="server" Text="Quit" Width="120px" Height="40px" Font-Bold="true" BackColor="#ff66cc" OnClick="exitButton_Click"/></td>
            </tr>
       
   </table>
</asp:Content>
