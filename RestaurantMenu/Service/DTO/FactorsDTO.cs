using System.Data;
using System.Data.SqlClient;

namespace Service.DTO
{
    public class FactorsDTO
    {
        ConnectToDB connect = new ConnectToDB();
        public int InsertFactor(int UserKey, int RestaurantKey, decimal Sum)
        {
            try
            {
                SqlConnection? connection = connect.CreateConnection();
                if (connection is null)
                    return -1;
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

        public (DataTable, string) ShowFactors(int ID)
        {
            DataTable dt = new DataTable();
            SqlConnection? con = connect.CreateConnection();
            SqlCommand sqlcommand = new SqlCommand("SELECT Factor_Table.Sum, Restaurant_Table.RestaurantName, User_Table.FirstName FROM Factor_Table JOIN Restaurant_Table ON Factor_Table.RestaurantKey = Restaurant_Table.ID JOIN User_Table ON User_Table.ID = Factor_Table.Userkey WHERE RestaurantKey = @ID ", con);
            sqlcommand.Parameters.AddWithValue("@ID", ID);

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
