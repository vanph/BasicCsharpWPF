using System.Collections.Generic;
using MyCountry.Model;

namespace MyCountry.Repository
{
    public interface IDistrictRepository
    {
        List<District> GetDistricts();
    }
}