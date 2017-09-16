using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCountry.DataAccess.Persistence;
using MyCountry.App.ViewModel;
using MyCountry.DataAccess.Model;

namespace MyCountry.App
{
    public partial class DistrictListForm : Form
    {
        //private readonly MyCountryEntities _myDistrict;
        public DistrictListForm()
        {
            InitializeComponent();

            lblDistrictCode.Text = "";
            lblDistrictName.Text = "";
            lblCityName.Text = "";

            dgvDistrictList.AutoGenerateColumns = false;

        }

        private void DistrictListForm_Load(object sender, EventArgs e)
        {
            dgvDistrictList.DataSource = SearchDistricts(txtSearch.Text);
            var dbContect = new MyCountryEntities();
            cmbCity.DataSource = dbContect.Cities.ToList();
            cmbCity.DisplayMember = nameof(City.Name);
            cmbCity.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var city = cmbCity.SelectedItem as City;
            var cityCode = city != null ? city.CityCode : string.Empty;

            dgvDistrictList.DataSource = SearchDistricts(txtSearch.Text, cityCode);
        }

        private static List<DistrictViewModel> SearchDistricts(string search, string cityCode ="" )
        {
            var dbContect = new MyCountryEntities();
            var query = dbContect.Districts as IQueryable<District>;
            
            if (!string.IsNullOrEmpty(search))
            {
                if (cityCode != "")
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
                if (cityCode != "")
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

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbCity.SelectedIndex = -1;
            dgvDistrictList.DataSource = SearchDistricts(txtSearch.Text);
        }
    }
}
