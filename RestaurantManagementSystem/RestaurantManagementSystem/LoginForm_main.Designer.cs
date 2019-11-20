namespace RestaurantManagementSystem
{
    partial class LoginForm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm_main));
            Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.txtLogUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtLogPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 229);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(213, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(0, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(32, 32);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReturn.TabIndex = 8;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtLogUser
            // 
            this.txtLogUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLogUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogUser.HintForeColor = System.Drawing.Color.Empty;
            this.txtLogUser.HintText = "";
            this.txtLogUser.isPassword = false;
            this.txtLogUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.txtLogUser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLogUser.LineMouseHoverColor = System.Drawing.Color.MediumVioletRed;
            this.txtLogUser.LineThickness = 3;
            this.txtLogUser.Location = new System.Drawing.Point(78, 300);
            this.txtLogUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLogUser.Name = "txtLogUser";
            this.txtLogUser.Size = new System.Drawing.Size(370, 43);
            this.txtLogUser.TabIndex = 33;
            this.txtLogUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogUser.TextChanged += new System.EventHandler(this.txtLogUser_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 285);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // txtLogPass
            // 
            this.txtLogPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLogPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtLogPass.HintText = "";
            this.txtLogPass.isPassword = true;
            this.txtLogPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.txtLogPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLogPass.LineMouseHoverColor = System.Drawing.Color.MediumVioletRed;
            this.txtLogPass.LineThickness = 3;
            this.txtLogPass.Location = new System.Drawing.Point(79, 406);
            this.txtLogPass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLogPass.Name = "txtLogPass";
            this.txtLogPass.Size = new System.Drawing.Size(370, 43);
            this.txtLogPass.TabIndex = 35;
            this.txtLogPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogPass.OnValueChanged += new System.EventHandler(this.txtLogPass_OnValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 393);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Location = new System.Drawing.Point(325, 469);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 48);
            this.btnLogin.TabIndex = 36;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.lbSignUp.Location = new System.Drawing.Point(372, 535);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(71, 21);
            this.lbSignUp.TabIndex = 38;
            this.lbSignUp.Text = "Sign Up";
            this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Don\'t have an account? ";
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 7;
            bunifuElipse1.TargetControl = this.btnLogin;
            // 
            // LoginForm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(463, 575);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLogPass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtLogUser);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm_main";
            this.Load += new System.EventHandler(this.LoginForm_main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnReturn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLogUser;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLogPass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.Label label4;
    }
}