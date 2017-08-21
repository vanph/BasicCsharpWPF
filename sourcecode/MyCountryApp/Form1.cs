using System;
using MyCountry;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCountry.Repository;

namespace MyCountryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cityRepo = new CityRepository();
            var cityList = cityRepo.GetCities();
            dataGridView1.DataSource = cityList;
            //var show = txtMaxDistrict.Text;
            //show.ToList();
            
        }

        private void btnGetDistrict_Click(object sender, EventArgs e)
        {
            var districtRepo = new DistrictRepository();
            var districtList = districtRepo.GetDistricts();
            var search = txtSearchDistrict.Text;
            if (string.IsNullOrEmpty(search))
            {
                grdDistrict.DataSource = districtList;
            }
            else
            {
                grdDistrict.DataSource = districtList.Where(x => x.Name.Contains(search) || x.Type.Contains(search) || x.Code.Contains(search)).ToList();
            }
            //districtList.Select(x => x.CityCode).Count();
        }

        private void btnGetDistrict1_Click(object sender, EventArgs e)
        {
            var districts = new DistrictRepository();
            var districtList1 = districts.GetDistricts();

            var districtcodes = (from district in districtList1 select new { CityCode = district.CityCode }).ToList();

            grdDistrict.DataSource = districtcodes;
        }
    }
}
