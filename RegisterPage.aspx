<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 588px;
        }
        .auto-style3 {
            width: 314px;
        }
        .auto-style4 {
            width: 314px;
            height: 26px;
        }
        .auto-style5 {
            width: 588px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 314px;
            height: 33px;
        }
        .auto-style8 {
            width: 588px;
            height: 33px;
        }
        .auto-style9 {
            height: 33px;
        }
        .auto-style10 {
            width: 314px;
            height: 23px;
        }
        .auto-style11 {
            width: 588px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="20pt" Text="Registration Page"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11">
                    <asp:Label ID="lblAlradyExist" runat="server" Font-Bold="True" ForeColor="Red" Text="l"></asp:Label>
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="LoginName"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtLoginName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLoginName" ErrorMessage="Required UserName" Font-Bold="True" ForeColor="Red" ValidationGroup="grpRegister"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="RequiredField Password" Font-Bold="True" ForeColor="Red" ValidationGroup="grpRegister"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtCfPassword" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtCfPassword" ErrorMessage="Password and Confirm Password Not Matched" Font-Bold="True" ForeColor="Red" ValidationGroup="grpRegister"></asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Email ID"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailId" ErrorMessage="Please Enter The Valid EmailId" Font-Bold="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="grpRegister"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddress" ErrorMessage="RequiredField Address" Font-Bold="True" ForeColor="Red" ValidationGroup="grpRegister"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label7" runat="server" Text="City"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlCity" runat="server" DataSourceID="SqlDataSource1" DataTextField="CItyName" DataValueField="CityId">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DotNetConnectionString %>" SelectCommand="SELECT * FROM [Cities]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label8" runat="server" Text="Payment Mode"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlPaymentMode" runat="server" DataSourceID="SqlDataSource2" DataTextField="PaymentModeName" DataValueField="PaymentModeId">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DotNetConnectionString %>" SelectCommand="SELECT * FROM [PaymentModeMaster]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" ValidationGroup="grpRegister" />
                    <input id="Reset1" type="reset" value="Reset" /></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
