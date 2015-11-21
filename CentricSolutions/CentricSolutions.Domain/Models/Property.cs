using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricSolutions.Domain.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Name { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }


        public decimal RentalRate { get; set; }
        public decimal Expenses { get; set; }
        public int RBA { get; set; }
        public int Stories { get; set; }


        public virtual ICollection<Tenant> Tenants { get; set; }
        public virtual ICollection<Prospect> Prospects { get; set; }


        public Property()
        {

        }

        public Property(int id, string name, string address1, string address2, string city, string state, string postalCode, string country, decimal rentalRate, decimal expenses, int rba, int stories)
        {
            this.PropertyId = id;
            this.Name = name;
            this.AddressLine1 = address1;
            this.AddressLine2 = address2;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.Country = country;
            this.RentalRate = rentalRate;
            this.Expenses = expenses;
            this.RBA = rba;
            this.Stories = stories;
        }

  




    }
}