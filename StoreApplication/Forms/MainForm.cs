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
    public partial class MainForm : Theme
    {
        public MainForm()
        {
            InitializeComponent();
            Login login = new Login();
            if (login.ShowDialog()==DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void لیستمحصولاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.ProductListForm().ShowDialog();
        }
    }
}
