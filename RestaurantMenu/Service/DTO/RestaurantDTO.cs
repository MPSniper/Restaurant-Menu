using System.Data.SqlClient;

namespace Service.DTO
{
    public class RestaurantDTO
    {
        ConnectToDB connect = new ConnectToDB();
        public int BtnSignUp(string RestaurantName, string OwnerName, string strStartTime, string strEndTime, string ResAddress, string NationalCode, string Password)
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

            connect.CloseConnection();
            return (row == 1 ? row : -1);

        }
        public int BtnLogin(string NationalCode, string Password)
        {

            try
            {
                if (NationalCode.Trim().Length != 10)
                {
                    MessageBox.Show("کد ملی وارد شده نامعتبر است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return -1;
                }
                else if (string.IsNullOrWhiteSpace(Password))
                {
                    MessageBox.Show("رمز ورود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return -1;
                }
                else
                {
                    SqlConnection? con = connect.CreateConnection();

                    SqlCommand insertcommand = new SqlCommand("select ID From Restaurant_Table Where NationalCode = @nationalCode and [Password] = @pass", con);
                    insertcommand.Parameters.AddWithValue("@nationalCode", NationalCode);
                    insertcommand.Parameters.AddWithValue("@pass", Password);

                    int id = 0;
                    try
                    {
                        id = Convert.ToInt32(insertcommand.ExecuteScalar());
                    }
                    catch
                    {
                        id = 0;
                    }
                    connect.CloseConnection();
                    return id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public List<(int, string)> GetRestaurants()
        {
            try
            {
                SqlConnection? con = connect.CreateConnection();
                if (con is null)
                {
                    return new();
                }
                SqlCommand command = new SqlCommand("Select * from Restaurant_Table", con);
                var result = new List<(int, string)>();
                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int Id;
                        string RestaurantName;
                        Id = Convert.ToInt32(reader["Id"].ToString());
                        RestaurantName = reader["RestaurantName"].ToString();
                        result.Add((Id, RestaurantName));
                    }
                }
                connect.CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<(int, string)>();
            }
        }
    }
}
