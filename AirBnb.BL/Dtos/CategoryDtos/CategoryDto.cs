using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.CategoryDtos
{
	public record CategoryAddDto(string Name,IFormFile IconURL,string Desc);

    public record CategoryDto(string Name,string? IconURL, string Desc);
     
    public class EditCategoryDto //update delete 
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string IconUrl { get; set;}
	}
}
