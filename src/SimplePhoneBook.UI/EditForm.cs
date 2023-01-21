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
    public partial class EditForm : Form
    {
        public static Guid Id;
        protected readonly IAppContext<Contact, Guid> _context;
        ReadForm readForm;
        public EditForm(ReadForm readForm)
        {
            InitializeComponent();

            _context = InstanceFactory.GetInstance<IAppContext<Contact, Guid>>(ConfigurationManager.ConnectionStrings["SPBConnection"].ConnectionString);
            this.readForm = readForm;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            var entity = _context.Generic.Get(Id);

            txtName.Text = entity.FirstName;
            txtLastName.Text = entity.LastName;
            txtPhoneNumber.Text = entity.PhoneNumber;
            txtTelephoneNumber.Text = entity.TelephoneNumber;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _context.Generic.Update(new Contact
            {
                ID = Id,
                FirstName = txtName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                TelephoneNumber = txtTelephoneNumber.Text
            });

            var ret = _context.Commit();
            if (!ret)
                MessageBox.Show("خطای اپدیت");
            else
                this.Close();
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            readForm.RefreshDataGridView();
        }
    }
}
