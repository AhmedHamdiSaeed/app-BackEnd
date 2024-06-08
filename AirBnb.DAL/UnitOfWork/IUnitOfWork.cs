using AirBnb.DAL.Repos.AmentityRepo;
using AirBnb.DAL.Repos.AppointmentAvailableRepo;
using AirBnb.DAL.Repos.BookingRepo;
using AirBnb.DAL.Repos.CategoryRepo;
using AirBnb.DAL.Repos.ReviewRepo;
using AirBnb.DAL.Repos.PropertyRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirBnb.DAL.Repos.UserRepo;
using AirBnb.DAL.Repos.cityRepo;

namespace AirBnb.DAL.Unit
{
	public interface  IUnitOfWork
	{
		IAmentityRepository AmentityRepository { get; }
		IReviewRepository ReviewRepository { get; }
		IBookingRepository BookingRepository { get; }
		ICategoryRepository CategoryRepository { get; }
		IPropertyRepository PropertyRepository { get; }
        ICityPrpository CityPrpository { get; }
        IUserRepository UserRepository { get; }
		IApptAvailableRepository ApptAvailableRepository { get; }

        Task<int> SaveChangesAsync();
        int SaveChanges();
	}
}
