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
	public interface  IUnitOfWork
	{
		IAmentityRepository AmentityRepository { get; }
		IReviewRepository ReviewRepository { get; }
		IBookingRepository BookingRepository { get; }
		IUserRepository UserRepository { get; }
		IApptAvailableRepository ApptAvailableRepository { get; }
		IPropertyRepository PropertyRepository { get; }
		ICategoryRepository CategoryRepository { get; }
		ICityRepository CityRepository { get; }
		ICountryRepository CountryRepository { get; }
		int SaveChanges();
	}
}
