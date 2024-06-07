using AirBnb.BL.Dtos.PropertyDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Properties;

public interface IPropertyManager
{
    Task<IEnumerable<DisplayAllPropertyDto>> GetAllProperty();
    Task<IEnumerable<PropertyGetDto>> GetAllPropertyForAllUsers(int? cityId = null, int? cateId = null);

    Task<GetPropertyDetailsDto> GetPropertyDetailsById(int propertyId);
    Task<IEnumerable<PropertyGetDto>> GetHosterProperties(string hosterId);

   
    Task<bool> AddProperty(AddPropertyDto addProperty, string userId);
    Task<bool> RemoveProperty(int propertyId);

    Task<bool> UpdatePrpery(PropertyUpdateDto propertyUpdateDto);
}

