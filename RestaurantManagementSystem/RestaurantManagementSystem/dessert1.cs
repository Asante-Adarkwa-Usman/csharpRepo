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
    public partial class dessert1 : UserControl
    {
        public dessert1()
        {
            InitializeComponent();
        }

        private void btnCustSubmit_Click(object sender, EventArgs e)
        {
            try {

                if (rdbChips.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Dessert','Chips','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbKele.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Dessert','Kelewele','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbCake.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Dessert','Cake','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();


                }

                if (rdbPie.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Dessert','Meat Pie','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbDouNut.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Dessert','Dough Nut','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
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
