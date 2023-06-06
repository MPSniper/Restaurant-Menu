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
            panel1 = new Panel();
            panel2 = new Panel();
            EndTime = new NumericUpDown();
            StartTime = new NumericUpDown();
            RestaurantBox = new TextBox();
            AddressBox = new TextBox();
            Owner = new TextBox();
            BtnBack = new Label();
            BtnLogin = new Label();
            label1 = new Label();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EndTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartTime).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(470, 345);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(EndTime);
            panel2.Controls.Add(StartTime);
            panel2.Controls.Add(RestaurantBox);
            panel2.Controls.Add(AddressBox);
            panel2.Controls.Add(Owner);
            panel2.Controls.Add(BtnBack);
            panel2.Controls.Add(BtnLogin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 282);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // EndTime
            // 
            EndTime.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EndTime.Location = new Point(262, 219);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(44, 41);
            EndTime.TabIndex = 3;
            EndTime.ValueChanged += EndTime_ValueChanged;
            // 
            // StartTime
            // 
            StartTime.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StartTime.Location = new Point(358, 220);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(44, 41);
            StartTime.TabIndex = 3;
            StartTime.ValueChanged += StartTime_ValueChanged;
            // 
            // RestaurantBox
            // 
            RestaurantBox.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RestaurantBox.Location = new Point(262, 47);
            RestaurantBox.Name = "RestaurantBox";
            RestaurantBox.Size = new Size(186, 41);
            RestaurantBox.TabIndex = 2;
            RestaurantBox.TextChanged += RestaurantName_TextChanged;
            // 
            // AddressBox
            // 
            AddressBox.AcceptsReturn = true;
            AddressBox.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(3, 47);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.ScrollBars = ScrollBars.Vertical;
            AddressBox.Size = new Size(243, 129);
            AddressBox.TabIndex = 2;
            AddressBox.TextChanged += Address_TextChanged;
            // 
            // Owner
            // 
            Owner.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Owner.Location = new Point(262, 135);
            Owner.Name = "Owner";
            Owner.Size = new Size(186, 41);
            Owner.TabIndex = 2;
            Owner.TextChanged += OwnerName_TextChanged;
            // 
            // BtnBack
            // 
            BtnBack.BorderStyle = BorderStyle.FixedSingle;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBack.Image = Properties.Resources.icons8_back_to_40px_1;
            BtnBack.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBack.Location = new Point(3, 233);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(243, 43);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "بازگشت";
            BtnBack.TextAlign = ContentAlignment.MiddleCenter;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BorderStyle = BorderStyle.FixedSingle;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.Image = Properties.Resources.icons8_asian_street_food_40px;
            BtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogin.Location = new Point(3, 180);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(243, 43);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "ثبت اطلاعات";
            BtnLogin.TextAlign = ContentAlignment.MiddleCenter;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(262, 3);
            label1.Name = "label1";
            label1.Size = new Size(186, 41);
            label1.TabIndex = 1;
            label1.Text = "نام رستوران : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(243, 41);
            label4.TabIndex = 1;
            label4.Text = "آدرس : ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label8
            // 
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(312, 219);
            label8.Name = "label8";
            label8.Size = new Size(40, 41);
            label8.TabIndex = 1;
            label8.Text = "تا : ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(408, 220);
            label7.Name = "label7";
            label7.Size = new Size(40, 41);
            label7.TabIndex = 1;
            label7.Text = "از : ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(262, 179);
            label3.Name = "label3";
            label3.Size = new Size(186, 41);
            label3.TabIndex = 1;
            label3.Text = "شیفت کاری : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(262, 91);
            label2.Name = "label2";
            label2.Size = new Size(186, 41);
            label2.TabIndex = 1;
            label2.Text = "صاحب رستوران : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(3, 12);
            label6.Name = "label6";
            label6.Size = new Size(456, 41);
            label6.TabIndex = 1;
            label6.Text = "اطلاعات رستوران";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // ResturanRegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._45_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(491, 369);
            Controls.Add(panel1);
            Font = new Font("B Zar", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ResturanRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EndTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartTime).EndInit();
            ResumeLayout(false);
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