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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved_1(object sender, SplitterEventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            txtfname.HintText = "First name";
            txtsecondname.HintText = "Second name";
            txtsala.HintText = "Salary";
            txttele.HintText = "telephone number";


            Dat f = new Dat();
            f.A = "select * from Admin";

            f.insert(f.A);

        }

        private void txtstatus_MouseEnter(object sender, EventArgs e)
        {
            txtstatus.ResetText();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(rdbmale.Checked == false & rdbfemale.Checked == false)
            {
                MessageBox.Show("Please select gender");
            }



           else if(rdbmale.Checked == true)
            {
                Dat d = new Dat();
                d.A = "insert into Admin (FirstName,SecondName,Salary,Telephone,DOB,Employment_Status,Gender) values ('" + txtfname.Text + "','" + txtsecondname.Text + "','"+txtsala.Text+"','" + txttele.Text + "','" + txtdob.Text + "','" + txtstatus.Text + "','Male')";

                d.insert(d.A);

              // bunifuCustomDataGrid1.DataSource = d.insert(d.A);

                MessageBox.Show("success");


                //Dat f = new Dat();
                //f.A = "select * from Admin ";

                //bunifuCustomDataGrid1.DataSource = f.insert(f.A);

                

            }




          else  if (rdbfemale.Checked == true)
            {
                Dat z = new Dat();
                z.A = "insert into Admin (FirstName,SecondName,Salary,Telephone,DOB,Employment_Status,Gender) values ('" + txtfname.Text + "','" + txtsecondname.Text + "','" + txtsala.Text + "','" + txttele.Text + "','" + txtdob.Text + "','" + txtstatus.Text + "','Female')";

                z.insert(z.A);

             //  bunifuCustomDataGrid1.DataSource = z.insert(z.A);

                MessageBox.Show("success");



                //Dat fz = new Dat();
                //fz.A = "select * from Admin ";

                //bunifuCustomDataGrid1.DataSource = fz.insert(fz.A);

            }








        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                Dat f = new Dat();
                f.A = "select * from Admin ";

                bunifuCustomDataGrid1.DataSource = f.insert(f.A);

            }
        }
    }
}
