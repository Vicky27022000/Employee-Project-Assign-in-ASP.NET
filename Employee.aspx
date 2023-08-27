<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Mobile.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EmployeeProjectAssign.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 40%;
        }
        .auto-style8 {
            width: 1105px;
            height: 413px;
            background-color:aquamarine;
        margin-right: 2px;
    }
        .auto-style11 {
            width: 345px;
        }
        .auto-style12 {
            width: 328px;
        }
        .auto-style7 {
            margin-left: 26px;
        }
        .auto-style13 {
        width: 345px;
        height: 36px;
    }
    .auto-style14 {
        width: 328px;
        height: 36px;
    }
        .auto-style15 {
            margin-left: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <table class="auto-style8">
            <tr>
                <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Type:-</td>
                <td class="auto-style12">
                    <asp:DropDownList ID="cmbtype" runat="server" Width="170px" AutoPostBack="True">
                        <asp:ListItem>Project Manager</asp:ListItem>
                        <asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Team Lead</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            
                <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name:-&nbsp;</td>
            
                <td>
                    <asp:TextBox ID="txtname" runat="server" Width="212px"></asp:TextBox>
            </td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email:-&nbsp;</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtemail" runat="server" Width="208px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Phone No.:-&nbsp;</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtphoneno" runat="server" Width="208px" CssClass="auto-style15" OnTextChanged="txtphoneno_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Gender:-&nbsp;</td>
                <td class="auto-style12">
                    <asp:RadioButton ID="male" runat="server" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="female" runat="server" Text="Female" />
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Country:-&nbsp;</td>
                <td class="auto-style12">
                    <asp:DropDownList ID="cmbcountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbcountry_SelectedIndexChanged" Width="172px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; State:-&nbsp;</td>
                <td class="auto-style12" id="cmbstate">
                    <asp:DropDownList ID="cmbstate" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbstate_SelectedIndexChanged1" Width="171px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; City:-</td>
                <td class="auto-style14">
                    <asp:DropDownList ID="cmbcity" runat="server" OnSelectedIndexChanged="cmbcity_SelectedIndexChanged" Width="170px" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password:-&nbsp;</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtpassword" runat="server" Width="223px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;<asp:Button ID="Button2" runat="server" Text="Save" OnClick="Button2_Click" BackColor="#00CC00" />
                &nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="Clear" CssClass="auto-style7" Width="69px" BackColor="#FF3300" OnClick="Button3_Click1" />
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
            </tr>
        </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</asp:Content>
