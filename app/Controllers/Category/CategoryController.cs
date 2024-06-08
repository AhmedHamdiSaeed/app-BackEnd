using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.CategoryDtos;
using AirBnb.BL.Managers.Categories;
using AirBnb.DAL.Data.Model;
using app.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace AirBnb.API.Controllers.Category
{
	[ApiController]
	[Route("api/[controller]")]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryManager _categoryManager;
		private readonly UserManager<AppUser> _userManager;

		public CategoryController(ICategoryManager categoryManager, UserManager<AppUser> userManager)
		{
			_categoryManager = categoryManager;
			_userManager = userManager;
		}

		[HttpGet("GetAllCategories")]
		public async Task<IActionResult> GetAllCategories()
		{
			var categories = await _categoryManager.GetAllCategories();
			if (categories is null)
			{
				return NotFound(new ApiResponse(200, $"Categories Is Not Found.", string.Empty));
			}
			return Ok(new ApiResponse(200, "success", categories));
        }


		[HttpGet("{id}")]
		public async Task<IActionResult> GetCategoryById(int id)
		{
			var category = await _categoryManager.GetCategoryById(id);
			if (category == null)
			{
				return NotFound(new ApiResponse(404,$"Category with ID {id} not found.",string.Empty));
			}
            return Ok(new ApiResponse(200, "success", category));
        }

		[HttpPost("AddCategory")]
        [Authorize(Policy = "ForAdmin")]
        public async Task<IActionResult> AddCategory([FromForm]CategoryAddDto category)
		{
			Console.WriteLine($"categoryDto API: {category}");
            string[] allowExtenstion = [".jpg", ".jpeg", ".png"];

            if (!allowExtenstion.Contains(Path.GetExtension(category.IconURL.FileName), StringComparer.InvariantCultureIgnoreCase))
            { return BadRequest(new ApiResponse (400,"not support this extension", string.Empty)); }
            if (category.IconURL.Length > 2_000_000)
            {
                return BadRequest(new ApiResponse(400, "must less or equal 2MB", string.Empty));
            }

            var newFileName = $"{Guid.NewGuid()}{Path.GetExtension(category.IconURL.FileName)}";
            var fullFilePath = Path.Combine(Environment.CurrentDirectory, "Images", $"{newFileName}");
            using var stream = new FileStream(fullFilePath, FileMode.Create);
            category.IconURL.CopyTo(stream);


		    var newCategory=await _categoryManager.AddCategory(new CategoryDto(category.Name,$"{Request.Scheme}://{Request.Host}/Images/{newFileName}",category.Desc));
            return Ok(new ApiResponse (201,"created",newCategory));
           
		}


		//[HttpPut("{id}")]
  //      [Authorize(Policy = "ForAdmin")]

  //      public async Task<IActionResult> UpdateCategory([FromForm]CategoryAddDto categoryDto)
		//{
			
		//	if (ModelState.IsValid)
		//	{
		//		var result = await _categoryManager.UpdateCategory(categoryDto);
		//		if (!result)
		//		{
		//			return NotFound("Update failed, category not found");
		//		}

		//		return Ok("Category Updated Successfully!");
		//	}

		//	return BadRequest("Invalid data");
		//}


		[HttpDelete("DeleteCategory/{id}")] //admin
		[Authorize(Policy ="ForAdmin")]
		
		public async Task<IActionResult> DeleteCategory(int id)
		{
			var result = await _categoryManager.DeleteCategory(id);
			if (!result)
			{
				return BadRequest("Deleted Fail");
			}

			return Ok("Category Deleted Successfully !");
		}
	}
}
