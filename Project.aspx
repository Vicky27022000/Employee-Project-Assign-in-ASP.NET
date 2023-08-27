<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Mobile.Master" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="EmployeeProjectAssign.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .auto-style8 {
            width: 1109px;
            height: 399px;
            background-color:aquamarine;
        margin-right: 2px;
    }
        .auto-style11 {
            width: 327px;
        }
        .auto-style12 {
            width: 328px;
        }
        .auto-style7 {
            margin-left: 26px;
        }
        .auto-style14 {
            margin-left: 0px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style8">
    <tr>
        <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Type:-</td>
        <td class="auto-style12">
            <asp:DropDownList ID="ddltype" runat="server" AutoPostBack="True">
                <asp:ListItem>ADO</asp:ListItem>
                <asp:ListItem Value="MVC">MVC</asp:ListItem>
                <asp:ListItem>.net</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Project Name:-&nbsp;</td>
    <td>
        <asp:TextBox ID="txtprojectname" runat="server" Width="212px"></asp:TextBox>
    </td>
    </tr>
    <tr>
        <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Start Date:-&nbsp;</td>
        <td class="auto-style12">
            <asp:TextBox ID="txtstartdate" runat="server" Width="225px" OnTextChanged="startdate_SelectionChanged"></asp:TextBox>
            <asp:ImageButton ID="btncalstartdate" runat="server" OnClick="btncalstartdate_Click" Width="24px" />
            <asp:Calendar ID="startdate" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="260px" CssClass="auto-style14" OnSelectionChanged="enddate_SelectionChanged">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
        </td>
    </tr>
    <tr>
        <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; End Date:-&nbsp;</td>
        <td class="auto-style12">
            <asp:TextBox ID="txtenddate0" runat="server" Width="225px" OnTextChanged="txtenddate0_TextChanged"></asp:TextBox>
            <asp:ImageButton ID="btncalenddate" runat="server" OnClick="btncalenddate_Click" Width="24px" />
            <asp:Calendar ID="enddate" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="260px" CssClass="auto-style14" OnSelectionChanged="enddate_SelectionChanged">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnsave" runat="server" Text="Save" BackColor="#33CC33" OnClick="btnsave_Click" />
        &nbsp;&nbsp;
            <asp:Button ID="btnclear" runat="server" Text="Clear" CssClass="auto-style7" Width="96px" BackColor="Red" OnClick="btnclear_Click" />
        </td>
    </tr>
</table>
</asp:Content>
