using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UI.ViewModels
{
    internal class RestaurantCardViewModel
    {
 

        public RestaurantCardViewModel(string RestaurantName, string OwnerName, decimal decStartTime, decimal decEndTime, string ResAddress, string Password, string NationalCode)
        {
            this.RestaurantName = RestaurantName;
            this.OwnerName = OwnerName;
            this.decStartTime = decStartTime;
            this.decEndTime = decEndTime;
            this.ResAddress = ResAddress;
            this.Password = Password;
            this.NationalCode = NationalCode;
        }

        public string RestaurantName { get; }
        public string OwnerName { get; }
        public decimal decStartTime { get; }
        public decimal decEndTime { get; }
        public string ResAddress { get; }
        public string Password { get; }
        public string NationalCode { get; }


        public string StrStartTime()
        {
            TimeSpan ts1 = TimeSpan.FromHours((double)decStartTime);
            return ts1.ToString("h\\:mm");
        }

        public string StrEndTime()
        {
            TimeSpan ts1 = TimeSpan.FromHours((double)decEndTime);
            return ts1.ToString("h\\:mm");
        }

        public int CheckValidation()
        {
            if (RestaurantName == "" || OwnerName == "" || decStartTime == 0 || decEndTime == 0 || ResAddress == "" || Password == "" || NationalCode == "")
            {
                MessageBox.Show("لطفا تمام گزینه ها را تکمیل کنید.");
                return -2;
            }
            return 0;

        }
    }
}
