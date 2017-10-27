using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MyCountry.Application.Business;
using MyCountry.Application.ViewModel;
using MyCountry.DataAccess.Model;
using MyCountry.DataAccess.Persistence;

namespace MyCountry.Application.Business
{
    public class CityBusiness: ICityBusiness
    {
        public List<City> GetCities()
        {
            var dbContect = new MyCountryEntities();
            var cities = dbContect.Cities.ToList();

            return cities;
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

        public void Add(ComboBox cmbCity, TextBox txtDistrictName, TextBox txtDistictCode, TextBox txtDistrictType)
        {
            var dbContext = new MyCountryEntities();
            var city = cmbCity.SelectedItem as City;

            var district = new District
            {
                Name = txtDistrictName.Text,
                DistrictCode = txtDistictCode.Text,
                Type = txtDistrictType.Text,
                CityCode = city != null ? city.CityCode : string.Empty,
                CreatedDate = DateTime.Now,
                CreatedBy = "Anonymous",
                ModifiedDate = DateTime.Now,
                ModifiedBy = "Anonymous"
            };
            dbContext.Districts.Add(district);
            dbContext.SaveChanges();
        }
    }
}
