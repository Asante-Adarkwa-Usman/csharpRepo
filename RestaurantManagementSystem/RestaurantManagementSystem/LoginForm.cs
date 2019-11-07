using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Your username field cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtUsername.Focus();
            }else if (txtPassword.Text == "")
            {
                MessageBox.Show("Your password field  cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtUsername.Focus();
            }
            else
            {

                MessageBox.Show("You have successfully signed in", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminForm admin = new AdminForm();
                admin.Show();
                this.Hide();


            }




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            SignUp newSignup = new SignUp();
            newSignup.Show();
            this.Hide();
        }
    }
}
