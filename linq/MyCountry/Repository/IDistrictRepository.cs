using System.Collections.Generic;
using MyCountry.Model;

namespace MyCountry.Repository
{
    public interface IDistrictRepository:IGenericRepository<District>
    {
        District GetDistrictByCode(string code);
    }
}