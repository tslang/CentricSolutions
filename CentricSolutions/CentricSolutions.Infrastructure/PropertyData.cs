using CentricSolutions.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricSolutions.Infrastructure
{
    public class PropertyData
    {
        public IList<Property> GetProps()
        {
            var props = new List<Property>
            {
                new Property
                {
                    PropertyId = 1,
                    Name = "Brookhollow Two",
                    AddressLine1 = "9800 Brookhollow",
                    AddressLine2 = "Suite 200",
                    City = "Houston",
                    State = "TX",
                    PostalCode = "77025",
                    Country = "USA",
                    RBA = 80000,                
                    RentalRate = 12,
                    Expenses = 5,
                    Stories = 6,
                },
                new Property
                {
                    PropertyId = 2,
                    Name = "480 North Belt",
                    AddressLine1 = "480 N Sam Houston Pkwy E",
                    AddressLine2 = "Suite 100",
                    City = "Houston",
                    State = "TX",
                    PostalCode = "77401",
                    Country = "USA",
                    RBA = 70000,
                    RentalRate = 14,
                    Expenses = 7,
                    Stories = 3,
                }
            };
            return props;
        }
    }
}