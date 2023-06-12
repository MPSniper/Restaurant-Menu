using Repository.DataModel;

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
            splashForm.ShowDialog();
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

            var RestaurantName = RestaurantNameBox.Text;
            var OwnerName = OwnerTextBox.Text;
            var decStartTime = StartTime.Value;
            TimeSpan ts1 = TimeSpan.FromHours((double)decStartTime);
            string strStartTime = ts1.ToString("h\\:mm");
            //string strStartTime = "10:00:00";
            var decEndTime = EndTime.Value;
            TimeSpan ts2 = TimeSpan.FromHours((double)decEndTime);
            string strEndTime = ts2.ToString("h\\:mm");
            //string strEndTime = "20:00:00";
            var ResAddress = AddressBox.Text;
            var Password = PasswordBox.Text;
            var NationalCode = NationalCodeBox.Text;

            if (RestaurantName=="" || OwnerName=="" || strStartTime=="" || strEndTime=="" || ResAddress=="" || NationalCode=="" || Password=="")
            {
                MessageBox.Show("Please complete all fields");
                return;
            }

            Restaurant restaurantDataModel = new Restaurant(RestaurantName, OwnerName, strStartTime, strEndTime, ResAddress, Password, NationalCode);

            var flag = restaurantDataModel.BtnSignUp();

            if (flag == 1)
            {
                this.Hide();
                MainResturanForm mainResturanForm = new MainResturanForm();
                mainResturanForm.Show();
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
    }
}

