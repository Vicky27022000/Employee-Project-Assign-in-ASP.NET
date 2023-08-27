<%@ Page Title="" Language="C#" MasterPageFile="~/Project Manager.Master" AutoEventWireup="true" CodeBehind="Project Manager.aspx.cs" Inherits="EmployeeProjectAssign.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 98%;
            height: 197px;
            background-color:paleturquoise;
        }
        .auto-style7 {
            width: 312px;

        }
        .auto-style8 {
            width: 293px;
        }
        .auto-style9 {
            width: 312px;
            height: 31px;
        }
        .auto-style10 {
            width: 293px;
            height: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Project</td>
            <td class="auto-style8">
                <asp:DropDownList ID="ddproject" runat="server" AutoPostBack="True" Width="113px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Team lead&nbsp;</td>
            <td class="auto-style10">
                <asp:DropDownList ID="ddteamlead" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="Clear" BackColor="Red" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="btnassign" runat="server" Text="Assign" OnClick="btnassign_Click" BackColor="#99FF66" />
            </td>
        </tr>
    </table>
</asp:Content>
