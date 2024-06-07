using AirBnb.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.PropertyDtos;

public class AddPropertyDto
{
    public string Name { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;

  
    public int NumberOfBedrooms { get; set; }
    public int NumberOfBathrooms { get; set; }
    public int Beds { get; set; }
    public string DisplayedImage { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public int CityId { get; set; }
    public int CheckIn { get; set; }
    public int CheckOut { get; set; }
    public int NumberOfGuest { get; set; }
    public bool Pets { get; set; }
    public bool TakePhotos { get; set; }
    public Status Status { get; set; }
    public List<TimeIntervalDto> AppointmentsAvailable { get; set; }
}

