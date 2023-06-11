using Repository.DataModel;

namespace UI
{
    public partial class RestaurantLoginForm : Form
    {

        public RestaurantLoginForm()
        {
            InitializeComponent();
        }

        private void TxtNationalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var NationalCode = TxtNationalCode.Text;
            var Password = TxtPassword.Text;

            Restaurant restaurant = new Restaurant();
            var id = restaurant.BtnLogin(NationalCode, Password);

            if (id != -1)
            {
                this.Hide();
                MainResturanForm restaurantForm = new MainResturanForm();
                restaurantForm.ID = id;
                restaurantForm.ShowDialog();
                this.Close();
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SplashForm().Show();


        }
    }
}
