using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataModel
{
    public class Foods
    {
        ConnectToDB connect = new ConnectToDB();
        public string Food;
        public int ID, RestaurantKey;
        public decimal Price;

        public Foods()
        {

        }

        public Foods(string food, int restaurantKey, decimal price)
        {
            Food = food;
            RestaurantKey = restaurantKey;
            Price = price;
        }

        public List<Foods> GetResturanFoods(int resturanId)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectToDB.strConnString);
                con.Open();
                SqlCommand command = new SqlCommand("select * from Foods_Table Where RestaurantKey = @rId", con);
                command.Parameters.AddWithValue("@rId", resturanId);
                List<Foods> result = new List<Foods>();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Foods food = new Foods();
                        food.ID = Convert.ToInt32(reader["ID"]);
                        food.Food = reader["Food"].ToString();
                        food.Price = Convert.ToDecimal(reader["Price"]);
                        result.Add(food);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Foods>();
            }
        }

        public List<Foods> SearchFoods(int resturanId, string? food, decimal price)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectToDB.strConnString);
                con.Open();
                StringBuilder sb = new();
                sb.Append("select * from Foods_Table Where RestaurantKey = @rId");
                if (!string.IsNullOrWhiteSpace(food))
                {
                    sb.Append($" and Food LIKE N'%{food}%'");
                }
                if (price != 0)
                {
                    sb.Append(" and Price >= @foodPrice");
                }
                SqlCommand command = new SqlCommand(sb.ToString(), con);
                command.Parameters.AddWithValue("@rId", resturanId);
                if (price != 0)
                {
                    command.Parameters.AddWithValue("@foodPrice", price);
                }
                List<Foods> result = new List<Foods>();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Foods foodInfo = new Foods();
                        foodInfo.ID = Convert.ToInt32(reader["ID"]);
                        foodInfo.Food = reader["Food"].ToString();
                        foodInfo.Price = Convert.ToDecimal(reader["Price"]);
                        result.Add(foodInfo);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Foods>();
            }
        }

        public int AddFood()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectToDB.strConnString);
                connection.Open();
                SqlCommand command = new SqlCommand("insert into Foods_Table(Food, RestaurantKey, Price) values(@foodName, @RestaurantId, @foodPrice)", connection);
                command.Parameters.AddWithValue("@foodName", Food);
                command.Parameters.AddWithValue("@RestaurantId", RestaurantKey);
                command.Parameters.AddWithValue("@foodPrice", Price);
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public int EditFood(int foodId)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectToDB.strConnString);
                connection.Open();
                SqlCommand command = new SqlCommand("Update Foods_Table set Food = @foodName, Price = @foodPrice Where ID = @foodId", connection);
                command.Parameters.AddWithValue("@foodName", Food);
                command.Parameters.AddWithValue("@foodPrice", Price);
                command.Parameters.AddWithValue("@foodId", foodId);
                return command.ExecuteNonQuery();
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
                SqlConnection connection = new SqlConnection(ConnectToDB.strConnString);
                connection.Open();
                SqlCommand command = new SqlCommand("Delete From Foods_Table Where ID = @foodId", connection);
                command.Parameters.AddWithValue("@foodId", foodId);
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
