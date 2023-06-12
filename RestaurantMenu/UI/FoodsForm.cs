using Repository.DataModel;

namespace UI
{
    public partial class FoodsForm : Form
    {
        string name;
        int id;
        readonly Foods food = new Foods();
        public int ResturantKey { get; set; }

        public FoodsForm()
        {
            InitializeComponent();
        }

        private void AddFoods(List<(int ID, string Food, decimal Price)> foods)
        {
            DataFoods.Rows.Clear();
            foreach (var item in foods)
            {
                object[] ob = new object[3];
                ob[0] = item.ID;
                ob[1] = item.Food;
                ob[2] = item.Price;
                DataFoods.Rows.Add(ob);
            }
        }

        private void FoodsForm_Load(object sender, EventArgs e)
        {
            AddFoods(food.SearchFoods(ResturantKey, name));
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            name = TxtNameSearch.Text.Trim();
            AddFoods(food.SearchFoods(ResturantKey, name));
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            name = "";
            AddFoods(food.SearchFoods(ResturantKey, name));
        }

        private void BtnAddOrEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                TxtName.Focus();
                MessageBox.Show("لطفا نام محصول را وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtName.Text.Trim().Length > 20)
            {
                TxtName.Focus();
                MessageBox.Show("نام محصول حداکثر صد و پنجاه کاراکتر می باشد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (id == 0)
                {
                    Foods newfood = new Foods(TxtName.Text.Trim(), ResturantKey, TxtPrice.Value);
                    if (newfood.AddFood() != -1)
                    {
                        MessageBox.Show("اطلاعات غذا با موفقیت ذخیره شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddFoods(food.SearchFoods(ResturantKey, name));
                        BtnCancell_Click(BtnCancell, new EventArgs());
                    }
                }
                else
                {
                    Foods editFood = new Foods(TxtName.Text.Trim(), ResturantKey, TxtPrice.Value);
                    if (editFood.EditFood(id) != -1)
                    {
                        MessageBox.Show("اطلاعات غذا با موفقیت ویرایش شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddFoods(food.SearchFoods(ResturantKey, name));
                        BtnCancell_Click(BtnCancell, new EventArgs());
                    }
                }
            }
        }

        private void BtnCancell_Click(object sender, EventArgs e)
        {
            BtnCancell.Enabled = false;
            BtnDeleteFood.Enabled = false;
            BtnAddOrEdit.Text = "افزودن";
            id = 0;
            TxtName.Clear();
            TxtPrice.Value = 0;
        }

        private void BtnDeleteFood_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                if (MessageBox.Show("آیا از حذف غذا مطمئن هستید؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (food.RemoveFood(id) != -1)
                    {
                        MessageBox.Show("اطلاعات غذا با موفقیت حذف شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddFoods(food.SearchFoods(ResturantKey, name));
                        BtnCancell_Click(BtnCancell, new EventArgs());
                    }
                }
            }
        }

        private void DataFoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataFoods.CurrentRow != null)
                {
                    id = Convert.ToInt32(DataFoods.CurrentRow.Cells[0].Value.ToString());
                    TxtName.Text = DataFoods.CurrentRow.Cells[1].Value.ToString();
                    TxtPrice.Value = Convert.ToDecimal(DataFoods.CurrentRow.Cells[2].Value.ToString());
                    BtnAddOrEdit.Text = "ویرایش";
                    BtnDeleteFood.Enabled = true;
                    BtnCancell.Enabled = true;
                }
            }
            catch { }
        }
    }
}
