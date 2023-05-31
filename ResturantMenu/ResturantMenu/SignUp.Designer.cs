namespace ResturantMenu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUserSignUp = new Button();
            btnRestaurantSignUp = new Button();
            ButtonBox = new GroupBox();
            ButtonBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnUserSignUp
            // 
            btnUserSignUp.BackColor = Color.FromArgb(199, 232, 202);
            btnUserSignUp.FlatAppearance.BorderColor = Color.Black;
            btnUserSignUp.FlatAppearance.BorderSize = 2;
            btnUserSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserSignUp.ForeColor = Color.Black;
            btnUserSignUp.Location = new Point(235, 117);
            btnUserSignUp.Name = "btnUserSignUp";
            btnUserSignUp.Size = new Size(269, 63);
            btnUserSignUp.TabIndex = 0;
            btnUserSignUp.Text = "ثبت نام کاربر";
            btnUserSignUp.UseVisualStyleBackColor = false;
            btnUserSignUp.Click += btnUserSignUp_Click;
            // 
            // btnRestaurantSignUp
            // 
            btnRestaurantSignUp.BackColor = Color.FromArgb(199, 232, 202);
            btnRestaurantSignUp.FlatAppearance.BorderColor = Color.Black;
            btnRestaurantSignUp.FlatAppearance.BorderSize = 2;
            btnRestaurantSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestaurantSignUp.ForeColor = Color.Black;
            btnRestaurantSignUp.Location = new Point(235, 259);
            btnRestaurantSignUp.Name = "btnRestaurantSignUp";
            btnRestaurantSignUp.Size = new Size(269, 63);
            btnRestaurantSignUp.TabIndex = 1;
            btnRestaurantSignUp.Text = "ثبت نام رستوران";
            btnRestaurantSignUp.UseMnemonic = false;
            btnRestaurantSignUp.UseVisualStyleBackColor = false;
            btnRestaurantSignUp.Click += btnRestaurantSignUp_Click;
            // 
            // ButtonBox
            // 
            ButtonBox.BackColor = Color.FromArgb(223, 46, 56);
            ButtonBox.Controls.Add(btnRestaurantSignUp);
            ButtonBox.Controls.Add(btnUserSignUp);
            ButtonBox.Location = new Point(25, 12);
            ButtonBox.Name = "ButtonBox";
            ButtonBox.Size = new Size(746, 426);
            ButtonBox.TabIndex = 2;
            ButtonBox.TabStop = false;
            ButtonBox.Text = "ButtonBox";
            ButtonBox.Enter += ButtonBox_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonBox);
            Name = "Form1";
            Text = "Form1";
            ButtonBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnUserSignUp;
        private Button btnRestaurantSignUp;
        private GroupBox ButtonBox;
    }
}