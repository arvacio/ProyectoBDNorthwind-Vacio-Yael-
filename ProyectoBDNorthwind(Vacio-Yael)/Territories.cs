using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class Territories
    {
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        public Territories() { }

        public Territories(string territoryID, string territoryDescription, int regionID)
        {
            TerritoryID = territoryID;
            TerritoryDescription = territoryDescription;
            RegionID = regionID;
        }
    }
}
