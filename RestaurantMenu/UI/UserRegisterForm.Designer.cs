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
            panel1 = new Panel();
            panel2 = new Panel();
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
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(16, 15);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(625, 430);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
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
            panel2.Location = new Point(4, 70);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 352);
            panel2.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(56, 155);
            PasswordTextBox.Margin = new Padding(4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(241, 30);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 100);
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
            NameTextBox.Location = new Point(355, 59);
            NameTextBox.Margin = new Padding(4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(241, 30);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.None;
            AddressTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTextBox.Location = new Point(56, 216);
            AddressTextBox.Margin = new Padding(4);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.ScrollBars = ScrollBars.Vertical;
            AddressTextBox.Size = new Size(407, 50);
            AddressTextBox.TabIndex = 5;
            AddressTextBox.TextChanged += textBox4_TextChanged;
            // 
            // NationalityTextBox
            // 
            NationalityTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NationalityTextBox.Location = new Point(355, 155);
            NationalityTextBox.Margin = new Padding(4);
            NationalityTextBox.Name = "NationalityTextBox";
            NationalityTextBox.Size = new Size(241, 30);
            NationalityTextBox.TabIndex = 3;
            NationalityTextBox.TextChanged += textBox3_TextChanged;
            // 
            // FamilyTextBox
            // 
            FamilyTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FamilyTextBox.Location = new Point(56, 59);
            FamilyTextBox.Margin = new Padding(4);
            FamilyTextBox.Name = "FamilyTextBox";
            FamilyTextBox.Size = new Size(241, 30);
            FamilyTextBox.TabIndex = 2;
            FamilyTextBox.TextChanged += textBox2_TextChanged;
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
            BtnBack.Margin = new Padding(4, 0, 4, 0);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(303, 53);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "بازگشت";
            BtnBack.TextAlign = ContentAlignment.MiddleCenter;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnSignUp
            // 
            BtnSignUp.BackColor = Color.FromArgb(192, 255, 192);
            BtnSignUp.BorderStyle = BorderStyle.FixedSingle;
            BtnSignUp.Cursor = Cursors.Hand;
            BtnSignUp.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSignUp.Image = Properties.Resources.icons8_add_user_group_woman_man_40px;
            BtnSignUp.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSignUp.Location = new Point(316, 291);
            BtnSignUp.Margin = new Padding(4, 0, 4, 0);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(281, 53);
            BtnSignUp.TabIndex = 0;
            BtnSignUp.Text = "ثبت اطلاعات";
            BtnSignUp.TextAlign = ContentAlignment.MiddleCenter;
            BtnSignUp.Click += BtnSignUp_Click;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(355, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 51);
            label1.TabIndex = 1;
            label1.Text = "نام : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(472, 216);
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
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(355, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(243, 51);
            label3.TabIndex = 1;
            label3.Text = "کد ملی : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(56, 4);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 51);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(4, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(608, 51);
            label6.TabIndex = 1;
            label6.Text = "اطلاعات کاربری";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserRegisterForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._45_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(655, 461);
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
    }
}