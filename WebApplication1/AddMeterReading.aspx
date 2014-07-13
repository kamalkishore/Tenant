                    <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddMeterReading.aspx.cs" Inherits="WebApplication1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Select Tenant"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddTenant" runat="server" Height="22px" Width="384px">
    </asp:DropDownList>
    <br />
    <br />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Per Unit Price"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddPricePerUnit" runat="server" Height="22px" Width="384px">
        <asp:ListItem>7</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Enter Current Month Reading"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtMeterReading" runat="server" Width="225px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSubmitMeterReading" runat="server" OnClick="btnSubmitMeterReading_Click" Text="Submit" />
    <br />
    <br />
</asp:Content>
