using AirBnb.BL.Dtos.CityDtos;
using AirBnb.BL.Managers.Cities;
using Microsoft.AspNetCore.Mvc;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace AirBnb.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        private readonly ICityManager _cityManager;
        private readonly UserManager<AppUser> _userManager;

        public CitiesController(ICityManager cityManager, UserManager<AppUser> userManager)
        {
            _cityManager = cityManager;
            _userManager = userManager;
        }



        [HttpGet("GetAllCities")]
        public async Task<IActionResult> GetAllCities()
        {
            var cities = await _cityManager.GetAllCities();
            if (cities == null)
            {
                return NotFound(new { message = "Cities not found." });
            }
            return Ok(cities);
        }

        [HttpGet("GetCityDetails/{id}")]
        public async Task<IActionResult> GetCityById(int id)
        {
            var city = await _cityManager.GetCityById(id);
            if (city == null)
            {
                return NotFound(new { message = $"City with ID {id} not found." });
            }
            return Ok(city);
        }

        [HttpPost("AddCity")]
        public async Task<IActionResult> AddCity(AddCityDto cityDto)
        {
            await _cityManager.AddCity(cityDto);
            return Ok("City added successfully!");
        }

        [HttpPut("UpdateCity/{id}")]
        public async Task<IActionResult> UpdateCity(int id, EditCityDtos cityDto)
        {
            if (id != cityDto.Id)
            {
                return BadRequest("City ID mismatch");
            }

            if (ModelState.IsValid)
            {
                var result = await _cityManager.UpdateCity(cityDto);
                if (! result)
                {
                    return NotFound("Update failed, city not found");
                }

                return Ok("City updated successfully!");
            }

            return BadRequest("Invalid data");
        }

        [HttpDelete("DeleteCity/{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var result = await _cityManager.DeleteCity(id);
            if (!result)
            {
                return BadRequest("Deletion failed");
            }

            return Ok("City deleted successfully!");
        }
    }
}
