using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class CustomerCustomerDemo
    {
        public string CustomerID { get; set; }  
        public string CustomerTypeID { get; set; }

        public CustomerCustomerDemo() { }
        public CustomerCustomerDemo(string customerID, string customerTypeID)
        {
            CustomerID = customerID;
            CustomerTypeID = customerTypeID;
        }

    }
}
