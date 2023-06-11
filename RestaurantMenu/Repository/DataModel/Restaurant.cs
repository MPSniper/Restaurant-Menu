using System.Data.SqlClient;
using System.Windows.Forms;

namespace Repository.DataModel
{
    public class Restaurant
    {
        ConnectToDB connect = new ConnectToDB();
        public string RestaurantName, OwnerName, strStartTime, strEndTime, ResAddress, NationalCode, Password;
        public int Id;

        public Restaurant()
        {

        }

        public Restaurant(string RestaurantName, string OwnerName, string strStartTime,string strEndTime, string ResAddress, string NationalCode, string Password)
        {

            this.RestaurantName = RestaurantName;
            this.OwnerName = OwnerName;
            this.strStartTime = strStartTime;
            this.strEndTime = strEndTime;
            this.ResAddress = ResAddress;
            this.NationalCode = NationalCode;
            this.Password= Password;

        }


        public int BtnSignUp()
        {
            if (RestaurantName.Equals("") || OwnerName.Equals("") || strStartTime.Equals("") || strEndTime.Equals("") || ResAddress.Equals("") || NationalCode.Equals("") || Password.Equals(""))
            {
                MessageBox.Show("Please complete all fields");
                return -1;
            }

            else
            {
                SqlCommand insertcommand = new SqlCommand("insert into Restaurant_Table(RestaurantName,OwnerName,StartTime,EndTime,Address,Password,NationalCode)" +
                    " values(@RestaurantName,@OwnerName,@StartTime,@EndTime,@ResAddress,@Password,@NationalCode)");
                insertcommand.Parameters.AddWithValue("@RestaurantName", RestaurantName);
                insertcommand.Parameters.AddWithValue("@OwnerName", OwnerName);
                insertcommand.Parameters.AddWithValue("@StartTime", strStartTime);
                insertcommand.Parameters.AddWithValue("@EndTime", strEndTime);
                insertcommand.Parameters.AddWithValue("@ResAddress", ResAddress);
                insertcommand.Parameters.AddWithValue("@Password", Password);
                insertcommand.Parameters.AddWithValue("@NationalCode", NationalCode);
                var row = connect.ExecuteQuery(insertcommand);

                if (row == 1)
                {
                    MessageBox.Show("SUCCESSFULL");
                    return 1;
                }
                else
                {
                    MessageBox.Show("Error");
                    return -1;
                }
            }
        }
        
        public int BtnLogin( string NationalCode, string Password)
        {
            if (NationalCode.Trim().Length != 10)
            {
                MessageBox.Show("کد ملی وارد شده نامعتبر است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("رمز ورود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {

                SqlConnection? con = connect.CreateConnection();

                SqlCommand insertcommand = new SqlCommand("select ID From Restaurant_Table Where NationalCode = @nationalCode and [Password] = @pass",con);
                insertcommand.Parameters.AddWithValue("@nationalCode", NationalCode);
                insertcommand.Parameters.AddWithValue("@pass", Password);

                int id = 0;
                try
                {
                    id = Convert.ToInt32(insertcommand.ExecuteScalar());
                }
                catch
                {
                    MessageBox.Show("اطلاعات وارد شده نادرست است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return -1;
                }

                connect.CloseConnection();
                return id;
               
            }
        }

        public List<Restaurant> GetRestaurants()
        {
            try
            {
                SqlConnection? con = connect.CreateConnection();
                if (con is null)
                {
                    return new();
                }
                SqlCommand command = new SqlCommand("Select * from Restaurant_Table", con);
                List<Restaurant> result = new List<Restaurant>();
                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Restaurant res = new Restaurant();
                        res.Id = Convert.ToInt32(reader["Id"].ToString());
                        res.RestaurantName = reader["RestaurantName"].ToString();
                        result.Add(res);
                    }
                }
                connect.CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Restaurant>();
            }
        }


    }
}
