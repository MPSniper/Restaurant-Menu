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
    }
}
