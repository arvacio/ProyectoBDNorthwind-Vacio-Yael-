using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class EmployeeTerritories
    {
        public int EmployeeID { get; set; }
        public string TerritoryID { get; set; }
        public EmployeeTerritories() { }

        public EmployeeTerritories(int EmployeeID, string Territory) 
        { 
            this.EmployeeID = EmployeeID;
            this.TerritoryID = Territory;
        }
    }
}
