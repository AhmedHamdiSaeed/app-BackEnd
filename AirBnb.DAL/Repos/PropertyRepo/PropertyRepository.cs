using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AirBnb.DAL.Repos.PropertyRepo;

public class PropertyRepository : GenericRepository<Property>, IPropertyRepository
{
    private readonly AppDbContext _context;
    public PropertyRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public void DeleteProperty(Property entity)
    {
        _context.Set<Booking>().RemoveRange(entity.PropertyBokking);
        _context.Set<AppointmentsAvailable>().RemoveRange(entity.AppointmentsAvailable);
        _context.Set<Property>().Remove(entity);
        _context.SaveChanges();
    }

    public async Task<IEnumerable<Property>> GetAllPropertyAsync()
    {
        return await _context.Set<Property>()
            .Include(p => p.City).Include(p => p.Category)
            .AsNoTracking().ToListAsync();
    }

    public async Task<IEnumerable<Property>> GetAllPropertyForAllUsers(int? cityId = null, int? cateId = null)
    {

        var query = _context.Set<Property>().Where(x => x.Status == Status.Confirmed).AsNoTracking().AsQueryable();


        if (cityId.HasValue)
        {
            query = query.Where(p => p.CityId == cityId.Value);
        }
        if (cateId.HasValue)
        {
            query = query.Where(p => p.CategoryId == cateId.Value);
        }


        return await query.ToListAsync();
    }

    public async Task<IEnumerable<Property>> GetHosterProperties(string hosterId)
    {
        return await _context.Set<Property>().AsNoTracking().Where(x => x.UserId == hosterId).ToListAsync();
    }

    public async Task<Property> GetProperty(int id)
    {
        return await _context.Set<Property>()
            .Include(p => p.User)
            .Include(p => p.City).ThenInclude(c => c.Country)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Property> GetPropertyToDeleteById(int id)
    {
        return await _context.Set<Property>()
            .Include(p => p.PropertyBokking).Include(p => p.AppointmentsAvailable)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}
