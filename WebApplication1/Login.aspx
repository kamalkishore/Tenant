<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>User Name</div>
        <div>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></div>
        <div>Password</div>
        <div><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></div>

    </div>
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></div>
    
</asp:Content>
