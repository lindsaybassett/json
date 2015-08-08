using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example01.App_Code
{
    public class CustomerAccount
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public Address[] addresses { get; set; }
        public bool famous { get; set; }
    }

    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
    }
}