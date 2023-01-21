namespace SimplePhoneBook.UI
{
    partial class EditForm
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
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephoneNumber.Location = new System.Drawing.Point(12, 90);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(151, 21);
            this.txtTelephoneNumber.TabIndex = 8;
            this.txtTelephoneNumber.Text = "شماره منزل";
            this.txtTelephoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 64);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(151, 21);
            this.txtPhoneNumber.TabIndex = 7;
            this.txtPhoneNumber.Text = "شماره همراه";
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(12, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(151, 21);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.Text = "نام خانوادگی";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 116);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(151, 32);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 21);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "نام";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 153);
            this.Controls.Add(this.txtTelephoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtName);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtName;
    }
}