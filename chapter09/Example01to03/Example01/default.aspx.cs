using Newtonsoft.Json;
using System;
using System.Net;
using System.Web.UI;
using Example01.App_Code;

namespace Example01
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerAccount bobsAccount = new CustomerAccount();
            bobsAccount.firstName = "Bob";
            bobsAccount.lastName = "Barker";
            bobsAccount.phone = "555-555-5555";

            Address[] addresses;
            addresses = new Address[2];

            Address bobsAddress1 = new Address();
            bobsAddress1.state = "123 fakey st";
            bobsAddress1.city = "Somewhere";
            bobsAddress1.state = "CA";
            bobsAddress1.zip = 96520;

            addresses[0] = bobsAddress1;

            Address bobsAddress2 = new Address();
            bobsAddress2.state = "456 fake dr";
            bobsAddress2.city = "Some Place";
            bobsAddress2.state = "CA";
            bobsAddress2.zip = 96538;

            addresses[1] = bobsAddress2;

            bobsAccount.addresses = addresses;
            bobsAccount.famous = true;

            string json = JsonConvert.SerializeObject(bobsAccount);

            txtJSON.Text = json;

        }
    }
}