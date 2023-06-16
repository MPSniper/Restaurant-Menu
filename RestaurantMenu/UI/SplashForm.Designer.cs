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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            panel1 = new Panel();
            BtnExit = new Label();
            BtnResturanRegister = new Label();
            BtnMainResturan = new Label();
            BtnLoginUser = new Label();
            BtnUserRegister = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnResturanRegister);
            panel1.Controls.Add(BtnMainResturan);
            panel1.Controls.Add(BtnLoginUser);
            panel1.Controls.Add(BtnUserRegister);
            panel1.Location = new Point(542, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 525);
            panel1.TabIndex = 20;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.DarkOrange;
            BtnExit.BorderStyle = BorderStyle.FixedSingle;
            BtnExit.Cursor = Cursors.Hand;
            BtnExit.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.Image = Properties.Resources.shutdown_40px;
            BtnExit.ImageAlign = ContentAlignment.MiddleRight;
            BtnExit.Location = new Point(57, 391);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(182, 43);
            BtnExit.TabIndex = 0;
            BtnExit.Text = "خروج";
            BtnExit.TextAlign = ContentAlignment.MiddleCenter;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnResturanRegister
            // 
            BtnResturanRegister.BackColor = Color.DarkOrange;
            BtnResturanRegister.BorderStyle = BorderStyle.FixedSingle;
            BtnResturanRegister.Cursor = Cursors.Hand;
            BtnResturanRegister.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnResturanRegister.Image = Properties.Resources.check_40px;
            BtnResturanRegister.ImageAlign = ContentAlignment.MiddleRight;
            BtnResturanRegister.Location = new Point(57, 317);
            BtnResturanRegister.Name = "BtnResturanRegister";
            BtnResturanRegister.Size = new Size(182, 43);
            BtnResturanRegister.TabIndex = 0;
            BtnResturanRegister.Text = "ثبت رستوران";
            BtnResturanRegister.TextAlign = ContentAlignment.MiddleCenter;
            BtnResturanRegister.Click += BtnResturanRegister_Click;
            // 
            // BtnMainResturan
            // 
            BtnMainResturan.BackColor = Color.DarkOrange;
            BtnMainResturan.BorderStyle = BorderStyle.FixedSingle;
            BtnMainResturan.Cursor = Cursors.Hand;
            BtnMainResturan.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMainResturan.Image = Properties.Resources.add_fingerprint_40px;
            BtnMainResturan.ImageAlign = ContentAlignment.MiddleRight;
            BtnMainResturan.Location = new Point(57, 80);
            BtnMainResturan.Name = "BtnMainResturan";
            BtnMainResturan.Size = new Size(182, 43);
            BtnMainResturan.TabIndex = 0;
            BtnMainResturan.Text = "ورود رستوران";
            BtnMainResturan.TextAlign = ContentAlignment.MiddleCenter;
            BtnMainResturan.Click += BtnMainResturan_Click;
            // 
            // BtnLoginUser
            // 
            BtnLoginUser.BackColor = Color.DarkOrange;
            BtnLoginUser.BorderStyle = BorderStyle.FixedSingle;
            BtnLoginUser.Cursor = Cursors.Hand;
            BtnLoginUser.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLoginUser.Image = Properties.Resources.add_fingerprint_40px;
            BtnLoginUser.ImageAlign = ContentAlignment.MiddleRight;
            BtnLoginUser.Location = new Point(57, 161);
            BtnLoginUser.Name = "BtnLoginUser";
            BtnLoginUser.Size = new Size(182, 43);
            BtnLoginUser.TabIndex = 0;
            BtnLoginUser.Text = "ورود کاربر";
            BtnLoginUser.TextAlign = ContentAlignment.MiddleCenter;
            BtnLoginUser.Click += BtnLoginUser_Click;
            // 
            // BtnUserRegister
            // 
            BtnUserRegister.BackColor = Color.DarkOrange;
            BtnUserRegister.BorderStyle = BorderStyle.FixedSingle;
            BtnUserRegister.Cursor = Cursors.Hand;
            BtnUserRegister.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUserRegister.Image = Properties.Resources.icons8_add_user_group_woman_man_40px;
            BtnUserRegister.ImageAlign = ContentAlignment.MiddleRight;
            BtnUserRegister.Location = new Point(57, 241);
            BtnUserRegister.Name = "BtnUserRegister";
            BtnUserRegister.Size = new Size(182, 43);
            BtnUserRegister.TabIndex = 0;
            BtnUserRegister.Text = "ثبت نام کاربر";
            BtnUserRegister.TextAlign = ContentAlignment.MiddleCenter;
            BtnUserRegister.Click += BtnUserRegister_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(86, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 375);
            panel2.TabIndex = 21;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(10F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 84, 50);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(887, 566);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("B Zar", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Label BtnLoginUser;
        private Panel panel2;
    }
}