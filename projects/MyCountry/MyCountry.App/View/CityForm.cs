using System;
using System.Linq;
using System.Windows.Forms;
using MyCountry.DataAccess.Model;
using MyCountry.DataAccess.Persistence;
using MyCountry.App.Business;

namespace MyCountry.App.View
{
    public partial class CityForm : Form
    {
        private readonly IMyCountryBusiness _myCountryBusiness;

        public CityForm()
        {
            InitializeComponent();

            dgvCityForm.AutoGenerateColumns = false;

            _myCountryBusiness = new MyCountryBusiness();
        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            //var dbContect = new MyCountryEntities();
            //var query = dbContect.Districts as IQueryable<District>;

            //var result = query.GroupBy(x => x.CityCode).Select(x => new { CityName = x.Key, DistrictsList = x.ToString() });

            //dgvCityForm.DataSource = result;

            dgvCityForm.DataSource = _myCountryBusiness.GetCityInfomations();
        }
    }
}
