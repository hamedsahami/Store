using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApplication.Forms
{
    public partial class ProductListForm : Theme
    {
        Repository.ProductRepository repo = new Repository.ProductRepository();
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = repo.GetAll().ToList();
        }
    }
}
