using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class fProduct : Form
    {
        private const string filePath = "ProductData.txt";
        private int currentMaxProductId;

        // Constructor
        public fProduct()
        {
            InitializeComponent();
            groupBoxProductInfo.Enabled = false;
            currentMaxProductId = GetMaxProductId();
            DisplayDataInDataGridView();
            DisplayDataInTextBox();
        }

        // Button click event for adding a new product or saving changes
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                // Enable controls for adding a new product
                groupBoxProductInfo.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

                // Clear input fields
                txtProductID.Text = (currentMaxProductId + 1).ToString(); // Auto-increment ID
                txtPrice.Text = "";
                txtProductName.Text = "";
                txtProductID.ReadOnly = true; // Lock the ProductID TextBox
                txtProductID.Focus();

                // Change button text
                btnAdd.Text = "Save";
            }
            else
            {
                // Validate input fields
                if (ValidateInput())
                {
                    // Add the new product to the file
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(String.Format("{0},{1},{2}", txtProductID.Text, txtProductName.Text, txtPrice.Text));
                    }

                    // Reset controls
                    btnAdd.Text = "Add";
                    groupBoxProductInfo.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                    // Refresh DataGridView and TextBoxes
                    DisplayDataInDataGridView();
                    DisplayDataInTextBox();

                    // Update currentMaxProductId
                    currentMaxProductId++;

                    // Unlock the ProductID TextBox for future edits
                    txtProductID.ReadOnly = false;
                }
            }
        }


        // Button click event for editing a product or saving changes
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                // Enable controls for editing a product
                groupBoxProductInfo.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                txtProductID.ReadOnly = true; // Lock the ProductID TextBox
                txtProductID.Focus();

                // Change button text
                btnEdit.Text = "Save";
            }
            else
            {
                // Validate input fields
                if (ValidateInput())
                {
                    // Update the selected product in the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        List<string> lines = new List<string>();
                        string lineToUpdate = String.Format("{0},{1},{2}", txtProductID.Text, txtProductName.Text, txtPrice.Text);

                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }

                        int index = lines.FindIndex(l => l == lineToUpdate);
                        lines[index] = lineToUpdate;

                        File.WriteAllLines(filePath, lines);
                    }

                    // Reset controls
                    btnEdit.Text = "Edit";
                    groupBoxProductInfo.Enabled = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;

                    // Refresh DataGridView and TextBoxes
                    DisplayDataInDataGridView();
                    DisplayDataInTextBox();
                }
            }
        }

        // Button click event for deleting a product
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Remove the selected product from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();
            string lineToDelete = String.Format("{0},{1},{2}", txtProductID.Text, txtProductName.Text, txtPrice.Text);

            lines.Remove(lineToDelete);
            File.WriteAllLines(filePath, lines);

            // Refresh DataGridView and TextBoxes
            DisplayDataInDataGridView();
            DisplayDataInTextBox();
        }

        // Display data in DataGridView
        private void DisplayDataInDataGridView()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ProductID");
                    table.Columns.Add("ProductName");
                    table.Columns.Add("Price");

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            table.Rows.Add(parts);
                        }
                    }

                    dgvProducts.DataSource = table;
                }
            }
        }

        // DataGridView SelectionChanged event
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.CurrentRow.Selected = true;
            }
            catch
            {
            }
        }

        // Display data in TextBoxes
        private void DisplayDataInTextBox()
        {
            txtProductID.DataBindings.Clear();
            txtProductID.DataBindings.Add("Text", dgvProducts.DataSource, "ProductID");

            txtProductName.DataBindings.Clear();
            txtProductName.DataBindings.Add("Text", dgvProducts.DataSource, "ProductName");

            txtPrice.DataBindings.Clear();
            txtPrice.DataBindings.Add("Text", dgvProducts.DataSource, "Price");
        }

        // Button click event for closing the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Validate input fields
        private bool ValidateInput()
        {
            // Validate Product ID
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Product ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Product Name
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Price
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid Price format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validation successful
            return true;
        }

        // Helper method to get the current maximum ProductID from the file
        // Helper method to get the current maximum ProductID from the file
        private int GetMaxProductId()
        {
            int maxProductId = 0;

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            int currentProductId;
                            if (int.TryParse(parts[0], out currentProductId))
                            {
                                maxProductId = Math.Max(maxProductId, currentProductId);
                            }
                        }
                    }
                }
            }

            return maxProductId;
        }

    }
}
