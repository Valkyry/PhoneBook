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
    public partial class AddForm : Form
    {
        protected readonly IAppContext<Contact, Guid> _context;

        public AddForm()
        {
            InitializeComponent();

            _context = InstanceFactory.GetInstance<IAppContext<Contact, Guid>>(ConfigurationManager.ConnectionStrings["SPBConnection"].ConnectionString);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                ID = Guid.NewGuid(),
                FirstName = txtName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                TelephoneNumber = txtTelephoneNumber.Text
            };

            _context.Generic.Add(contact);
            var ret = _context.Commit();
            if (!ret)
                MessageBox.Show("خطای دیتابیسی");
            else
                this.Close();
        }
    }
}
