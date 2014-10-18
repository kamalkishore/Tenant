using System;
using TenantSystem;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Tenant tenant = new Tenant 
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text
            };

            TenantRepository tenantRepository = new TenantRepository();
            tenantRepository.Add(tenant);
            grdTenant.DataSource = null;
            grdTenant.DataSource = tenantRepository.GetAllTenant();
            grdTenant.DataBind();

        }
    }
}