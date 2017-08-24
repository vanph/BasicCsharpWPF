﻿using System;
using System.Linq;
using System.Windows.Forms;
using MyCountry.Model;
using MyCountry.Repository;

namespace MyCountryApp
{
    public partial class Form1 : Form
    {
        private readonly ICityRepository _cityRepository;
        private readonly IDistrictRepository _districtRepository;
        public Form1()
        {
            InitializeComponent();

            _cityRepository = new CityRepository();
            _districtRepository = new DistrictRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cityList = _cityRepository.GetAll();
            dataGridView1.DataSource = cityList;
        }

        private void btnGetDistrict_Click(object sender, EventArgs e)
        {
            var districtList = _districtRepository.GetAll();
            var search = txtSearchDistrict.Text;
            if (string.IsNullOrEmpty(search))
            {
                grdDistrict.DataSource = districtList;
            }
            else
            {
                search = search.ToLower();

                //grdDistrict.DataSource = districtList.Where(x => x.Name.ToLower().Contains(search)|| x.Code.Contains(search)).ToList();
                grdDistrict.DataSource = districtList.Where(x => x.Name.ContainsByStringComparison(search, StringComparison.OrdinalIgnoreCase) || x.Code.Contains(search)).ToList();
            }
            //districtList.Select(x => x.CityCode).Count();
        }



        private void btnGetDistrict1_Click(object sender, EventArgs e)
        {
            var cityList = _cityRepository.GetAll();
            var districts = _districtRepository.GetAll();

            //Code Minh
            //var districtcode = from district in districtList1
            //                   select district.CityCode;
            //grdDistrict.DataSource = districtcode.ToArray();
            //1. Code của của Minh them ToList hoặc ToArray vào:
            //M:Thêm ToList hay ToArray vào đều trả về độ dài chuỗi
            //M:Enumerable class? => vì trong ... chỉ có mỗi method lengt()

            //check code
            //var districtcodes = (from district in districtList1 select new { CityCode = district.CityCode }).ToList();
            //grdDistrict.DataSource = districtcodes;
            //2. tìm hiểu tại sao a lại them dòng này select new { CityCode = district.CityCode }
            //M:Anonymous Type?
            //M:SAo của e khai báo thì thành Enonymous còn của a thêm new vào lại thành List?
            //M:Vì sao lại cần anonymous ở đây? =>đẻ có thể xuất ra các trường đã chọn

            var grpDistricts = districts.GroupBy(p => p.CityCode).Select(g => new { Code = g.Key, CityCodeCount = g.Count() }).ToList();
            var maxCityCount = grpDistricts.Max(l => l.CityCodeCount);

            var cityCodes = grpDistricts.Where(h => h.CityCodeCount == maxCityCount).Select(x => x.Code);
            var cityName = cityList.Where(x => cityCodes.Contains(x.Code)).Select(x => x.Name).JoinStrings(" , ");

            MessageBox.Show($@"Tỉnh có nhiều quận huyện nhât: {cityName}");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var cityList = _cityRepository.GetAll();
            var districtList1 = _districtRepository.GetAll();

            var result = cityList.Join(districtList1, p => p.Code, c => c.CityCode, (p, c) => new
            {
                getdisCode = c.Code,
                getdisName = c.Name,
                getcityName = p.Name
            }).OrderBy(x => x.getcityName.ExtTrimStart("Tỉnh ").ExtTrimStart("Thành phố ")).ToList();
            dataGridView1.DataSource = result;
        }


    }
}
