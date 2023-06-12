using Repository.DataModel;

namespace UI
{
    public partial class UserRegisterForm : Form
    {

        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //SplashForm splashForm = new SplashForm();
            this.Hide();

            new SplashForm().ShowDialog();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            var userName = NameTextBox.Text;
            var userFamily = FamilyTextBox.Text;
            var userNation = NationalityTextBox.Text;
            var userAddress = AddressTextBox.Text;
            var password = PasswordTextBox.Text;

            if (userName == "" || userFamily == "" || userNation == "" || userAddress == "" || password == "")
            {
                MessageBox.Show("Please complete all fields");
                return;
            }

            Users userDataModel = new Users(userName, userFamily, userNation, userAddress, password);

            var flag = userDataModel.BtnSignUp();

            if (flag == 1)
            {
                this.Hide();
                MainUserForm mainUserForm = new MainUserForm();
                mainUserForm.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
