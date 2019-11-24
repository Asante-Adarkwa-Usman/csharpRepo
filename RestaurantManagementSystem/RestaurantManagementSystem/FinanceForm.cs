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
    public partial class FinanceForm : Form
    {
        public FinanceForm()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FinanceForm_Load(object sender, EventArgs e)
        {
            Dat d = new Dat();
            d.A = "select * from Finance";
            d.insert(d.A);

            bunifuCustomDataGrid1.DataSource = d.insert(d.A);

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void txtfootp_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {



        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try { 

            //  bunifuCustomDataGrid1.DataSource = AB.insert(AB.A);


            int C = int.Parse(txtprice.Text);

            int d = int.Parse(txtquantity.Text);

            String f = txttotal.Text;

            txttotal.Text = (C * d).ToString();


            DialogResult y = MessageBox.Show("Do want to add to records ?", "info", MessageBoxButtons.YesNo);

            if (y == DialogResult.Yes)
            {

            Dat AB = new Dat();
                AB.A = "update Finance set Price = '"+txtprice.Text+"', Total_Price = '" + txttotal.Text + "' where Customer_Name = '"+txtcust.Text+"' ";
                AB.insert(AB.A);

        // bunifuCustomDataGrid1.DataSource = AB.insert(AB.A);

           
            }


            Dat AB1 = new Dat();
            AB1.A = "SELECT * FROM Finance";
            AB1.insert(AB1.A);

            bunifuCustomDataGrid1.DataSource = AB1.insert(AB1.A);

            MessageBox.Show("Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }

        }

        private void txtnumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            RequestForm re = new RequestForm();
            re.Show();
            this.Hide();
        }

        private void txtfood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtfoodtype_SelectionChangeCommitted(object sender, EventArgs e)
        {
         

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {

                OleDbConnection con = new OleDbConnection();
                //  OleDbConnection con1 = new OleDbConnection();



                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";
                // con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";


                con.Open();
                // con1.Open();

                OleDbCommand command = new OleDbCommand();
                //OleDbCommand command1 = new OleDbCommand();


                command.Connection = con;
                // command1.Connection = con1;


                //  String query = "SELECT Price FROM Foods WHERE Food = '"+comboBox1.Text+"'";

                // command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    // comboBox1.Items.Add(reader["Food"].ToString() + " " + reader["Price"].ToString());
                    // txtfood1.Text = reader["Food"].ToString();

                    // txtamount.Text = reader["Price"].ToString();


                }

                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }


        }

        private void txtprice_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void txtamount_OnValueChanged(object sender, EventArgs e)
        {
            


            
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtnumber_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txttotal_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txttotal_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtprice_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void txtamount_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try {

                Dat d = new Dat();
                d.A = "select * from Finance where Customer_Name = '" + txtcust.Text + "'";
                d.insert(d.A);


                bunifuCustomDataGrid1.DataSource = d.insert(d.A);


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

                    txtfood.Text = row.Cells[3].Value.ToString();

                    txtprice.Text = row.Cells[4].Value.ToString();

                    txtquantity.Text = row.Cells[5].Value.ToString();

                    txttotal.Text = row.Cells[6].Value.ToString();


                }

            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            } 

        }
    }




}
