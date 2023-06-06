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
            this.Close();
        }

        private void BtnMainResturan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainResturanForm().ShowDialog();
        }

        private void BtnMainUser_Click(object sender, EventArgs e)
        {
            this.Hide();

            new MainUserForm().ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
