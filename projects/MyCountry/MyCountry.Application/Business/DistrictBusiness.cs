using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCountry.Application.ViewModel;
using MyCountry.DataAccess.Persistence;

namespace MyCountry.Application.Business
{
    public class DistrictBusiness: IDistrictBusiness
    {
        public List<DistrictViewModel> SearchDistricts(string search, string cityCode = "")
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
    }
}
