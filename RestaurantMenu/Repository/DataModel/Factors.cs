using System.Data.SqlClient;

namespace Repository.DataModel
{
    public class Factors
    {
        ConnectToDB connect = new ConnectToDB();
        public int ID, UserKey, RestaurantKey;
        public decimal Sum;

        public Factors(int userKey, int restaurantKey, decimal sum)
        {
            UserKey = userKey;
            RestaurantKey = restaurantKey;
            Sum = sum;
        }

        public int InsertFactor()
        {
            try
            {
                SqlConnection? connection = connect.CreateConnection();
                if (connection is null)
                {
                    return -1;
                }
                SqlCommand command = new SqlCommand("insert into Factor_Table(UserKey, RestaurantKey, [Sum]) values(@userKey, @restaurantKey, @factorSum)", connection);
                command.Parameters.AddWithValue("@userKey", UserKey);
                command.Parameters.AddWithValue("@restaurantKey", RestaurantKey);
                command.Parameters.AddWithValue("@factorSum", Sum);
                var result = command.ExecuteNonQuery();
                connect.CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}