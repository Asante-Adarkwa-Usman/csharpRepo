using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Continental : UserControl
    {
        public Continental()
        {
            InitializeComponent();
        }

        private void btnCustSubmit_Click(object sender, EventArgs e)
        {
            try {

                if (rdbFried.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Continental','Fried Rice','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbSushi.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Continental','Sushi','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbRamen.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Continental','Ramen','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();


                }

                if (rdbKebab.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Continental','Kebab','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbFrench.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Continental','French Rice','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }
        }
    }
}
