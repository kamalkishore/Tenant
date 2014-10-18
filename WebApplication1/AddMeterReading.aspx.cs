using System;
using TenantSystem;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var tenant = new TenantRepository();
            ddTenant.DataSource = tenant.GetAllTenant();
            ddTenant.DataTextField = "FirstName";
            ddTenant.DataValueField = "id";
            ddTenant.DataBind();
        }

        protected void btnSubmitMeterReading_Click(object sender, EventArgs e)
        {
            // todo seperate the code into smaller parts
            // todo convert the sql statements to procedure and functions
            GenerateBill();
        }

        private void GenerateBill()
        {
            int selectedTenantId = GetSelectedTenantId();
            int selectedPricePerUnit = GetSelectedPricePerUnit();
            int currentMeterReading = Convert.ToInt32(txtMeterReading.Text);
            
            var tenantSystemController = new TenantSystemController();
            tenantSystemController.GenerateBill(selectedTenantId, selectedPricePerUnit, currentMeterReading);
        }

        private int GetSelectedPricePerUnit()
        {
            return Convert.ToInt32(ddPricePerUnit.SelectedValue);
        }

        private int GetSelectedTenantId()
        {
            return Convert.ToInt32(ddTenant.SelectedItem.Value);
        }
    }
}