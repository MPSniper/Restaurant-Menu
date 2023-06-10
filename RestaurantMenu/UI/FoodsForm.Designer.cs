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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.NumericUpDown();
            this.BtnAddOrEdit = new System.Windows.Forms.Button();
            this.BtnCancell = new System.Windows.Forms.Button();
            this.BtnDeleteFood = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNameSearch = new System.Windows.Forms.TextBox();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFoods)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.FoodPrice});
            this.DataFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataFoods.Location = new System.Drawing.Point(0, 0);
            this.DataFoods.Name = "DataFoods";
            this.DataFoods.ReadOnly = true;
            this.DataFoods.RowTemplate.Height = 25;
            this.DataFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataFoods.Size = new System.Drawing.Size(894, 331);
            this.DataFoods.TabIndex = 0;
            this.DataFoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataFoods_CellClick);
            // 
            // FoodId
            // 
            this.FoodId.HeaderText = "کد محصول";
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            this.FoodId.Visible = false;
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
            this.groupBox2.Controls.Add(this.BtnAddOrEdit);
            this.groupBox2.Controls.Add(this.BtnCancell);
            this.groupBox2.Controls.Add(this.BtnDeleteFood);
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
            this.BtnAddOrEdit.Location = new System.Drawing.Point(3, 27);
            this.BtnAddOrEdit.Name = "BtnAddOrEdit";
            this.BtnAddOrEdit.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnAddOrEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAddOrEdit.Size = new System.Drawing.Size(135, 40);
            this.BtnAddOrEdit.TabIndex = 18;
            this.BtnAddOrEdit.Text = "افزودن";
            this.BtnAddOrEdit.UseVisualStyleBackColor = false;
            this.BtnAddOrEdit.Click += new System.EventHandler(this.BtnAddOrEdit_Click);
            // 
            // BtnCancell
            // 
            this.BtnCancell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnCancell.Enabled = false;
            this.BtnCancell.FlatAppearance.BorderSize = 0;
            this.BtnCancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancell.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancell.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCancell.Image = global::UI.Properties.Resources.cancel_32px;
            this.BtnCancell.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancell.Location = new System.Drawing.Point(3, 119);
            this.BtnCancell.Name = "BtnCancell";
            this.BtnCancell.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnCancell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCancell.Size = new System.Drawing.Size(135, 40);
            this.BtnCancell.TabIndex = 18;
            this.BtnCancell.Text = "کنسل";
            this.BtnCancell.UseVisualStyleBackColor = false;
            this.BtnCancell.Click += new System.EventHandler(this.BtnCancell_Click);
            // 
            // BtnDeleteFood
            // 
            this.BtnDeleteFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnDeleteFood.Enabled = false;
            this.BtnDeleteFood.FlatAppearance.BorderSize = 0;
            this.BtnDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteFood.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDeleteFood.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDeleteFood.Image = global::UI.Properties.Resources.unavailable_32px;
            this.BtnDeleteFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeleteFood.Location = new System.Drawing.Point(3, 73);
            this.BtnDeleteFood.Name = "BtnDeleteFood";
            this.BtnDeleteFood.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnDeleteFood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDeleteFood.Size = new System.Drawing.Size(135, 40);
            this.BtnDeleteFood.TabIndex = 18;
            this.BtnDeleteFood.Text = "حذف";
            this.BtnDeleteFood.UseVisualStyleBackColor = false;
            this.BtnDeleteFood.Click += new System.EventHandler(this.BtnDeleteFood_Click);
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
            this.groupBox1.Controls.Add(this.BtnAll);
            this.groupBox1.Controls.Add(this.BtnSearch);
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
            this.TxtNameSearch.Location = new System.Drawing.Point(40, 55);
            this.TxtNameSearch.MaxLength = 150;
            this.TxtNameSearch.Name = "TxtNameSearch";
            this.TxtNameSearch.Size = new System.Drawing.Size(282, 32);
            this.TxtNameSearch.TabIndex = 23;
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
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
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
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(328, 56);
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
            this.Text = "مدیریت محصولات";
            this.Load += new System.EventHandler(this.FoodsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataFoods)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataFoods;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnAddOrEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancell;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.NumericUpDown TxtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtNameSearch;
        private Button BtnDeleteFood;
        private DataGridViewTextBoxColumn FoodId;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn FoodPrice;
    }
}