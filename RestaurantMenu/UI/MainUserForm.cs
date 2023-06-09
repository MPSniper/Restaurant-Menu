﻿using Repository.DataModel;
using Service.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainUserForm : Form
    {
        List<FoodCartViewModel> Cart = new();
        public int Id { get; set; }
        int ResturanKey;

        public MainUserForm()
        {
            InitializeComponent();
        }

        #region Add Form Data

        private void AddResturant()
        {
            PanelMenu.Controls.Clear();
            Restaurant res = new Restaurant();
            foreach (var item in res.GetRestaurants())
            {
                var BtnResturan = new Button();
                BtnResturan.FlatAppearance.BorderSize = 0;
                BtnResturan.FlatStyle = FlatStyle.Flat;
                BtnResturan.ForeColor = Color.Black;
                BtnResturan.Image = Properties.Resources.ifood_40px;
                BtnResturan.ImageAlign = ContentAlignment.MiddleLeft;
                BtnResturan.Size = new Size(175, 60);
                BtnResturan.Tag = item.Id;
                BtnResturan.Text = item.RestaurantName;
                BtnResturan.TextAlign = ContentAlignment.MiddleLeft;
                BtnResturan.TextImageRelation = TextImageRelation.ImageBeforeText;
                BtnResturan.UseVisualStyleBackColor = true;
                BtnResturan.Click += BtnResturan_Click;
                PanelMenu.Controls.Add(BtnResturan);
            }

            var BtnExit = new Button();
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.ForeColor = Color.Black;
            BtnExit.Image = Properties.Resources.icons8_close_window_40px;
            BtnExit.ImageAlign = ContentAlignment.MiddleLeft;
            BtnExit.Size = new Size(175, 60);
            BtnExit.Text = "خروج";
            BtnExit.TextAlign = ContentAlignment.MiddleLeft;
            BtnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnExit.UseVisualStyleBackColor = true;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            BtnExit.Click += BtnExit_Click;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            PanelMenu.Controls.Add(BtnExit);
        }

        private void AddFoods(int resturanId)
        {
            PanelFoods.Controls.Clear();
            Foods foods = new Foods();
            foreach (var item in foods.GetResturanFoods(resturanId))
            {
                Label foodsLabel = new Label();
                foodsLabel.BackColor = SystemColors.ScrollBar;
                foodsLabel.BorderStyle = BorderStyle.FixedSingle;
                foodsLabel.Cursor = Cursors.Hand;
                foodsLabel.Padding = new Padding(5);
                foodsLabel.Margin = new Padding(5);
                foodsLabel.Size = new Size(113, 40);
                foodsLabel.Text = item.Food;
                foodsLabel.Tag = item;
                foodsLabel.TextAlign = ContentAlignment.MiddleCenter;
                foodsLabel.Click += FoodsLabel_Click;
                foodsLabel.MouseHover += FoodsLabel_MouseHover;
                PanelFoods.Controls.Add(foodsLabel);
            }
        }

        private void FoodsLabel_MouseHover(object? sender, EventArgs e)
        {
            var foodLabel = sender as Label;
            if (foodLabel is null)
                return;
            Foods? food = foodLabel.Tag as Foods;
            if (food is null)
                return;
            ToolTip tip = new ToolTip();
            tip.SetToolTip(foodLabel, food.Price.ToString());
        }

        private void AddCartFoods()
        {
            DataCarts.Rows.Clear();
            foreach (var item in Cart)
            {
                object[] ob = new object[5];
                ob[0] = item.FoodId;
                ob[1] = item.FoodName;
                ob[2] = item.Count;
                ob[3] = item.FoodPrice;
                ob[4] = item.FoodPrice * item.Count;
                DataCarts.Rows.Add(ob);
            }
            CalcCartSum();
            if (Cart.Count == 0)
            {
                PanelCartControls.Enabled = false;
                BtnPay.Enabled = false;
            }
            else
            {
                PanelCartControls.Enabled = true;
                BtnPay.Enabled = true;
            }
        }

        private decimal CalcCartSum()
        {
            decimal sum = 0;
            foreach (var item in Cart)
            {
                sum += item.FoodPrice * item.Count;
            }

            LblCartSum.Text = sum.ToString();

            return sum;
        }

        private void ResetFoodsButton()
        {
            foreach (var item in PanelFoods.Controls)
            {
                if (item != null && item is Label)
                {
                    var foodLabel = item as Label;
                    if (foodLabel != null && foodLabel.Tag is Foods)
                    {
                        var food = foodLabel.Tag as Foods;
                        if (food != null)
                        {
                            if (Cart.Any(x => x.FoodId == food.ID))
                                foodLabel.BackColor = Color.Goldenrod;
                            else
                                foodLabel.BackColor = SystemColors.ScrollBar;
                        }
                    }
                }
            }
        }

        #endregion

        private void FoodsLabel_Click(object? sender, EventArgs e)
        {
        }

        private void BtnResturan_Click(object? sender, EventArgs e)
        {
            var resturanButton = sender as Button;
            if (resturanButton is null)
                return;
            int id = Convert.ToInt32(resturanButton.Tag);
            AddFoods(id);
            foreach (var item in PanelMenu.Controls)
            {
                if (item is Button)
                {
                    var btn = item as Button;
                    if (btn is null)
                        return;
                    if (btn.Tag == resturanButton.Tag)
                    {
                        btn.BackColor = Color.Coral;
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(252, 194, 252);
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainUserForm_Load(object sender, EventArgs e)
        {
            AddResturant();
            AddFoods(0);
        }
    }
}
