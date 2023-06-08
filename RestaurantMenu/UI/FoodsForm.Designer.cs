namespace UI
{
    partial class FoodsForm
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
            this.DataFoods = new System.Windows.Forms.DataGridView();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.NumericUpDown();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.BtnAddOrEdit = new System.Windows.Forms.Button();
            this.BtnCancell = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnDisableAndEnable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNameSearch = new System.Windows.Forms.TextBox();
            this.TxtPriceSearch = new System.Windows.Forms.NumericUpDown();
            this.CmbCategorySearch = new System.Windows.Forms.ComboBox();
            this.CmbStatusSearch = new System.Windows.Forms.ComboBox();
            this.BtnAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFoods)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPriceSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataFoods);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 331);
            this.panel1.TabIndex = 0;
            // 
            // DataFoods
            // 
            this.DataFoods.AllowUserToAddRows = false;
            this.DataFoods.AllowUserToDeleteRows = false;
            this.DataFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.FoodName,
            this.FoodPrice,
            this.FoodCategory,
            this.IsDeleted,
            this.CreationDate});
            this.DataFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataFoods.Location = new System.Drawing.Point(0, 0);
            this.DataFoods.Name = "DataFoods";
            this.DataFoods.ReadOnly = true;
            this.DataFoods.RowTemplate.Height = 25;
            this.DataFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataFoods.Size = new System.Drawing.Size(894, 331);
            this.DataFoods.TabIndex = 0;
            // 
            // FoodId
            // 
            this.FoodId.HeaderText = "کد محصول";
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "نام محصول";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // FoodPrice
            // 
            this.FoodPrice.HeaderText = "قیمت محصول";
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.ReadOnly = true;
            // 
            // FoodCategory
            // 
            this.FoodCategory.HeaderText = "دسته بندی محصول";
            this.FoodCategory.Name = "FoodCategory";
            this.FoodCategory.ReadOnly = true;
            // 
            // IsDeleted
            // 
            this.IsDeleted.HeaderText = "وضعیت";
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.HeaderText = "تاریخ ایجاد";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 170);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtName);
            this.groupBox2.Controls.Add(this.TxtPrice);
            this.groupBox2.Controls.Add(this.CmbCategory);
            this.groupBox2.Controls.Add(this.BtnAddOrEdit);
            this.groupBox2.Controls.Add(this.BtnCancell);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BtnDisableAndEnable);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 170);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حذف، ویرایش، افزودن";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(147, 26);
            this.TxtName.MaxLength = 150;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(219, 32);
            this.TxtName.TabIndex = 23;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TxtPrice.Location = new System.Drawing.Point(147, 71);
            this.TxtPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(219, 32);
            this.TxtPrice.TabIndex = 22;
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Items.AddRange(new object[] {
            "همه",
            "فعال",
            "غیرفعال"});
            this.CmbCategory.Location = new System.Drawing.Point(147, 116);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(219, 33);
            this.CmbCategory.TabIndex = 21;
            // 
            // BtnAddOrEdit
            // 
            this.BtnAddOrEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddOrEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnAddOrEdit.FlatAppearance.BorderSize = 0;
            this.BtnAddOrEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddOrEdit.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddOrEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAddOrEdit.Image = global::UI.Properties.Resources.add_32px;
            this.BtnAddOrEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddOrEdit.Location = new System.Drawing.Point(3, 21);
            this.BtnAddOrEdit.Name = "BtnAddOrEdit";
            this.BtnAddOrEdit.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnAddOrEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAddOrEdit.Size = new System.Drawing.Size(135, 40);
            this.BtnAddOrEdit.TabIndex = 18;
            this.BtnAddOrEdit.Text = "افزودن";
            this.BtnAddOrEdit.UseVisualStyleBackColor = false;
            // 
            // BtnCancell
            // 
            this.BtnCancell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnCancell.FlatAppearance.BorderSize = 0;
            this.BtnCancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancell.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancell.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCancell.Image = global::UI.Properties.Resources.cancel_32px;
            this.BtnCancell.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancell.Location = new System.Drawing.Point(3, 113);
            this.BtnCancell.Name = "BtnCancell";
            this.BtnCancell.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnCancell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCancell.Size = new System.Drawing.Size(135, 40);
            this.BtnCancell.TabIndex = 18;
            this.BtnCancell.Text = "کنسل";
            this.BtnCancell.UseVisualStyleBackColor = false;
            this.BtnCancell.Visible = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(372, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "دسته بندی : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDisableAndEnable
            // 
            this.BtnDisableAndEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDisableAndEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnDisableAndEnable.FlatAppearance.BorderSize = 0;
            this.BtnDisableAndEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisableAndEnable.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDisableAndEnable.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDisableAndEnable.Image = global::UI.Properties.Resources.unavailable_32px;
            this.BtnDisableAndEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDisableAndEnable.Location = new System.Drawing.Point(3, 67);
            this.BtnDisableAndEnable.Name = "BtnDisableAndEnable";
            this.BtnDisableAndEnable.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnDisableAndEnable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDisableAndEnable.Size = new System.Drawing.Size(135, 40);
            this.BtnDisableAndEnable.TabIndex = 18;
            this.BtnDisableAndEnable.Text = "فعال سازی";
            this.BtnDisableAndEnable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDisableAndEnable.UseVisualStyleBackColor = false;
            this.BtnDisableAndEnable.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(372, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "نام : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(372, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "قیمت : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNameSearch);
            this.groupBox1.Controls.Add(this.TxtPriceSearch);
            this.groupBox1.Controls.Add(this.CmbCategorySearch);
            this.groupBox1.Controls.Add(this.CmbStatusSearch);
            this.groupBox1.Controls.Add(this.BtnAll);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(449, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 170);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جو";
            // 
            // TxtNameSearch
            // 
            this.TxtNameSearch.Location = new System.Drawing.Point(229, 25);
            this.TxtNameSearch.MaxLength = 150;
            this.TxtNameSearch.Name = "TxtNameSearch";
            this.TxtNameSearch.Size = new System.Drawing.Size(110, 32);
            this.TxtNameSearch.TabIndex = 23;
            // 
            // TxtPriceSearch
            // 
            this.TxtPriceSearch.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TxtPriceSearch.Location = new System.Drawing.Point(32, 28);
            this.TxtPriceSearch.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.TxtPriceSearch.Name = "TxtPriceSearch";
            this.TxtPriceSearch.Size = new System.Drawing.Size(129, 32);
            this.TxtPriceSearch.TabIndex = 22;
            // 
            // CmbCategorySearch
            // 
            this.CmbCategorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategorySearch.FormattingEnabled = true;
            this.CmbCategorySearch.Items.AddRange(new object[] {
            "همه",
            "فعال",
            "غیرفعال"});
            this.CmbCategorySearch.Location = new System.Drawing.Point(229, 75);
            this.CmbCategorySearch.Name = "CmbCategorySearch";
            this.CmbCategorySearch.Size = new System.Drawing.Size(110, 33);
            this.CmbCategorySearch.TabIndex = 21;
            // 
            // CmbStatusSearch
            // 
            this.CmbStatusSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatusSearch.FormattingEnabled = true;
            this.CmbStatusSearch.Items.AddRange(new object[] {
            "همه",
            "فعال",
            "غیرفعال"});
            this.CmbStatusSearch.Location = new System.Drawing.Point(32, 73);
            this.CmbStatusSearch.Name = "CmbStatusSearch";
            this.CmbStatusSearch.Size = new System.Drawing.Size(129, 33);
            this.CmbStatusSearch.TabIndex = 21;
            // 
            // BtnAll
            // 
            this.BtnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnAll.FlatAppearance.BorderSize = 0;
            this.BtnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAll.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAll.Image = global::UI.Properties.Resources.search_32px;
            this.BtnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAll.Location = new System.Drawing.Point(99, 120);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAll.Size = new System.Drawing.Size(135, 40);
            this.BtnAll.TabIndex = 21;
            this.BtnAll.Text = "مشاهده همه";
            this.BtnAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAll.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(345, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "دسته بندی : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSearch.Image = global::UI.Properties.Resources.search_32px;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.Location = new System.Drawing.Point(240, 120);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSearch.Size = new System.Drawing.Size(135, 40);
            this.BtnSearch.TabIndex = 21;
            this.BtnSearch.Text = "جست و جو";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(167, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "قیمت : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(167, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "وضعیت : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(345, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "نام : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("B Zar", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FoodsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataFoods)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPriceSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataFoods;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDisableAndEnable;
        private System.Windows.Forms.Button BtnAddOrEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbStatusSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancell;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TxtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TxtPriceSearch;
        private System.Windows.Forms.ComboBox CmbCategorySearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtNameSearch;
    }
}