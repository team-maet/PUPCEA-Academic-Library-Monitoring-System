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
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void buttonLogout_Submit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You have logout successfully");

            this.Hide();
            Home Home = new Home();
            Home.ShowDialog();
        }

        private void buttonLogout_Back_Click(object sender, EventArgs e)
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
