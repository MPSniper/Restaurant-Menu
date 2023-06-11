using System.Data.SqlClient;

namespace Repository.DataModel
{
    public class Users
    {
        ConnectToDB connect = new ConnectToDB();
        string userName, userFamily, userNation, userAddress, password;

        public Users()
        {

        }

        public Users(string userName, string userFamily, string userNation, string userAddress, string password)
        {

            this.userName = userName;
            this.userFamily = userFamily;
            this.userNation = userNation;
            this.userAddress = userAddress;
            this.password = password;

        }


        public int BtnSignUp()
        {
            if (userName.Equals("") || userFamily.Equals("") || userNation.Equals("") || userAddress.Equals(""))
            {
                MessageBox.Show("Please complete all fields");
                return -1;
            }

            else
            {
                SqlCommand insertcommand = new SqlCommand("insert into User_Table(FirstName,LastName,NationalCode,Address,Password) values(@userName,@userFamily,@userNation,@userAddress,@password)");
                insertcommand.Parameters.AddWithValue("@username", userName);
                insertcommand.Parameters.AddWithValue("@userFamily", userFamily);
                insertcommand.Parameters.AddWithValue("@userNation", userNation);
                insertcommand.Parameters.AddWithValue("@userAddress", userAddress);
                insertcommand.Parameters.AddWithValue("@password", password);
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
                connect.CloseConnection();

            }
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
                SqlCommand command = new SqlCommand("select ID From User_Table Where NationalCode = @nationalCode and [Password] = @pass", con);
                command.Parameters.AddWithValue("@nationalCode", nationalCode);
                command.Parameters.AddWithValue("@pass", password);
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
