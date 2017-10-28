using System.Collections.Generic;
using System.Windows.Forms;
using MyCountry.Application.ViewModel;
using MyCountry.DataAccess.Model;

namespace MyCountry.Application.Business
{
    public interface ICityBusiness
    {
        List<City> GetCities();
        List<CityInfomation> GetCityInfomations();
    }
}
