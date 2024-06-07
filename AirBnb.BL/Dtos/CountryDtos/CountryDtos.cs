using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.CountryDtos
{
    public class CountryDtos //add 
    {
        public string Name { get; set; }
    }
    public class EditCountryDtos  //update delete get
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
