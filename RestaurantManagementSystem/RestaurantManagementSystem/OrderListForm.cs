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
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RequestForm request = new RequestForm();
            request.Show();
            this.Hide();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {

            Dat AB1 = new Dat();
            AB1.A = "SELECT * FROM OrderedFood";
            AB1.insert(AB1.A);

            bunifuCustomDataGrid1.DataSource = AB1.insert(AB1.A);
        }

        private void bunifuCustomDataGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try {
                DataGridViewCell cell = null;

                foreach (DataGridViewCell select in bunifuCustomDataGrid1.SelectedCells)
                {
                    cell = select;
                    break;
                }

                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;

                    txtname.Text = row.Cells[1].Value.ToString();

                    txtfoodtype.Text = row.Cells[2].Value.ToString();

                    txtprice.Text = row.Cells[3].Value.ToString();

                    txtfood.Text = row.Cells[4].Value.ToString();

                    txtquantity.Text = row.Cells[5].Value.ToString();

                    txtnumber.Text = row.Cells[6].Value.ToString();




                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {


                if (rdb.Checked == true)
                {


                    Dat AB1 = new Dat();
                    AB1.A = "update OrderedFood set Order_Placed = 'Order placed' where Customer_Name ='" + txtname.Text + "' ";
                    AB1.insert(AB1.A);


                    Dat a = new Dat();
                    a.A = "insert into Finance (Customer_Name,Food_Type,Price,Food,Quantity,Table_Number) values ('" + txtname.Text + "','" + txtfoodtype.Text + "','"+txtprice.Text+"','" + txtfood.Text + "','" + txtquantity.Text + "','" + txtnumber.Text + "')";
                    a.insert(a.A);

                    Dat AB = new Dat();
                    AB.A = "select * from OrderedFood'";
                    AB.insert(AB.A);

                    bunifuCustomDataGrid1.DataSource = AB.insert(AB.A);

                    MessageBox.Show("Order placed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }
        }
    }
}
