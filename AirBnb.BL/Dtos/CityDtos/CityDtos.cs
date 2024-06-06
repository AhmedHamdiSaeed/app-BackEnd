using AirBnb.BL.Dtos.CountryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.CityDtos
{
    public class CityDtos // Get
    {
        public string Name { get; set; }
        public CountryDtos.CountryDtos Country { get; set; }
    }

    public class EditCityDtos  // Update, Delete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }  
    }
    public class AddCityDto //add
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
    }

}
