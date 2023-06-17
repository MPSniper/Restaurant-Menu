using Repository.DataModel;
using UI.ViewModels;

namespace UI
{
    public partial class ResturanRegisterForm : Form
    {
        public ResturanRegisterForm()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SplashForm splashForm = new SplashForm();
            splashForm.Show();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {

            RestaurantCardViewModel restaurantCard = new RestaurantCardViewModel(RestaurantNameBox.Text, OwnerTextBox.Text, StartTime.Value, EndTime.Value, AddressBox.Text, PasswordBox.Text, NationalCodeBox.Text);
            Restaurant restaurantDataModel = new Restaurant(restaurantCard.RestaurantName, restaurantCard.OwnerName, restaurantCard.StrStartTime(), restaurantCard.StrEndTime(), restaurantCard.ResAddress, restaurantCard.Password, restaurantCard.NationalCode);

            var id = restaurantDataModel.CheckNationalCode();
            var x = restaurantCard.CheckValidation();

            if (x == (int)ErrorCode_Enum.ThereIsNull)
                return;

            else if (id != (int)ErrorCode_Enum.ErrorInDB && id != (int)ErrorCode_Enum.Nationalcode_Correct)
            {
                MessageBox.Show("کد ملی وارد شده قبلا ثبت شده است.", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var flag = restaurantDataModel.BtnSignUp();

            if (flag == (int)ErrorCode_Enum.Register_successfully && id == (int)ErrorCode_Enum.Nationalcode_Correct && x == (int)ErrorCode_Enum.AllFieldsComplete)
            {

                MessageBox.Show("حساب کاربری با موفقیت ایجاد شد.", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                SplashForm splashForm = new SplashForm();
                splashForm.Show();
            }
        }

        private void ResturanRegisterForm_Load(object sender, EventArgs e)
        {
        }
    }
}

