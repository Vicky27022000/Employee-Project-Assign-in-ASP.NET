<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Pay.aspx.cs" Inherits="EmployeeProjectAssign.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Project Name:-&nbsp;&nbsp;
        <asp:Label ID="lblprojectname" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Team Leader:-&nbsp; -<asp:Label ID="lblteamlead" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Project Manager:-&nbsp;&nbsp;
        <asp:Label ID="lblprojectmanager" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Pay Amount:-
        <asp:TextBox ID="txtamount" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="btnpayment" runat="server" OnClick="btnpayment_Click" Text="Payment" />
    <p>
        &nbsp;</p>
</asp:Content>
