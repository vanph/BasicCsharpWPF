using System.Collections.Generic;
using System.Windows.Forms;
using MyCountry.Application.ViewModel;
using MyCountry.DataAccess.Model;

namespace MyCountry.Application.Business
{
    public interface IDistrictBusiness
    {
        List<DistrictViewModel> SearchDistricts(string search, string cityCode = "");

        void Add(District districtParameter);

        void Update(District districtParameter);
    }
}
