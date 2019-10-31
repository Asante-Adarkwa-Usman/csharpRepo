﻿using System;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            DialogResult exitMsg = MessageBox.Show("Are you sure you want to close this application", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if( exitMsg == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    

        private void btnCollection_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FoodCollectionFormcs newFoodType = new FoodCollectionFormcs();
            newFoodType.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
