namespace RestaurantManagementSystem
{
    partial class MoreLocalFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreLocalFood));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSlideLeft = new System.Windows.Forms.Button();
            this.btnSlideRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(303, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSlideLeft
            // 
            this.btnSlideLeft.FlatAppearance.BorderSize = 0;
            this.btnSlideLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlideLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnSlideLeft.Image")));
            this.btnSlideLeft.Location = new System.Drawing.Point(66, 214);
            this.btnSlideLeft.Name = "btnSlideLeft";
            this.btnSlideLeft.Size = new System.Drawing.Size(83, 83);
            this.btnSlideLeft.TabIndex = 1;
            this.btnSlideLeft.UseVisualStyleBackColor = true;
            // 
            // btnSlideRight
            // 
            this.btnSlideRight.FlatAppearance.BorderSize = 0;
            this.btnSlideRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlideRight.Image = ((System.Drawing.Image)(resources.GetObject("btnSlideRight.Image")));
            this.btnSlideRight.Location = new System.Drawing.Point(868, 226);
            this.btnSlideRight.Name = "btnSlideRight";
            this.btnSlideRight.Size = new System.Drawing.Size(83, 83);
            this.btnSlideRight.TabIndex = 2;
            this.btnSlideRight.UseVisualStyleBackColor = true;
            // 
            // MoreLocalFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1074, 585);
            this.Controls.Add(this.btnSlideRight);
            this.Controls.Add(this.btnSlideLeft);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoreLocalFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoreLocalFood";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSlideLeft;
        private System.Windows.Forms.Button btnSlideRight;
    }
}