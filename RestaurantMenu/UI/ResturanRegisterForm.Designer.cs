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
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            EndTime = new NumericUpDown();
            StartTime = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            PasswordBox = new TextBox();
            label9 = new Label();
            NationalCodeBox = new TextBox();
            label5 = new Label();
            RestaurantNameBox = new TextBox();
            AddressBox = new TextBox();
            OwnerTextBox = new TextBox();
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
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(355, 4);
            label1.Name = "label1";
            label1.Size = new Size(243, 42);
            label1.TabIndex = 1;
            label1.Text = "نام رستوران : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(56, 4);
            label2.Name = "label2";
            label2.Size = new Size(243, 42);
            label2.TabIndex = 1;
            label2.Text = "صاحب رستوران : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(4, 15);
            label6.Name = "label6";
            label6.Size = new Size(608, 51);
            label6.TabIndex = 1;
            label6.Text = "اطلاعات رستوران";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click_1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(EndTime);
            panel2.Controls.Add(StartTime);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(PasswordBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(NationalCodeBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(RestaurantNameBox);
            panel2.Controls.Add(AddressBox);
            panel2.Controls.Add(OwnerTextBox);
            panel2.Controls.Add(BtnBack);
            panel2.Controls.Add(BtnLogin);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(4, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 352);
            panel2.TabIndex = 3;
            // 
            // EndTime
            // 
            EndTime.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EndTime.Location = new Point(56, 211);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(67, 30);
            EndTime.TabIndex = 7;
            // 
            // StartTime
            // 
            StartTime.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StartTime.Location = new Point(184, 211);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(67, 30);
            StartTime.TabIndex = 6;
            // 
            // label8
            // 
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(138, 206);
            label8.Name = "label8";
            label8.Size = new Size(40, 41);
            label8.TabIndex = 9;
            label8.Text = "تا : ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(257, 205);
            label7.Name = "label7";
            label7.Size = new Size(40, 41);
            label7.TabIndex = 10;
            label7.Text = "از : ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ImageAlign = ContentAlignment.MiddleRight;
            label10.Location = new Point(56, 160);
            label10.Name = "label10";
            label10.Size = new Size(243, 42);
            label10.TabIndex = 11;
            label10.Text = "شیفت کاری : ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(56, 127);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(241, 30);
            PasswordBox.TabIndex = 4;
            // 
            // label9
            // 
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(56, 82);
            label9.Name = "label9";
            label9.Size = new Size(243, 42);
            label9.TabIndex = 6;
            label9.Text = "رمز عبور :";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NationalCodeBox
            // 
            NationalCodeBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NationalCodeBox.Location = new Point(355, 127);
            NationalCodeBox.Name = "NationalCodeBox";
            NationalCodeBox.Size = new Size(241, 30);
            NationalCodeBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(355, 82);
            label5.Name = "label5";
            label5.Size = new Size(243, 42);
            label5.TabIndex = 4;
            label5.Text = "کد ملی :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RestaurantNameBox
            // 
            RestaurantNameBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RestaurantNameBox.Location = new Point(356, 49);
            RestaurantNameBox.Name = "RestaurantNameBox";
            RestaurantNameBox.Size = new Size(241, 30);
            RestaurantNameBox.TabIndex = 1;
            // 
            // AddressBox
            // 
            AddressBox.AcceptsReturn = true;
            AddressBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddressBox.Location = new Point(353, 205);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.ScrollBars = ScrollBars.Vertical;
            AddressBox.Size = new Size(241, 64);
            AddressBox.TabIndex = 5;
            // 
            // OwnerTextBox
            // 
            OwnerTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OwnerTextBox.Location = new Point(56, 49);
            OwnerTextBox.Name = "OwnerTextBox";
            OwnerTextBox.Size = new Size(241, 30);
            OwnerTextBox.TabIndex = 2;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.FromArgb(224, 224, 224);
            BtnBack.BorderStyle = BorderStyle.FixedSingle;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBack.Image = Properties.Resources.icons8_back_to_40px_1;
            BtnBack.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBack.Location = new Point(4, 291);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(303, 53);
            BtnBack.TabIndex = 9;
            BtnBack.Text = "بازگشت";
            BtnBack.TextAlign = ContentAlignment.MiddleCenter;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(192, 255, 192);
            BtnLogin.BorderStyle = BorderStyle.FixedSingle;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.Image = Properties.Resources.icons8_asian_street_food_40px;
            BtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogin.Location = new Point(316, 291);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(281, 53);
            BtnLogin.TabIndex = 8;
            BtnLogin.Text = "ثبت اطلاعات";
            BtnLogin.TextAlign = ContentAlignment.MiddleCenter;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(353, 160);
            label4.Name = "label4";
            label4.Size = new Size(243, 42);
            label4.TabIndex = 1;
            label4.Text = "آدرس : ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(16, 15);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(625, 430);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint_1;
            // 
            // ResturanRegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._45_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(655, 461);
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
    }
}