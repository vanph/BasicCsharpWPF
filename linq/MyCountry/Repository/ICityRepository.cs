using System.Collections.Generic;
using MyCountry.Model;

namespace MyCountry.Repository
{
    public interface ICityRepository
    {
        IEnumerable<City> GetAll();

        City GetByCode(string code);
    }
}