using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.PropertyDtos;
using AirBnb.BL.Managers.Properties;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers.Property;

[Route("api/[controller]")]
[ApiController]
public class PropertyController : ControllerBase
{
    private readonly IPropertyManager _propertyManager;
    private readonly UserManager<AppUser> _userManager;

    public PropertyController(IPropertyManager propertyManager, UserManager<AppUser> userManager)
    {
        _propertyManager = propertyManager;
        _userManager = userManager;
    }

    #region GetAllPropertyForAllUsersWithCityIDandCateoryID
    [HttpGet("GetAllPropertyForAllUsersWithCityIDandCateoryID")]
    public async Task<IActionResult> GetAllPropertyForAllUsers(int? cityId = null, int? cateId = null)
    {
        var result = await _propertyManager.GetAllPropertyForAllUsers(cityId, cateId);
        if (result == null) return NotFound("Data Is Empty");
        return Ok(result);
    }
    #endregion

    #region GetPropertyDetailsById
    [HttpGet("GetPropertyDetailsById/{propertyId}")]
    public async Task<IActionResult> GetPropertyDetailsById(int propertyId)
    {
        var result = await _propertyManager.GetPropertyDetailsById(propertyId);
        if (result == null) return NotFound($"Property With Id {propertyId} Not Exist");
        return Ok(result);
    }
    #endregion

    #region GetHosterProperties
    [HttpGet("GetHosterProperties")]
    [Authorize(Policy = "ForHost")]
    [AuthorizeCurrentUser]
    public async Task<IActionResult> GetHosterProperties()
    {
        AppUser CurrentUser = await _userManager.GetUserAsync(User);
        var result = await _propertyManager.GetHosterProperties(CurrentUser.Id);
        if (result is null)
        {
            return NotFound("You Dont Have Any Property Yet");
        }
        return Ok(result);
    }

    #endregion

    #region GetAllPropertyWithNoFilter
    [HttpGet("GetAllProperty")]
    public async Task<ActionResult<IEnumerable<DisplayAllPropertyDto>>> getAll()
    {
        var properties = await _propertyManager.GetAllProperty();
        if (properties == null) { return NotFound(); }
        return Ok(properties);
    }
    #endregion

    #region AddNewProperty
    [HttpPost("AddNewProperty")]
    [Authorize(Policy = "ForHost")]
    [AuthorizeCurrentUser]
    public async Task<ActionResult> AddProperty(AddPropertyDto addProperty)
    {
        // Check if _propertyManager is null
        if (_propertyManager == null)
        {
            return BadRequest("Internal server error: Property manager not available.");
        }

        AppUser CurrentUser = await _userManager.GetUserAsync(User);

        if (ModelState.IsValid)
        {
            var result = await _propertyManager.AddProperty(addProperty, CurrentUser.Id);
            if (result is false)
            {
                return BadRequest("Add Field");
            }

            return Ok("Added sucssefully");
        }
        return BadRequest("Data Not Valid");

    }
    #endregion

    #region DeletePropertyById
    [HttpDelete("DeletePropertyById/{id}")]
    [Authorize(Policy = "ForHost")]
    [AuthorizeCurrentUser]
    
    public async Task<IActionResult> DeleteProperty(int id)
    {
        var propertyDeleted = await _propertyManager.RemoveProperty(id);
        if (propertyDeleted)
        {
            return Ok("Property updated to disable future bookings.");
        }
        else
        {
            return BadRequest("Failed to update the property status.");
        }

    }
    #endregion

    #region UpdateProperty
    [HttpPut("UpdateProperty")]
    [Authorize(Policy = "ForHost")]
    [AuthorizeCurrentUser]
    public async Task<ActionResult> UpdateProperty( PropertyUpdateDto propertyUpdateDto)
    {
        var isFound= await _propertyManager.UpdatePrpery(propertyUpdateDto);
        if (!isFound) { NotFound(); }
        return Ok("Property Updated Sucssfully.");

    }
    #endregion
}

