using AirBnb.BL.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Categories
{
	public interface ICategoryManager
	{
        Task<IEnumerable<CategoryDto>> GetAllCategories();
        Task<CategoryDto> GetCategoryById(int id);
        Task<CategoryDto> AddCategory(CategoryDto categoryDto); //return void 
		//Task<bool> UpdateCategory(EditCategoryDto categoryDto);
		Task<bool> DeleteCategory(int id);
	}
}
