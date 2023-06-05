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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnFactors = new System.Windows.Forms.Button();
            this.BtnFoods = new System.Windows.Forms.Button();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.PanelMenu.Controls.Add(this.BtnExit);
            this.PanelMenu.Controls.Add(this.BtnFactors);
            this.PanelMenu.Controls.Add(this.BtnFoods);
            this.PanelMenu.Controls.Add(this.BtnCategory);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelMenu.Location = new System.Drawing.Point(894, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 581);
            this.PanelMenu.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("B Zar", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Image = global::UI.Properties.Resources.icons8_close_window_40px;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(0, 260);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnExit.Size = new System.Drawing.Size(220, 60);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "خروج";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnFactors
            // 
            this.BtnFactors.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFactors.FlatAppearance.BorderSize = 0;
            this.BtnFactors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFactors.Font = new System.Drawing.Font("B Zar", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFactors.ForeColor = System.Drawing.Color.Black;
            this.BtnFactors.Image = global::UI.Properties.Resources.arabic_book_40px;
            this.BtnFactors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactors.Location = new System.Drawing.Point(0, 200);
            this.BtnFactors.Name = "BtnFactors";
            this.BtnFactors.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnFactors.Size = new System.Drawing.Size(220, 60);
            this.BtnFactors.TabIndex = 4;
            this.BtnFactors.Text = "فاکتور ها ";
            this.BtnFactors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFactors.UseVisualStyleBackColor = true;
            this.BtnFactors.Click += new System.EventHandler(this.BtnFactors_Click);
            // 
            // BtnFoods
            // 
            this.BtnFoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFoods.FlatAppearance.BorderSize = 0;
            this.BtnFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFoods.Font = new System.Drawing.Font("B Zar", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFoods.ForeColor = System.Drawing.Color.Black;
            this.BtnFoods.Image = global::UI.Properties.Resources.food_cart_40px;
            this.BtnFoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFoods.Location = new System.Drawing.Point(0, 140);
            this.BtnFoods.Name = "BtnFoods";
            this.BtnFoods.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnFoods.Size = new System.Drawing.Size(220, 60);
            this.BtnFoods.TabIndex = 3;
            this.BtnFoods.Text = "محصولات";
            this.BtnFoods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFoods.UseVisualStyleBackColor = true;
            this.BtnFoods.Click += new System.EventHandler(this.BtnFoods_Click);
            // 
            // BtnCategory
            // 
            this.BtnCategory.BackColor = System.Drawing.Color.Coral;
            this.BtnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCategory.FlatAppearance.BorderSize = 0;
            this.BtnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategory.Font = new System.Drawing.Font("B Zar", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCategory.ForeColor = System.Drawing.Color.Black;
            this.BtnCategory.Image = global::UI.Properties.Resources.home_40px;
            this.BtnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategory.Location = new System.Drawing.Point(0, 80);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnCategory.Size = new System.Drawing.Size(220, 60);
            this.BtnCategory.TabIndex = 2;
            this.BtnCategory.Text = "دسته بندی ها";
            this.BtnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCategory.UseVisualStyleBackColor = false;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(244)))), ((int)(((byte)(170)))));
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 80);
            this.PanelLogo.TabIndex = 0;
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PanelTitleBar.Controls.Add(this.lblTitle);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(894, 80);
            this.PanelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(204)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("B Zar", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(894, 80);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "مدیریت رستوران";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 80);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(894, 501);
            this.PanelMain.TabIndex = 2;
            // 
            // MainResturanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 581);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("B Zar", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainResturanForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelMenu.ResumeLayout(false);
            this.PanelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Button BtnCategory;
    }
}