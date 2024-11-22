using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class Categories
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public string? Description { get; set; }
        public byte[]? Picture { get; set; }

        public Categories() { }

        public Categories(int categoryID, string categoryName, string? description, byte[]? picture)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
            Picture = picture;
        }
    }
}
