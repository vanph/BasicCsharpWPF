using System.Collections.Generic;
using MyCountry.Model;

namespace MyCountry.Repository
{
    public interface ICityRepository : IGenericRepository<City>
    {
        City GetCityByCode(string code);
    }
}