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
                search = search.ToLower();

                //grdDistrict.DataSource = districtList.Where(x => x.Name.ToLower().Contains(search)|| x.Code.Contains(search)).ToList();
                grdDistrict.DataSource = districtList.Where(x => x.Name.ContainsByStringComparison(search,StringComparison.OrdinalIgnoreCase)  || x.Code.Contains(search)).ToList();
            }
            //districtList.Select(x => x.CityCode).Count();
        }

       

        private void btnGetDistrict1_Click(object sender, EventArgs e)
        {
            var districts = new DistrictRepository();
            var districtList1 = districts.GetDistricts();

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
            var x = districtList1.GroupBy(p => p.CityCode).Select(g => new { mode = g.Key, CityCodeCount = g.Count() }).ToList();
            var y = x.Max(l => l.CityCodeCount);
            var z = x.Where(h => h.CityCodeCount == y).Select(m => new { dstmax = m.mode }).ToList();
            grdDistrict.DataSource = z;
            txtSearchDistrict.Text = z.First().ToString();//M:Tại sao kế quả ra: { dstmax = 01 }, chỉ muốn là 01???
        }

        private void btnGetDisMax_Click(object sender, EventArgs e)
        {
            //M:Ở đây e không biết làm sao truyền dữ liệu nhận được là Code của tỉnh có số Districts nhiều nhất sang đây để tiếp tục tính toán???
        }
    }
}
