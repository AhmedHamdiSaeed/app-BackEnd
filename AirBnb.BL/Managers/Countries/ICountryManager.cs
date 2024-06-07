using AirBnb.BL.Dtos.CategoryDtos;
using AirBnb.BL.Dtos.CountryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Countries
{
    public interface ICountryManager
    {
        Task<IEnumerable<CountryDtos>> GetAllCountries();
        Task<CountryDtos> GetCountryById(int id);
        Task AddCountry(CountryDtos countryDto); //return void 
        Task<bool> UpdateCountry(EditCountryDtos countryDto);
        Task<bool> DeleteCountry(int id);
    }
}
