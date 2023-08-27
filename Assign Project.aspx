<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Assign Project.aspx.cs" Inherits="EmployeeProjectAssign.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 50%;
            height: 365px;
            background-color:navajowhite;
            color:blueviolet;
        }
        .auto-style3 {
            height: 103px;
            width: 942px;
        }
        .auto-style4 {
            height: 122px;
            width: 942px;
        }
        .auto-style5 {
            width: 422px;
        }
        .auto-style6 {
            height: 103px;
            width: 422px;
        }
        .auto-style7 {
            height: 122px;
            width: 422px;
          
        }
        .auto-style8 {
        width: 942px;
        color: aqua;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">Project</td>
            <td class="auto-style3">
                <asp:DropDownList ID="ddproject" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Project Manager</td>
            <td class="auto-style4">
                <asp:DropDownList ID="ddprojectmanager" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" Text="Clear" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Assign" />
            </td>
        </tr>
        </table>
</asp:Content>
