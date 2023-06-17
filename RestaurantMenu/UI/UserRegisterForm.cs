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
            new SplashForm().Show();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {

            UserCardViewModel userViewModel = new UserCardViewModel(NameTextBox.Text, FamilyTextBox.Text, NationalityTextBox.Text, AddressTextBox.Text, PasswordTextBox.Text);

            Users userDataModel = new Users(userViewModel.UserName, userViewModel.UserFamily, userViewModel.UserNation, userViewModel.UserAddress, userViewModel.Password);
            var id = userDataModel.CheckNationalCode();
            var Valid = userViewModel.CheckValidation();

            if (Valid == (int)ErrorCode_Enum.ThereIsNull)
                return;
            else if (id != (int)ErrorCode_Enum.ErrorInDB && id != (int)ErrorCode_Enum.Nationalcode_Correct)
            {
                MessageBox.Show("کد ملی وارد شده قبلا ثبت شده است.", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var flag = userDataModel.BtnSignUp();

            if (flag == (int)ErrorCode_Enum.Register_successfully && id == (int)ErrorCode_Enum.Nationalcode_Correct && Valid == (int)ErrorCode_Enum.AllFieldsComplete)
            {

                MessageBox.Show("حساب کاربری با موفقیت ایجاد شد.", "پیغام");
                this.Hide();
                new SplashForm().ShowDialog();
            }
        }
    }
}
