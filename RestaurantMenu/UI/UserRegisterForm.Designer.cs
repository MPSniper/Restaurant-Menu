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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.NationalityTextBox = new System.Windows.Forms.TextBox();
            this.FamilyTextBox = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(470, 345);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.AddressTextBox);
            this.panel2.Controls.Add(this.NationalityTextBox);
            this.panel2.Controls.Add(this.FamilyTextBox);
            this.panel2.Controls.Add(this.BtnBack);
            this.panel2.Controls.Add(this.BtnLogin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 282);
            this.panel2.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(266, 47);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(182, 41);
            this.NameTextBox.TabIndex = 2;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressTextBox.Location = new System.Drawing.Point(3, 47);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddressTextBox.Size = new System.Drawing.Size(257, 129);
            this.AddressTextBox.TabIndex = 2;
            // 
            // NationalityTextBox
            // 
            this.NationalityTextBox.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NationalityTextBox.Location = new System.Drawing.Point(266, 223);
            this.NationalityTextBox.Name = "NationalityTextBox";
            this.NationalityTextBox.Size = new System.Drawing.Size(182, 41);
            this.NationalityTextBox.TabIndex = 2;
            // 
            // FamilyTextBox
            // 
            this.FamilyTextBox.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FamilyTextBox.Location = new System.Drawing.Point(266, 135);
            this.FamilyTextBox.Name = "FamilyTextBox";
            this.FamilyTextBox.Size = new System.Drawing.Size(182, 41);
            this.FamilyTextBox.TabIndex = 2;
            // 
            // BtnBack
            // 
            this.BtnBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Image = global::UI.Properties.Resources.icons8_back_to_40px_1;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Location = new System.Drawing.Point(3, 233);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(257, 43);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "بازگشت";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.Image = global::UI.Properties.Resources.icons8_add_user_group_woman_man_40px;
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.Location = new System.Drawing.Point(3, 180);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(257, 43);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "ثبت اطلاعات";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(266, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "آدرس : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(266, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "کد ملی : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(266, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(456, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "اطلاعات کاربری";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources._45_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 369);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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