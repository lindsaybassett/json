using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example04
{
    public class account : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.WriteFile("account.json");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}