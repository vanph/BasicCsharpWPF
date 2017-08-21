using System.Collections.Generic;
using MyCountry.Model;

namespace MyCountry.Repository
{
    public interface ICityRepository
    {
        List<City> GetCities();
    }
}