using Repository.DataModel;
using UI.ViewModels;

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
            this.Hide();
            new SplashForm().ShowDialog();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {

            UserCardViewModel userViewModel = new UserCardViewModel(NameTextBox.Text, FamilyTextBox.Text, NationalityTextBox.Text, AddressTextBox.Text, PasswordTextBox.Text);
            Users userDataModel = new Users(userViewModel.UserName,  userViewModel.UserFamily,userViewModel.UserNation, userViewModel.UserAddress, userViewModel.Password);

            var flag = userDataModel.BtnSignUp();

            if (flag == 1)
            {
                this.Hide();
                new SplashForm().ShowDialog();
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
