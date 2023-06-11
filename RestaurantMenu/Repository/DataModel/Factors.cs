using System.Data;
using System.Data.SqlClient;

namespace Repository.DataModel
{
    public class Factors
    {
        ConnectToDB connect = new ConnectToDB();
        public int ID, UserKey, RestaurantKey;
        public decimal Sum;

        public Factors()
        {
        }
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

        public (DataTable , string ) ShowFactors()
        {
            DataTable dt = new DataTable();
            string sqlcommand = "SELECT Factor_Table.Sum, Restaurant_Table.RestaurantName, User_Table.FirstName FROM Factor_Table JOIN Restaurant_Table ON Factor_Table.RestaurantKey = Restaurant_Table.ID JOIN User_Table ON User_Table.ID = Factor_Table.Userkey";
            connect.readData(sqlcommand, dt);
            DataColumn column = dt.Columns["Sum"];
            DataRow[] rows = dt.Select();
            var sum = 0;
            foreach (DataRow row in rows)
            {
                object columnValue = row[column];
                sum += Convert.ToInt32(columnValue);
            }
            return (dt, sum.ToString());
        }
    }
}