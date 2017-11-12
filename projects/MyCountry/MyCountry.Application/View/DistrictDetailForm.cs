using System;
using System.Linq;
using System.Windows.Forms;
using MyCountry.Application.Business;
using MyCountry.Application.Exceptions;
using MyCountry.DataAccess.Model;
using MyCountry.DataAccess.Persistence;

namespace MyCountry.Application.View
{
    public sealed partial class DistrictDetailForm : Form // vì sao phải sealed?
    {
        private readonly ICityBusiness _cityBusiness;
        private readonly IDistrictBusiness _districtBusiness;
        private readonly bool _isAddNew;
        private readonly string _selectedCode;

        public DistrictDetailForm(bool isAddNew, string code="")
        {
            InitializeComponent();
            _isAddNew = isAddNew;
            if (!isAddNew)
            {
                _selectedCode = code;
            }

            Text = _isAddNew ? @"Add new District" : @"Edit District";

            _cityBusiness = new CityBusiness();
            _districtBusiness = new DistrictBusiness();
        }

        private void DistrictDetailForm_Load(object sender, System.EventArgs e)
        {
            var cities = _cityBusiness.GetCities();
            cmbCity.DataSource = cities;
            cmbCity.DisplayMember = nameof(City.Name);
            if (!_isAddNew)
            {
                cmbCity.Enabled = false;
                txtDistictCode.Enabled = false;
                var dbContext = new MyCountryEntities();
                var editingDistrict = dbContext.Districts.FirstOrDefault(x => x.DistrictCode == _selectedCode);
                if (editingDistrict != null)
                {
                    txtDistrictName.Text = editingDistrict.Name;
                    txtDistictCode.Text = editingDistrict.DistrictCode;
                    txtDistrictType.Text = editingDistrict.Type;
                    var city = cities.FirstOrDefault(x => x.CityCode == editingDistrict.CityCode);
                    cmbCity.SelectedItem = city;
                }
                else
                {
                    MessageBox.Show(@"Cannot found district.", @"Message", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    btnSave.Enabled = false;
                }
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                var city = cmbCity.SelectedItem as City;
                var cityCode = city != null ? city.CityCode : string.Empty;

                var districtParameter = new District
                {
                    Name = txtDistrictName.Text,
                    DistrictCode = txtDistictCode.Text,
                    Type = txtDistrictType.Text,
                    CityCode = cityCode
                };

                if (_isAddNew)
                {


                    _districtBusiness.Add(districtParameter);
                }
                else
                {
                    _districtBusiness.Update(districtParameter);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DistrictValiationException ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    } 
}
