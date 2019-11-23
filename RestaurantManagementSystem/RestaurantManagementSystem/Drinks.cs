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
    public partial class Drinks : UserControl
    {
        public Drinks()
        {
            InitializeComponent();
        }

        private void btnCustSubmit_Click(object sender, EventArgs e)
        {
            try {

                if (rdbSobolo.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Drinks','Sobolo','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbBottle.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Drinks','Bottled Water','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbPalm.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Drinks','Palm Wine','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();


                }

                if (rdbPito.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Drinks','Pito','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbShamp.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Drinks','Shampaign','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
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
