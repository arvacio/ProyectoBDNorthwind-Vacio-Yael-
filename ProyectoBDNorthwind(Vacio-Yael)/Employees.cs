using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public class Employees
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }
        public string? BirthDate { get; set; }
        public string? HireDate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? HomePhone { get; set; }
        public string? Extension { get; set; }
        public byte[]? Photo { get; set; }
        public string? Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string? PhotoPath { get; set; }

        public Employees() { }

        public Employees(int employeeID, string lastName, string firstName, string? title, string? titleOfCourtesy, string? birthDate, string? hireDate, string? address, string? city, string? region, string? postalCode, string? country, string? homePhone, string? extension, byte[]? photo, string? notes, int? reportsTo, string? photoPath)
        {
            this.EmployeeID = employeeID;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Title = title;
            this.TitleOfCourtesy = titleOfCourtesy;
            this.BirthDate = birthDate;
            this.HireDate = hireDate;
            this.Address = address;
            this.City = city;
            this.Region = region;
            this.PostalCode = postalCode;
            this.Country = country;
            this.HomePhone = homePhone;
            this.Extension = extension;
            this.Photo = photo;
            this.Notes = notes;
            this.ReportsTo = reportsTo;
            this.PhotoPath = photoPath;
        }
    }
}
