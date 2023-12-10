namespace CoffeeShopManagement
{
    partial class fAbout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAbout));
            this.labelProjectName = new System.Windows.Forms.Label();
            this.labelDevelopers = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxFeature = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectName.Location = new System.Drawing.Point(12, 20);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(219, 20);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "Coffee Shop Management";
            // 
            // labelDevelopers
            // 
            this.labelDevelopers.AutoSize = true;
            this.labelDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevelopers.Location = new System.Drawing.Point(13, 60);
            this.labelDevelopers.Name = "labelDevelopers";
            this.labelDevelopers.Size = new System.Drawing.Size(277, 31);
            this.labelDevelopers.TabIndex = 1;
            this.labelDevelopers.Text = "Developers: Kris Dinh";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(603, 367);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(18, 105);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(660, 200);
            this.textBoxDescription.TabIndex = 6;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // checkBoxFeature
            // 
            this.checkBoxFeature.AutoSize = true;
            this.checkBoxFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFeature.Location = new System.Drawing.Point(19, 319);
            this.checkBoxFeature.Name = "checkBoxFeature";
            this.checkBoxFeature.Size = new System.Drawing.Size(140, 29);
            this.checkBoxFeature.TabIndex = 4;
            this.checkBoxFeature.Text = "Like it (^o^)";
            this.checkBoxFeature.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuItem1
            // 
            this.contextMenuItem1.Name = "contextMenuItem1";
            this.contextMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // contextMenuItem2
            // 
            this.contextMenuItem2.Name = "contextMenuItem2";
            this.contextMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // fAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 431);
            this.Controls.Add(this.checkBoxFeature);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelDevelopers);
            this.Controls.Add(this.labelProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Coffee Shop Management";
            this.Load += new System.EventHandler(this.fAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Label labelDevelopers;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxFeature;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem2;
    }
}
