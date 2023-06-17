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
            panel1 = new Panel();
            DataFactors = new DataGridView();
            FoodResturan = new DataGridViewTextBoxColumn();
            FactorCostumer = new DataGridViewTextBoxColumn();
            FactorPrice = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataFactors).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(DataFactors);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 429);
            panel1.TabIndex = 0;
            // 
            // DataFactors
            // 
            DataFactors.AllowUserToAddRows = false;
            DataFactors.AllowUserToDeleteRows = false;
            DataFactors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataFactors.BackgroundColor = SystemColors.GradientInactiveCaption;
            DataFactors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataFactors.Columns.AddRange(new DataGridViewColumn[] { FoodResturan, FactorCostumer, FactorPrice });
            DataFactors.Dock = DockStyle.Fill;
            DataFactors.Location = new Point(0, 0);
            DataFactors.MultiSelect = false;
            DataFactors.Name = "DataFactors";
            DataFactors.ReadOnly = true;
            DataFactors.RowHeadersWidth = 51;
            DataFactors.RowTemplate.Height = 25;
            DataFactors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataFactors.Size = new Size(894, 429);
            DataFactors.TabIndex = 2;
            // 
            // FoodResturan
            // 
            FoodResturan.DataPropertyName = "RestaurantName";
            FoodResturan.HeaderText = "نام رستوران";
            FoodResturan.MinimumWidth = 6;
            FoodResturan.Name = "FoodResturan";
            FoodResturan.ReadOnly = true;
            // 
            // FactorCostumer
            // 
            FactorCostumer.DataPropertyName = "FirstName";
            FactorCostumer.HeaderText = "نام مشتری";
            FactorCostumer.MinimumWidth = 6;
            FactorCostumer.Name = "FactorCostumer";
            FactorCostumer.ReadOnly = true;
            // 
            // FactorPrice
            // 
            FactorPrice.DataPropertyName = "Sum";
            FactorPrice.HeaderText = "مبلغ فاکتور";
            FactorPrice.MinimumWidth = 6;
            FactorPrice.Name = "FactorPrice";
            FactorPrice.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 429);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 72);
            panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(891, 72);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ImageAlign = ContentAlignment.MiddleRight;
            label12.Location = new Point(9, 19);
            label12.Name = "label12";
            label12.Size = new Size(159, 41);
            label12.TabIndex = 21;
            label12.Text = "1.000.000";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Click += label12_Click;
            // 
            // label3
            // 
            label3.Location = new Point(164, 23);
            label3.Name = "label3";
            label3.Size = new Size(101, 32);
            label3.TabIndex = 20;
            label3.Text = "مجموع کل :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // FactorsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 501);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("B Zar", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FactorsForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مدیریت فاکتورها";
            Load += LoadFactors;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataFactors).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataFactors;
        private Label label12;
        private DataGridViewTextBoxColumn FoodResturan;
        private DataGridViewTextBoxColumn FactorCostumer;
        private DataGridViewTextBoxColumn FactorPrice;
    }
}