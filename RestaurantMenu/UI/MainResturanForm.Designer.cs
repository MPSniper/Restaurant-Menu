namespace UI
{
    partial class MainResturanForm
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
            PanelMenu = new Panel();
            BtnExit = new Button();
            BtnFactors = new Button();
            BtnFoods = new Button();
            PanelLogo = new Panel();
            PanelTitleBar = new Panel();
            lblTitle = new Label();
            PanelMain = new Panel();
            PanelMenu.SuspendLayout();
            PanelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(252, 194, 252);
            PanelMenu.Controls.Add(BtnExit);
            PanelMenu.Controls.Add(BtnFactors);
            PanelMenu.Controls.Add(BtnFoods);
            PanelMenu.Controls.Add(PanelLogo);
            PanelMenu.Dock = DockStyle.Right;
            PanelMenu.Location = new Point(894, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(220, 581);
            PanelMenu.TabIndex = 0;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Top;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("B Zar", 17F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = Color.Black;
            BtnExit.Image = Properties.Resources.icons8_close_window_40px;
            BtnExit.ImageAlign = ContentAlignment.MiddleLeft;
            BtnExit.Location = new Point(0, 200);
            BtnExit.Name = "BtnExit";
            BtnExit.Padding = new Padding(0, 0, 8, 0);
            BtnExit.Size = new Size(220, 60);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "خروج";
            BtnExit.TextAlign = ContentAlignment.MiddleLeft;
            BtnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnFactors
            // 
            BtnFactors.Dock = DockStyle.Top;
            BtnFactors.FlatAppearance.BorderSize = 0;
            BtnFactors.FlatStyle = FlatStyle.Flat;
            BtnFactors.Font = new Font("B Zar", 17F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFactors.ForeColor = Color.Black;
            BtnFactors.Image = Properties.Resources.arabic_book_40px;
            BtnFactors.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFactors.Location = new Point(0, 140);
            BtnFactors.Name = "BtnFactors";
            BtnFactors.Padding = new Padding(0, 0, 8, 0);
            BtnFactors.Size = new Size(220, 60);
            BtnFactors.TabIndex = 4;
            BtnFactors.Text = "فاکتور ها ";
            BtnFactors.TextAlign = ContentAlignment.MiddleLeft;
            BtnFactors.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFactors.UseVisualStyleBackColor = true;
            BtnFactors.Click += BtnFactors_Click;
            // 
            // BtnFoods
            // 
            BtnFoods.BackColor = Color.FromArgb(252, 194, 252);
            BtnFoods.Dock = DockStyle.Top;
            BtnFoods.FlatAppearance.BorderSize = 0;
            BtnFoods.FlatStyle = FlatStyle.Flat;
            BtnFoods.Font = new Font("B Zar", 17F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFoods.ForeColor = Color.Black;
            BtnFoods.Image = Properties.Resources.food_cart_40px;
            BtnFoods.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFoods.Location = new Point(0, 80);
            BtnFoods.Name = "BtnFoods";
            BtnFoods.Padding = new Padding(0, 0, 8, 0);
            BtnFoods.Size = new Size(220, 60);
            BtnFoods.TabIndex = 3;
            BtnFoods.Text = "محصولات";
            BtnFoods.TextAlign = ContentAlignment.MiddleLeft;
            BtnFoods.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFoods.UseVisualStyleBackColor = false;
            BtnFoods.Click += BtnFoods_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(201, 244, 170);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(220, 80);
            PanelLogo.TabIndex = 0;
            // 
            // PanelTitleBar
            // 
            PanelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            PanelTitleBar.Controls.Add(lblTitle);
            PanelTitleBar.Dock = DockStyle.Top;
            PanelTitleBar.Location = new Point(0, 0);
            PanelTitleBar.Name = "PanelTitleBar";
            PanelTitleBar.Size = new Size(894, 80);
            PanelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(201, 244, 170);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("B Zar", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(894, 80);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "مدیریت رستوران                    ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(0, 80);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(894, 501);
            PanelMain.TabIndex = 2;
            // 
            // MainResturanForm
            // 
            AutoScaleDimensions = new SizeF(10F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 581);
            Controls.Add(PanelMain);
            Controls.Add(PanelTitleBar);
            Controls.Add(PanelMenu);
            Font = new Font("B Zar", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainResturanForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            PanelMenu.ResumeLayout(false);
            PanelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel PanelMain;
        private Button BtnExit;
        private Button BtnFactors;
        private Button BtnFoods;
    }
}