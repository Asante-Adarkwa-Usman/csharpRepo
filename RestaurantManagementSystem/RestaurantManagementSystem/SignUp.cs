using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem/Restaurant.accdb";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "insert into Signup (First_Name, Last_Name, Username, Password) values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + adminUsername.Text + "','" + adminPass.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Success");
            connection.Close();




            if (adminUsername.Text == "")
            {
                MessageBox.Show("Your username field cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else if (adminPass.Text == "")
            {
                MessageBox.Show("Your password field  cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminPass.ResetText();
                adminPass.HintText = "Password";
            }
            else if (adminConPass.Text == "")
            {
                MessageBox.Show("Make sure that your password matches the previous one and it's not empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminConPass.ResetText();
                adminConPass.HintText = "Confirm Password";
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
                else if (adminPass.Text.Length != adminConPass.Text.Length)
                {
                    MessageBox.Show("Your password does not match the previous one, try again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {

                }


            }


        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            LoginForm newLogin = new LoginForm();
            newLogin.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            adminUsername.HintText = "Username";
            adminConPass.HintText = "Confirm Password";
            adminPass.HintText = "Password";
            txtFirstName.HintText = "First Name";
            txtLastName.HintText = "Last Name";
            adminConPass.isPassword = true;
            adminPass.isPassword = true;

        }

        private void adminUsername_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void adminConPass_OnValueChanged(object sender, EventArgs e)
        {



        }

        private void adminPass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void adminUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminConPass_MouseEnter(object sender, EventArgs e)
        {
            adminConPass.isPassword = true;
            adminPass.isPassword = true;
        }
    }
}
