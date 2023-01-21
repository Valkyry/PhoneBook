namespace SimplePhoneBook.UI
{
    partial class ReadForm
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
            this.contactGV = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactGV)).BeginInit();
            this.SuspendLayout();
            // 
            // contactGV
            // 
            this.contactGV.AllowUserToAddRows = false;
            this.contactGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactGV.Location = new System.Drawing.Point(12, 57);
            this.contactGV.Name = "contactGV";
            this.contactGV.Size = new System.Drawing.Size(869, 328);
            this.contactGV.TabIndex = 0;
            this.contactGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactGV_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(141, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(552, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 27);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Text = "نام";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(446, 12);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 27);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Text = "نام خانوادگی";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(340, 12);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 27);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.Text = "شماره همراه";
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephoneNumber.Location = new System.Drawing.Point(234, 12);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(100, 27);
            this.txtTelephoneNumber.TabIndex = 5;
            this.txtTelephoneNumber.Text = "شماره منزل";
            this.txtTelephoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 397);
            this.Controls.Add(this.txtTelephoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.contactGV);
            this.Name = "ReadForm";
            this.Text = "ReadForm";
            this.Load += new System.EventHandler(this.ReadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView contactGV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
    }
}