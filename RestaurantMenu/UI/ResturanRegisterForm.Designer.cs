namespace UI
{
    partial class ResturanRegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EndTime = new System.Windows.Forms.NumericUpDown();
            this.StartTime = new System.Windows.Forms.NumericUpDown();
            this.RestaurantBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.Owner = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(470, 345);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.EndTime);
            this.panel2.Controls.Add(this.StartTime);
            this.panel2.Controls.Add(this.RestaurantBox);
            this.panel2.Controls.Add(this.AddressBox);
            this.panel2.Controls.Add(this.Owner);
            this.panel2.Controls.Add(this.BtnBack);
            this.panel2.Controls.Add(this.BtnLogin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 282);
            this.panel2.TabIndex = 3;
            // 
            // EndTime
            // 
            this.EndTime.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndTime.Location = new System.Drawing.Point(262, 219);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(44, 41);
            this.EndTime.TabIndex = 3;
            // 
            // StartTime
            // 
            this.StartTime.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartTime.Location = new System.Drawing.Point(358, 220);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(44, 41);
            this.StartTime.TabIndex = 3;
            // 
            // RestaurantBox
            // 
            this.RestaurantBox.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestaurantBox.Location = new System.Drawing.Point(262, 47);
            this.RestaurantBox.Name = "RestaurantBox";
            this.RestaurantBox.Size = new System.Drawing.Size(186, 41);
            this.RestaurantBox.TabIndex = 2;
            // 
            // AddressBox
            // 
            this.AddressBox.AcceptsReturn = true;
            this.AddressBox.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressBox.Location = new System.Drawing.Point(3, 47);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddressBox.Size = new System.Drawing.Size(243, 129);
            this.AddressBox.TabIndex = 2;
            // 
            // Owner
            // 
            this.Owner.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Owner.Location = new System.Drawing.Point(262, 135);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(186, 41);
            this.Owner.TabIndex = 2;
            // 
            // BtnBack
            // 
            this.BtnBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Image = global::UI.Properties.Resources.icons8_back_to_40px_1;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Location = new System.Drawing.Point(3, 233);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(243, 43);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "بازگشت";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.Image = global::UI.Properties.Resources.icons8_asian_street_food_40px;
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.Location = new System.Drawing.Point(3, 180);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(243, 43);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "ثبت اطلاعات";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(262, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام رستوران : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "آدرس : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(312, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 41);
            this.label8.TabIndex = 1;
            this.label8.Text = "تا : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(408, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 41);
            this.label7.TabIndex = 1;
            this.label7.Text = "از : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(262, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "شیفت کاری : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(262, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "صاحب رستوران : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(456, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "اطلاعات رستوران";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResturanRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources._45_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 369);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResturanRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label BtnLogin;
        private Panel panel2;
        private TextBox RestaurantBox;
        private TextBox AddressBox;
        private TextBox Owner;
        private Label BtnBack;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private NumericUpDown EndTime;
        private NumericUpDown StartTime;
        private Label label8;
        private Label label7;
    }
}