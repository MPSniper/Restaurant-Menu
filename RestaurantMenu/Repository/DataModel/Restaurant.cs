using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataModel
{
    public class Restaurant
    {
        ConnectToDB connect = new ConnectToDB();
        string RestaurantName, OwnerName, strStartTime, strEndTime, ResAddress;



        public Restaurant(string RestaurantName, string OwnerName, string strStartTime,string strEndTime, string ResAddress)
        {

            this.RestaurantName = RestaurantName;
            this.OwnerName = OwnerName;
            this.strStartTime = strStartTime;
            this.strEndTime = strEndTime;
            this.ResAddress = ResAddress;

        }


        public int BtnLogin()
        {
            if (RestaurantName.Equals("") || OwnerName.Equals("") || strStartTime.Equals("") || strEndTime.Equals("") || ResAddress.Equals(""))
            {
                MessageBox.Show("Please complete all fields");
                return -1;
            }

            else
            {
                SqlCommand insertcommand = new SqlCommand("insert into Restaurant_Table(RestaurantName,OwnerName,StartTime,EndTime,Address)" +
                    " values(@RestaurantName,@OwnerName,@StartTime,@EndTime,@userAddress)");
                insertcommand.Parameters.AddWithValue("@RestaurantName", RestaurantName);
                insertcommand.Parameters.AddWithValue("@OwnerName", OwnerName);
                insertcommand.Parameters.AddWithValue("@StartTime", strStartTime);
                insertcommand.Parameters.AddWithValue("@EndTime", strEndTime);
                insertcommand.Parameters.AddWithValue("@userAddress", ResAddress);
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
    }
}
