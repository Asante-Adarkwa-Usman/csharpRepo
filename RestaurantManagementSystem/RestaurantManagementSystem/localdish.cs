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
    public partial class localdish : UserControl
    {
        public localdish()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCustSubmit_Click(object sender, EventArgs e)
        {
            try {


                if (rdbEtor.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Local','Etor','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbBanku.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Local','Banku and Okro Stew','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbFufu.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Local','Fufu and groundnut soup','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Success");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();


                }

                if (rdbYam.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Local','Yam and stew','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                    AB.insert(AB.A);
                    MessageBox.Show("Food Successfully ordered");
                    txtCustName.ResetText();
                    txtCustQnty.ResetText();
                    txtCustTable.ResetText();

                }

                if (rdbWaakye.Checked)
                {
                    Dat AB = new Dat();
                    AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Local','Waakye','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
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
