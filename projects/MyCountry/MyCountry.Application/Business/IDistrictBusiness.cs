using System.Collections.Generic;
using MyCountry.Application.ViewModel;

namespace MyCountry.Application.Business
{
    public interface IDistrictBusiness
    {
        List<DistrictViewModel> SearchDistricts(string search, string cityCode = "");
    }
}
