using Repository.DataModel;
using UI.ViewModels;

namespace UI
{
    public partial class UserRegisterForm : Form
    {
        ErrorCode_Enum errorCode = new ErrorCode_Enum();
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

            Users userDataModel = new Users(userViewModel.UserName, userViewModel.UserFamily, userViewModel.UserNation, userViewModel.UserAddress, userViewModel.Password);
            var id = userDataModel.CheckNationalCode();
            var x = userViewModel.CheckValidation();

            if (x == (int)ErrorCode_Enum.ThereIsNull)
                return;
            else if (id != (int)ErrorCode_Enum.ErrorInDB && id != (int)ErrorCode_Enum.Nationalcode_Correct)
            {
                MessageBox.Show("کد ملی وارد شده قبلا ثبت شده است.", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var flag = userDataModel.BtnSignUp();

            if (flag == (int)ErrorCode_Enum.Register_successfully && id == (int)ErrorCode_Enum.Nationalcode_Correct && x == (int)ErrorCode_Enum.AllFieldsComplete)
            {

                MessageBox.Show("حساب کاربری با موفقیت ایجاد شد.", "پیغام");
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
