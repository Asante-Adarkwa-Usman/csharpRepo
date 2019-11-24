namespace RestaurantManagementSystem
{
    partial class FinanceForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txttotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtfoodtype = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtfood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcust = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtquantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1856, 90);
            this.panel2.TabIndex = 23;
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1797, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(747, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "Finance Details";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 90);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(496, 745);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this;
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(321, 736);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(156, 58);
            this.bunifuThinButton21.TabIndex = 34;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(496, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1360, 745);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(3, 18);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 30;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1354, 724);
            this.bunifuCustomDataGrid1.TabIndex = 34;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // txttotal
            // 
            this.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttotal.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txttotal.ForeColor = System.Drawing.Color.White;
            this.txttotal.HintForeColor = System.Drawing.Color.White;
            this.txttotal.HintText = "";
            this.txttotal.isPassword = false;
            this.txttotal.LineFocusedColor = System.Drawing.Color.Gray;
            this.txttotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txttotal.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txttotal.LineThickness = 3;
            this.txttotal.Location = new System.Drawing.Point(36, 666);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(443, 48);
            this.txttotal.TabIndex = 30;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txttotal.OnValueChanged += new System.EventHandler(this.txtnumber_OnValueChanged);
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtname.ForeColor = System.Drawing.Color.White;
            this.txtname.HintForeColor = System.Drawing.Color.White;
            this.txtname.HintText = "";
            this.txtname.isPassword = false;
            this.txtname.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtname.LineIdleColor = System.Drawing.Color.Gray;
            this.txtname.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtname.LineThickness = 3;
            this.txtname.Location = new System.Drawing.Point(36, 238);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(443, 47);
            this.txtname.TabIndex = 25;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Search";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(338, 163);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(128, 56);
            this.bunifuThinButton22.TabIndex = 43;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // txtfoodtype
            // 
            this.txtfoodtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfoodtype.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtfoodtype.ForeColor = System.Drawing.Color.White;
            this.txtfoodtype.HintForeColor = System.Drawing.Color.White;
            this.txtfoodtype.HintText = "";
            this.txtfoodtype.isPassword = false;
            this.txtfoodtype.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtfoodtype.LineIdleColor = System.Drawing.Color.Gray;
            this.txtfoodtype.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtfoodtype.LineThickness = 3;
            this.txtfoodtype.Location = new System.Drawing.Point(36, 321);
            this.txtfoodtype.Margin = new System.Windows.Forms.Padding(4);
            this.txtfoodtype.Name = "txtfoodtype";
            this.txtfoodtype.Size = new System.Drawing.Size(443, 47);
            this.txtfoodtype.TabIndex = 44;
            this.txtfoodtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtfood
            // 
            this.txtfood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfood.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtfood.ForeColor = System.Drawing.Color.White;
            this.txtfood.HintForeColor = System.Drawing.Color.White;
            this.txtfood.HintText = "";
            this.txtfood.isPassword = false;
            this.txtfood.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtfood.LineIdleColor = System.Drawing.Color.Gray;
            this.txtfood.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtfood.LineThickness = 3;
            this.txtfood.Location = new System.Drawing.Point(36, 408);
            this.txtfood.Margin = new System.Windows.Forms.Padding(4);
            this.txtfood.Name = "txtfood";
            this.txtfood.Size = new System.Drawing.Size(443, 47);
            this.txtfood.TabIndex = 45;
            this.txtfood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfood.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // txtcust
            // 
            this.txtcust.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcust.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtcust.ForeColor = System.Drawing.Color.White;
            this.txtcust.HintForeColor = System.Drawing.Color.White;
            this.txtcust.HintText = "";
            this.txtcust.isPassword = false;
            this.txtcust.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtcust.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcust.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtcust.LineThickness = 3;
            this.txtcust.Location = new System.Drawing.Point(25, 108);
            this.txtcust.Margin = new System.Windows.Forms.Padding(4);
            this.txtcust.Name = "txtcust";
            this.txtcust.Size = new System.Drawing.Size(443, 47);
            this.txtcust.TabIndex = 46;
            this.txtcust.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(36, 562);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(443, 48);
            this.bunifuMaterialTextbox1.TabIndex = 47;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtquantity
            // 
            this.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtquantity.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtquantity.ForeColor = System.Drawing.Color.White;
            this.txtquantity.HintForeColor = System.Drawing.Color.White;
            this.txtquantity.HintText = "";
            this.txtquantity.isPassword = false;
            this.txtquantity.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtquantity.LineIdleColor = System.Drawing.Color.Gray;
            this.txtquantity.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtquantity.LineThickness = 3;
            this.txtquantity.Location = new System.Drawing.Point(34, 574);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(443, 48);
            this.txtquantity.TabIndex = 48;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtprice
            // 
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtprice.ForeColor = System.Drawing.Color.White;
            this.txtprice.HintForeColor = System.Drawing.Color.White;
            this.txtprice.HintText = "";
            this.txtprice.isPassword = false;
            this.txtprice.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtprice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtprice.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtprice.LineThickness = 3;
            this.txtprice.Location = new System.Drawing.Point(36, 482);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(443, 48);
            this.txtprice.TabIndex = 49;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1856, 835);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.txtcust);
            this.Controls.Add(this.txtfood);
            this.Controls.Add(this.txtfoodtype);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinanceForm";
            this.Text = "FinanceForm";
            this.Load += new System.EventHandler(this.FinanceForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtfood;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtfoodtype;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txttotal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcust;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtquantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
    }
}