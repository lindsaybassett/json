using Newtonsoft.Json;
using System;
using System.Net;
using System.Web.UI;
using Example04.App_Code;

namespace Example04
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerAccount customerAccount;

            using (var webClient = new WebClient())
            {
                // modified example 9-7 to get JSON from local file instead of CouchDB database
                string json = webClient.DownloadString("http://localhost:49903/account.ashx");
                customerAccount = JsonConvert.DeserializeObject<CustomerAccount>(json);
            }

            string fullName = customerAccount.firstName + " " + customerAccount.lastName;

            txtJSON.Text = fullName;

        }
    }
}