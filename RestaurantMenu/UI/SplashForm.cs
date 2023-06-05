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
            new UserRegisterForm().ShowDialog();
        }

        private void BtnResturanRegister_Click(object sender, EventArgs e)
        {
            new ResturanRegisterForm().ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMainResturan_Click(object sender, EventArgs e)
        {
            new MainResturanForm().ShowDialog();
        }

        private void BtnMainUser_Click(object sender, EventArgs e)
        {
            new MainUserForm().ShowDialog();
        }
    }
}
