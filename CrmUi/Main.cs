using CrmBL_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CrmUi
{
    public partial class Form1 : Form
    {

        CrmContext db;
        public Form1()
        {
            InitializeComponent();
            db = new CrmContext();
        }


  

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products);
            catalogProduct.Show();
        }
        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers);
            catalogCustomer.Show();
        }

        private void checklToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(db.Checks);
            catalogCheck.Show();
        }

        private void sellerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers);
            catalogSeller.Show();
        }


        private void CustomerAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            if(form.ShowDialog()==DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

   
    }
}
