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
            var id = userDataModel.CheckNationalCode();
            var x = userViewModel.CheckValidation();

            if (x == -2)
                return;
            else if (id != -1 && id != 0 )
            {
                MessageBox.Show("کد ملی وارد شده قبلا ثبت شده است.", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var flag = userDataModel.BtnSignUp();

            if (flag == 1 && id == 0 && x == 0)
            {

                MessageBox.Show("حساب کاربری با موفقیت ایجاد شد.", "پیغام" );
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
