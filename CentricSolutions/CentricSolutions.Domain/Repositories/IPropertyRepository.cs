using CentricSolutions.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentricSolutions.Domain.Repositories
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetAllProperties();
        void AddProperty(Property property);
        void EditProperty(Property property);
        void DeleteProperty();
    }
}
