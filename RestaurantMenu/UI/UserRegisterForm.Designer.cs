namespace UI
{
    partial class UserRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegisterForm));
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            PasswordTextBox = new TextBox();
            label5 = new Label();
            NameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            NationalityTextBox = new TextBox();
            FamilyTextBox = new TextBox();
            BtnBack = new Label();
            BtnSignUp = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(879, 547);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(PasswordTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(AddressTextBox);
            panel2.Controls.Add(NationalityTextBox);
            panel2.Controls.Add(FamilyTextBox);
            panel2.Controls.Add(BtnBack);
            panel2.Controls.Add(BtnSignUp);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(8, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 541);
            panel2.TabIndex = 3;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOrange;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(-8, -4);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(901, 53);
            label6.TabIndex = 1;
            label6.Text = "اطلاعات کاربری";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(63, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(285, 268);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(521, 340);
            PasswordTextBox.Margin = new Padding(4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(241, 36);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // label5
            // 
            label5.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(529, 298);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(243, 51);
            label5.TabIndex = 3;
            label5.Text = "رمز عبور:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(521, 93);
            NameTextBox.Margin = new Padding(4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(241, 36);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.None;
            AddressTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTextBox.Location = new Point(522, 425);
            AddressTextBox.Margin = new Padding(4);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.ScrollBars = ScrollBars.Vertical;
            AddressTextBox.Size = new Size(241, 85);
            AddressTextBox.TabIndex = 5;
            AddressTextBox.TextChanged += textBox4_TextChanged;
            // 
            // NationalityTextBox
            // 
            NationalityTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NationalityTextBox.Location = new Point(521, 258);
            NationalityTextBox.Margin = new Padding(4);
            NationalityTextBox.Name = "NationalityTextBox";
            NationalityTextBox.Size = new Size(241, 36);
            NationalityTextBox.TabIndex = 3;
            NationalityTextBox.TextChanged += textBox3_TextChanged;
            // 
            // FamilyTextBox
            // 
            FamilyTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FamilyTextBox.Location = new Point(521, 178);
            FamilyTextBox.Margin = new Padding(4);
            FamilyTextBox.Name = "FamilyTextBox";
            FamilyTextBox.Size = new Size(241, 36);
            FamilyTextBox.TabIndex = 2;
            FamilyTextBox.TextChanged += textBox2_TextChanged;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.DarkOrange;
            BtnBack.BorderStyle = BorderStyle.FixedSingle;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.Image = Properties.Resources.icons8_back_to_40px_1;
            BtnBack.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBack.Location = new Point(15, 455);
            BtnBack.Margin = new Padding(4, 0, 4, 0);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(214, 64);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "بازگشت";
            BtnBack.TextAlign = ContentAlignment.MiddleCenter;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnSignUp
            // 
            BtnSignUp.BackColor = Color.DarkOrange;
            BtnSignUp.BorderStyle = BorderStyle.FixedSingle;
            BtnSignUp.Cursor = Cursors.Hand;
            BtnSignUp.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSignUp.Image = Properties.Resources.icons8_add_user_group_woman_man_40px;
            BtnSignUp.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSignUp.Location = new Point(237, 455);
            BtnSignUp.Margin = new Padding(4, 0, 4, 0);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(216, 64);
            BtnSignUp.TabIndex = 0;
            BtnSignUp.Text = "ثبت اطلاعات";
            BtnSignUp.TextAlign = ContentAlignment.MiddleCenter;
            BtnSignUp.Click += BtnSignUp_Click;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(522, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 51);
            label1.TabIndex = 1;
            label1.Text = "نام : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(560, 380);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 51);
            label4.TabIndex = 1;
            label4.Text = "آدرس : ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(523, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(243, 51);
            label3.TabIndex = 1;
            label3.Text = "کد ملی : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(523, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 51);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserRegisterForm
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 84, 50);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(887, 566);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            Name = "UserRegisterForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label BtnSignUp;
        private Panel panel2;
        private TextBox NameTextBox;
        private TextBox AddressTextBox;
        private TextBox NationalityTextBox;
        private TextBox FamilyTextBox;
        private Label BtnBack;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        protected Label label5;
        private TextBox PasswordTextBox;
        private Panel panel3;
    }
}