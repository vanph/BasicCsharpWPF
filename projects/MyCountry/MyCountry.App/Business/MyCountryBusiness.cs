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
            var query = dbContect.Districts.Select(x => new DistrictViewModel
            {
                DistrictCode = x.DistrictCode,
                DistrictName = x.Name,
                CityCode = x.CityCode,
                CityName = x.City.Name//Join
            });


            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.DistrictCode.Contains(search) || x.DistrictName.Contains(search));
            }
            if (!string.IsNullOrEmpty(cityCode))
            {
                query = query.Where(x => x.CityCode.Contains(cityCode));
            }

            //if (!string.IsNullOrEmpty(search))
            //{
            //    if (!String.IsNullOrEmpty(cityCode))
            //    {
            //        query = query.Where(x => (x.DistrictCode.Contains(search) || x.Name.Contains(search)) && x.CityCode.Contains(cityCode));//
            //    }
            //    else
            //    {
            //        query = query.Where(x => x.DistrictCode.Contains(search) || x.Name.Contains(search));
            //    }
            //}
            //else
            //{
            //    if (!String.IsNullOrEmpty(cityCode))
            //    {
            //        query = query.Where(x => x.CityCode.Contains(cityCode));
            //    }
            //}

            var result = query.OrderBy(x => x.DistrictCode).ToList();

            return result;

        }

        public List<CityInfomation> GetCityInfomations()
        {
            var dbContect = new MyCountryEntities();
            //var cityInfomations = dbContect.Districts.GroupBy(d => new { d.CityCode, d.City.Name }).Select(
            //    c => new CityInfomation()
            //    {
            //        CityCode = c.Key.CityCode,
            //        CityName = c.Key.Name,
            //        DistrictNames = c.Select(x => x.Name).ToList()

            //    }).ToList();


            var cityInfomations = dbContect.Cities.Select(x => new CityInfomation()
            {
                CityName = x.Name,
                DistrictNames = x.Districts.Select(d => d.Name).ToList(),

            }).ToList();

            return cityInfomations;
        }
    }
}