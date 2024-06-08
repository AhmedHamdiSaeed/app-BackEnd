using AirBnb.BL.Dtos.PropertyDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Properties;

public class PropertyManager : IPropertyManager
{
    private readonly IUnitOfWork _unitOfWork;
    public PropertyManager(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

    }
    public async Task<bool> AddProperty(AddPropertyDto addProperty, string userId)
    {
        Property newProp = new Property()
        {
            Name = addProperty.Name,
            Description = addProperty.Description,
            Adress = addProperty.Adress,
            NumberOfBathrooms = addProperty.NumberOfBathrooms,
            NumberOfBedrooms = addProperty.NumberOfBedrooms,
            DisplayedImage = addProperty.DisplayedImage,
            Beds = addProperty.Beds,
            UserId = userId,
            CategoryId = addProperty.CategoryId,
            CityId = addProperty.CityId,
            Status = Status.Pending,
            CheckIn = new TimeOnly(addProperty.CheckIn),
            CheckOut = new TimeOnly(addProperty.CheckOut),
            NumberOfGuest = addProperty.NumberOfGuest,
            Pets = addProperty.Pets,
            TakePhotos = addProperty.TakePhotos,
          
            AppointmentsAvailable = addProperty.AppointmentsAvailable.Select(a => new AppointmentsAvailable
            {
                From = a.StartTime,
                To = a.EndTime,
                PricePerNight = a.PricePerNight,
                IsAvailable = true
            }).ToList()

        };
        await _unitOfWork.PropertyRepository.AddAsync(newProp);
        return await _unitOfWork.SaveChangesAsync() > 0;

    }

    public async Task<IEnumerable<DisplayAllPropertyDto>> GetAllProperty()
    {
        var properties = await _unitOfWork.PropertyRepository.GetAllPropertyAsync();
        if (properties == null) { return null; }

        var res = properties.Select(p => new DisplayAllPropertyDto
        {
            Id = p.Id,
            Name = p.Name,
            City = p.City.Name,
            CategoryName=p.Category.Name
        });
        return res;
    }

    public async Task<IEnumerable<PropertyGetDto>> GetAllPropertyForAllUsers(int? cityId = null, int? cateId = null)
    {
        IEnumerable<Property> AllProperty = await _unitOfWork.PropertyRepository.GetAllPropertyForAllUsers(cityId, cateId);
        if (AllProperty is null) { return null; }
            

        var result = AllProperty.Select(pro => new PropertyGetDto
        {
            Id = pro.Id,
            Name = pro.Name,
            DisplayedImage = pro.DisplayedImage,

        });
        return result;
    }

    public async Task<IEnumerable<PropertyGetDto>> GetHosterProperties(string hosterId)
    {
        IEnumerable<Property> allProp = await _unitOfWork.PropertyRepository.GetHosterProperties(hosterId);

        if (allProp is null) return null;

        var result = allProp.Select(pro => new PropertyGetDto
        {
            Id = pro.Id,
            Name = pro.Name,
            DisplayedImage = pro.DisplayedImage,

        });
        return result;
    }

