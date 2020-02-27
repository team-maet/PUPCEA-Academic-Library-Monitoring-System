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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logout Logout = new Logout();
            Logout.ShowDialog();
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
