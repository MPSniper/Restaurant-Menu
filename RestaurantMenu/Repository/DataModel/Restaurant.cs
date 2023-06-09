using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Repository;

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


        public int BtnLogin()
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

        public List<Restaurant> GetRestaurants()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectToDB.strConnString);
                con.Open();
                SqlCommand command = new SqlCommand("Select * from Restaurant_Table", con);
                List<Restaurant> result = new List<Restaurant>();
                SqlDataReader reader = command.ExecuteReader();
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
