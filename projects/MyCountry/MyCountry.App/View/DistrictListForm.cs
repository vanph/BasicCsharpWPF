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
        }

        private void DistrictListForm_Load(object sender, EventArgs e)
        {
            //var districtList = _myDistrict.Districts;
            //dgvDistrictList.DataSource = districtList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dbContect = new MyCountryEntities();
            var search = txtSearch.Text;
            var query = dbContect.Districts.OrderBy(x => x.DistrictCode);
            if (string.IsNullOrEmpty(search))
            {
                dgvDistrictList.DataSource = query.ToList();
            }
            else
            {
                dgvDistrictList.DataSource = query.Where(x => x.DistrictCode.Contains(search)).ToList();
            }
        }
    }
}
