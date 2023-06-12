using System.Data.SqlClient;
using System.Text;

namespace Service.DTO
{
    public class FoodsDTO
    {
        ConnectToDB connect = new ConnectToDB();


        public List<(int, string, decimal)> GetResturanFoods(int resturanId)
        {
            try
            {
                SqlConnection? con = connect.CreateConnection();
                if (con is null)
                {
                    return new();
                }
                SqlCommand command = new SqlCommand("select * from Foods_Table Where RestaurantKey = @rId", con);
                command.Parameters.AddWithValue("@rId", resturanId);
                List<(int, string, decimal)> result = new List<(int, string, decimal)>();
                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Food = reader["Food"].ToString();
                        decimal Price = Convert.ToDecimal(reader["Price"]);
                        result.Add((ID, Food, Price));
                    }
                }
                connect.CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<(int, string, decimal)>();
            }
        }

        public List<(int, string, decimal)> SearchFoods(int resturanId, string? food)
        {
            try
            {
                SqlConnection? con = connect.CreateConnection();
                if (con is null)
                {
                    return new();
                }
                StringBuilder sb = new();
                sb.Append("select * from Foods_Table Where RestaurantKey = @rId");
                if (!string.IsNullOrWhiteSpace(food))
                {
                    sb.Append($" and Food LIKE N'%{food}%'");
                }
                SqlCommand command = new SqlCommand(sb.ToString(), con);
                command.Parameters.AddWithValue("@rId", resturanId);
                List<(int, string, decimal)> result = new List<(int, string, decimal)>();
                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Food = reader["Food"].ToString();
                        decimal Price = Convert.ToDecimal(reader["Price"]);
                        result.Add((ID, food, Price));
                    }
                }
                connect.CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<(int, string, decimal)>();
            }
        }

        public int AddFood(string Food, int RestaurantKey, decimal Price)
        {
            try
            {
                SqlConnection? con = connect.CreateConnection();
                if (con is null)
                {
                    return new();
                }
                SqlCommand command = new SqlCommand("insert into Foods_Table(Food, RestaurantKey, Price) values(@foodName, @RestaurantId, @foodPrice)", con);
                command.Parameters.AddWithValue("@foodName", Food);
                command.Parameters.AddWithValue("@RestaurantId", RestaurantKey);
                command.Parameters.AddWithValue("@foodPrice", Price);
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

        public int EditFood(string Food, decimal Price, int foodId)
        {
            try
            {
                SqlConnection? con = connect.CreateConnection();
                if (con is null)
                {
                    return new();
                }
                SqlCommand command = new SqlCommand("Update Foods_Table set Food = @foodName, Price = @foodPrice Where ID = @foodId", con);
                command.Parameters.AddWithValue("@foodName", Food);
                command.Parameters.AddWithValue("@foodPrice", Price);
                command.Parameters.AddWithValue("@foodId", foodId);
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

        public int RemoveFood(int foodId)
        {
            try
            {
                SqlConnection? con = connect.CreateConnection();
                if (con is null)
                {
                    return new();
                }
                SqlCommand command = new SqlCommand("Delete From Foods_Table Where ID = @foodId", con);
                command.Parameters.AddWithValue("@foodId", foodId);
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
