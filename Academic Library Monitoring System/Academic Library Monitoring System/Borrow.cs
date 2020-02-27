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
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void buttonBorrow_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
        }

        private void buttonBorrow_Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please go to the admin to leave your ID and claim the book.", "Successful Login");

            this.Hide();
            Home Home = new Home();
            Home.ShowDialog();
        }
    }
}
