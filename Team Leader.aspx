<%@ Page Title="" Language="C#" MasterPageFile="~/Team Leader.Master" AutoEventWireup="true" CodeBehind="Team Leader.aspx.cs" Inherits="EmployeeProjectAssign.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        width: 1025px;
        margin-right: 0px;
        background-color:aquamarine;
    }
        .auto-style5 {
            width: 290px;
        }
        .auto-style6 {
            width: 194px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table class="auto-style4">
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style5">Team Leader Name</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style11">
                <asp:Label ID="lblteamleadername" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Project Name</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>
                <asp:Label ID="lblprojectname" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lblprojectname0" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style6">
                Iteration1</td>
            <td class="auto-style11">
                <asp:Button ID="btncomplete0" runat="server" Text="Complete" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lblprojectname1" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style6">
                Iteration2</td>
            <td class="auto-style11">
                <asp:Button ID="btncomplete1" runat="server" Text="Complete" OnClick="btncomplete1_Click1" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lblprojectname2" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style6">
                Iteration3</td>
            <td class="auto-style11">
                <asp:Button ID="btncomplete2" runat="server" Text="Complete" OnClick="btncomplete2_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
