namespace RestaurantManagementSystem
{
    partial class localdish
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(localdish));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCustQnty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCustSubmit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtCustTable = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(572, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Etor",
            "Yam and Stew",
            "Fufu and ground soup",
            "Waakye ",
            "Banku and okro stew"});
            this.comboBox1.Location = new System.Drawing.Point(7, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 30);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCustName
            // 
            this.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCustName.ForeColor = System.Drawing.Color.White;
            this.txtCustName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustName.HintText = "Customer Name";
            this.txtCustName.isPassword = false;
            this.txtCustName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.txtCustName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.txtCustName.LineThickness = 3;
            this.txtCustName.Location = new System.Drawing.Point(79, 52);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(388, 42);
            this.txtCustName.TabIndex = 1;
            this.txtCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCustQnty
            // 
            this.txtCustQnty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustQnty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCustQnty.ForeColor = System.Drawing.Color.White;
            this.txtCustQnty.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustQnty.HintText = "Quantity";
            this.txtCustQnty.isPassword = false;
            this.txtCustQnty.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.txtCustQnty.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustQnty.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.txtCustQnty.LineThickness = 3;
            this.txtCustQnty.Location = new System.Drawing.Point(79, 239);
            this.txtCustQnty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustQnty.Name = "txtCustQnty";
            this.txtCustQnty.Size = new System.Drawing.Size(388, 42);
            this.txtCustQnty.TabIndex = 2;
            this.txtCustQnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCustSubmit
            // 
            this.btnCustSubmit.ActiveBorderThickness = 1;
            this.btnCustSubmit.ActiveCornerRadius = 20;
            this.btnCustSubmit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.btnCustSubmit.ActiveForecolor = System.Drawing.Color.White;
            this.btnCustSubmit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.btnCustSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.btnCustSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustSubmit.BackgroundImage")));
            this.btnCustSubmit.ButtonText = "Submit";
            this.btnCustSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustSubmit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustSubmit.ForeColor = System.Drawing.Color.White;
            this.btnCustSubmit.IdleBorderThickness = 1;
            this.btnCustSubmit.IdleCornerRadius = 20;
            this.btnCustSubmit.IdleFillColor = System.Drawing.Color.White;
            this.btnCustSubmit.IdleForecolor = System.Drawing.Color.Teal;
            this.btnCustSubmit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.btnCustSubmit.Location = new System.Drawing.Point(606, 387);
            this.btnCustSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCustSubmit.Name = "btnCustSubmit";
            this.btnCustSubmit.Size = new System.Drawing.Size(211, 59);
            this.btnCustSubmit.TabIndex = 4;
            this.btnCustSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustSubmit.Click += new System.EventHandler(this.btnCustSubmit_Click);
            // 
            // txtCustTable
            // 
            this.txtCustTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustTable.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCustTable.ForeColor = System.Drawing.Color.White;
            this.txtCustTable.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustTable.HintText = "Table Number";
            this.txtCustTable.isPassword = false;
            this.txtCustTable.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.txtCustTable.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustTable.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.txtCustTable.LineThickness = 3;
            this.txtCustTable.Location = new System.Drawing.Point(79, 326);
            this.txtCustTable.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustTable.Name = "txtCustTable";
            this.txtCustTable.Size = new System.Drawing.Size(388, 42);
            this.txtCustTable.TabIndex = 8;
            this.txtCustTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtprice
            // 
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtprice.ForeColor = System.Drawing.Color.White;
            this.txtprice.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtprice.HintText = "Price";
            this.txtprice.isPassword = false;
            this.txtprice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.txtprice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtprice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.txtprice.LineThickness = 3;
            this.txtprice.Location = new System.Drawing.Point(79, 154);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(388, 42);
            this.txtprice.TabIndex = 9;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // localdish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtCustTable);
            this.Controls.Add(this.btnCustSubmit);
            this.Controls.Add(this.txtCustQnty);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.groupBox1);
            this.Name = "localdish";
            this.Size = new System.Drawing.Size(914, 517);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCustQnty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCustName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCustSubmit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCustTable;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtprice;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
