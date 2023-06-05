namespace UI
{
    partial class FactorsForm
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
            this.DataFactors = new System.Windows.Forms.DataGridView();
            this.FoodResturan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorCostumer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnFactorInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtToDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.BtnAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFactors)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataFactors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 429);
            this.panel1.TabIndex = 0;
            // 
            // DataFactors
            // 
            this.DataFactors.AllowUserToAddRows = false;
            this.DataFactors.AllowUserToDeleteRows = false;
            this.DataFactors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFactors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodResturan,
            this.FactorId,
            this.FactorCostumer,
            this.FactorPrice,
            this.FactorCreationDate});
            this.DataFactors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataFactors.Location = new System.Drawing.Point(0, 0);
            this.DataFactors.MultiSelect = false;
            this.DataFactors.Name = "DataFactors";
            this.DataFactors.ReadOnly = true;
            this.DataFactors.RowTemplate.Height = 25;
            this.DataFactors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataFactors.Size = new System.Drawing.Size(894, 429);
            this.DataFactors.TabIndex = 2;
            // 
            // FoodResturan
            // 
            this.FoodResturan.HeaderText = "نام رستوران";
            this.FoodResturan.Name = "FoodResturan";
            this.FoodResturan.ReadOnly = true;
            // 
            // FactorId
            // 
            this.FactorId.HeaderText = "کد فاکتور";
            this.FactorId.Name = "FactorId";
            this.FactorId.ReadOnly = true;
            // 
            // FactorCostumer
            // 
            this.FactorCostumer.HeaderText = "نام مشتری";
            this.FactorCostumer.Name = "FactorCostumer";
            this.FactorCostumer.ReadOnly = true;
            // 
            // FactorPrice
            // 
            this.FactorPrice.HeaderText = "مبلغ فاکتور";
            this.FactorPrice.Name = "FactorPrice";
            this.FactorPrice.ReadOnly = true;
            // 
            // FactorCreationDate
            // 
            this.FactorCreationDate.HeaderText = "تاریخ ثبت";
            this.FactorCreationDate.Name = "FactorCreationDate";
            this.FactorCreationDate.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 72);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnFactorInfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 72);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات";
            // 
            // BtnFactorInfo
            // 
            this.BtnFactorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFactorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnFactorInfo.FlatAppearance.BorderSize = 0;
            this.BtnFactorInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFactorInfo.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFactorInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnFactorInfo.Image = global::UI.Properties.Resources.add_32px;
            this.BtnFactorInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFactorInfo.Location = new System.Drawing.Point(12, 21);
            this.BtnFactorInfo.Name = "BtnFactorInfo";
            this.BtnFactorInfo.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnFactorInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnFactorInfo.Size = new System.Drawing.Size(149, 40);
            this.BtnFactorInfo.TabIndex = 18;
            this.BtnFactorInfo.Text = "اطلاعات فاکتور";
            this.BtnFactorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactorInfo.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtToDate);
            this.groupBox1.Controls.Add(this.TxtFromDate);
            this.groupBox1.Controls.Add(this.BtnAll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(167, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 72);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جو";
            // 
            // TxtToDate
            // 
            this.TxtToDate.Location = new System.Drawing.Point(288, 26);
            this.TxtToDate.Mask = "0000/00/00";
            this.TxtToDate.Name = "TxtToDate";
            this.TxtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtToDate.Size = new System.Drawing.Size(144, 32);
            this.TxtToDate.TabIndex = 22;
            // 
            // TxtFromDate
            // 
            this.TxtFromDate.Location = new System.Drawing.Point(515, 25);
            this.TxtFromDate.Mask = "0000/00/00";
            this.TxtFromDate.Name = "TxtFromDate";
            this.TxtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtFromDate.Size = new System.Drawing.Size(144, 32);
            this.TxtFromDate.TabIndex = 22;
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
            this.BtnAll.Location = new System.Drawing.Point(6, 20);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAll.Size = new System.Drawing.Size(135, 40);
            this.BtnAll.TabIndex = 21;
            this.BtnAll.Text = "مشاهده همه";
            this.BtnAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAll.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(438, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "تا تاریخ : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnSearch.Location = new System.Drawing.Point(147, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSearch.Size = new System.Drawing.Size(135, 40);
            this.BtnSearch.TabIndex = 21;
            this.BtnSearch.Text = "جست و جو";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(662, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "از تاریخ : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FactorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("B Zar", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FactorsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataFactors)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnFactorInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.DataGridView DataFactors;
        private System.Windows.Forms.MaskedTextBox TxtToDate;
        private System.Windows.Forms.MaskedTextBox TxtFromDate;
        private System.Windows.Forms.Label label1;
        private DataGridViewTextBoxColumn FoodResturan;
        private DataGridViewTextBoxColumn FactorId;
        private DataGridViewTextBoxColumn FactorCostumer;
        private DataGridViewTextBoxColumn FactorPrice;
        private DataGridViewTextBoxColumn FactorCreationDate;
    }
}