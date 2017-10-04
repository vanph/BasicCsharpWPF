using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCountry.App.ViewModel;
using MyCountry.DataAccess.Model;

namespace MyCountry.App.Business
{
    public interface IMyCountryBusiness
    {
        List<City> GetCities();
        List<DistrictViewModel> SearchDistricts(string search, string cityCode = "");
        List<CityInfomation> GetCityInfomations();
    }
}
