using System;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class fLogin  : Form
    {
        // Hardcoded username and password
        private const string DefaultUsername = "admin";
        private const string DefaultPassword = "password";

        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Compare input with hardcoded values
                if (txtUsername.Text == DefaultUsername && txtPassword.Text == DefaultPassword)
                {
                    this.Hide();
                    fMain main = new fMain();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Notification");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error!", "Notification");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
