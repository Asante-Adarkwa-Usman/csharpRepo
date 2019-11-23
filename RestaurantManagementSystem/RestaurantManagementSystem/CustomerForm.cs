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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void txtCustPrice_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCustQnty_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCustSubmit_Click(object sender, EventArgs e)
        {
            


















              
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    bunifuTransition1.ShowSync(localdish1);
                    bunifuTransition1.HideSync(drinks1);
                    bunifuTransition1.HideSync(continental1);
                    bunifuTransition1.HideSync(dessert11);
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    bunifuTransition1.ShowSync(drinks1);
                    bunifuTransition1.HideSync(localdish1);
                    bunifuTransition1.HideSync(continental1);
                    bunifuTransition1.HideSync(dessert11);
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    bunifuTransition1.ShowSync(continental1);
                    bunifuTransition1.HideSync(localdish1);
                    bunifuTransition1.HideSync(drinks1);
                    bunifuTransition1.HideSync(dessert11);

                }

                if (comboBox1.SelectedIndex == 3)
                {
                    bunifuTransition1.ShowSync(dessert11);
                    bunifuTransition1.HideSync(localdish1);
                    bunifuTransition1.HideSync(drinks1);
                    bunifuTransition1.HideSync(continental1);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }
          
        }

        private void continental1_Load(object sender, EventArgs e)
        {
           
        }

        private void dessert11_Load(object sender, EventArgs e)
        {

        }
    }
}
