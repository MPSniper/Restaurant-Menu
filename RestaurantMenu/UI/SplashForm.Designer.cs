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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Label();
            this.BtnResturanRegister = new System.Windows.Forms.Label();
            this.BtnMainResturan = new System.Windows.Forms.Label();
            this.BtnMainUser = new System.Windows.Forms.Label();
            this.BtnUserRegister = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnResturanRegister);
            this.panel1.Controls.Add(this.BtnMainResturan);
            this.panel1.Controls.Add(this.BtnMainUser);
            this.panel1.Controls.Add(this.BtnUserRegister);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 316);
            this.panel1.TabIndex = 20;
            // 
            // BtnExit
            // 
            this.BtnExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Image = global::UI.Properties.Resources.shutdown_40px;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.Location = new System.Drawing.Point(252, 269);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(182, 43);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "خروج";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnResturanRegister
            // 
            this.BtnResturanRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnResturanRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResturanRegister.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnResturanRegister.Image = global::UI.Properties.Resources.check_40px;
            this.BtnResturanRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnResturanRegister.Location = new System.Drawing.Point(252, 217);
            this.BtnResturanRegister.Name = "BtnResturanRegister";
            this.BtnResturanRegister.Size = new System.Drawing.Size(182, 43);
            this.BtnResturanRegister.TabIndex = 0;
            this.BtnResturanRegister.Text = "ثبت رستوران";
            this.BtnResturanRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnResturanRegister.Click += new System.EventHandler(this.BtnResturanRegister_Click);
            // 
            // BtnMainResturan
            // 
            this.BtnMainResturan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnMainResturan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMainResturan.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMainResturan.Image = global::UI.Properties.Resources.ifood_40px;
            this.BtnMainResturan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMainResturan.Location = new System.Drawing.Point(252, 53);
            this.BtnMainResturan.Name = "BtnMainResturan";
            this.BtnMainResturan.Size = new System.Drawing.Size(182, 43);
            this.BtnMainResturan.TabIndex = 0;
            this.BtnMainResturan.Text = "صفحه اصلی رستوران";
            this.BtnMainResturan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainResturan.Click += new System.EventHandler(this.BtnMainResturan_Click);
            // 
            // BtnMainUser
            // 
            this.BtnMainUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnMainUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMainUser.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMainUser.Image = global::UI.Properties.Resources.home_40px;
            this.BtnMainUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMainUser.Location = new System.Drawing.Point(252, 106);
            this.BtnMainUser.Name = "BtnMainUser";
            this.BtnMainUser.Size = new System.Drawing.Size(182, 43);
            this.BtnMainUser.TabIndex = 0;
            this.BtnMainUser.Text = "صفحه اصلی کاربران";
            this.BtnMainUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainUser.Click += new System.EventHandler(this.BtnMainUser_Click);
            // 
            // BtnUserRegister
            // 
            this.BtnUserRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnUserRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserRegister.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUserRegister.Image = global::UI.Properties.Resources.add_fingerprint_40px;
            this.BtnUserRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUserRegister.Location = new System.Drawing.Point(252, 162);
            this.BtnUserRegister.Name = "BtnUserRegister";
            this.BtnUserRegister.Size = new System.Drawing.Size(182, 43);
            this.BtnUserRegister.TabIndex = 0;
            this.BtnUserRegister.Text = "ثبت نام کاربر";
            this.BtnUserRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnUserRegister.Click += new System.EventHandler(this.BtnUserRegister_Click);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources._2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 340);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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