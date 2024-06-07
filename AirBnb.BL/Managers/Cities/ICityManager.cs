using AirBnb.BL.Dtos.CityDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Cities
{
    public interface ICityManager
    {
        Task<IEnumerable<CityDtos>> GetAllCities();
        Task<CityDtos> GetCityById(int id);
        Task AddCity(AddCityDto CityDto); //return void 
        Task<bool> UpdateCity(EditCityDtos CityDto);
        Task<bool> DeleteCity(int id);
    }
}
