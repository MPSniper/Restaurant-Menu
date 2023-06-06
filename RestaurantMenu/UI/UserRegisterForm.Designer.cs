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
            NameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            NationalityTextBox = new TextBox();
            FamilyTextBox = new TextBox();
            BtnBack = new Label();
            BtnLogin = new Label();
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(470, 345);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(AddressTextBox);
            panel2.Controls.Add(NationalityTextBox);
            panel2.Controls.Add(FamilyTextBox);
            panel2.Controls.Add(BtnBack);
            panel2.Controls.Add(BtnLogin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 282);
            panel2.TabIndex = 3;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(266, 47);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(182, 41);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTextBox.Location = new Point(3, 47);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.ScrollBars = ScrollBars.Vertical;
            AddressTextBox.Size = new Size(257, 129);
            AddressTextBox.TabIndex = 2;
            AddressTextBox.TextChanged += textBox4_TextChanged;
            // 
            // NationalityTextBox
            // 
            NationalityTextBox.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NationalityTextBox.Location = new Point(266, 223);
            NationalityTextBox.Name = "NationalityTextBox";
            NationalityTextBox.Size = new Size(182, 41);
            NationalityTextBox.TabIndex = 2;
            NationalityTextBox.TextChanged += textBox3_TextChanged;
            // 
            // FamilyTextBox
            // 
            FamilyTextBox.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FamilyTextBox.Location = new Point(266, 135);
            FamilyTextBox.Name = "FamilyTextBox";
            FamilyTextBox.Size = new Size(182, 41);
            FamilyTextBox.TabIndex = 2;
            FamilyTextBox.TextChanged += textBox2_TextChanged;
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
            BtnBack.Size = new Size(257, 43);
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
            BtnLogin.Image = Properties.Resources.icons8_add_user_group_woman_man_40px;
            BtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogin.Location = new Point(3, 180);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(257, 43);
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
            label1.Location = new Point(266, 3);
            label1.Name = "label1";
            label1.Size = new Size(182, 41);
            label1.TabIndex = 1;
            label1.Text = "نام : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(257, 41);
            label4.TabIndex = 1;
            label4.Text = "آدرس : ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(266, 179);
            label3.Name = "label3";
            label3.Size = new Size(182, 41);
            label3.TabIndex = 1;
            label3.Text = "کد ملی : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(266, 91);
            label2.Name = "label2";
            label2.Size = new Size(182, 41);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            label6.Text = "اطلاعات کاربری";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserRegisterForm
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
            Name = "UserRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label BtnLogin;
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
    }
}