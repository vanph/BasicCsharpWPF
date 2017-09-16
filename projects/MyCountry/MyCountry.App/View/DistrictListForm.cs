using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyCountry.App.Business;
using MyCountry.App.ViewModel;
using MyCountry.DataAccess.Model;
using MyCountry.DataAccess.Persistence;

namespace MyCountry.App.View
{
    public partial class DistrictListForm : Form
    {
        private readonly IMyCountryBusiness _myCountryBusiness;
        
        public DistrictListForm()
        {
            InitializeComponent();

            lblDistrictCode.Text = "";
            lblDistrictName.Text = "";
            lblCityName.Text = "";

            dgvDistrictList.AutoGenerateColumns = false;
            
            _myCountryBusiness = new MyCountryBusiness();
            
            //Dependency Injection - IoC
        }
        

        private void DistrictListForm_Load(object sender, EventArgs e)
        {
            SearchDistrictInformations();

            LoadCities();
        }

        private void LoadCities()
        {
            cmbCity.DataSource = _myCountryBusiness.GetCities();
            cmbCity.DisplayMember = nameof(City.Name);
            cmbCity.ValueMember = nameof(City.CityCode);
            cmbCity.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDistrictInformations();
        }

        private void SearchDistrictInformations()
        {
            var city = cmbCity.SelectedItem as City;
            var cityCode = city != null ? city.CityCode : string.Empty;

            dgvDistrictList.DataSource = _myCountryBusiness.SearchDistricts(txtSearch.Text, cityCode);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbCity.SelectedIndex = -1;
            dgvDistrictList.DataSource = _myCountryBusiness.SearchDistricts(txtSearch.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Export districts to csv file.

            saveFileDialog1.Filter = @"txt files (*.txt)|*.txt|csv files (*.csv)|*.csv|All files (*.*)|*.*";

            //Save file with a saveFileDialog
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportDistricts();
            }
        }

        private void ExportDistricts()
        {
            var districtViewModels = dgvDistrictList.DataSource as IEnumerable<DistrictViewModel>;

            var str = new StringBuilder();

            foreach (var district in districtViewModels)
            {
                var properties = district.GetType().GetProperties();
                for (var i = 0; i < properties.Length; i++)
                {
                    var propInfo = properties[i];

                    if (propInfo.Name != "CityCode")
                    {
                        if (i == properties.Length - 1)
                        {
                            str.AppendLine(propInfo.GetValue(district).ToString());
                        }
                        else
                        {
                            str.Append($"{propInfo.GetValue(district)},");
                        }
                    }
                }
            }

            File.WriteAllText(saveFileDialog1.FileName, str.ToString(), Encoding.UTF8);
        }

        private void dgvDistrictList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDistrictList.SelectedRows.Count > 0)
            {
                var districtInfo = dgvDistrictList.SelectedRows[0].DataBoundItem as DistrictViewModel;
                if (districtInfo != null)
                {
                    //update infor
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvDistrictList.SelectedRows.Count > 0)
            {
                var districtInfo = dgvDistrictList.SelectedRows[0].DataBoundItem as DistrictViewModel;
                if (districtInfo != null)
                {
                    if (MessageBox.Show($@"Do you really want to delete the District {districtInfo.DistrictName}?",
                            @"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        var dbContext  = new MyCountryEntities();
                        var district = dbContext.Districts.FirstOrDefault(x => x.DistrictCode == districtInfo.DistrictCode);
                        if (district != null)
                        {
                            dbContext.Districts.Remove(district);
                            dbContext.SaveChanges();
                            MessageBox.Show(@"Successfully deleted!", @"Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            SearchDistrictInformations();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($@"Please select a district to delete", @"Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
