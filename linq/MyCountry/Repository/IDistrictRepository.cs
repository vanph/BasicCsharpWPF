using System.Collections.Generic;
using MyCountry.Model;

namespace MyCountry.Repository
{
    public interface IDistrictRepository
    {
        IEnumerable<District> GetAll();

        District GetByCode(string code);
    }
}