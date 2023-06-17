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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResturanRegisterForm));
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            AddressBox = new TextBox();
            PasswordBox = new TextBox();
            NationalCodeBox = new TextBox();
            RestaurantNameBox = new TextBox();
            OwnerTextBox = new TextBox();
            panel3 = new Panel();
            EndTime = new NumericUpDown();
            StartTime = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            BtnBack = new Label();
            BtnLogin = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EndTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartTime).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 8, 8);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(527, 38);
            label1.Name = "label1";
            label1.Size = new Size(243, 42);
            label1.TabIndex = 1;
            label1.Text = "نام رستوران : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(8, 8, 8);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(529, 124);
            label2.Name = "label2";
            label2.Size = new Size(243, 42);
            label2.TabIndex = 1;
            label2.Text = "صاحب رستوران : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOrange;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(8, 8, 8);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(-25, 13);
            label6.Name = "label6";
            label6.Size = new Size(886, 41);
            label6.TabIndex = 1;
            label6.Text = "اطلاعات رستوران";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(AddressBox);
            panel2.Controls.Add(PasswordBox);
            panel2.Controls.Add(NationalCodeBox);
            panel2.Controls.Add(RestaurantNameBox);
            panel2.Controls.Add(OwnerTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(EndTime);
            panel2.Controls.Add(StartTime);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(BtnBack);
            panel2.Controls.Add(BtnLogin);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(3, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 518);
            panel2.TabIndex = 3;
            // 
            // AddressBox
            // 
            AddressBox.AcceptsReturn = true;
            AddressBox.BackColor = SystemColors.Window;
            AddressBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(532, 421);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.ScrollBars = ScrollBars.Vertical;
            AddressBox.Size = new Size(241, 64);
            AddressBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = SystemColors.Window;
            PasswordBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(531, 337);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(241, 36);
            PasswordBox.TabIndex = 4;
            // 
            // NationalCodeBox
            // 
            NationalCodeBox.BackColor = SystemColors.Window;
            NationalCodeBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NationalCodeBox.Location = new Point(531, 253);
            NationalCodeBox.Name = "NationalCodeBox";
            NationalCodeBox.Size = new Size(241, 36);
            NationalCodeBox.TabIndex = 3;
            // 
            // RestaurantNameBox
            // 
            RestaurantNameBox.BackColor = SystemColors.Window;
            RestaurantNameBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RestaurantNameBox.Location = new Point(529, 86);
            RestaurantNameBox.Name = "RestaurantNameBox";
            RestaurantNameBox.Size = new Size(241, 36);
            RestaurantNameBox.TabIndex = 1;
            // 
            // OwnerTextBox
            // 
            OwnerTextBox.BackColor = SystemColors.Window;
            OwnerTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OwnerTextBox.Location = new Point(529, 169);
            OwnerTextBox.Name = "OwnerTextBox";
            OwnerTextBox.Size = new Size(241, 36);
            OwnerTextBox.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(96, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(274, 240);
            panel3.TabIndex = 21;
            // 
            // EndTime
            // 
            EndTime.BackColor = SystemColors.Window;
            EndTime.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EndTime.Location = new Point(130, 86);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(67, 36);
            EndTime.TabIndex = 7;
            // 
            // StartTime
            // 
            StartTime.BackColor = SystemColors.Window;
            StartTime.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StartTime.Location = new Point(248, 86);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(67, 36);
            StartTime.TabIndex = 6;
            // 
            // label8
            // 
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(8, 8, 8);
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(202, 80);
            label8.Name = "label8";
            label8.Size = new Size(40, 41);
            label8.TabIndex = 9;
            label8.Text = "تا : ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(8, 8, 8);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(312, 80);
            label7.Name = "label7";
            label7.Size = new Size(40, 41);
            label7.TabIndex = 10;
            label7.Text = "از : ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(8, 8, 8);
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(116, 38);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(243, 42);
            label10.TabIndex = 11;
            label10.Text = "شیفت کاری : ";
            label10.TextAlign = ContentAlignment.BottomCenter;
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(8, 8, 8);
            label9.Location = new Point(532, 292);
            label9.Name = "label9";
            label9.Size = new Size(243, 42);
            label9.TabIndex = 6;
            label9.Text = "رمز عبور :";
            label9.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(8, 8, 8);
            label5.Location = new Point(529, 208);
            label5.Name = "label5";
            label5.Size = new Size(243, 42);
            label5.TabIndex = 4;
            label5.Text = "کد ملی :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.DarkOrange;
            BtnBack.BorderStyle = BorderStyle.FixedSingle;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.ForeColor = Color.FromArgb(8, 8, 8);
            BtnBack.Image = Properties.Resources.icons8_back_to_40px_1;
            BtnBack.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBack.Location = new Point(16, 456);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(219, 53);
            BtnBack.TabIndex = 9;
            BtnBack.Text = "بازگشت";
            BtnBack.TextAlign = ContentAlignment.MiddleCenter;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.DarkOrange;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.FromArgb(8, 8, 8);
            BtnLogin.Image = Properties.Resources.icons8_asian_street_food_40px;
            BtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogin.Location = new Point(241, 456);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(207, 53);
            BtnLogin.TabIndex = 8;
            BtnLogin.Text = "ثبت اطلاعات";
            BtnLogin.TextAlign = ContentAlignment.MiddleCenter;
            BtnLogin.Click += BtnSignUp_Click;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(8, 8, 8);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(529, 376);
            label4.Name = "label4";
            label4.Size = new Size(243, 42);
            label4.TabIndex = 1;
            label4.Text = "آدرس : ";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 5);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(874, 553);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint_1;
            // 
            // ResturanRegisterForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 84, 50);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(887, 566);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ResturanRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ResturanRegisterForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EndTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartTime).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label6;
        private Panel panel2;
        private Label label9;
        private TextBox NationalCodeBox;
        private Label label5;
        private TextBox RestaurantNameBox;
        private TextBox AddressBox;
        private TextBox OwnerTextBox;
        private Label BtnBack;
        private Label BtnLogin;
        private Label label4;
        private Panel panel1;
        private TextBox PasswordBox;
        private NumericUpDown EndTime;
        private NumericUpDown StartTime;
        private Label label8;
        private Label label7;
        private Label label10;
        private Panel panel3;
    }
}