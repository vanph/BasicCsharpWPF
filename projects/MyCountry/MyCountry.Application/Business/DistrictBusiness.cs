using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCountry.Application.Exceptions;
using MyCountry.Application.Security;
using MyCountry.Application.Utility;
using MyCountry.Application.ViewModel;
using MyCountry.DataAccess.Model;
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

        public void Add(District districtParameter)
        {
            using (var dbContext = new MyCountryEntities())
            {
                var currentDateTime = DateTimeUtil.GetCurrentDateTime();

                var existingDistrict = InnerGetDistrictByCode(dbContext, districtParameter.DistrictCode);
                if (existingDistrict != null)
                {
                    throw new DistrictValiationException($@"District code {existingDistrict.DistrictCode} exists.");
                }

                var district = new District
                {
                    Name = districtParameter.Name,
                    DistrictCode = districtParameter.DistrictCode,
                    Type = districtParameter.Type,
                    CityCode = districtParameter.CityCode,
                    CreatedDate = currentDateTime,
                    CreatedBy = ServiceContext.UserName,
                    ModifiedDate = currentDateTime,
                    ModifiedBy = ServiceContext.UserName
                };

                dbContext.Districts.Add(district);
                dbContext.SaveChanges();
            }
                
        }

        private static District InnerGetDistrictByCode(MyCountryEntities dbContext, string distrisctCode)
        {
            return dbContext.Districts.FirstOrDefault(x => x.DistrictCode == distrisctCode);
        }

        public void Update(District districtParameter)
        {
            using (var dbContext = new MyCountryEntities())
            {
                var currentDateTime = DateTimeUtil.GetCurrentDateTime();

                var existingDistrict = InnerGetDistrictByCode(dbContext, districtParameter.DistrictCode); 
                if (existingDistrict == null)
                {
                    throw new DistrictValiationException(@"Cannot found district");
                }

                existingDistrict.Name = districtParameter.Name;
                existingDistrict.Type = districtParameter.Type;
                existingDistrict.ModifiedDate = currentDateTime;
                existingDistrict.ModifiedBy = ServiceContext.UserName;

                dbContext.SaveChanges();
            }

        }
    }
}
