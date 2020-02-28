using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Academic_Library_Monitoring_System
{
    public partial class Admin : Form
    {
          MySqlConnection Connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=testing101");
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void jMaterialTextbox2_Load(object sender, EventArgs e)
        {

        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
            if (jMaterialTextbox1.Text == "" || jMaterialTextbox2.Text == "" || jMaterialTextbox3.Text == "" || jMaterialTextbox4.Text == "" || jMaterialTextbox5.Text == "")
            {
                MessageBox.Show("Blank Field. Fill up necessary Fields.");

            }
            else
            {
                string insertQuery = "INSERT INTO pizza.delivery(student-no,name,course,address,phone-no) VALUES('" + jMaterialTextbox1.Text + "','" + jMaterialTextbox2.Text + "','" + jMaterialTextbox3.Text + "','" + jMaterialTextbox4.Text + "','" + jMaterialTextbox5.Text + "')";
                Connect.Open();
                MySqlCommand test = new MySqlCommand(insertQuery, Connect);
            }
            try
            {
             
                if (test.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connect.Close();
        
         }
    }
}
