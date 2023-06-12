
using System.Data;
using System.Data.SqlClient;

namespace Repository.DataModel
{
    public class ConnectToDB
    {
        private static SqlConnection sqlConnection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        public static string strConnString = "Data Source=KODI\\MSSQLSERVER02;Initial Catalog=RestaurantDB;Integrated Security=True";
       // public static string strConnString = "Data Source=.;Initial Catalog=RestaurantDB;Integrated Security=True";
        //public static string strConnString = "Data Source=MamadPC;Initial Catalog=NewRestaurant;Integrated Security=True";



        public int ExecuteQuery(SqlCommand dbCommand)
        {
            

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

        public SqlConnection? CreateConnection()
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.ConnectionString = strConnString;
                    sqlConnection.Open();
                }
                return sqlConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public void readData(SqlCommand  query, DataTable tblName)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    CreateConnection();
                }

                command = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}