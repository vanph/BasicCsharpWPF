using System.Collections.Generic;
using MyCountry.Application.ViewModel;
using MyCountry.DataAccess.Model;

namespace MyCountry.Application.Business
{
    public interface IMyCountryBusiness
    {
        List<City> GetCities();
        List<DistrictViewModel> SearchDistricts(string search, string cityCode = "");
        List<CityInfomation> GetCityInfomations();
    }
}
