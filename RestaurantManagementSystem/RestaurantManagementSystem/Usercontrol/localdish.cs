﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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


              

                Dat AB = new Dat();
                AB.A = "INSERT INTO OrderedFood(Customer_Name, Food_Type,Price,Food,Quantity,Table_Number) VALUES('" + txtCustName.Text + "','Local','" + txtprice.Text + "','" + comboBox1.Text+"','" + txtCustQnty.Text + "','" + txtCustTable.Text + "')";
                AB.insert(AB.A);
                MessageBox.Show("Food Successfully ordered");
                txtCustName.ResetText();
                txtCustQnty.ResetText();
                txtCustTable.ResetText();


            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();

            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";

            conn.Open();

            OleDbCommand command = new OleDbCommand();

            command.Connection = conn;

            command.CommandText = "select * from Foods where Food = '" + comboBox1.Text + "' ";

            OleDbDataReader r = command.ExecuteReader();

            while (r.Read())
            {
                txtprice.Text = r[2].ToString();
            }

            conn.Close();


        }
    }
}
