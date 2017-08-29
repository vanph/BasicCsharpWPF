using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
            this.Load += MainFormLoaded;
            dataGridView1.AutoGenerateColumns = true;
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

        private void MainFormLoaded(object sender, EventArgs e)
        {
            var cityNameList = _cityRepository.GetAll();

            comboBox1.DataSource = cityNameList.Select(x => x.Name).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cityNameList = _cityRepository.GetAll();
            var distNameList = _districtRepository.GetAll();

            string selected = comboBox1.SelectedValue.ToString();
            var codeCity = cityNameList.Where(x => x.Name == selected).Select(x => x.Code).FirstOrDefault();
            comboBox2.DataSource = distNameList.Where(x => x.CityCode == codeCity).Select(x => x.Name).ToList();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            var frm = new Form2()
            {
                Width = 400,
                Height = 300
            };


            frm.ShowDialog();
        }

        private void btnShowDialog_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var btn = sender as Button;
            //if (btn != null)
            //{
            //    btn.Text = @"I clicked";
            //}

            if (sender is Button)
            {
                var btn = (Button) sender;
                btn.Text = @"I clicked";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //export cities to text file.
            var cities = _cityRepository.GetAll();

            StringBuilder str = new StringBuilder();
            foreach (var city in cities)
            {
                //typeof(City)
                var properties = city.GetType().GetProperties();
                for (var i = 0; i < properties.Length; i++)
                {
                    var propInfo = properties[i];

                    if (i == properties.Length - 1)
                    {
                        str.AppendLine($"{propInfo.Name}:{propInfo.GetValue(city)}");
                    }
                    else
                    {
                        str.Append($"{propInfo.Name}:{propInfo.GetValue(city)},");
                    }
                }
            }
            //Save file
            var path = $"{Directory.GetCurrentDirectory()}\\city.txt";
            File.WriteAllText(path,str.ToString(), Encoding.UTF8);

            MessageBox.Show(@"Success");
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            //export cities to csv file.
            var cities = _cityRepository.GetAll();

            var str = new StringBuilder();

            foreach (var city in cities)
            {
                var properties = city.GetType().GetProperties();
                for (var i = 0; i < properties.Length; i++)
                {
                    var propInfo = properties[i];

                    if (i == properties.Length - 1)
                    {
                        str.AppendLine(propInfo.GetValue(city).ToString());
                    }
                    else
                    {
                        str.Append($"{propInfo.GetValue(city)},");
                    }
                }
            }
            //Save file
            var path = $"{Directory.GetCurrentDirectory()}\\city.csv";
            File.WriteAllText(path, str.ToString(), Encoding.UTF8);

            MessageBox.Show(@"Success");
        }

        private void btnExportCsvDistrict_Click(object sender, EventArgs e)
        {
            //Export districts to csv file.
            var districts = _districtRepository.GetAll();

            var str = new StringBuilder();

            foreach (var district in districts)
            {
                var properties = district.GetType().GetProperties();
                for (var i = 0; i < properties.Length; i++)
                {
                    var propInfo = properties[i];

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
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv|All files (*.*)|*.*";

            //Save file with a saveFileDialog
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, str.ToString(), Encoding.UTF8);
            }
        }
    }
}
