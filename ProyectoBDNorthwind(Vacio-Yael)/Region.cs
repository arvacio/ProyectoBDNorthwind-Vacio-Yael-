using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        public Region() { }

        public Region(int regionID, string regionDescription)
        {
            RegionID = regionID;
            RegionDescription = regionDescription;
        }

    }
}
