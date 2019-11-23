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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try {

                if (txtLogUser.Text.Length == 0)
                {
                    MessageBox.Show("Username field cannot be empty ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtLogPass.Text.Length == 0)
                {
                    MessageBox.Show("Password field cannot be empty ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtLogUser.Text.Length == 0 && txtLogPass.Text.Length == 0)
                {
                    MessageBox.Show("Username and password fields cannot be empty ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {



                    //Login as Admin

                    OleDbConnection con = new OleDbConnection();
                    OleDbConnection con1 = new OleDbConnection();



                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";
                    con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";


                    con.Open();
                    con1.Open();

                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand command1 = new OleDbCommand();


                    command.Connection = con;
                    command1.Connection = con1;


                    command.CommandText = "SELECT * FROM Signup WHERE Job_Status = 'Admin' and Username = '" + txtLogUser.Text + "' and Passcode = '" + txtLogPass.Text + "' ";

                    OleDbDataReader reader = command.ExecuteReader();


                    command1.CommandText = "INSERT INTO Login ( Username, Passcode, Job_Status) VALUES('" + txtLogUser.Text + "','" + txtLogPass.Text + "', 'Admin')";
                    OleDbDataReader re = command1.ExecuteReader();



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
                    OleDbConnection Con1 = new OleDbConnection();




                    Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";
                    Con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";




                    Con.Open();
                    Con1.Open();


                    OleDbCommand Command = new OleDbCommand();
                    OleDbCommand Command1 = new OleDbCommand();

                    Command.Connection = Con;
                    Command1.Connection = Con1;



                    Command.CommandText = "SELECT * FROM Signup WHERE Job_Status = 'Chef'  and Username = '" + txtLogUser.Text + "' and Passcode = '" + txtLogPass.Text + "' ";

                    OleDbDataReader read = Command.ExecuteReader();

                    Command1.CommandText = "INSERT INTO Login ( Username, Passcode, Job_Status) VALUES('" + txtLogUser.Text + "','" + txtLogPass.Text + "', 'Chef')";

                    OleDbDataReader readers = Command1.ExecuteReader();

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
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }
        }
    }
}
