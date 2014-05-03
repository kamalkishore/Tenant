<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SubmitTenantDetails.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>Fill Tenant Details</div>
        <div>First Name</div>
        <div>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </div>
        <div>Last Name</div>
        <div>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </div>
        <div>Phone Number</div>
        <div>
            <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        </div>
        
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit Details" OnClick="btnSubmit_Click" /></div>
    </div>
</asp:Content>
