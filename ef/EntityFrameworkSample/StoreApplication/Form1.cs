using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreApplication.DataAccess;

namespace StoreApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbContext = new NorthwindEntities();
            var query = dbContext.Customers.Where(x => x.CustomerID.Contains("A")).OrderBy(x => x.CustomerID);
            var customers = query.ToList();
            dataGridView1.DataSource = customers;
        }
    }
}
