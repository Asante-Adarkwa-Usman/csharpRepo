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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            adminUsername.Focus();
        }

        private void adminPass_TextChanged(object sender, EventArgs e)
        {
            adminPass.Focus();
        }

        private void adminConPass_TextChanged(object sender, EventArgs e)
        {
            adminConPass.Focus();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (adminUsername.Text == "")
            {
                MessageBox.Show("Your username field cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminUsername.Clear();
                adminUsername.Focus();
            }
            else if (adminPass.Text == "")
            {
                MessageBox.Show("Your password field  cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminPass.Clear();
                adminPass.Focus();
            }
            else if (adminConPass.Text == "")
            {
                MessageBox.Show("Make sure that your password matches the previous one and it's not empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminConPass.Clear();
                adminConPass.Focus();
            }
            else
            {

                if (adminPass.Text.Length == adminConPass.Text.Length)
                {
                    MessageBox.Show("You have successfully created an admin account,Let's get you sign in", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Your password does not match the previous one, try again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adminConPass.Clear();
                    adminConPass.Focus();

                }


            }








        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            LoginForm newLogin = new LoginForm();
            newLogin.Show();
            this.Hide();
        }
    }
}
