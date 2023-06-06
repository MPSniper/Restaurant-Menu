using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Repository.DataModel
{
    public class Users
    {
        ConnectToDB connect = new ConnectToDB();
        string userName, userFamily, userNation, userAddress;

        public Users()
        {

        }

        public Users(string userName, string userFamily, string userNation, string userAddress)
        {

            this.userName = userName;
            this.userFamily = userFamily;
            this.userNation = userNation;
            this.userAddress = userAddress;

        }


        public int BtnLogin()
        {
            if (userName.Equals("") || userFamily.Equals("") || userNation.Equals("") || userAddress.Equals(""))
            {
                MessageBox.Show("Please complete all fields");
                return -1;
            }

            else
            {
                SqlCommand insertcommand = new SqlCommand("insert into User_Table(FirstName,LastName,NationalCode,Address) values(@userName,@userFamily,@userNation,@userAddress)");
                insertcommand.Parameters.AddWithValue("@username", userName);
                insertcommand.Parameters.AddWithValue("@userFamily", userFamily);
                insertcommand.Parameters.AddWithValue("@userNation", userNation);
                insertcommand.Parameters.AddWithValue("@userAddress", userAddress);
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

        public int Login(string nationalCode, string password)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectToDB.strConnString);
                con.Open();
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
