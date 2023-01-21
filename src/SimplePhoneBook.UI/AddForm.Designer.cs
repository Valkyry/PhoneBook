namespace SimplePhoneBook.UI
{
    partial class AddForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 21);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "نام";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 116);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(151, 32);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(12, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(151, 21);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "نام خانوادگی";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 64);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(151, 21);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.Text = "شماره همراه";
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephoneNumber.Location = new System.Drawing.Point(12, 90);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(151, 21);
            this.txtTelephoneNumber.TabIndex = 3;
            this.txtTelephoneNumber.Text = "شماره منزل";
            this.txtTelephoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 154);
            this.Controls.Add(this.txtTelephoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtName);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
    }
}