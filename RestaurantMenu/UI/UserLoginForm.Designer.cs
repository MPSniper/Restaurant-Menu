namespace UI
{
    partial class UserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            TxtNationalCode = new TextBox();
            label6 = new Label();
            TxtPassword = new TextBox();
            BtnBack = new Label();
            BtnLogin = new Label();
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(863, 542);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(TxtNationalCode);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(TxtPassword);
            panel2.Controls.Add(BtnBack);
            panel2.Controls.Add(BtnLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, -14);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 553);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(73, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 254);
            panel3.TabIndex = 21;
            // 
            // TxtNationalCode
            // 
            TxtNationalCode.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNationalCode.Location = new Point(506, 187);
            TxtNationalCode.MaxLength = 10;
            TxtNationalCode.Name = "TxtNationalCode";
            TxtNationalCode.RightToLeft = RightToLeft.No;
            TxtNationalCode.Size = new Size(257, 49);
            TxtNationalCode.TabIndex = 2;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOrange;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(2, 14);
            label6.Name = "label6";
            label6.Size = new Size(858, 41);
            label6.TabIndex = 1;
            label6.Text = "اطلاعات کاربری";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(506, 295);
            TxtPassword.MaxLength = 10;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.RightToLeft = RightToLeft.No;
            TxtPassword.Size = new Size(257, 49);
            TxtPassword.TabIndex = 2;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.DarkOrange;
            BtnBack.BorderStyle = BorderStyle.FixedSingle;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.Image = Properties.Resources.icons8_back_to_40px_1;
            BtnBack.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBack.Location = new Point(106, 454);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(230, 66);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "بازگشت";
            BtnBack.TextAlign = ContentAlignment.MiddleCenter;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.DarkOrange;
            BtnLogin.BorderStyle = BorderStyle.FixedSingle;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.Image = Properties.Resources.add_fingerprint_40px;
            BtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogin.Location = new Point(516, 454);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(238, 66);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "ورود";
            BtnLogin.TextAlign = ContentAlignment.MiddleCenter;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(506, 143);
            label3.Name = "label3";
            label3.Size = new Size(257, 41);
            label3.TabIndex = 1;
            label3.Text = "کد ملی : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(506, 248);
            label2.Name = "label2";
            label2.Size = new Size(257, 41);
            label2.TabIndex = 1;
            label2.Text = "رمز ورود : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 84, 50);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(887, 566);
            Controls.Add(panel1);
            Font = new Font("B Zar", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserLoginForm";
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
        private TextBox TxtNationalCode;
        private TextBox TxtPassword;
        private Label BtnBack;
        private Label label3;
        private Label label2;
        private Label label6;
        private Panel panel3;
    }
}