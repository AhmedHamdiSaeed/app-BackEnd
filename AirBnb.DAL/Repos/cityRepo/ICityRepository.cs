using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.CityRepo
{
    public interface ICityRepository :IGenericRepository<City>
    {
        Task<IEnumerable<City>> GetAllCitiesWithCountry();
        Task<City> GetCityByIdWithCountry(int Cityid);
    }
}
