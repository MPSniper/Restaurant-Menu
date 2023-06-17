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
            new UserRegisterForm().Show();
        }

        private void BtnResturanRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ResturanRegisterForm().Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnMainResturan_Click(object sender, EventArgs e)
        {

            this.Hide();
            new RestaurantLoginForm().Show();
        }

        private void BtnMainUser_Click(object sender, EventArgs e)
        {
            this.Hide();

            new MainUserForm().Show();
        }

        private void BtnLoginUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserLoginForm().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
