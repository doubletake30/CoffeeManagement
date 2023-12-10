namespace CoffeeShopManagement
{
    partial class fGuest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.dataGridViewGuestList = new System.Windows.Forms.DataGridView();
            this.columnTableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxInputInfo = new System.Windows.Forms.GroupBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.textBoxTableID = new System.Windows.Forms.TextBox();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelTableID = new System.Windows.Forms.Label();
            this.labelTableName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestList)).BeginInit();
            this.groupBoxInputInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.dataGridViewGuestList);
            this.groupBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxList.Location = new System.Drawing.Point(3, 168);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(684, 171);
            this.groupBoxList.TabIndex = 3;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "List of Guests who Reserved Tables";
            // 
            // dataGridViewGuestList
            // 
            this.dataGridViewGuestList.AllowUserToAddRows = false;
            this.dataGridViewGuestList.AllowUserToDeleteRows = false;
            this.dataGridViewGuestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGuestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTableID,
            this.columnTableName,
            this.columnArea,
            this.columnProductName,
            this.columnQuantity});
            this.dataGridViewGuestList.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewGuestList.Name = "dataGridViewGuestList";
            this.dataGridViewGuestList.ReadOnly = true;
            this.dataGridViewGuestList.Size = new System.Drawing.Size(678, 145);
            this.dataGridViewGuestList.TabIndex = 0;
            this.dataGridViewGuestList.SelectionChanged += new System.EventHandler(this.dataGridViewGuestList_SelectionChanged);
            // 
            // columnTableID
            // 
            this.columnTableID.DataPropertyName = "TableID";
            this.columnTableID.HeaderText = "TableID";
            this.columnTableID.Name = "columnTableID";
            this.columnTableID.ReadOnly = true;
            // 
            // columnTableName
            // 
            this.columnTableName.DataPropertyName = "TableName";
            this.columnTableName.HeaderText = "Table Name";
            this.columnTableName.Name = "columnTableName";
            this.columnTableName.ReadOnly = true;
            // 
            // columnArea
            // 
            this.columnArea.DataPropertyName = "Area";
            this.columnArea.HeaderText = "Area";
            this.columnArea.Name = "columnArea";
            this.columnArea.ReadOnly = true;
            // 
            // columnProductName
            // 
            this.columnProductName.DataPropertyName = "ProductName";
            this.columnProductName.HeaderText = "Product Name";
            this.columnProductName.Name = "columnProductName";
            this.columnProductName.ReadOnly = true;
            // 
            // columnQuantity
            // 
            this.columnQuantity.DataPropertyName = "Quantity";
            this.columnQuantity.HeaderText = "Quantity";
            this.columnQuantity.Name = "columnQuantity";
            this.columnQuantity.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Blue;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(595, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxInputInfo
            // 
            this.groupBoxInputInfo.Controls.Add(this.textBoxQuantity);
            this.groupBoxInputInfo.Controls.Add(this.textBoxArea);
            this.groupBoxInputInfo.Controls.Add(this.textBoxTableName);
            this.groupBoxInputInfo.Controls.Add(this.textBoxTableID);
            this.groupBoxInputInfo.Controls.Add(this.comboBoxProductName);
            this.groupBoxInputInfo.Controls.Add(this.labelQuantity);
            this.groupBoxInputInfo.Controls.Add(this.labelArea);
            this.groupBoxInputInfo.Controls.Add(this.labelProductName);
            this.groupBoxInputInfo.Controls.Add(this.labelTableID);
            this.groupBoxInputInfo.Controls.Add(this.labelTableName);
            this.groupBoxInputInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInputInfo.Location = new System.Drawing.Point(3, 1);
            this.groupBoxInputInfo.Name = "groupBoxInputInfo";
            this.groupBoxInputInfo.Size = new System.Drawing.Size(681, 114);
            this.groupBoxInputInfo.TabIndex = 6;
            this.groupBoxInputInfo.TabStop = false;
            this.groupBoxInputInfo.Text = "Input Information";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(507, 68);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(112, 21);
            this.textBoxQuantity.TabIndex = 17;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(507, 29);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(112, 21);
            this.textBoxArea.TabIndex = 17;
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(265, 29);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(112, 21);
            this.textBoxTableName.TabIndex = 17;
            // 
            // textBoxTableID
            // 
            this.textBoxTableID.Location = new System.Drawing.Point(78, 29);
            this.textBoxTableID.Name = "textBoxTableID";
            this.textBoxTableID.Size = new System.Drawing.Size(112, 21);
            this.textBoxTableID.TabIndex = 17;
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(78, 68);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(299, 23);
            this.comboBoxProductName.TabIndex = 16;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(442, 71);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(51, 15);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(442, 32);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(32, 15);
            this.labelArea.TabIndex = 6;
            this.labelArea.Text = "Area";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(13, 71);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(49, 15);
            this.labelProductName.TabIndex = 5;
            this.labelProductName.Text = "Product";
            // 
            // labelTableID
            // 
            this.labelTableID.AutoSize = true;
            this.labelTableID.Location = new System.Drawing.Point(13, 32);
            this.labelTableID.Name = "labelTableID";
            this.labelTableID.Size = new System.Drawing.Size(53, 15);
            this.labelTableID.TabIndex = 8;
            this.labelTableID.Text = "Table ID";
            // 
            // labelTableName
            // 
            this.labelTableName.AutoSize = true;
            this.labelTableName.Location = new System.Drawing.Point(207, 32);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(38, 15);
            this.labelTableName.TabIndex = 7;
            this.labelTableName.Text = "Table";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(575, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 41);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(457, 121);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 41);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(338, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 41);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 402);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxInputInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBoxList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUEST RESERVATION";
            this.groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestList)).EndInit();
            this.groupBoxInputInfo.ResumeLayout(false);
            this.groupBoxInputInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.DataGridView dataGridViewGuestList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxInputInfo;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.TextBox textBoxTableID;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelTableID;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
    }
}
