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
    public partial class LoginForm_main : Form
    {
        public LoginForm_main()
        {
            InitializeComponent();
        }

        private void LoginForm_main_Load(object sender, EventArgs e)
        {
            txtLogUser.HintText = "Username";
            
            txtLogPass.HintText = "Password";

            txtLogPass.isPassword = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

              if (txtLogUser.Text == " ")
            {
                MessageBox.Show("Username field cannot be empty ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtLogPass.Text == " ")
            {
                MessageBox.Show("Password field cannot be empty ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtLogUser.Text == " " && txtLogPass.Text == " ")
            {
                MessageBox.Show("Username and password fields cannot be empty ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else {
           
           
             
                //Login as Admin

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM Signup WHERE Job_Status = 'Admin' and Username = '" + txtLogUser.Text + "' and Passcode = '" + txtLogPass.Text + "' ";

                OleDbDataReader reader = command.ExecuteReader();
                command.CommandText = "INSERT INTO Login ( Username, Passcode, Job_Status) VALUES('" + txtLogUser.Text + "','" + txtLogPass.Text + "', 'Admin')";

                int counter = 0;   //provides the number of items in the database
                while (reader.Read())
                {
                    counter += 1;
                }
                if (counter == 1)
                {
                    MessageBox.Show(" Admin Login successful");
                    AdminForm administrator = new AdminForm();
                    administrator.Show();
                    this.Hide();
                    con.Close();

                }


                // Login as Chef

                OleDbConnection Con = new OleDbConnection();
                Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";
                Con.Open();
                OleDbCommand Command = new OleDbCommand();
                Command.Connection = Con;
                Command.CommandText = "SELECT * FROM Signup WHERE Job_Status = 'Chef'  and Username = '" + txtLogUser.Text + "' and Passcode = '" + txtLogPass.Text + "' ";

                OleDbDataReader read = Command.ExecuteReader();
                Command.CommandText = "INSERT INTO Login ( Username, Passcode, Job_Status) VALUES('" + txtLogUser.Text + "','" + txtLogPass.Text + "', 'Chef')";

                int count = 0;  //provides the number of items in the database
                while (read.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Chef login successful");
                    OrderListForm order = new OrderListForm();
                    order.Show();
                    this.Hide();
                    Con.Close();
                }


                // Login as Finance

                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";
                conn.Open();
                OleDbCommand commands = new OleDbCommand();
                commands.Connection = conn;
                commands.CommandText = "SELECT * FROM Signup WHERE Job_Status = 'Finance'  and Username = '" + txtLogUser.Text + "' and Passcode = '" + txtLogPass.Text + "' ";
            
                OleDbDataReader R = commands.ExecuteReader();
                commands.CommandText = "INSERT INTO Login ( Username, Passcode, Job_Status) VALUES('" + txtLogUser.Text + "','" + txtLogPass.Text + "', 'Finance')";
               
                int Count_Num = 0;  //provides the number of items in the database
                while (R.Read())
                {
                    Count_Num += 1;
                }
                if (Count_Num == 1)
                {
                    MessageBox.Show("Accountant login successful");

                    FinanceForm finance = new FinanceForm();
                    finance.Show();
                    this.Hide();
                    con.Close();
                }


            }



        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            SignUp newSignup = new SignUp();
            newSignup.Show();
            this.Hide();
        }

        private void txtlogPassword_MouseEnter(object sender, EventArgs e)
        {
            txtLogPass.isPassword = true;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            RequestForm re = new RequestForm();
            re.Show();
            this.Hide();
        }

        private void txtLogPass_OnValueChanged(object sender, EventArgs e)
        {
            txtLogPass.isPassword = true;
        }

        private void txtLogUser_TextChanged(object sender, EventArgs e)
        {
            txtLogUser.Focus();
        }
    }
}
