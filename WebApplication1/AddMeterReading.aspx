                    <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddMeterReading.aspx.cs" Inherits="WebApplication1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="Scripts/jquery-2.1.1.intellisense.js"></script>
    <script src="Scripts/jquery-2.1.1.js"></script>
    <script src="Scripts/jquery-2.1.1.min.js"></script>
    <script src="Scripts/jquery.daterangepicker/daterangepicker.jQuery.js"></script>
    <script>
        $(document).ready(function() {
            //$("#<%= txtDateMeterReading.ClientID %>").datepicker(); 
            $(".date-picker").datepicker({
                showOn: 'button',
                buttonImageOnly: true,
                buttonImage: 'http://jqueryui.com/demos/datepicker/images/calendar.gif'
            });
        });
    </script>
    <div>
        <div>
            <label>Date of Meter Reading</label>
        </div>
        <div>
            <asp:TextBox ID="txtDateMeterReading" CssClass="date-picker" runat="server" Width="225px"></asp:TextBox>
        </div>
    </div>
    <br/>
    <br/>
    <div>
        <div>
            <label>Select Tenant</label>
        </div>
        <div>
            <asp:DropDownList ID="ddTenant" runat="server" Height="22px" Width="384px">
            </asp:DropDownList>
        </div>
    </div>
    <br />
    <br />
    <div>
        <div>
            <label>Per Unit Price</label>
        </div>
        <div>
            <asp:DropDownList ID="ddPricePerUnit" runat="server" Height="22px" Width="384px">
            <asp:ListItem>7</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <br />
    <br />
    <div>
        <div>
            <label>Enter Current Month Reading</label>
        </div>
        <div>
            <asp:TextBox ID="txtMeterReading" runat="server" Width="225px"></asp:TextBox>
        </div>
    </div>
    <br />
    <br />
    <div>
        <asp:Button ID="btnSubmitMeterReading" runat="server" OnClick="btnSubmitMeterReading_Click" Text="Submit" />
    </div>
    
    <br />
    <br />
</asp:Content>
