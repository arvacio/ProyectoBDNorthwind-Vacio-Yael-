using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class CustomerDemographics
    {
        public string CustomerTypeID { get; set; }
        public string? CustomerDesc { get; set; }

        public CustomerDemographics() { }

        public CustomerDemographics(string customerTypeID, string? customerDesc)
        {
            CustomerTypeID = customerTypeID;
            CustomerDesc = customerDesc;
        }
    }
}
