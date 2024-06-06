using AirBnb.DAL.Data.context;
using AirBnb.DAL.Repos.AmentityRepo;
using AirBnb.DAL.Repos.AppointmentAvailableRepo;
using AirBnb.DAL.Repos.BookingRepo;
using AirBnb.DAL.Repos.CategoryRepo;
using AirBnb.DAL.Repos.CityRepo;
using AirBnb.DAL.Repos.CountryRepo;
using AirBnb.DAL.Repos.PropertyRepo;
using AirBnb.DAL.Repos.ReviewRepo;
using AirBnb.DAL.Repos.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Unit
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AppDbContext _context;
		public IAmentityRepository AmentityRepository { get; }

		public IReviewRepository ReviewRepository { get; }

		public IBookingRepository BookingRepository { get; }
		public ICategoryRepository CategoryRepository { get; }
		public IApptAvailableRepository ApptAvailableRepository { get; }

		public IPropertyRepository PropertyRepository { get; }

		public ICityRepository CityRepository { get; }
		public ICountryRepository CountryRepository { get; }
		public IUserRepository UserRepository { get; }

		public UnitOfWork(AppDbContext context,
						IUserRepository userRepository,
						ICityRepository cityRrpository,
						IPropertyRepository propertyRepository,
						IBookingRepository bookingRepository, 
						IReviewRepository reviewRepository,
						IApptAvailableRepository apptAvailableRepository, 
						IAmentityRepository amentityRepository, 
						ICategoryRepository categoryRepository,
						ICountryRepository countryRepository)
        {
            _context = context;
			BookingRepository = bookingRepository;
			ReviewRepository = reviewRepository;
			AmentityRepository = amentityRepository;
			ApptAvailableRepository = apptAvailableRepository;
			PropertyRepository = propertyRepository;
			UserRepository = userRepository;
			CategoryRepository = categoryRepository;
			CityRepository = cityRrpository; 
            CountryRepository = countryRepository;
		}
        public int SaveChanges()
		{
			return _context.SaveChanges();
		}
	}
}
