<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SignupForm.aspx.cs" Inherits="ASPWebForms.SignupForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 runat="server" id="headerSignup">SignUp Form</h2>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblFName" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtbFName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtbLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtbEmail" TextMode="Email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtbPassword" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
                    </td
                    <td>
                        <asp:Calendar ID="calendarDOB" runat="server"></asp:Calendar>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlCountry" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButton Text="Male" ID="rbMale" GroupName="Gender" runat="server" />
                        <asp:RadioButton Text="Female" ID="rbFemale" GroupName="Gender" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td>

                    </td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>

            <label id="lblData" runat="server"></label>

        </div>
</asp:Content>
