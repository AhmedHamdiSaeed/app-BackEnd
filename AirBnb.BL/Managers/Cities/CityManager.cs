using AirBnb.BL.Dtos.CityDtos;
using AirBnb.BL.Dtos.CountryDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Cities
{
    public class CityManager : ICityManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public CityManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddCity(AddCityDto cityDto)
        {
            var city = new City
            {
                Name = cityDto.Name,
                CountryId = cityDto.CountryId
            };

            await _unitOfWork.CityRepository.AddAsync(city);
            _unitOfWork.SaveChanges();
        }

        public async Task<bool> DeleteCity(int id)
        {
            City city = await _unitOfWork.CityRepository.GetByIdAsync(id);
            if (city == null)
            {
                return false;
            }

            _unitOfWork.CityRepository.Delete(city);
            _unitOfWork.SaveChanges();
            return true;
        }

        public async Task<IEnumerable<CityDtos>> GetAllCities()
        {
            var cities = await _unitOfWork.CityRepository.GetAllCitiesWithCountry();
            return cities.Select(c => new CityDtos
            {
                Name = c.Name,
                Country = new CountryDtos
                {
                    Name = c.Country.Name
                }
            }).ToList();
        }

        public async Task<CityDtos> GetCityById(int id)
        {
            City city = await _unitOfWork.CityRepository.GetCityByIdWithCountry(id);
            if (city == null)
            {
                return null;
            }

            return new CityDtos
            {
                Name = city.Name,
                Country = new CountryDtos
                {
                    Name = city.Country.Name
                }
            };
        }

        public async Task<bool> UpdateCity(EditCityDtos cityDto)
        {
            City city = await _unitOfWork.CityRepository.GetByIdAsync(cityDto.Id);
            if (city == null)
            {
                return false;
            }

            city.Name = cityDto.Name;
            city.CountryId = cityDto.CountryId;
            _unitOfWork.CityRepository.Update(city);
            _unitOfWork.SaveChanges();

            return true;
        }
    }
}
