using AirBnb.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.PropertyDtos;

public class GetPropertyDetailsDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;
    public int NumberOfBedrooms { get; set; }
    public int NumberOfBathrooms { get; set; }
    public string DisplayedImage { get; set; }
    public int Beds { get; set; }
    public string UserName { get; set; }
    public string CategoryName { get; set; }
    public string CityName { get; set; }
    public TimeOnly CheckIn { get; set; }
    public TimeOnly CheckOut { get; set; }
    public int NumberOfGuest { get; set; }
    public bool Pets { get; set; }
    public bool TakePhotos { get; set; }
    public List<string> ImageUrl { get; set; }
    public IEnumerable<AmintsDTO> Amentities { get; set; } = new HashSet<AmintsDTO>();
    public IEnumerable<PropAppoinmentAvailable> AppoinmentAvaiable { get; set; } = new HashSet<PropAppoinmentAvailable>();
    public IEnumerable<PropertyBookingDates> BookingDates { get; set; } = new HashSet<PropertyBookingDates>();
    public IEnumerable<Reviewdto> Reviews { get; set; } = new HashSet<Reviewdto>();
   

}
public class PropAppoinmentAvailable
{
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public decimal PricePerNight { get; set; }
    public bool IsAvailable { get; set; }
}
public class PropertyBookingDates
{
    public DateTime CheckInDate { get; set; } = DateTime.Now;
    public DateTime CheckOutDate { get; set; } = DateTime.Now;

}



public class AmintsDTO
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

}
public class Reviewdto
{
    public string Comment { get; set; } = string.Empty;
    public int Rating { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Userimage { get; set; } = string.Empty;
   
}
