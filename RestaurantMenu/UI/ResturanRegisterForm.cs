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

        private void BtnLogin_Click(object sender, EventArgs e)
        {



            var RestaurantName = RestaurantBox.Text;
            var OwnerName = Owner.Text;

            var decStartTime = StartTime.Value;
            TimeSpan ts1 = TimeSpan.FromHours((double)decStartTime);
            string strStartTime = ts1.ToString("h\\:mm");
            var decEndTime = EndTime.Value;
            TimeSpan ts2 = TimeSpan.FromHours((double)decEndTime);
            string strEndTime = ts2.ToString("h\\:mm");

            var ResAddress = AddressBox.Text;

            Restaurant restaurantDataModel = new Restaurant(RestaurantName, OwnerName, strStartTime, strEndTime, ResAddress);


            var flag = restaurantDataModel.BtnLogin();


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
    }
}

