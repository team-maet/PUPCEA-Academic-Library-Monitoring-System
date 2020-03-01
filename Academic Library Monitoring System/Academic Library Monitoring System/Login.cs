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
    public partial class Login : Form
    {
        MySqlConnection Connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=phpMAImmature23;database=pupcea_academic_library_monitoring_system");

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Submit_Click(object sender, EventArgs e)
        {
            //if (textUsername.Text == "" || textUsername.Text == "(e.g.) juandelacruz09" || textPassword.Text == "" || textPassword.Text == "aaaaaaaa")
            //{
            //    MessageBox.Show("Blank Field. Fill up necessary Fields.");
            //}
            //else
            //{
            //}

            DB db = new DB();

            String username = textUsername.Text;
            String password = textPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user_data` WHERE `username` = @usn and `password` = @pass", db.getConnect());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("NO");
            }

            //mesage box if you want to borrow book.
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
