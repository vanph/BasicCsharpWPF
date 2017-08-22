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
            dataGridViewCode.AutoGenerateColumns = false;
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
                search = search.ToLower();

                //Solution 1
                //grdDistrict.DataSource = districtList.Where(x => x.Name.ToLower().Contains(search)|| x.Code.Contains(search)).ToList();
                //Solution 2
                //1.000
                grdDistrict.DataSource = districtList.Where(x => x.Name.ContainsByStringComparison(search, StringComparison.OrdinalIgnoreCase) || x.Code.Contains(search)).ToList();
            }
            //districtList.Select(x => x.CityCode).Count();
        }

       

        private void btnGetDistrict1_Click(object sender, EventArgs e)
        {
            var districts = new DistrictRepository();
            var districtList1 = districts.GetDistricts();

            var districtcodes = (from district in districtList1 select new { Code = district.CityCode}).Distinct().ToList();
            
            dataGridViewCode.DataSource = districtcodes;

            var count = districtcodes.Count();

            MessageBox.Show("Done");
        }

       
    }
}
