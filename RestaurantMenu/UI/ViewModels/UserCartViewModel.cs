using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UI.ViewModels
{
    public class UserCartViewModel
    {
        public UserCartViewModel(string userName, string userFamily, string userNation, string userAddress, string password) 
        {
            UserName = userName;
            UserFamily = userFamily;
            UserNation = userNation;
            UserAddress = userAddress;
            Password = password;
            CheckValidation();
        }

        public string UserName { get; }
        public string UserFamily { get; }
        public string UserNation { get; }
        public string UserAddress { get; }
        public string Password { get; }

        public void CheckValidation()
        {
            if (UserName == "" || UserFamily == "" || UserNation == "" || UserAddress == "" || Password == "")
            {
                MessageBox.Show("Please complete all fields");
                return;
            }
        }
          
}
}
