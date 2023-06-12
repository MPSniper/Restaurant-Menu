
using System.Data.SqlClient;


namespace UI.ViewModels
{
    public class UserCardViewModel
    {

        public UserCardViewModel(string userName, string userFamily, string userNation, string userAddress, string password) 
        {
            UserName = userName;
            UserFamily = userFamily;
            UserNation = userNation;
            UserAddress = userAddress;
            Password = password;
             

        }

        public string UserName { get; }
        public string UserFamily { get; }
        public string UserNation { get; }
        public string UserAddress { get; }
        public string Password { get; }

        public int CheckValidation()
        {
            if (UserName == "" || UserFamily == "" || UserNation == "" || UserAddress == "" || Password == "")
            {
                MessageBox.Show("لطفا تمام گزینه ها را تکمیل کنید.");
                return -2 ;
            }
            return 2 ;

        }
          
}
}
