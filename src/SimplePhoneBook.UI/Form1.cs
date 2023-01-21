using SimplePhoneBook.Domain.Entities;
using SimplePhoneBook.Domain.Interfaces;
using SimplePhoneBook.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePhoneBook.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddForm().Show();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            new ReadForm().Show();
        }
    }
}
