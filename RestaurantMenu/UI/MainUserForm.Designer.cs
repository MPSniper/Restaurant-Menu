namespace UI
{
    partial class MainUserForm
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
            PanelTitleBar = new Panel();
            lblTitle = new Label();
            PanelMain = new Panel();
            DataCarts = new DataGridView();
            FoodId = new DataGridViewTextBoxColumn();
            FoodName = new DataGridViewTextBoxColumn();
            FoodCount = new DataGridViewTextBoxColumn();
            FoodPrice = new DataGridViewTextBoxColumn();
            SumPrice = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            LblCartSum = new Label();
            label11 = new Label();
            BtnPay = new Button();
            PanelCartControls = new Panel();
            BtnDeleteAllRow = new Button();
            BtnDeleteRow = new Button();
            BtnMinCount = new Button();
            BtnAddCount = new Button();
            panel1 = new Panel();
            PanelFoods = new FlowLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            PanelMenu = new FlowLayoutPanel();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            Btn4 = new Button();
            BtnExit = new Button();
            PanelLogo = new Panel();
            PanelTitleBar.SuspendLayout();
            PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataCarts).BeginInit();
            panel2.SuspendLayout();
            PanelCartControls.SuspendLayout();
            panel1.SuspendLayout();
            PanelFoods.SuspendLayout();
            panel4.SuspendLayout();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTitleBar
            // 
            PanelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            PanelTitleBar.Controls.Add(lblTitle);
            PanelTitleBar.Dock = DockStyle.Top;
            PanelTitleBar.Location = new Point(0, 0);
            PanelTitleBar.Name = "PanelTitleBar";
            PanelTitleBar.Size = new Size(950, 80);
            PanelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(43, 84, 50);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("B Zar", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(950, 80);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "منو رستوران                  ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            PanelMain.Controls.Add(DataCarts);
            PanelMain.Controls.Add(panel2);
            PanelMain.Controls.Add(panel1);
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(0, 80);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(950, 602);
            PanelMain.TabIndex = 2;
            // 
            // DataCarts
            // 
            DataCarts.AllowUserToAddRows = false;
            DataCarts.AllowUserToDeleteRows = false;
            DataCarts.BackgroundColor = SystemColors.GradientInactiveCaption;
            DataCarts.BorderStyle = BorderStyle.Fixed3D;
            DataCarts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataCarts.Columns.AddRange(new DataGridViewColumn[] { FoodId, FoodName, FoodCount, FoodPrice, SumPrice });
            DataCarts.Dock = DockStyle.Fill;
            DataCarts.Location = new Point(0, 0);
            DataCarts.Name = "DataCarts";
            DataCarts.ReadOnly = true;
            DataCarts.RowHeadersWidth = 51;
            DataCarts.RowTemplate.Height = 25;
            DataCarts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataCarts.Size = new Size(578, 495);
            DataCarts.TabIndex = 1;
            // 
            // FoodId
            // 
            FoodId.HeaderText = "کد غذا";
            FoodId.MinimumWidth = 6;
            FoodId.Name = "FoodId";
            FoodId.ReadOnly = true;
            FoodId.Visible = false;
            FoodId.Width = 125;
            // 
            // FoodName
            // 
            FoodName.HeaderText = "نام غذا";
            FoodName.MinimumWidth = 6;
            FoodName.Name = "FoodName";
            FoodName.ReadOnly = true;
            FoodName.Width = 155;
            // 
            // FoodCount
            // 
            FoodCount.HeaderText = "تعداد";
            FoodCount.MinimumWidth = 6;
            FoodCount.Name = "FoodCount";
            FoodCount.ReadOnly = true;
            FoodCount.Width = 120;
            // 
            // FoodPrice
            // 
            FoodPrice.HeaderText = "قیمت واحد";
            FoodPrice.MinimumWidth = 6;
            FoodPrice.Name = "FoodPrice";
            FoodPrice.ReadOnly = true;
            FoodPrice.Width = 125;
            // 
            // SumPrice
            // 
            SumPrice.HeaderText = "جمع";
            SumPrice.MinimumWidth = 6;
            SumPrice.Name = "SumPrice";
            SumPrice.ReadOnly = true;
            SumPrice.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(LblCartSum);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(BtnPay);
            panel2.Controls.Add(PanelCartControls);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 495);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 107);
            panel2.TabIndex = 2;
            // 
            // LblCartSum
            // 
            LblCartSum.Cursor = Cursors.Hand;
            LblCartSum.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblCartSum.ImageAlign = ContentAlignment.MiddleRight;
            LblCartSum.Location = new Point(174, 57);
            LblCartSum.Name = "LblCartSum";
            LblCartSum.Size = new Size(159, 41);
            LblCartSum.TabIndex = 2;
            LblCartSum.Text = "1.000.000";
            LblCartSum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Cursor = Cursors.Hand;
            label11.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ImageAlign = ContentAlignment.MiddleRight;
            label11.Location = new Point(318, 57);
            label11.Name = "label11";
            label11.Size = new Size(121, 41);
            label11.TabIndex = 2;
            label11.Text = "جمع فاکتور : ";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnPay
            // 
            BtnPay.BackColor = Color.DarkOrange;
            BtnPay.FlatStyle = FlatStyle.Popup;
            BtnPay.Font = new Font("B Zar", 17F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPay.Image = Properties.Resources.payment_history_40px;
            BtnPay.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPay.Location = new Point(12, 52);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(156, 52);
            BtnPay.TabIndex = 0;
            BtnPay.Text = "پرداخت ";
            BtnPay.UseVisualStyleBackColor = false;
            BtnPay.Click += BtnPay_Click;
            // 
            // PanelCartControls
            // 
            PanelCartControls.Controls.Add(BtnDeleteAllRow);
            PanelCartControls.Controls.Add(BtnDeleteRow);
            PanelCartControls.Controls.Add(BtnMinCount);
            PanelCartControls.Controls.Add(BtnAddCount);
            PanelCartControls.Dock = DockStyle.Top;
            PanelCartControls.Location = new Point(0, 0);
            PanelCartControls.Name = "PanelCartControls";
            PanelCartControls.Size = new Size(578, 46);
            PanelCartControls.TabIndex = 0;
            // 
            // BtnDeleteAllRow
            // 
            BtnDeleteAllRow.Location = new Point(21, 3);
            BtnDeleteAllRow.Name = "BtnDeleteAllRow";
            BtnDeleteAllRow.Size = new Size(100, 37);
            BtnDeleteAllRow.TabIndex = 0;
            BtnDeleteAllRow.Text = "حذف همه";
            BtnDeleteAllRow.UseVisualStyleBackColor = true;
            BtnDeleteAllRow.Click += BtnDeleteAllRow_Click;
            // 
            // BtnDeleteRow
            // 
            BtnDeleteRow.Location = new Point(127, 3);
            BtnDeleteRow.Name = "BtnDeleteRow";
            BtnDeleteRow.Size = new Size(100, 37);
            BtnDeleteRow.TabIndex = 0;
            BtnDeleteRow.Text = "حذف";
            BtnDeleteRow.UseVisualStyleBackColor = true;
            BtnDeleteRow.Click += BtnDeleteRow_Click;
            // 
            // BtnMinCount
            // 
            BtnMinCount.Location = new Point(233, 3);
            BtnMinCount.Name = "BtnMinCount";
            BtnMinCount.Size = new Size(100, 37);
            BtnMinCount.TabIndex = 0;
            BtnMinCount.Text = "کاهش تعداد";
            BtnMinCount.UseVisualStyleBackColor = true;
            BtnMinCount.Click += BtnMinCount_Click;
            // 
            // BtnAddCount
            // 
            BtnAddCount.Location = new Point(339, 3);
            BtnAddCount.Name = "BtnAddCount";
            BtnAddCount.Size = new Size(100, 37);
            BtnAddCount.TabIndex = 0;
            BtnAddCount.Text = "افزایش تعداد";
            BtnAddCount.UseVisualStyleBackColor = true;
            BtnAddCount.Click += BtnAddCount_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(PanelFoods);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(578, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 602);
            panel1.TabIndex = 0;
            // 
            // PanelFoods
            // 
            PanelFoods.BackColor = SystemColors.GradientInactiveCaption;
            PanelFoods.Controls.Add(label5);
            PanelFoods.Controls.Add(label6);
            PanelFoods.Controls.Add(label7);
            PanelFoods.Controls.Add(label10);
            PanelFoods.Controls.Add(label9);
            PanelFoods.Controls.Add(label8);
            PanelFoods.Location = new Point(0, 0);
            PanelFoods.Name = "PanelFoods";
            PanelFoods.Size = new Size(369, 602);
            PanelFoods.TabIndex = 1;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ScrollBar;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("B Zar", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(251, 5);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Padding = new Padding(5);
            label5.Size = new Size(113, 40);
            label5.TabIndex = 0;
            label5.Text = "همبرگر";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Goldenrod;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("B Zar", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(128, 5);
            label6.Margin = new Padding(5);
            label6.Name = "label6";
            label6.Padding = new Padding(5);
            label6.Size = new Size(113, 40);
            label6.TabIndex = 1;
            label6.Text = "پیتزا";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ScrollBar;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("B Zar", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 5);
            label7.Margin = new Padding(5);
            label7.Name = "label7";
            label7.Padding = new Padding(5);
            label7.Size = new Size(113, 40);
            label7.TabIndex = 2;
            label7.Text = "بندری";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ScrollBar;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("B Zar", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(251, 55);
            label10.Margin = new Padding(5);
            label10.Name = "label10";
            label10.Padding = new Padding(5);
            label10.Size = new Size(113, 40);
            label10.TabIndex = 5;
            label10.Text = "فلافل";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.Goldenrod;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("B Zar", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(128, 55);
            label9.Margin = new Padding(5);
            label9.Name = "label9";
            label9.Padding = new Padding(5);
            label9.Size = new Size(113, 40);
            label9.TabIndex = 6;
            label9.Text = "برگر مخصوص";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.Goldenrod;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("B Zar", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(5, 55);
            label8.Margin = new Padding(5);
            label8.Name = "label8";
            label8.Padding = new Padding(5);
            label8.Size = new Size(113, 40);
            label8.TabIndex = 7;
            label8.Text = "کباب لقمه";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(PanelMenu);
            panel4.Controls.Add(PanelLogo);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(950, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(211, 682);
            panel4.TabIndex = 7;
            // 
            // PanelMenu
            // 
            PanelMenu.AutoScroll = true;
            PanelMenu.BackColor = Color.FromArgb(252, 194, 252);
            PanelMenu.Controls.Add(Btn1);
            PanelMenu.Controls.Add(Btn2);
            PanelMenu.Controls.Add(Btn3);
            PanelMenu.Controls.Add(Btn4);
            PanelMenu.Controls.Add(BtnExit);
            PanelMenu.FlowDirection = FlowDirection.RightToLeft;
            PanelMenu.Location = new Point(0, 80);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(217, 602);
            PanelMenu.TabIndex = 3;
            // 
            // Btn1
            // 
            Btn1.Dock = DockStyle.Top;
            Btn1.FlatAppearance.BorderSize = 0;
            Btn1.FlatStyle = FlatStyle.Flat;
            Btn1.Font = new Font("B Zar", 17F, FontStyle.Regular, GraphicsUnit.Point);
            Btn1.ForeColor = Color.Black;
            Btn1.Image = Properties.Resources.ifood_40px;
            Btn1.ImageAlign = ContentAlignment.MiddleLeft;
            Btn1.Location = new Point(3, 3);
            Btn1.Name = "Btn1";
            Btn1.Padding = new Padding(0, 0, 8, 0);
            Btn1.Size = new Size(175, 60);
            Btn1.TabIndex = 6;
            Btn1.Text = "رستوران 1";
            Btn1.TextAlign = ContentAlignment.MiddleLeft;
            Btn1.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn1.UseVisualStyleBackColor = true;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.Coral;
            Btn2.Dock = DockStyle.Top;
            Btn2.FlatAppearance.BorderSize = 0;
            Btn2.FlatStyle = FlatStyle.Flat;
            Btn2.Font = new Font("B Zar", 19F, FontStyle.Regular, GraphicsUnit.Point);
            Btn2.ForeColor = Color.Black;
            Btn2.Image = Properties.Resources.ifood_40px;
            Btn2.ImageAlign = ContentAlignment.MiddleLeft;
            Btn2.Location = new Point(3, 69);
            Btn2.Name = "Btn2";
            Btn2.Padding = new Padding(0, 0, 8, 0);
            Btn2.Size = new Size(175, 60);
            Btn2.TabIndex = 12;
            Btn2.Text = "رستوران 2";
            Btn2.TextAlign = ContentAlignment.MiddleLeft;
            Btn2.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn2.UseVisualStyleBackColor = false;
            // 
            // Btn3
            // 
            Btn3.Dock = DockStyle.Top;
            Btn3.FlatAppearance.BorderSize = 0;
            Btn3.FlatStyle = FlatStyle.Flat;
            Btn3.Font = new Font("B Zar", 17F, FontStyle.Regular, GraphicsUnit.Point);
            Btn3.ForeColor = Color.Black;
            Btn3.Image = Properties.Resources.ifood_40px;
            Btn3.ImageAlign = ContentAlignment.MiddleLeft;
            Btn3.Location = new Point(3, 135);
            Btn3.Name = "Btn3";
            Btn3.Padding = new Padding(0, 0, 8, 0);
            Btn3.Size = new Size(175, 60);
            Btn3.TabIndex = 13;
            Btn3.Text = "رستوران 3";
            Btn3.TextAlign = ContentAlignment.MiddleLeft;
            Btn3.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn3.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            Btn4.Dock = DockStyle.Top;
            Btn4.FlatAppearance.BorderSize = 0;
            Btn4.FlatStyle = FlatStyle.Flat;
            Btn4.Font = new Font("B Zar", 17F, FontStyle.Regular, GraphicsUnit.Point);
            Btn4.ForeColor = Color.Black;
            Btn4.Image = Properties.Resources.ifood_40px;
            Btn4.ImageAlign = ContentAlignment.MiddleLeft;
            Btn4.Location = new Point(3, 201);
            Btn4.Name = "Btn4";
            Btn4.Padding = new Padding(0, 0, 8, 0);
            Btn4.Size = new Size(175, 60);
            Btn4.TabIndex = 14;
            Btn4.Text = "رستوران 4";
            Btn4.TextAlign = ContentAlignment.MiddleLeft;
            Btn4.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn4.UseVisualStyleBackColor = true;
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
            BtnExit.Location = new Point(3, 267);
            BtnExit.Name = "BtnExit";
            BtnExit.Padding = new Padding(0, 0, 8, 0);
            BtnExit.Size = new Size(175, 60);
            BtnExit.TabIndex = 15;
            BtnExit.Text = "خروج";
            BtnExit.TextAlign = ContentAlignment.MiddleLeft;
            BtnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(43, 84, 50);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(211, 80);
            PanelLogo.TabIndex = 2;
            // 
            // MainUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 682);
            Controls.Add(PanelMain);
            Controls.Add(PanelTitleBar);
            Controls.Add(panel4);
            Font = new Font("B Zar", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainUserForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainUserForm_Load;
            PanelTitleBar.ResumeLayout(false);
            PanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataCarts).EndInit();
            panel2.ResumeLayout(false);
            PanelCartControls.ResumeLayout(false);
            panel1.ResumeLayout(false);
            PanelFoods.ResumeLayout(false);
            panel4.ResumeLayout(false);
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel PanelMain;
        private Panel panel1;
        private FlowLayoutPanel PanelFoods;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView DataCarts;
        private Panel panel2;
        private Panel PanelCartControls;
        private Button BtnDeleteAllRow;
        private Button BtnDeleteRow;
        private Button BtnMinCount;
        private Button BtnAddCount;
        private Button BtnPay;
        private Label LblCartSum;
        private Label label11;
        private Panel panel4;
        private Panel PanelLogo;
        private FlowLayoutPanel PanelMenu;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button Btn4;
        private Button BtnExit;
        private DataGridViewTextBoxColumn FoodId;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn FoodCount;
        private DataGridViewTextBoxColumn FoodPrice;
        private DataGridViewTextBoxColumn SumPrice;
    }
}