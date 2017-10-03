using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCountry.App.Business;
using MyCountry.App.ViewModel;
using MyCountry.DataAccess.Model;
using MyCountry.DataAccess.Persistence;

namespace MyCountry.App.View
{
    public partial class CityForm : Form
    {
        //private readonly MyCountryBusiness _myCountryBusiness;

        public CityForm()
        {
            InitializeComponent();

            dgvCityForm.AutoGenerateColumns = false;
        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            //var dbContect = new MyCountryEntities();
            //var query = dbContect.Districts as IQueryable<District>;

            //var result = query.GroupBy(x => x.CityCode).Select(x => new {CityName = x.Key, DistrictsList = x.ToString()});

            //dgvCityForm.DataSource = result;
        }
    }
}
