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
            <asp:Button ID="btnSubmit" runat="server" Text="Submit Details" OnClick="btnSubmit_Click" />
            <br />
            <br />
            <asp:GridView ID="grdTenant" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <br />
        </div>
    </div>
</asp:Content>
