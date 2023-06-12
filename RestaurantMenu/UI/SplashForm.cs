namespace UI
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void BtnUserRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            new UserRegisterForm().ShowDialog();
        }

        private void BtnResturanRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            new ResturanRegisterForm().ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnMainResturan_Click(object sender, EventArgs e)
        {

            this.Hide();
            new RestaurantLoginForm().ShowDialog();
        }

        private void BtnMainUser_Click(object sender, EventArgs e)
        {
            this.Hide();

            new MainUserForm().ShowDialog();
        }

        private void BtnLoginUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserLoginForm().ShowDialog();
        }
    }
}
