using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class Shippers
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string? Phone { get; set; }

        public Shippers() { }

        public Shippers(int shipperID, string companyName, string? phone)
        {
            ShipperID = shipperID;
            CompanyName = companyName;
            Phone = phone;
        }
    }
}
