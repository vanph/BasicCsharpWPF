using System;
using System.Linq;
using System.Windows.Forms;
using MyCountry.App.Business;
using MyCountry.App.ViewModel;
using MyCountry.DataAccess.Model;
using MyCountry.DataAccess.Persistence;

namespace MyCountry.App.View
{
    public sealed partial class DistrictDetailForm : Form // vì sao phải sealed?
    {
        private readonly MyCountryBusiness _myCountryBusiness;
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

            _myCountryBusiness = new MyCountryBusiness();
        }

        private void DistrictDetailForm_Load(object sender, System.EventArgs e)
        {
            var cities = _myCountryBusiness.GetCities();
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
                if (_isAddNew)
                {
                    
                    var dbContext = new MyCountryEntities();
                    var city = cmbCity.SelectedItem as City;

                    var district = new District
                    {
                        Name = txtDistrictName.Text,
                        DistrictCode = txtDistictCode.Text,
                        Type = txtDistrictType.Text,
                        CityCode = city != null ? city.CityCode : string.Empty
                    };
                    dbContext.Districts.Add(district);
                    dbContext.SaveChanges();
                }
                else
                {
                    var dbContext = new MyCountryEntities();
                    var district = dbContext.Districts.FirstOrDefault(x => x.DistrictCode == _selectedCode);
                    if (district != null)
                    {
                        district.Name = txtDistrictName.Text;
                        district.Type = txtDistrictType.Text;

                        dbContext.SaveChanges();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    } 
}
