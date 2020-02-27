using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Academic_Library_Monitoring_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Submit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to borrow a book", "BORROW", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Borrow Borrow = new Borrow();
                Borrow.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("You have login successfully");

                this.Hide();
                Home Home = new Home();
                Home.ShowDialog();
            }
        }

        private void buttonLogin_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Home = new Home();
            Home.ShowDialog();
        }

        private void textUsername_Enter(object sender, EventArgs e)
        {
            if (textUsername.Text == "(e.g.) juandelacruz09")
            {
                textUsername.Text = "";
            }
        }

        private void textUsername_Leave(object sender, EventArgs e)
        {
            if (textUsername.Text == "")
            {
                textUsername.Text = "(e.g.) juandelacruz09";
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textUsername.Text == "********")
            {
                textUsername.Text = "";
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textUsername.Text == "")
            {
                textUsername.Text = "********";
            }
        }
    }
}
