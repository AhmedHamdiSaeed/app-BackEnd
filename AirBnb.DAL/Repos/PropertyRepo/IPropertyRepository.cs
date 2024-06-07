using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.PropertyRepo;

public interface IPropertyRepository : IGenericRepository<Property>
{
    Task<IEnumerable<Property>> GetAllPropertyAsync();
    Task<IEnumerable<Property>> GetAllPropertyForAllUsers(int? cityId = null, int? cateId = null);
    Task<IEnumerable<Property>> GetHosterProperties(string hosterId);
    Task<Property> GetProperty(int id);
    Task<Property> GetPropertyToDeleteById(int id);
    void DeleteProperty(Property entity);
}
