using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.CityRepo
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        private readonly AppDbContext _context;

        public CityRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<City>> GetAllCitiesWithCountry()
        {
            return await _context.Set<City>()
                                 .Include(c => c.Country)
                                 .ToListAsync();
        }
        public async Task<City> GetCityByIdWithCountry(int cityId)
        {
            return await _context.Set<City>()
                                 .Include(c => c.Country)
                                 .FirstOrDefaultAsync(x => x.Id == cityId);
        }


    }
}
