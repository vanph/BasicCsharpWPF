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
            var search = txtSearch.Text;
            var query = dbContext.Customers.OrderBy(x => x.CustomerID);
            if (string.IsNullOrEmpty(search))
            {
                dataGridView1.DataSource = query.ToList();
            }
            else
            {
                search = search.ToLower();
                dataGridView1.DataSource = query.Where(x => x.CustomerID.ToLower().Contains(search)).ToList();
            }           
        }
    }
}
