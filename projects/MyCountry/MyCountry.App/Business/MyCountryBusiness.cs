using System;
using System.Collections.Generic;
using System.Linq;
using MyCountry.App.ViewModel;
using MyCountry.DataAccess.Model;
using MyCountry.DataAccess.Persistence;

namespace MyCountry.App.Business
{
    public class MyCountryBusiness: IMyCountryBusiness
    {

        public List<City> GetCities()
        {
            var dbContect = new MyCountryEntities();
            var cities = dbContect.Cities.ToList();
            
            return cities;
        }

        public  List<DistrictViewModel> SearchDistricts(string search, string cityCode ="" )
        {
            var dbContect = new MyCountryEntities();
            var query = dbContect.Districts as IQueryable<District>;
            
            if (!String.IsNullOrEmpty(search))
            {
                if (!String.IsNullOrEmpty(cityCode))
                {
                    query = query.Where(x => (x.DistrictCode.Contains(search) || x.Name.Contains(search)) && x.CityCode.Contains(cityCode));//
                }
                else
                {
                    query = query.Where(x => x.DistrictCode.Contains(search) || x.Name.Contains(search));
                }               
            }
            else
            {
                if (!String.IsNullOrEmpty(cityCode))
                {
                    query = query.Where(x => x.CityCode.Contains(cityCode));
                }                
            }

            var result = query.Select(x => new DistrictViewModel
            {
                DistrictCode = x.DistrictCode,
                DistrictName = x.Name,
                CityCode = x.CityCode,
                CityName = x.City.Name//Join
            }).OrderBy(x => x.DistrictCode).ToList();

            return result;
        }
    }
}