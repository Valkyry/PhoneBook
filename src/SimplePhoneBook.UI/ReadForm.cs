using SimplePhoneBook.Domain.Entities;
using SimplePhoneBook.Domain.Interfaces;
using SimplePhoneBook.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePhoneBook.UI
{
    public partial class ReadForm : Form
    {
        protected readonly IAppContext<Contact, Guid> _context;

        public ReadForm()
        {
            InitializeComponent();

            _context = InstanceFactory.GetInstance<IAppContext<Contact, Guid>>(ConfigurationManager.ConnectionStrings["SPBConnection"].ConnectionString);
        }

        private void ReadForm_Load(object sender, EventArgs e)
        {
            CreateDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) || !string.IsNullOrEmpty(txtLastName.Text) || !string.IsNullOrEmpty(txtPhoneNumber.Text) || !string.IsNullOrEmpty(txtTelephoneNumber.Text))
            {
                contactGV.DataSource = _context.Generic.Get(row => row.FirstName == txtFirstName.Text || row.LastName == txtLastName.Text || row.PhoneNumber == txtPhoneNumber.Text || row.TelephoneNumber == txtTelephoneNumber.Text);
            }
            else
                contactGV.DataSource = _context.Generic.Get();
        }

        private void contactGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (senderGrid.SelectedCells[0].OwningColumn.Name == "btnEdit")
                {
                    EditForm.Id = (Guid)GetIdFromDataGridView(senderGrid);
                    new EditForm(this).Show();
                }

                if (senderGrid.SelectedCells[0].OwningColumn.Name == "btnDelete")
                {
                    var entity = _context.Generic.Get((Guid)GetIdFromDataGridView(senderGrid));
                    _context.Generic.Delete(entity);
                    var ret = _context.Commit();
                    if (!ret)
                    {
                        MessageBox.Show("خطا در حذف");
                    }
                    else
                        RefreshDataGridView();
                }
            }

        }

        public void RefreshDataGridView()
        {
            this.Close();
            new ReadForm().Show();
        }

        private void CreateDataGridView()
        {
            contactGV.ColumnCount = 7;
            contactGV.Columns[0].HeaderText = "نام";
            contactGV.Columns[0].DataPropertyName = "FirstName";
            contactGV.Columns[0].Name = "FirstName";

            contactGV.Columns[1].HeaderText = "نام خانوادگی";
            contactGV.Columns[1].DataPropertyName = "LastName";
            contactGV.Columns[1].Name = "LastName";

            contactGV.Columns[2].HeaderText = "شماره همراه";
            contactGV.Columns[2].DataPropertyName = "PhoneNumber";
            contactGV.Columns[2].Name = "PhoneNumber";

            contactGV.Columns[3].HeaderText = "شماره منزل";
            contactGV.Columns[3].DataPropertyName = "TelephoneNumber";
            contactGV.Columns[3].Name = "TelephoneNumber";

            contactGV.Columns[4].Name = "ID";
            contactGV.Columns[4].DataPropertyName = "ID";
            contactGV.Columns[4].Visible = false;

            contactGV.Columns[5].HeaderText = "زمان ساخت";
            contactGV.Columns[5].DataPropertyName = "CreateDate";
            contactGV.Columns[5].Name = "CreateDate";

            contactGV.Columns[6].HeaderText = "زمان اخرین تغییر";
            contactGV.Columns[6].DataPropertyName = "LastModifiedDate";
            contactGV.Columns[6].Name = "LastModifiedDate";

            contactGV.DataSource = _context.Generic.Get();


            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            contactGV.Columns.Add(btnEdit);
            btnEdit.HeaderText = "";
            btnEdit.Text = "ویرایش";
            btnEdit.Name = "btnEdit";
            btnEdit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            contactGV.Columns.Add(btnDelete);
            btnDelete.HeaderText = "";
            btnDelete.Text = "حذف";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;
        }

        private object GetIdFromDataGridView(DataGridView dataGridView)
        {
            var cell = dataGridView.SelectedCells;
            return dataGridView.Rows[cell[0].RowIndex].Cells[4].Value;
        }
    }
}
