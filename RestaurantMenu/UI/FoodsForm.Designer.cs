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
            panel1 = new Panel();
            DataFoods = new DataGridView();
            FoodId = new DataGridViewTextBoxColumn();
            FoodName = new DataGridViewTextBoxColumn();
            FoodPrice = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            TxtName = new TextBox();
            TxtPrice = new NumericUpDown();
            BtnAddOrEdit = new Button();
            BtnCancell = new Button();
            BtnDeleteFood = new Button();
            label2 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            TxtNameSearch = new TextBox();
            BtnAll = new Button();
            BtnSearch = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataFoods).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtPrice).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(DataFoods);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 331);
            panel1.TabIndex = 0;
            // 
            // DataFoods
            // 
            DataFoods.AllowUserToAddRows = false;
            DataFoods.AllowUserToDeleteRows = false;
            DataFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataFoods.BackgroundColor = SystemColors.GradientInactiveCaption;
            DataFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataFoods.Columns.AddRange(new DataGridViewColumn[] { FoodId, FoodName, FoodPrice });
            DataFoods.Dock = DockStyle.Fill;
            DataFoods.Location = new Point(0, 0);
            DataFoods.Name = "DataFoods";
            DataFoods.ReadOnly = true;
            DataFoods.RowHeadersWidth = 51;
            DataFoods.RowTemplate.Height = 25;
            DataFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataFoods.Size = new Size(894, 331);
            DataFoods.TabIndex = 0;
            DataFoods.CellClick += DataFoods_CellClick;
            // 
            // FoodId
            // 
            FoodId.HeaderText = "کد محصول";
            FoodId.MinimumWidth = 6;
            FoodId.Name = "FoodId";
            FoodId.ReadOnly = true;
            FoodId.Visible = false;
            // 
            // FoodName
            // 
            FoodName.HeaderText = "نام محصول";
            FoodName.MinimumWidth = 6;
            FoodName.Name = "FoodName";
            FoodName.ReadOnly = true;
            // 
            // FoodPrice
            // 
            FoodPrice.HeaderText = "قیمت محصول";
            FoodPrice.MinimumWidth = 6;
            FoodPrice.Name = "FoodPrice";
            FoodPrice.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 331);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 170);
            panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtName);
            groupBox2.Controls.Add(TxtPrice);
            groupBox2.Controls.Add(BtnAddOrEdit);
            groupBox2.Controls.Add(BtnCancell);
            groupBox2.Controls.Add(BtnDeleteFood);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label6);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 170);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "حذف، ویرایش، افزودن";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(168, 26);
            TxtName.MaxLength = 150;
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(198, 38);
            TxtName.TabIndex = 23;
            // 
            // TxtPrice
            // 
            TxtPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            TxtPrice.Location = new Point(168, 71);
            TxtPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(198, 38);
            TxtPrice.TabIndex = 22;
            // 
            // BtnAddOrEdit
            // 
            BtnAddOrEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAddOrEdit.BackColor = Color.DarkOrange;
            BtnAddOrEdit.FlatAppearance.BorderSize = 0;
            BtnAddOrEdit.FlatStyle = FlatStyle.Flat;
            BtnAddOrEdit.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddOrEdit.ForeColor = SystemColors.ControlText;
            BtnAddOrEdit.Image = Properties.Resources.add_32px;
            BtnAddOrEdit.ImageAlign = ContentAlignment.MiddleRight;
            BtnAddOrEdit.Location = new Point(3, 27);
            BtnAddOrEdit.Name = "BtnAddOrEdit";
            BtnAddOrEdit.Padding = new Padding(0, 0, 8, 0);
            BtnAddOrEdit.RightToLeft = RightToLeft.No;
            BtnAddOrEdit.Size = new Size(159, 40);
            BtnAddOrEdit.TabIndex = 18;
            BtnAddOrEdit.Text = "افزودن";
            BtnAddOrEdit.UseVisualStyleBackColor = false;
            BtnAddOrEdit.Click += BtnAddOrEdit_Click;
            // 
            // BtnCancell
            // 
            BtnCancell.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancell.BackColor = Color.DarkOrange;
            BtnCancell.Enabled = false;
            BtnCancell.FlatAppearance.BorderSize = 0;
            BtnCancell.FlatStyle = FlatStyle.Flat;
            BtnCancell.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancell.ForeColor = SystemColors.ControlText;
            BtnCancell.Image = Properties.Resources.cancel_32px;
            BtnCancell.ImageAlign = ContentAlignment.MiddleRight;
            BtnCancell.Location = new Point(3, 119);
            BtnCancell.Name = "BtnCancell";
            BtnCancell.Padding = new Padding(0, 0, 8, 0);
            BtnCancell.RightToLeft = RightToLeft.No;
            BtnCancell.Size = new Size(159, 40);
            BtnCancell.TabIndex = 18;
            BtnCancell.Text = "کنسل";
            BtnCancell.UseVisualStyleBackColor = false;
            BtnCancell.Click += BtnCancell_Click;
            // 
            // BtnDeleteFood
            // 
            BtnDeleteFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnDeleteFood.BackColor = Color.DarkOrange;
            BtnDeleteFood.Enabled = false;
            BtnDeleteFood.FlatAppearance.BorderSize = 0;
            BtnDeleteFood.FlatStyle = FlatStyle.Flat;
            BtnDeleteFood.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDeleteFood.ForeColor = SystemColors.ControlText;
            BtnDeleteFood.Image = Properties.Resources.unavailable_32px;
            BtnDeleteFood.ImageAlign = ContentAlignment.MiddleRight;
            BtnDeleteFood.Location = new Point(3, 73);
            BtnDeleteFood.Name = "BtnDeleteFood";
            BtnDeleteFood.Padding = new Padding(0, 0, 8, 0);
            BtnDeleteFood.RightToLeft = RightToLeft.No;
            BtnDeleteFood.Size = new Size(159, 40);
            BtnDeleteFood.TabIndex = 18;
            BtnDeleteFood.Text = "حذف";
            BtnDeleteFood.UseVisualStyleBackColor = false;
            BtnDeleteFood.Click += BtnDeleteFood_Click;
            // 
            // label2
            // 
            label2.Location = new Point(372, 24);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 20;
            label2.Text = "نام : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(372, 69);
            label6.Name = "label6";
            label6.Size = new Size(71, 32);
            label6.TabIndex = 20;
            label6.Text = "قیمت : ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtNameSearch);
            groupBox1.Controls.Add(BtnAll);
            groupBox1.Controls.Add(BtnSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(449, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 170);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "جست و جو";
            // 
            // TxtNameSearch
            // 
            TxtNameSearch.Location = new Point(40, 55);
            TxtNameSearch.MaxLength = 150;
            TxtNameSearch.Name = "TxtNameSearch";
            TxtNameSearch.Size = new Size(282, 38);
            TxtNameSearch.TabIndex = 23;
            // 
            // BtnAll
            // 
            BtnAll.BackColor = Color.DarkOrange;
            BtnAll.FlatAppearance.BorderSize = 0;
            BtnAll.FlatStyle = FlatStyle.Flat;
            BtnAll.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAll.ForeColor = SystemColors.ControlText;
            BtnAll.Image = Properties.Resources.search_32px;
            BtnAll.ImageAlign = ContentAlignment.MiddleRight;
            BtnAll.Location = new Point(40, 112);
            BtnAll.Name = "BtnAll";
            BtnAll.Padding = new Padding(0, 0, 8, 0);
            BtnAll.RightToLeft = RightToLeft.No;
            BtnAll.Size = new Size(152, 47);
            BtnAll.TabIndex = 21;
            BtnAll.Text = "مشاهده همه";
            BtnAll.TextAlign = ContentAlignment.MiddleLeft;
            BtnAll.UseVisualStyleBackColor = false;
            BtnAll.Click += BtnAll_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.DarkOrange;
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.Font = new Font("B Nazanin", 13F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSearch.ForeColor = SystemColors.ControlText;
            BtnSearch.Image = Properties.Resources.search_32px;
            BtnSearch.ImageAlign = ContentAlignment.MiddleRight;
            BtnSearch.Location = new Point(198, 112);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Padding = new Padding(0, 0, 8, 0);
            BtnSearch.RightToLeft = RightToLeft.No;
            BtnSearch.Size = new Size(145, 47);
            BtnSearch.TabIndex = 21;
            BtnSearch.Text = "جست و جو";
            BtnSearch.TextAlign = ContentAlignment.MiddleLeft;
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // label3
            // 
            label3.Location = new Point(328, 56);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 20;
            label3.Text = "نام : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FoodsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 501);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("B Zar", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FoodsForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مدیریت محصولات";
            Load += FoodsForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataFoods).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtPrice).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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