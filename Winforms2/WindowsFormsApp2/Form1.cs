using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<string> contacts;
        public Form1()
        {
            InitializeComponent();
            contacts = new List<string>();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;

            string contactInfo = $"Name: {name} Phone: {phone} Email: {email}"; 
            contacts.Add(contactInfo);

            listBoxContacts.Items. Add(contactInfo);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
        }

        private void Numbersonly(object sender, KeyPressEventArgs e)
        {
            char numOnly = e.KeyChar;

            if (!char.IsDigit(numOnly) && numOnly != 8)
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && textBoxPhone.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }
    }
}
