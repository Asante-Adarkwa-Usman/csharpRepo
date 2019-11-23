using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace RestaurantManagementSystem
{
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string code = "1234";
            string inp = Interaction.InputBox("Enter Staff Passcode ", "SECURITY", "0000");

            if(inp == code)
            {
                MessageBox.Show("Staff verified, Access Granted");
                LoginForm_main login = new LoginForm_main();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Access Denied ");
                this.Show();

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code = "1234";
           string inp = Interaction.InputBox("Enter Staff Passcode ","SECURITY","0000");
            if (inp == code)
            {
                MessageBox.Show("Staff verified, Access Granted");
                LoginForm_main login = new LoginForm_main();
                login.Show();
                this.Hide();
            }else
            {
                MessageBox.Show(" Access Denied ");
                this.Show();

            }
        }

        private void btnFinane_Click(object sender, EventArgs e)
        {
            string code = "1234";
            string inp = Interaction.InputBox("Enter Staff Passcode ", "SECURITY", "0000");

            if (inp == code)
            {
                MessageBox.Show("Staff verified, Access Granted");
                LoginForm_main login = new LoginForm_main();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Access Denied ");
                this.Show();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            DialogResult exitMsg = MessageBox.Show("Are you sure you want to exit ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitMsg == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
