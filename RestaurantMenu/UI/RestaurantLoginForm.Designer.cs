namespace UI
{
    partial class RestaurantLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantLoginForm));
            TxtNationalCode = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            BtnLogin = new Label();
            panel3 = new Panel();
            BtnBack = new Label();
            TxtPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TxtNationalCode
            // 
            TxtNationalCode.BackColor = Color.MistyRose;
            TxtNationalCode.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNationalCode.Location = new Point(498, 136);
            TxtNationalCode.Margin = new Padding(3, 4, 3, 4);
            TxtNationalCode.MaxLength = 10;
            TxtNationalCode.Name = "TxtNationalCode";
            TxtNationalCode.RightToLeft = RightToLeft.No;
            TxtNationalCode.Size = new Size(293, 49);
            TxtNationalCode.TabIndex = 2;
            TxtNationalCode.TextChanged += TxtNationalCode_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(14, 5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(861, 548);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnLogin);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(BtnBack);
            panel2.Controls.Add(TxtNationalCode);
            panel2.Controls.Add(TxtPassword);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(15, 5);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 539);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.DarkOrange;
            BtnLogin.BorderStyle = BorderStyle.FixedSingle;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.Image = Properties.Resources.add_fingerprint_40px;
            BtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogin.Location = new Point(511, 462);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(265, 57);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "ورود";
            BtnLogin.TextAlign = ContentAlignment.MiddleCenter;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(45, 77);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(392, 334);
            panel3.TabIndex = 22;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.DarkOrange;
            BtnBack.BorderStyle = BorderStyle.FixedSingle;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.Image = Properties.Resources.icons8_back_to_40px_1;
            BtnBack.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBack.Location = new Point(109, 462);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(268, 57);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "بازگشت";
            BtnBack.TextAlign = ContentAlignment.MiddleCenter;
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.MistyRose;
            TxtPassword.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(498, 276);
            TxtPassword.Margin = new Padding(3, 4, 3, 4);
            TxtPassword.MaxLength = 10;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.RightToLeft = RightToLeft.No;
            TxtPassword.Size = new Size(293, 49);
            TxtPassword.TabIndex = 2;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(497, 77);
            label3.Name = "label3";
            label3.Size = new Size(294, 55);
            label3.TabIndex = 1;
            label3.Text = "کد ملی : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(498, 217);
            label2.Name = "label2";
            label2.Size = new Size(294, 55);
            label2.TabIndex = 1;
            label2.Text = "رمز ورود : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(355, 4);
            label6.Name = "label6";
            label6.Size = new Size(313, 55);
            label6.TabIndex = 1;
            label6.Text = "اطلاعات کاربری";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RestaurantLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 84, 50);
            ClientSize = new Size(887, 566);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RestaurantLoginForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود رستوران";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtNationalCode;
        private Panel panel1;
        private Panel panel2;
        private TextBox TxtPassword;
        private Label BtnBack;
        private Label BtnLogin;
        private Label label3;
        private Label label2;
        private Label label6;
        private Panel panel3;
    }
}