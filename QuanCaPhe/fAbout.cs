using System;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class fAbout : Form
    {
        public fAbout()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAbout_Load(object sender, EventArgs e)
        {
            // Add project description dynamically
            this.Text += " - Version 1.0"; // Example version information
        }

    }
}
