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
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.DataCarts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblCartSum = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnPay = new System.Windows.Forms.Button();
            this.PanelCartControls = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelFoods = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTitleBar.SuspendLayout();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCarts)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelCartControls.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelFoods.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PanelTitleBar.Controls.Add(this.lblTitle);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(814, 80);
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
            this.lblTitle.Size = new System.Drawing.Size(814, 80);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "دسته بندی ها و غذاها";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.DataCarts);
            this.PanelMain.Controls.Add(this.panel2);
            this.PanelMain.Controls.Add(this.panel1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 80);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(814, 430);
            this.PanelMain.TabIndex = 2;
            // 
            // DataCarts
            // 
            this.DataCarts.AllowUserToAddRows = false;
            this.DataCarts.AllowUserToDeleteRows = false;
            this.DataCarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCarts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.FoodName,
            this.FoodCount,
            this.FoodPrice,
            this.SumPrice});
            this.DataCarts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataCarts.Location = new System.Drawing.Point(0, 0);
            this.DataCarts.Name = "DataCarts";
            this.DataCarts.ReadOnly = true;
            this.DataCarts.RowTemplate.Height = 25;
            this.DataCarts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataCarts.Size = new System.Drawing.Size(442, 323);
            this.DataCarts.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblCartSum);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.BtnPay);
            this.panel2.Controls.Add(this.PanelCartControls);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 107);
            this.panel2.TabIndex = 2;
            // 
            // LblCartSum
            // 
            this.LblCartSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCartSum.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCartSum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblCartSum.Location = new System.Drawing.Point(174, 57);
            this.LblCartSum.Name = "LblCartSum";
            this.LblCartSum.Size = new System.Drawing.Size(159, 41);
            this.LblCartSum.TabIndex = 2;
            this.LblCartSum.Text = "1.000.000";
            this.LblCartSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("B Zar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(318, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 41);
            this.label11.TabIndex = 2;
            this.label11.Text = "جمع فاکتور : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPay
            // 
            this.BtnPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPay.Font = new System.Drawing.Font("B Zar", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPay.Image = global::UI.Properties.Resources.payment_history_40px;
            this.BtnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPay.Location = new System.Drawing.Point(12, 52);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(156, 52);
            this.BtnPay.TabIndex = 0;
            this.BtnPay.Text = "پرداخت ";
            this.BtnPay.UseVisualStyleBackColor = false;
            // 
            // PanelCartControls
            // 
            this.PanelCartControls.Controls.Add(this.button4);
            this.PanelCartControls.Controls.Add(this.button3);
            this.PanelCartControls.Controls.Add(this.button2);
            this.PanelCartControls.Controls.Add(this.button1);
            this.PanelCartControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCartControls.Location = new System.Drawing.Point(0, 0);
            this.PanelCartControls.Name = "PanelCartControls";
            this.PanelCartControls.Size = new System.Drawing.Size(442, 46);
            this.PanelCartControls.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "حذف همه";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 0;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "کاهش تعداد";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "افزایش تعداد";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelFoods);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(442, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 430);
            this.panel1.TabIndex = 0;
            // 
            // PanelFoods
            // 
            this.PanelFoods.Controls.Add(this.label5);
            this.PanelFoods.Controls.Add(this.label6);
            this.PanelFoods.Controls.Add(this.label7);
            this.PanelFoods.Controls.Add(this.label10);
            this.PanelFoods.Controls.Add(this.label9);
            this.PanelFoods.Controls.Add(this.label8);
            this.PanelFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFoods.Location = new System.Drawing.Point(0, 0);
            this.PanelFoods.Name = "PanelFoods";
            this.PanelFoods.Size = new System.Drawing.Size(372, 430);
            this.PanelFoods.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(254, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(113, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "همبرگر";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Goldenrod;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(131, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(113, 40);
            this.label6.TabIndex = 1;
            this.label6.Text = "پیتزا";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(113, 40);
            this.label7.TabIndex = 2;
            this.label7.Text = "بندری";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(254, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(113, 40);
            this.label10.TabIndex = 5;
            this.label10.Text = "فلافل";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Goldenrod;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(131, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(113, 40);
            this.label9.TabIndex = 6;
            this.label9.Text = "برگر مخصوص";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Goldenrod;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(113, 40);
            this.label8.TabIndex = 7;
            this.label8.Text = "کباب لقمه";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PanelMenu);
            this.panel4.Controls.Add(this.PanelLogo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(814, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 510);
            this.panel4.TabIndex = 7;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.PanelMenu.Controls.Add(this.Btn1);
            this.PanelMenu.Controls.Add(this.Btn2);
            this.PanelMenu.Controls.Add(this.Btn3);
            this.PanelMenu.Controls.Add(this.Btn4);
            this.PanelMenu.Controls.Add(this.BtnExit);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Location = new System.Drawing.Point(0, 80);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(178, 430);
            this.PanelMenu.TabIndex = 3;
            // 
            // Btn1
            // 
            this.Btn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("B Zar", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn1.ForeColor = System.Drawing.Color.Black;
            this.Btn1.Image = global::UI.Properties.Resources.ifood_40px;
            this.Btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1.Location = new System.Drawing.Point(0, 3);
            this.Btn1.Name = "Btn1";
            this.Btn1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Btn1.Size = new System.Drawing.Size(175, 60);
            this.Btn1.TabIndex = 6;
            this.Btn1.Text = "رستوران 1";
            this.Btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1.UseVisualStyleBackColor = true;
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Coral;
            this.Btn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("B Zar", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn2.ForeColor = System.Drawing.Color.Black;
            this.Btn2.Image = global::UI.Properties.Resources.ifood_40px;
            this.Btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2.Location = new System.Drawing.Point(0, 69);
            this.Btn2.Name = "Btn2";
            this.Btn2.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Btn2.Size = new System.Drawing.Size(175, 60);
            this.Btn2.TabIndex = 12;
            this.Btn2.Text = "رستوران 2";
            this.Btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn2.UseVisualStyleBackColor = false;
            // 
            // Btn3
            // 
            this.Btn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("B Zar", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn3.ForeColor = System.Drawing.Color.Black;
            this.Btn3.Image = global::UI.Properties.Resources.ifood_40px;
            this.Btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3.Location = new System.Drawing.Point(0, 135);
            this.Btn3.Name = "Btn3";
            this.Btn3.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Btn3.Size = new System.Drawing.Size(175, 60);
            this.Btn3.TabIndex = 13;
            this.Btn3.Text = "رستوران 3";
            this.Btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("B Zar", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn4.ForeColor = System.Drawing.Color.Black;
            this.Btn4.Image = global::UI.Properties.Resources.ifood_40px;
            this.Btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4.Location = new System.Drawing.Point(0, 201);
            this.Btn4.Name = "Btn4";
            this.Btn4.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Btn4.Size = new System.Drawing.Size(175, 60);
            this.Btn4.TabIndex = 14;
            this.Btn4.Text = "رستوران 4";
            this.Btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn4.UseVisualStyleBackColor = true;
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
            this.BtnExit.Location = new System.Drawing.Point(0, 267);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.BtnExit.Size = new System.Drawing.Size(175, 60);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "خروج";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(244)))), ((int)(((byte)(170)))));
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(178, 80);
            this.PanelLogo.TabIndex = 2;
            // 
            // FoodId
            // 
            this.FoodId.HeaderText = "کد غذا";
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            this.FoodId.Visible = false;
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "نام غذا";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // FoodCount
            // 
            this.FoodCount.HeaderText = "تعداد";
            this.FoodCount.Name = "FoodCount";
            this.FoodCount.ReadOnly = true;
            // 
            // FoodPrice
            // 
            this.FoodPrice.HeaderText = "قیمت واحد";
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.ReadOnly = true;
            // 
            // SumPrice
            // 
            this.SumPrice.HeaderText = "جمع";
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.ReadOnly = true;
            // 
            // MainUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 510);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("B Zar", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainUserForm_Load);
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataCarts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PanelCartControls.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelFoods.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
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