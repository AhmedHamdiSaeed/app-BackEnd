using AirBnb.BL.Dtos.CountryDtos;
using AirBnb.BL.Managers.Countries;
using Microsoft.AspNetCore.Mvc;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace AirBnb.API.Controllers.Countries
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryManager _countryManager;
        private readonly UserManager<AppUser> _userManager;

        public CountriesController(ICountryManager countryManager, UserManager<AppUser> userManager)
        {
            _countryManager = countryManager;
            _userManager = userManager;
        }



        [HttpGet("GetAllCountries")]
        public async Task<IActionResult> GetAllCountries()
        {
            var countries = await _countryManager.GetAllCountries();
            if (countries == null)
            {
                return NotFound(new { message = "Countries not found." });
            }
            return Ok(countries);
        }

        [HttpGet("GetCountryDetails/{id}")]
        public async Task<IActionResult> GetCountryById(int id)
        {
            var country = await _countryManager.GetCountryById(id);
            if (country == null)
            {
                return NotFound(new { message = $"Country with ID {id} not found." });
            }
            return Ok(country);
        }

        [HttpPost("AddCountry")] //admin
        public async Task<IActionResult> AddCountry(CountryDtos countryDto)
        {
            await _countryManager.AddCountry(countryDto);
            return Ok("Country added successfully!");
        }

        [HttpPut("UpdateCountry/{id}")] //admin
        public async Task<IActionResult> UpdateCountry(int id, EditCountryDtos countryDto)
        {
            if (id != countryDto.Id)
            {
                return BadRequest("Country ID mismatch");
            }

            if (ModelState.IsValid)
            {
                var result = await _countryManager.UpdateCountry(countryDto);
                if (!result)
                {
                    return NotFound("Update failed, country not found");
                }

                return Ok("Country updated successfully!");
            }

            return BadRequest("Invalid data");
        }

        [HttpDelete("DeleteCountry/{id}")] //admin
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var result = await _countryManager.DeleteCountry(id);
            if (!result)
            {
                return BadRequest("Delete failed");
            }

            return Ok("Country deleted successfully!");
        }
    }
}
