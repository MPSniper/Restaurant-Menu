using System.Data.SqlClient;


namespace Service.DTO
{
    public class UsersDTO
    {
        ConnectToDB connect = new ConnectToDB();
        

        public int BtnSignUp(string userName, string userFamily, string userNation, string userAddress, string password)
        {
            
                SqlCommand insertcommand = new SqlCommand("insert into User_Table(FirstName,LastName,NationalCode,Address,Password) values(@userName,@userFamily,@userNation,@userAddress,@password)");
                insertcommand.Parameters.AddWithValue("@username", userName);
                insertcommand.Parameters.AddWithValue("@userFamily", userFamily);
                insertcommand.Parameters.AddWithValue("@userNation", userNation);
                insertcommand.Parameters.AddWithValue("@userAddress", userAddress);
                insertcommand.Parameters.AddWithValue("@password", password);
                var row = connect.ExecuteQuery(insertcommand);
            connect.CloseConnection();
            return (row == 1 ? row : -1);



        }

        public int Login(string nationalCode, string password)
        {
            try
            {
                SqlConnection? con = connect.CreateConnection();
                if (con is null)
                {
                    return -1;
                }
                SqlCommand command = new SqlCommand("select ID From User_Table Where NationalCode = @nationalCode and [Password] = @password", con);
                command.Parameters.AddWithValue("@nationalCode", nationalCode);
                command.Parameters.AddWithValue("@password", password);
                int id = 0;
                try
                {
                    id = Convert.ToInt32(command.ExecuteScalar());
                }
                catch
                {
                    id = 0;
                }
                connect.CloseConnection();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ارتباط با دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}

