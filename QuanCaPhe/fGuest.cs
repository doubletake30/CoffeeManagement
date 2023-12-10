using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class fGuest : Form
    {
        // List to store reserved tables
        private List<ReservedTable> reservedTableList;

        // File path for storing reserved table data
        private const string filePath = "GuestsBookTables.txt";

        // List to store product data
        private List<Product> productList;

        // File path for storing product data
        private const string productFilePath = "ProductData.txt";

        // HashSet to keep track of existing table IDs
        private HashSet<string> existingTableIDs;

        // Constructor
        public fGuest()
        {
            InitializeComponent();
            groupBoxInputInfo.Enabled = false;
            LoadDataFromFile();
            LoadProductData();
            LoadComboBoxProductNames();
            DisplayData();
            DisplayDataInTextBoxes();
        }

        // Load product data from file
        private void LoadProductData()
        {
            productList = File.Exists(productFilePath)
                ? File.ReadAllLines(productFilePath)
                    .Select(line =>
                    {
                        string[] parts = line.Split(',');
                        return parts.Length == 3
                            ? new Product { ID = parts[0], Name = parts[1], Price = decimal.Parse(parts[2]) }
                            : null;
                    })
                    .Where(product => product != null)
                    .ToList()
                : new List<Product>();
        }

        // Load product names into the ComboBox
        private void LoadComboBoxProductNames()
        {
            if (productList.Any())
            {
                comboBoxProductName.DataSource = productList;
                comboBoxProductName.DisplayMember = "ToString";
                comboBoxProductName.ValueMember = "Name";
            }
            else
            {
                MessageBox.Show("Product list is empty or null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load data from file on form load
        private void fGuest_Load(object sender, EventArgs e)
        {
            LoadComboBoxProductNames();
        }

        // Load reserved table data from file
        private void LoadDataFromFile()
        {
            reservedTableList = File.Exists(filePath)
                ? File.ReadAllLines(filePath)
                    .Select(line =>
                    {
                        string[] parts = line.Split(',');
                        return parts.Length == 5
                            ? new ReservedTable { TableID = parts[0], TableName = parts[1], Area = parts[2], ProductName = parts[3], Quantity = parts[4] }
                            : null;
                    })
                    .Where(reservedTable => reservedTable != null)
                    .ToList()
                : new List<ReservedTable>();

            // Populate the HashSet with existing TableIDs
            existingTableIDs = new HashSet<string>(reservedTableList.Select(table => table.TableID));
        }

        // Button click event for adding or saving reserved table
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                // Enable input controls for adding a new table
                groupBoxInputInfo.Enabled = true;
                btnUpdate.Enabled = btnDelete.Enabled = false;

                // Clear input fields
                textBoxTableID.Text = textBoxTableName.Text = textBoxArea.Text = "";
                comboBoxProductName.SelectedIndex = -1;
                textBoxQuantity.Text = "";

                // Change button text
                btnAdd.Text = "Save";
            }
            else
            {
                // Validate input fields
                if (ValidateInput())
                {
                    // Create a new reserved table object
                    var newReservedTable = new ReservedTable
                    {
                        TableID = textBoxTableID.Text,
                        TableName = textBoxTableName.Text,
                        Area = textBoxArea.Text,
                        ProductName = comboBoxProductName.SelectedIndex == -1 ? string.Empty : comboBoxProductName.Text,
                        Quantity = textBoxQuantity.Text
                    };

                    // Check if the table ID already exists
                    if (existingTableIDs.Contains(newReservedTable.TableID))
                    {
                        // Table with the given TableID already exists, show an error message
                        MessageBox.Show("Table with the given TableID already exists. Please choose a different TableID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Table with the given TableID doesn't exist, add the new reservation

                        // Add the new table to the list
                        reservedTableList.Add(newReservedTable);

                        // Update the HashSet with the new TableID
                        existingTableIDs.Add(newReservedTable.TableID);

                        // Save the new reservation to the file
                        string lineToAdd = string.Format("{0},{1},{2},{3},{4}", newReservedTable.TableID, newReservedTable.TableName, newReservedTable.Area, newReservedTable.ProductName, newReservedTable.Quantity);
                        File.AppendAllLines(filePath, new[] { lineToAdd });

                        // Reload data from the file
                        LoadDataFromFile();
                        // Refresh DataGridView
                        DisplayData();
                        // Reload product names into the ComboBox
                        LoadComboBoxProductNames();
                        // Refresh TextBoxes
                        DisplayDataInTextBoxes();

                        // Change button text
                        btnAdd.Text = "Add";
                        btnUpdate.Enabled = btnDelete.Enabled = true;
                        groupBoxInputInfo.Enabled = false;
                    }
                }
            }
        }

        // Validate input fields
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxTableID.Text) || string.IsNullOrWhiteSpace(textBoxTableName.Text) || string.IsNullOrWhiteSpace(textBoxArea.Text) || comboBoxProductName.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBoxQuantity.Text))
            {
                // Show an error message for empty fields
                MessageBox.Show("All fields are required. Please fill in all the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Quantity as a numeric value
            decimal quantity;
            if (!decimal.TryParse(textBoxQuantity.Text, out quantity))
            {
                // Show an error message for an invalid quantity
                MessageBox.Show("Quantity must be a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Button click event for deleting a reserved table
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewGuestList.SelectedRows.Count > 0)
            {
                // Get the selected TableID from the DataGridView
                string selectedTableID = dataGridViewGuestList.SelectedRows[0].Cells[0].Value.ToString();

                // Remove the selected table from the list
                reservedTableList.RemoveAll(table => table.TableID == selectedTableID);

                // Remove the selected table from the HashSet
                existingTableIDs.Remove(selectedTableID);

                // Remove the selected table from the file
                List<string> lines = File.ReadAllLines(filePath)
                    .Where(line => !line.Split(',')[0].Equals(selectedTableID))
                    .ToList();

                File.WriteAllLines(filePath, lines);

                // Reload data from the file
                LoadDataFromFile();
                // Refresh DataGridView
                DisplayData();
                // Refresh TextBoxes
                DisplayDataInTextBoxes();
            }
        }

        // Display data in DataGridView
        private void DisplayData()
        {
            // Create a DataTable and add columns to it
            DataTable table = new DataTable();
            table.Columns.Add("TableID");
            table.Columns.Add("TableName");
            table.Columns.Add("Area");
            table.Columns.Add("ProductName");
            table.Columns.Add("Quantity");

            // Check if reservedTableList is not null
            if (reservedTableList != null)
            {
                // Clear existing data in the DataTable
                table.Rows.Clear();

                // Iterate over reservedTableList and add rows to the DataTable
                foreach (var reservedTable in reservedTableList)
                {
                    DataRow row = table.NewRow();
                    row["TableID"] = reservedTable.TableID;
                    row["TableName"] = reservedTable.TableName;
                    row["Area"] = reservedTable.Area;
                    row["ProductName"] = reservedTable.ProductName;
                    row["Quantity"] = reservedTable.Quantity;

                    table.Rows.Add(row);
                }
            }

            // Set the DataTable as the DataSource for the DataGridView
            dataGridViewGuestList.DataSource = table;
        }

        // Button click event for closing the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // SelectionChanged event for DataGridView
        private void dataGridViewGuestList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewGuestList.CurrentRow != null)
                {
                    dataGridViewGuestList.CurrentRow.Selected = true;
                }
            }
            catch (Exception)
            {
                // Handle exception if any
            }
        }

        // Display data in TextBoxes using data binding
        private void DisplayDataInTextBoxes()
        {
            if (reservedTableList != null && reservedTableList.Any())
            {
                // Clear existing data bindings
                textBoxTableID.DataBindings.Clear();
                textBoxTableID.DataBindings.Add("Text", reservedTableList, "TableID");

                textBoxTableName.DataBindings.Clear();
                textBoxTableName.DataBindings.Add("Text", reservedTableList, "TableName");

                textBoxArea.DataBindings.Clear();
                textBoxArea.DataBindings.Add("Text", reservedTableList, "Area");

                comboBoxProductName.DataBindings.Clear();
                comboBoxProductName.DataBindings.Add("SelectedValue", reservedTableList, "ProductName");

                textBoxQuantity.DataBindings.Clear();
                textBoxQuantity.DataBindings.Add("Text", reservedTableList, "Quantity");
            }
            else
            {
                ClearTextBoxes();
            }
        }

        // Button click event for updating a reserved table
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                // Enable input controls for updating a table
                groupBoxInputInfo.Enabled = true;
                btnAdd.Enabled = btnDelete.Enabled = false;

                // Change button text
                btnUpdate.Text = "Save";
            }
            else
            {
                // Find the selected reserved table
                ReservedTable selectedReservedTable = reservedTableList.Find(table => table.TableID == textBoxTableID.Text);

                if (selectedReservedTable != null)
                {
                    // Update the selected reserved table
                    selectedReservedTable.Update(new ReservedTable
                    {
                        TableName = textBoxTableName.Text,
                        Area = textBoxArea.Text,
                        ProductName = comboBoxProductName.Text,
                        Quantity = textBoxQuantity.Text
                    });

                    // Save the updated data to the file
                    SaveDataToFile();
                    // Refresh DataGridView
                    DisplayData();
                    // Refresh TextBoxes
                    DisplayDataInTextBoxes();

                    // Change button text
                    btnUpdate.Text = "Update";
                    btnAdd.Enabled = btnDelete.Enabled = true;
                    groupBoxInputInfo.Enabled = false;
                }
            }
        }

        // Save data to file
        private void SaveDataToFile()
        {
            try
            {
                // Create a list to store lines of data
                List<string> lines = new List<string>();

                // Iterate over reservedTableList and add lines to the list
                foreach (var reservedTable in reservedTableList)
                {
                    string line = string.Format("{0},{1},{2},{3},{4}", reservedTable.TableID, reservedTable.TableName, reservedTable.Area, reservedTable.ProductName, reservedTable.Quantity);
                    lines.Add(line);
                }

                // Write the list of lines to the file
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear TextBoxes
        private void ClearTextBoxes()
        {
            textBoxTableID.Text = textBoxTableName.Text = textBoxArea.Text = string.Empty;
            comboBoxProductName.SelectedIndex = -1;
            textBoxQuantity.Text = string.Empty;
        }
    }

    // Class representing a reserved table
    public class ReservedTable
    {
        public string TableID { get; set; }
        public string TableName { get; set; }
        public string Area { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }

        // Method to update the reserved table
        public void Update(ReservedTable newReservedTable)
        {
            TableName = newReservedTable.TableName;
            Area = newReservedTable.Area;
            ProductName = newReservedTable.ProductName;
            Quantity = newReservedTable.Quantity;
        }
    }

    // Class representing a product
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Override ToString method for display in ComboBox
        public override string ToString()
        {
            return string.Format("{0} - ${1}", Name, Price);
        }
    }
}