    public async Task<GetPropertyDetailsDto> GetPropertyDetailsById(int propertyId)
    {
        Property singleProp = await _unitOfWork.PropertyRepository.GetByIdAsync(propertyId);
        GetPropertyDetailsDto result = new GetPropertyDetailsDto
        {
            Name = singleProp.Name,
            Description = singleProp.Description,
            Adress = singleProp.Adress,
            NumberOfBathrooms = singleProp.NumberOfBathrooms,
            NumberOfBedrooms = singleProp.NumberOfBedrooms,
            DisplayedImage = singleProp.DisplayedImage,
            Beds = singleProp.Beds,
            UserName = singleProp.User != null ? singleProp.User.FirstName : "N/A", // Null-check for User
            CategoryName = singleProp.Category != null ? singleProp.Category.Name : "N/A", // Null-check for Category
            CityName = singleProp.City != null ? singleProp.City.Name : "N/A", // Null-check for City
            CheckIn = singleProp.CheckIn,
            CheckOut = singleProp.CheckOut,
            NumberOfGuest = singleProp.NumberOfGuest,
            Pets = singleProp.Pets,
            TakePhotos = singleProp.TakePhotos,
            ImageUrl = singleProp.PropertyImages.Select(img => img.ImageUrl).ToList(), 
            Amentities = singleProp.Amenity.Select(am => new AmintsDTO
            {
                Name = am.Name,
                Description = am.Description
            }).ToList(), 
            AppoinmentAvaiable = singleProp.AppointmentsAvailable.Select(app => new PropAppoinmentAvailable
            {
                From = app.From,
                To = app.To,
                PricePerNight = app.PricePerNight,
                IsAvailable = app.IsAvailable,
            }).ToList(), 
            Reviews = singleProp.Reviews.Select(x => new Reviewdto
            {
                Rating = x.Rating,
                Comment = x.Comment,
                UserName = x.User != null ? x.User.FirstName + ' ' + x.User.LastName : "Anonymous", 
                Userimage = x.User != null ? x.User.Image : "No Image" 
            }).ToList() 
        };

        return result;
    }

    public async Task<bool> RemoveProperty(int propertyId)
    {
        var res = await _unitOfWork.PropertyRepository.GetPropertyToDeleteById(propertyId);
        var bookings = res.PropertyBokking.ToList();

        bool hasActiveOrFutureBookings = bookings.Any(booking =>
            (booking.CheckInDate <= DateTime.Now && booking.CheckOutDate >= DateTime.Now) || // Ongoing booking
            booking.CheckInDate > DateTime.Now);

        if (hasActiveOrFutureBookings)
        {
            // If there are future bookings, set property to unavailable for future bookings only
            foreach (var appointment in res.AppointmentsAvailable)
            {
                appointment.IsAvailable = false;
            }


            return await _unitOfWork.SaveChangesAsync() > 0;


        }
        else
        {
            // If no future bookings, proceed with setting appointments to unavailable and deleting property
            foreach (var appointment in res.AppointmentsAvailable)
            {
                appointment.IsAvailable = false;
            }

            _unitOfWork.PropertyRepository.DeleteProperty(res);
            return await _unitOfWork.SaveChangesAsync() > 0;

        }
    }

    public async Task<bool> UpdatePrpery(PropertyUpdateDto propertyUpdateDto)
    {
        var property = await _unitOfWork.PropertyRepository.GetPropertyToDeleteById(propertyUpdateDto.Id);
         if (property == null) { return false; }
        // Update property details
        property.Name = propertyUpdateDto.Name;
        property.Adress = propertyUpdateDto.Adress;
        property.NumberOfBathrooms = propertyUpdateDto.NumberOfBathrooms;
        property.Beds = propertyUpdateDto.Beds;
        property.NumberOfBedrooms = propertyUpdateDto.NumberOfBedrooms;
        property.Description = propertyUpdateDto.Description;
        property.CityId = propertyUpdateDto.CityId;
        property.CategoryId = propertyUpdateDto.CategoryId;
        property.DisplayedImage = propertyUpdateDto.DisplayedImage;
        property.CheckIn = new TimeOnly(propertyUpdateDto.CheckIn);
        property.CheckOut = new TimeOnly(propertyUpdateDto.CheckOut);
        property.NumberOfGuest = propertyUpdateDto.NumberOfGuest;
        property.Pets = propertyUpdateDto.Pets;
        property.Status = propertyUpdateDto.Status;
        property.TakePhotos = propertyUpdateDto.TakePhotos;
        // Update appointments
        property.AppointmentsAvailable = propertyUpdateDto.AppointmentsAvailable.Select(a => new AppointmentsAvailable
        {
            From = a.StartTime,
            To = a.EndTime,
            PricePerNight = a.PricePerNight,
            IsAvailable = true // Assuming all updated appointments are available
        }).ToList();

        // Save changes to the repository
        _unitOfWork.PropertyRepository.Update(property);
        return await _unitOfWork.SaveChangesAsync() > 0;

    }
}
