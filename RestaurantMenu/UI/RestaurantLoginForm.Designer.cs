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
            TxtNationalCode = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            TxtPassword = new TextBox();
            BtnBack = new Label();
            BtnLogin = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TxtNationalCode
            // 
            TxtNationalCode.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNationalCode.Location = new Point(3, 53);
            TxtNationalCode.MaxLength = 10;
            TxtNationalCode.Name = "TxtNationalCode";
            TxtNationalCode.RightToLeft = RightToLeft.No;
            TxtNationalCode.Size = new Size(257, 41);
            TxtNationalCode.TabIndex = 2;
            TxtNationalCode.TextChanged += TxtNationalCode_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources._45_;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(286, 345);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TxtNationalCode);
            panel2.Controls.Add(TxtPassword);
            panel2.Controls.Add(BtnBack);
            panel2.Controls.Add(BtnLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 296);
            panel2.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(3, 141);
            TxtPassword.MaxLength = 10;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.RightToLeft = RightToLeft.No;
            TxtPassword.Size = new Size(257, 41);
            TxtPassword.TabIndex = 2;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // BtnBack
            // 
            BtnBack.BorderStyle = BorderStyle.FixedSingle;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBack.Image = Properties.Resources.icons8_back_to_40px_1;
            BtnBack.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBack.Location = new Point(3, 238);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(257, 43);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "بازگشت";
            BtnBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnLogin
            // 
            BtnLogin.BorderStyle = BorderStyle.FixedSingle;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.Image = Properties.Resources.add_fingerprint_40px;
            BtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogin.Location = new Point(3, 185);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(257, 43);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "ورود";
            BtnLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(257, 41);
            label3.TabIndex = 1;
            label3.Text = "کد ملی : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(3, 97);
            label2.Name = "label2";
            label2.Size = new Size(257, 41);
            label2.TabIndex = 1;
            label2.Text = "رمز ورود : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(3, 12);
            label6.Name = "label6";
            label6.Size = new Size(274, 41);
            label6.TabIndex = 1;
            label6.Text = "اطلاعات کاربری";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RestaurantLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 358);
            Controls.Add(panel1);
            Name = "RestaurantLoginForm";
            Text = "RestaurantRegisterForm";
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
    }
}