using Repository.DataModel;

namespace UI
{
    public partial class RestaurantLoginForm : Form
    {

        public RestaurantLoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            var NationalCode = TxtNationalCode.Text;
            var Password = TxtPassword.Text;

            Restaurant restaurant = new Restaurant();
            var id = restaurant.BtnLogin(NationalCode, Password);
            if (id == 0)
            {
                MessageBox.Show("اطلاعات وارد شده نادرست است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (id != -1)
            {

                this.Hide();
                MainResturanForm restaurantForm = new MainResturanForm();
                restaurantForm.ID = id;
                restaurantForm.Show();
                this.Close();
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SplashForm().Show();
        }
    }
}
