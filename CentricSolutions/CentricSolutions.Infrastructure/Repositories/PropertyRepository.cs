using CentricSolutions.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CentricSolutions.Domain.Repositories;

namespace CentricSolutions.Infrastructure.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
       internal IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            }
        }

        public PropertyRepository()
        {

        }

        public IEnumerable<Property> GetAllProperties()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                var properties = cn.Query<Property>("SELECT * FROM Property").ToList();
                return properties;
            }
        }

        public void AddProperty(Property property)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                const string query = "INSERT INTO [dbo].[Property]([Name],[AddressLine1],[AddressLine2],[City],[State],[PostalCode],[Country],[RentalRate],[Expenses],[RBA],[Stories]) VALUES (@Name,@AddressLine1,@AddressLine2,@City,@State,@PostalCode,@Country,@RentalRate,@Expenses,@RBA,@Stories)";
                cn.Execute(query,
                    new
                    {
                        Name = property.Name,
                        AddressLine1 = property.AddressLine1,
                        AddressLine2 = property.AddressLine2,
                        City = property.City,
                        State = property.State,
                        PostalCode = property.PostalCode,
                        Country = property.Country,
                        RentalRate = property.RentalRate,
                        Expenses = property.Expenses,
                        RBA = property.RBA,
                        Stories = property.Stories
                    });
                cn.Close();
            }
        }

        public void EditProperty(Property property)
        {

        }

        public void DeleteProperty()
        {

        }

    }
}