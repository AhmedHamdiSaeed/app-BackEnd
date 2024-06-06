using AirBnb.BL.Dtos.CountryDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Countries
{
    public class CountryManager : ICountryManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public CountryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddCountry(CountryDtos countryDto)
        {
            var country = new Country
            {
                Name = countryDto.Name
            };

            await _unitOfWork.CountryRepository.AddAsync(country);
            _unitOfWork.SaveChanges();
        }

        public async Task<bool> DeleteCountry(int id)
        {
            Country country = await _unitOfWork.CountryRepository.GetByIdAsync(id);
            if (country is null)
            {
                return false;
            }

            _unitOfWork.CountryRepository.Delete(country);
            _unitOfWork.SaveChanges();
            return true;
        }

        public async Task<IEnumerable<CountryDtos>> GetAllCountries()
        {
            var countries = await _unitOfWork.CountryRepository.GetAllAsync();
            return countries.Select(c => new CountryDtos
            {
                Name = c.Name
            }).ToList();
        }

        public async Task<CountryDtos> GetCountryById(int id)
        {
            Country country = await _unitOfWork.CountryRepository.GetByIdAsync(id);
            if (country is null)
            {
                return null;
            }

            return new CountryDtos
            {
                Name = country.Name
            };
        }

        public async Task<bool> UpdateCountry(EditCountryDtos countryDto)
        {
            Country country = await _unitOfWork.CountryRepository.GetByIdAsync(countryDto.Id);
            if (country is null)
            {
                return false;
            }

            country.Name = countryDto.Name;

            _unitOfWork.CountryRepository.Update(country);
            _unitOfWork.SaveChanges();
            return true;
        }
    }
}
