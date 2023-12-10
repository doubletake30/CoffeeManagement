using System;
using System.Globalization;
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
    public partial class fStaff : Form
    {
        // File path for storing staff data
        private const string filePath = "StaffData.txt";

        // Constructor
        public fStaff()
        {
            InitializeComponent();
            pnl_ttnd.Enabled = false;
            GetDataPutInGridView(); // Load data into DataGridView
            GetDataPutInTextBox(); // Load data into TextBoxes
        }

        // Event handler for the "Add" button
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (btn_add.Text == "Add")
            {
                pnl_ttnd.Enabled = true;
                btn_fix.Enabled = false;
                btn_delete.Enabled = false;

                // Clear TextBoxes
                txt_name.Text = "";
                txt_account.Text = "";
                txt_password.Text = "";
                txt_birthday.Text = "";
                txt_address.Text = "";
                txt_phone.Text = "";
                cbb_role.Text = "";

                // Auto-increment staff ID
                txt_id.Text = (GetMaxStaffId() + 1).ToString();

                txt_id.ReadOnly = true; // Lock the staff ID TextBox
                txt_id.BackColor = SystemColors.Control; // Change background color to indicate it's read-only

                btn_add.Text = "Save";
            }
            else
            {
                // Validate input fields
                if (ValidateInput())
                {
                    // Save data to the file
                    SaveDataToFile();

                    btn_add.Text = "Add";
                    pnl_ttnd.Enabled = false;
                    btn_fix.Enabled = true;
                    btn_delete.Enabled = true;
                    GetDataPutInGridView(); // Refresh DataGridView
                    GetDataPutInTextBox(); // Refresh TextBoxes
                }
            }
        }

        // Event handler for the "Edit" button
        private void btn_fix_Click(object sender, EventArgs e)
        {
            if (btn_fix.Text == "Edit")
            {
                pnl_ttnd.Enabled = true;
                btn_add.Enabled = false;
                btn_delete.Enabled = false;

                btn_fix.Text = "Save";
                txt_id.ReadOnly = true; // Lock the staff ID TextBox
                txt_id.BackColor = SystemColors.Control; // Change background color to indicate it's read-only
            }
            else
            {
                // Validate input fields
                if (ValidateInput())
                {
                    // Update data in the file
                    UpdateDataInTextFile();

                    btn_fix.Text = "Edit";
                    pnl_ttnd.Enabled = false;
                    btn_add.Enabled = true;
                    btn_delete.Enabled = true;
                    GetDataPutInGridView(); // Refresh DataGridView
                    GetDataPutInTextBox(); // Refresh TextBoxes
                }
            }
        }

        private bool ValidateInput()
        {
            return ValidateEmptyFields() && ValidateDateFormat() && ValidatePhoneNumberFormat();
        }

        // Event handler for the "Delete" button
        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Delete data from the file
            DeleteDataFromTextFile(txt_id.Text);

            GetDataPutInGridView(); // Refresh DataGridView
            GetDataPutInTextBox(); // Refresh TextBoxes
        }

        // Load data into DataGridView
        private void GetDataPutInGridView()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("manv");
                    table.Columns.Add("tennv");
                    table.Columns.Add("tendangnhap");
                    table.Columns.Add("ngaysinh");
                    table.Columns.Add("diachi");
                    table.Columns.Add("dienthoai");
                    table.Columns.Add("matkhau");
                    table.Columns.Add("phanquyen");

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 8)
                        {
                            table.Rows.Add(parts);
                        }
                    }

                    dgv_dsnd.DataSource = table; // Set DataGridView's DataSource to the created DataTable
                }
            }
        }

        // Event handler for the "SelectionChanged" event of DataGridView
        private void dgv_dsnd_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_dsnd.CurrentRow.Selected = true;
            }
            catch (Exception)
            {
                // Handle exception if any
            }
        }

        // Load data into TextBoxes using data binding
        private void GetDataPutInTextBox()
        {
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("Text", dgv_dsnd.DataSource, "manv");

            txt_name.DataBindings.Clear();
            txt_name.DataBindings.Add("Text", dgv_dsnd.DataSource, "tennv");

            txt_account.DataBindings.Clear();
            txt_account.DataBindings.Add("Text", dgv_dsnd.DataSource, "tendangnhap");

            txt_password.DataBindings.Clear();
            txt_password.DataBindings.Add("Text", dgv_dsnd.DataSource, "matkhau");

            txt_birthday.DataBindings.Clear();
            txt_birthday.DataBindings.Add("Text", dgv_dsnd.DataSource, "ngaysinh");

            txt_address.DataBindings.Clear();
            txt_address.DataBindings.Add("Text", dgv_dsnd.DataSource, "diachi");

            txt_phone.DataBindings.Clear();
            txt_phone.DataBindings.Add("Text", dgv_dsnd.DataSource, "dienthoai");

            cbb_role.DataBindings.Clear();
            cbb_role.DataBindings.Add("Text", dgv_dsnd.DataSource, "phanquyen");
        }

        // Save data to the file
        private void SaveDataToFile()
        {
            try
            {
                // Validate required fields
                if (!ValidateEmptyFields() || !ValidateDateFormat() || !ValidatePhoneNumberFormat())
                {
                    return;
                }

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    // Append a new line with the entered data
                    sw.WriteLine(txt_id.Text + "," + txt_name.Text + "," + txt_account.Text + "," + txt_birthday.Text + "," + txt_address.Text + "," + txt_phone.Text + "," + txt_password.Text + "," + cbb_role.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete data from the file
        private void DeleteDataFromTextFile(string manv)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            string lineToDelete = manv + "," + txt_name.Text + "," + txt_account.Text + "," + txt_birthday.Text + "," + txt_address.Text + "," + txt_phone.Text + "," + txt_password.Text + "," + cbb_role.Text;

            lines.Remove(lineToDelete);
            File.WriteAllLines(filePath, lines);
        }

        // Update data in the file
        private void UpdateDataInTextFile()
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            string lineToUpdate = txt_id.Text + "," + txt_name.Text + "," + txt_account.Text + "," + txt_birthday.Text + "," + txt_address.Text + "," + txt_phone.Text + "," + txt_password.Text + "," + cbb_role.Text;

            int index = lines.FindIndex(l => l.Split(',')[0] == txt_id.Text);

            if (index != -1)
            {
                lines[index] = lineToUpdate;
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                // Handle the case where the line does not exist
                MessageBox.Show("Line not found for updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "Close" button
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetMaxStaffId()
        {
            int maxStaffId = 0;

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length > 0)
                        {
                            int currentStaffId;
                            if (int.TryParse(parts[0], out currentStaffId))
                            {
                                maxStaffId = Math.Max(maxStaffId, currentStaffId);
                            }
                        }
                    }
                }
            }

            return maxStaffId;
        }

        // Validate if any of the required fields are empty
        private bool ValidateEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text) || string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_account.Text) ||
                string.IsNullOrWhiteSpace(txt_birthday.Text) || string.IsNullOrWhiteSpace(txt_address.Text) || string.IsNullOrWhiteSpace(txt_phone.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text) || string.IsNullOrWhiteSpace(cbb_role.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Validate the date format
        private bool ValidateDateFormat()
        {
            DateTime result;
            if (!DateTime.TryParseExact(txt_birthday.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                MessageBox.Show("Invalid date format. Please enter a valid date in the format dd/MM/yyyy.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Validate the phone number format
        private bool ValidatePhoneNumberFormat()
        {
            // Assuming a simple validation for numeric characters, adjust as needed
            if (!txt_phone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Invalid phone number format. Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
