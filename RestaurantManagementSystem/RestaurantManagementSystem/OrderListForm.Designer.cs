namespace RestaurantManagementSystem
{
    partial class OrderListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderListForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdb = new System.Windows.Forms.RadioButton();
            this.txtquantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtfood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtfoodtype = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtnumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 835);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(415, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(921, 735);
            this.panel4.TabIndex = 9;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(921, 735);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            this.bunifuCustomDataGrid1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bunifuCustomDataGrid1_CellMouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Controls.Add(this.rdb);
            this.panel3.Controls.Add(this.txtquantity);
            this.panel3.Controls.Add(this.txtfood);
            this.panel3.Controls.Add(this.txtfoodtype);
            this.panel3.Controls.Add(this.bunifuThinButton21);
            this.panel3.Controls.Add(this.txtnumber);
            this.panel3.Controls.Add(this.txtname);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 735);
            this.panel3.TabIndex = 8;
            // 
            // rdb
            // 
            this.rdb.AutoSize = true;
            this.rdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb.ForeColor = System.Drawing.Color.White;
            this.rdb.Location = new System.Drawing.Point(13, 610);
            this.rdb.Name = "rdb";
            this.rdb.Size = new System.Drawing.Size(184, 33);
            this.rdb.TabIndex = 56;
            this.rdb.TabStop = true;
            this.rdb.Text = "Order Placed ";
            this.rdb.UseVisualStyleBackColor = true;
            // 
            // txtquantity
            // 
            this.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtquantity.Enabled = false;
            this.txtquantity.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtquantity.ForeColor = System.Drawing.Color.White;
            this.txtquantity.HintForeColor = System.Drawing.Color.White;
            this.txtquantity.HintText = "";
            this.txtquantity.isPassword = false;
            this.txtquantity.LineFocusedColor = System.Drawing.Color.White;
            this.txtquantity.LineIdleColor = System.Drawing.Color.White;
            this.txtquantity.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtquantity.LineThickness = 3;
            this.txtquantity.Location = new System.Drawing.Point(12, 421);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(377, 48);
            this.txtquantity.TabIndex = 55;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtfood
            // 
            this.txtfood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfood.Enabled = false;
            this.txtfood.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtfood.ForeColor = System.Drawing.Color.White;
            this.txtfood.HintForeColor = System.Drawing.Color.White;
            this.txtfood.HintText = "";
            this.txtfood.isPassword = false;
            this.txtfood.LineFocusedColor = System.Drawing.Color.White;
            this.txtfood.LineIdleColor = System.Drawing.Color.White;
            this.txtfood.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtfood.LineThickness = 3;
            this.txtfood.Location = new System.Drawing.Point(13, 321);
            this.txtfood.Margin = new System.Windows.Forms.Padding(4);
            this.txtfood.Name = "txtfood";
            this.txtfood.Size = new System.Drawing.Size(377, 47);
            this.txtfood.TabIndex = 54;
            this.txtfood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtfoodtype
            // 
            this.txtfoodtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfoodtype.Enabled = false;
            this.txtfoodtype.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtfoodtype.ForeColor = System.Drawing.Color.White;
            this.txtfoodtype.HintForeColor = System.Drawing.Color.White;
            this.txtfoodtype.HintText = "";
            this.txtfoodtype.isPassword = false;
            this.txtfoodtype.LineFocusedColor = System.Drawing.Color.White;
            this.txtfoodtype.LineIdleColor = System.Drawing.Color.White;
            this.txtfoodtype.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtfoodtype.LineThickness = 3;
            this.txtfoodtype.Location = new System.Drawing.Point(12, 159);
            this.txtfoodtype.Margin = new System.Windows.Forms.Padding(4);
            this.txtfoodtype.Name = "txtfoodtype";
            this.txtfoodtype.Size = new System.Drawing.Size(377, 47);
            this.txtfoodtype.TabIndex = 53;
            this.txtfoodtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Submit";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(237, 654);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(156, 58);
            this.bunifuThinButton21.TabIndex = 52;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnumber.Enabled = false;
            this.txtnumber.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtnumber.ForeColor = System.Drawing.Color.White;
            this.txtnumber.HintForeColor = System.Drawing.Color.White;
            this.txtnumber.HintText = "";
            this.txtnumber.isPassword = false;
            this.txtnumber.LineFocusedColor = System.Drawing.Color.White;
            this.txtnumber.LineIdleColor = System.Drawing.Color.White;
            this.txtnumber.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtnumber.LineThickness = 3;
            this.txtnumber.Location = new System.Drawing.Point(13, 517);
            this.txtnumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(377, 48);
            this.txtnumber.TabIndex = 51;
            this.txtnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtname.ForeColor = System.Drawing.Color.White;
            this.txtname.HintForeColor = System.Drawing.Color.White;
            this.txtname.HintText = "";
            this.txtname.isPassword = false;
            this.txtname.LineFocusedColor = System.Drawing.Color.White;
            this.txtname.LineIdleColor = System.Drawing.Color.White;
            this.txtname.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtname.LineThickness = 3;
            this.txtname.Location = new System.Drawing.Point(12, 76);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(377, 47);
            this.txtname.TabIndex = 50;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1249, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(485, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordered Items";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 100);
            this.panel2.TabIndex = 7;
            // 
            // txtprice
            // 
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.Enabled = false;
            this.txtprice.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtprice.ForeColor = System.Drawing.Color.White;
            this.txtprice.HintForeColor = System.Drawing.Color.White;
            this.txtprice.HintText = "";
            this.txtprice.isPassword = false;
            this.txtprice.LineFocusedColor = System.Drawing.Color.White;
            this.txtprice.LineIdleColor = System.Drawing.Color.White;
            this.txtprice.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtprice.LineThickness = 3;
            this.txtprice.Location = new System.Drawing.Point(12, 257);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(377, 47);
            this.txtprice.TabIndex = 57;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 835);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderListForm";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtquantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtfood;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtfoodtype;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private System.Windows.Forms.RadioButton rdb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtprice;
    }
}