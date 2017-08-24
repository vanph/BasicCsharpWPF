using System.Collections.Generic;
using MyCountry.Model;

namespace MyCountry.Repository
{
    public interface ICityRepository
    {
        IList<City> GetCities();
    }
}