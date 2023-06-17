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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void EndTime_ValueChanged(object sender, EventArgs e)
        {
        }

        private void StartTime_ValueChanged(object sender, EventArgs e)
        {
        }

        private void RestaurantName_TextChanged(object sender, EventArgs e)
        {
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {
        }

        private void OwnerName_TextChanged(object sender, EventArgs e)
        {
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


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void ResturanRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


    }
}

