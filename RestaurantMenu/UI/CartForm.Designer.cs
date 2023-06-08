namespace UI
{
    partial class CartForm
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
            dataGridView1 = new DataGridView();
            Fee = new DataGridViewTextBoxColumn();
            FoodName = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            PriceAll = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            button5 = new Button();
            Menu = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fee, FoodName, Number, PriceAll });
            dataGridView1.Location = new Point(15, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 550);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Fee
            // 
            Fee.HeaderText = "فی";
            Fee.Name = "Fee";
            Fee.ReadOnly = true;
            Fee.Width = 150;
            // 
            // FoodName
            // 
            FoodName.HeaderText = "نام غذا";
            FoodName.Name = "FoodName";
            FoodName.ReadOnly = true;
            FoodName.Width = 200;
            // 
            // Number
            // 
            Number.HeaderText = "تعداد";
            Number.Name = "Number";
            Number.ReadOnly = true;
            // 
            // PriceAll
            // 
            PriceAll.HeaderText = "قیمت کل";
            PriceAll.Name = "PriceAll";
            PriceAll.ReadOnly = true;
            PriceAll.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(12, 559);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 74);
            panel1.TabIndex = 2;
            // 
            // label12
            // 
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ImageAlign = ContentAlignment.MiddleRight;
            label12.Location = new Point(165, 15);
            label12.Name = "label12";
            label12.Size = new Size(159, 41);
            label12.TabIndex = 5;
            label12.Text = "1.000.000";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Cursor = Cursors.Hand;
            label11.Font = new Font("B Zar", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ImageAlign = ContentAlignment.MiddleRight;
            label11.Location = new Point(309, 15);
            label11.Name = "label11";
            label11.Size = new Size(121, 41);
            label11.TabIndex = 4;
            label11.Text = "جمع فاکتور : ";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("B Zar", 17F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = Properties.Resources.payment_history_40px;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 8);
            button5.Name = "button5";
            button5.Size = new Size(156, 52);
            button5.TabIndex = 3;
            button5.Text = "پرداخت ";
            button5.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            Menu.Controls.Add(label6);
            Menu.Controls.Add(label5);
            Menu.Location = new Point(665, 12);
            Menu.Name = "Menu";
            Menu.Size = new Size(348, 621);
            Menu.TabIndex = 3;
            Menu.TabStop = false;
            Menu.Text = "Menu";
            Menu.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.BackColor = Color.Goldenrod;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("B Zar", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(219, 74);
            label6.Margin = new Padding(5);
            label6.Name = "label6";
            label6.Padding = new Padding(5);
            label6.Size = new Size(113, 40);
            label6.TabIndex = 2;
            label6.Text = "پیتزا";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ScrollBar;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("B Zar", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(219, 24);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Padding = new Padding(5);
            label5.Size = new Size(113, 40);
            label5.TabIndex = 1;
            label5.Text = "همبرگر";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 633);
            Controls.Add(Menu);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "CartForm";
            Text = "CartForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            Menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private Button button5;
        private GroupBox Menu;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Fee;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn PriceAll;
    }
}