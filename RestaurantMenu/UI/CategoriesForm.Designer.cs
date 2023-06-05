namespace UI
{
    partial class CategoriesForm
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
            this.DataCategoroies = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtLabel = new System.Windows.Forms.TextBox();
            this.BtnAddOrEdit = new System.Windows.Forms.Button();
            this.BtnCancell = new System.Windows.Forms.Button();
            this.BtnDisableAndEnable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtLabelSearch = new System.Windows.Forms.TextBox();
            this.CmbStatusSearch = new System.Windows.Forms.ComboBox();
            this.BtnAllCategory = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCategoroies)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataCategoroies);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 331);
            this.panel1.TabIndex = 0;
            // 
            // DataCategoroies
            // 
            this.DataCategoroies.AllowUserToAddRows = false;
            this.DataCategoroies.AllowUserToDeleteRows = false;
            this.DataCategoroies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataCategoroies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCategoroies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Label,
            this.IsDeleted,
            this.CreationDate});
            this.DataCategoroies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataCategoroies.Location = new System.Drawing.Point(0, 0);
            this.DataCategoroies.MultiSelect = false;
            this.DataCategoroies.Name = "DataCategoroies";
            this.DataCategoroies.ReadOnly = true;
            this.DataCategoroies.RowTemplate.Height = 25;
            this.DataCategoroies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataCategoroies.Size = new System.Drawing.Size(894, 331);
            this.DataCategoroies.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "کد دسته بندی";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Label
            // 
            this.Label.HeaderText = "نام دسته بندی";
            this.Label.Name = "Label";
            this.Label.ReadOnly = true;
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
            this.groupBox2.Controls.Add(this.TxtLabel);
            this.groupBox2.Controls.Add(this.BtnAddOrEdit);
            this.groupBox2.Controls.Add(this.BtnCancell);
            this.groupBox2.Controls.Add(this.BtnDisableAndEnable);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 170);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حذف، ویرایش، افزودن";
            // 
            // TxtLabel
            // 
            this.TxtLabel.Location = new System.Drawing.Point(59, 32);
            this.TxtLabel.MaxLength = 100;
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.Size = new System.Drawing.Size(276, 32);
            this.TxtLabel.TabIndex = 22;
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
            this.BtnAddOrEdit.Location = new System.Drawing.Point(200, 73);
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
            this.BtnCancell.Location = new System.Drawing.Point(128, 119);
            this.BtnCancell.Name = "BtnCancell";
            this.BtnCancell.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnCancell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCancell.Size = new System.Drawing.Size(135, 40);
            this.BtnCancell.TabIndex = 18;
            this.BtnCancell.Text = "کنسل";
            this.BtnCancell.UseVisualStyleBackColor = false;
            this.BtnCancell.Visible = false;
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
            this.BtnDisableAndEnable.Location = new System.Drawing.Point(59, 73);
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
            this.label2.Location = new System.Drawing.Point(317, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "نام : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtLabelSearch);
            this.groupBox1.Controls.Add(this.CmbStatusSearch);
            this.groupBox1.Controls.Add(this.BtnAllCategory);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(451, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 170);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جو";
            // 
            // TxtLabelSearch
            // 
            this.TxtLabelSearch.Location = new System.Drawing.Point(60, 38);
            this.TxtLabelSearch.MaxLength = 100;
            this.TxtLabelSearch.Name = "TxtLabelSearch";
            this.TxtLabelSearch.Size = new System.Drawing.Size(204, 32);
            this.TxtLabelSearch.TabIndex = 22;
            // 
            // CmbStatusSearch
            // 
            this.CmbStatusSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatusSearch.FormattingEnabled = true;
            this.CmbStatusSearch.Items.AddRange(new object[] {
            "همه",
            "فعال",
            "غیرفعال"});
            this.CmbStatusSearch.Location = new System.Drawing.Point(60, 76);
            this.CmbStatusSearch.Name = "CmbStatusSearch";
            this.CmbStatusSearch.Size = new System.Drawing.Size(204, 33);
            this.CmbStatusSearch.TabIndex = 21;
            // 
            // BtnAllCategory
            // 
            this.BtnAllCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnAllCategory.FlatAppearance.BorderSize = 0;
            this.BtnAllCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllCategory.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAllCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAllCategory.Image = global::UI.Properties.Resources.search_32px;
            this.BtnAllCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAllCategory.Location = new System.Drawing.Point(73, 123);
            this.BtnAllCategory.Name = "BtnAllCategory";
            this.BtnAllCategory.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnAllCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAllCategory.Size = new System.Drawing.Size(135, 40);
            this.BtnAllCategory.TabIndex = 21;
            this.BtnAllCategory.Text = "مشاهده همه";
            this.BtnAllCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAllCategory.UseVisualStyleBackColor = false;
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
            this.BtnSearch.Location = new System.Drawing.Point(214, 123);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSearch.Size = new System.Drawing.Size(135, 40);
            this.BtnSearch.TabIndex = 21;
            this.BtnSearch.Text = "جست و جو";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(270, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "وضعیت : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(270, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "نام : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoriesForm
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
            this.Name = "CategoriesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataCategoroies)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataCategoroies;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDisableAndEnable;
        private System.Windows.Forms.Button BtnAddOrEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbStatusSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancell;
        private System.Windows.Forms.Button BtnAllCategory;
        private System.Windows.Forms.TextBox TxtLabel;
        private System.Windows.Forms.TextBox TxtLabelSearch;
    }
}