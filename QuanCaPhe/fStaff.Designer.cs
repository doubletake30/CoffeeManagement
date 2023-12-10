namespace CoffeeShopManagement
{
    partial class fStaff
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
            this.grb_ttnd = new System.Windows.Forms.GroupBox();
            this.pnl_ttnd = new System.Windows.Forms.Panel();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsnd = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenquyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_ttnd.SuspendLayout();
            this.pnl_ttnd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnd)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_ttnd
            // 
            this.grb_ttnd.Controls.Add(this.pnl_ttnd);
            this.grb_ttnd.Controls.Add(this.btn_delete);
            this.grb_ttnd.Controls.Add(this.btn_fix);
            this.grb_ttnd.Controls.Add(this.btn_add);
            this.grb_ttnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ttnd.Location = new System.Drawing.Point(6, 8);
            this.grb_ttnd.Name = "grb_ttnd";
            this.grb_ttnd.Size = new System.Drawing.Size(268, 510);
            this.grb_ttnd.TabIndex = 0;
            this.grb_ttnd.TabStop = false;
            this.grb_ttnd.Text = "Info User";
            // 
            // pnl_ttnd
            // 
            this.pnl_ttnd.Controls.Add(this.cbb_role);
            this.pnl_ttnd.Controls.Add(this.txt_phone);
            this.pnl_ttnd.Controls.Add(this.txt_address);
            this.pnl_ttnd.Controls.Add(this.txt_birthday);
            this.pnl_ttnd.Controls.Add(this.txt_password);
            this.pnl_ttnd.Controls.Add(this.txt_account);
            this.pnl_ttnd.Controls.Add(this.txt_id);
            this.pnl_ttnd.Controls.Add(this.txt_name);
            this.pnl_ttnd.Controls.Add(this.label5);
            this.pnl_ttnd.Controls.Add(this.label7);
            this.pnl_ttnd.Controls.Add(this.label6);
            this.pnl_ttnd.Controls.Add(this.label4);
            this.pnl_ttnd.Controls.Add(this.label3);
            this.pnl_ttnd.Controls.Add(this.label2);
            this.pnl_ttnd.Controls.Add(this.label8);
            this.pnl_ttnd.Controls.Add(this.label1);
            this.pnl_ttnd.Location = new System.Drawing.Point(3, 21);
            this.pnl_ttnd.Name = "pnl_ttnd";
            this.pnl_ttnd.Size = new System.Drawing.Size(264, 446);
            this.pnl_ttnd.TabIndex = 4;
            // 
            // cbb_role
            // 
            this.cbb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.ItemHeight = 16;
            this.cbb_role.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cbb_role.Location = new System.Drawing.Point(31, 402);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(190, 24);
            this.cbb_role.TabIndex = 18;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(31, 351);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(190, 22);
            this.txt_phone.TabIndex = 6;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(31, 273);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(190, 56);
            this.txt_address.TabIndex = 5;
            // 
            // txt_birthday
            // 
            this.txt_birthday.Location = new System.Drawing.Point(31, 229);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(190, 22);
            this.txt_birthday.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(31, 185);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(190, 22);
            this.txt_password.TabIndex = 3;
            // 
            // txt_account
            // 
            this.txt_account.Location = new System.Drawing.Point(31, 138);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(190, 22);
            this.txt_account.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(31, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(190, 22);
            this.txt_id.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(31, 90);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(190, 22);
            this.txt_name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "User account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(171, 473);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 31);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Location = new System.Drawing.Point(90, 473);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(75, 31);
            this.btn_fix.TabIndex = 3;
            this.btn_fix.Text = "Fix";
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(9, 473);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 31);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsnd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(280, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List user";
            // 
            // dgv_dsnd
            // 
            this.dgv_dsnd.AllowUserToAddRows = false;
            this.dgv_dsnd.AllowUserToDeleteRows = false;
            this.dgv_dsnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.tendangnhap,
            this.ngaysinh,
            this.diachi,
            this.dienthoai,
            this.matkhau,
            this.tenquyen});
            this.dgv_dsnd.Location = new System.Drawing.Point(5, 21);
            this.dgv_dsnd.Name = "dgv_dsnd";
            this.dgv_dsnd.ReadOnly = true;
            this.dgv_dsnd.Size = new System.Drawing.Size(843, 483);
            this.dgv_dsnd.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Blue;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(1018, 524);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(103, 31);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Exit";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "ID";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Name";
            this.tennv.Name = "tennv";
            this.tennv.ReadOnly = true;
            // 
            // tendangnhap
            // 
            this.tendangnhap.DataPropertyName = "tendangnhap";
            this.tendangnhap.HeaderText = "User Account";
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Birthday";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Address";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "Phone";
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.ReadOnly = true;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Password";
            this.matkhau.Name = "matkhau";
            this.matkhau.ReadOnly = true;
            // 
            // tenquyen
            // 
            this.tenquyen.DataPropertyName = "phanquyen";
            this.tenquyen.HeaderText = "Role";
            this.tenquyen.Name = "tenquyen";
            this.tenquyen.ReadOnly = true;
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 567);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_ttnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLOYEE MANEGMENT";
            this.grb_ttnd.ResumeLayout(false);
            this.pnl_ttnd.ResumeLayout(false);
            this.pnl_ttnd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ttnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_dsnd;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Panel pnl_ttnd;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_birthday;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenquyen;
    }
}