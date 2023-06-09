
using System.Data;
using System.Data.SqlClient;

namespace Repository.DataModel
{
    public class ConnectToDB
    {
        private static SqlConnection sqlConnection = new SqlConnection();


        
        //public static string strConnString = "Data Source=.;Initial Catalog=RestaurantDB;Integrated Security=True";

        //public static string strConnString = "Data Source=KODI\\MSSQLSERVER02;Initial Catalog=RestaurantDB;Integrated Security=True";
        //public static string strConnString = "Data Source=.;Initial Catalog=RestaurantDB;Integrated Security=True";
        public static string strConnString = "Data Source=MamadPC;Initial Catalog=NewRestaurant;Integrated Security=True";



        public int ExecuteQuery(SqlCommand dbCommand)
        {
            if (sqlConnection.State == 0)
            {
                MessageBox.Show("00");
                CreateConnection();
            }
            if (sqlConnection.State != 0)
                MessageBox.Show("111");

            try
            {
                if (sqlConnection.State == 0)
                {
                    CreateConnection();
                }

                dbCommand.Connection = sqlConnection;
                dbCommand.CommandType = CommandType.Text;


                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CreateConnection()
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.ConnectionString = strConnString;
                    sqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}