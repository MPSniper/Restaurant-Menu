namespace UI
{
    partial class SplashForm
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
            BtnExit = new Label();
            BtnResturanRegister = new Label();
            BtnMainResturan = new Label();
            BtnMainUser = new Label();
            BtnUserRegister = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnResturanRegister);
            panel1.Controls.Add(BtnMainResturan);
            panel1.Controls.Add(BtnMainUser);
            panel1.Controls.Add(BtnUserRegister);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 316);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // BtnExit
            // 
            BtnExit.BorderStyle = BorderStyle.FixedSingle;
            BtnExit.Cursor = Cursors.Hand;
            BtnExit.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.Image = Properties.Resources.shutdown_40px;
            BtnExit.ImageAlign = ContentAlignment.MiddleRight;
            BtnExit.Location = new Point(252, 269);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(182, 43);
            BtnExit.TabIndex = 0;
            BtnExit.Text = "خروج";
            BtnExit.TextAlign = ContentAlignment.MiddleCenter;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnResturanRegister
            // 
            BtnResturanRegister.BorderStyle = BorderStyle.FixedSingle;
            BtnResturanRegister.Cursor = Cursors.Hand;
            BtnResturanRegister.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnResturanRegister.Image = Properties.Resources.check_40px;
            BtnResturanRegister.ImageAlign = ContentAlignment.MiddleRight;
            BtnResturanRegister.Location = new Point(252, 217);
            BtnResturanRegister.Name = "BtnResturanRegister";
            BtnResturanRegister.Size = new Size(182, 43);
            BtnResturanRegister.TabIndex = 0;
            BtnResturanRegister.Text = "ثبت رستوران";
            BtnResturanRegister.TextAlign = ContentAlignment.MiddleCenter;
            BtnResturanRegister.Click += BtnResturanRegister_Click;
            // 
            // BtnMainResturan
            // 
            BtnMainResturan.BorderStyle = BorderStyle.FixedSingle;
            BtnMainResturan.Cursor = Cursors.Hand;
            BtnMainResturan.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMainResturan.Image = Properties.Resources.ifood_40px;
            BtnMainResturan.ImageAlign = ContentAlignment.MiddleRight;
            BtnMainResturan.Location = new Point(252, 53);
            BtnMainResturan.Name = "BtnMainResturan";
            BtnMainResturan.Size = new Size(182, 43);
            BtnMainResturan.TabIndex = 0;
            BtnMainResturan.Text = "صفحه اصلی رستوران";
            BtnMainResturan.TextAlign = ContentAlignment.MiddleLeft;
            BtnMainResturan.Click += BtnMainResturan_Click;
            // 
            // BtnMainUser
            // 
            BtnMainUser.BorderStyle = BorderStyle.FixedSingle;
            BtnMainUser.Cursor = Cursors.Hand;
            BtnMainUser.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMainUser.Image = Properties.Resources.home_40px;
            BtnMainUser.ImageAlign = ContentAlignment.MiddleRight;
            BtnMainUser.Location = new Point(252, 106);
            BtnMainUser.Name = "BtnMainUser";
            BtnMainUser.Size = new Size(182, 43);
            BtnMainUser.TabIndex = 0;
            BtnMainUser.Text = "صفحه اصلی کاربران";
            BtnMainUser.TextAlign = ContentAlignment.MiddleLeft;
            BtnMainUser.Click += BtnMainUser_Click;
            // 
            // BtnUserRegister
            // 
            BtnUserRegister.BorderStyle = BorderStyle.FixedSingle;
            BtnUserRegister.Cursor = Cursors.Hand;
            BtnUserRegister.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUserRegister.Image = Properties.Resources.add_fingerprint_40px;
            BtnUserRegister.ImageAlign = ContentAlignment.MiddleRight;
            BtnUserRegister.Location = new Point(252, 162);
            BtnUserRegister.Name = "BtnUserRegister";
            BtnUserRegister.Size = new Size(182, 43);
            BtnUserRegister.TabIndex = 0;
            BtnUserRegister.Text = "ثبت نام کاربر";
            BtnUserRegister.TextAlign = ContentAlignment.MiddleCenter;
            BtnUserRegister.Click += BtnUserRegister_Click;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(10F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(549, 340);
            Controls.Add(panel1);
            Font = new Font("B Zar", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label BtnExit;
        private Label BtnResturanRegister;
        private Label BtnUserRegister;
        private Label BtnMainResturan;
        private Label BtnMainUser;
    }
}