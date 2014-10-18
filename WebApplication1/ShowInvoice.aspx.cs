using System;
using TenantSystem;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var tenant = new TenantRepository();
            ddTenant.DataSource = tenant.GetAllTenant();
            ddTenant.DataTextField = "FirstName";
            ddTenant.DataValueField = "id";
            ddTenant.DataBind();

            ShowInvoiceDetails();
        }

        protected void ddTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInvoiceDetails();
        }

        private int GetSelectedTenantId()
        {
            return Convert.ToInt32(ddTenant.SelectedItem.Value);
        }

        private void ShowInvoiceDetails()
        {
            var billInvoiceRepository = new BillInvoiceRepository();
            GridView1.DataSource = billInvoiceRepository.GetInvoiceDetails(GetSelectedTenantId());
            GridView1.DataBind();
        }
    }
}