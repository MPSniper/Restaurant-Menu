using Service.DTO;

namespace Repository.DataModel
{
    public class Restaurant
    {
        RestaurantDTO dto = new RestaurantDTO();
        public string RestaurantName, OwnerName, strStartTime, strEndTime, ResAddress, NationalCode, Password;
        public int Id;
        public Restaurant() {}
        public Restaurant(string RestaurantName, string OwnerName, string strStartTime, string strEndTime, string ResAddress, string NationalCode, string Password)
        {
            this.RestaurantName = RestaurantName;
            this.OwnerName = OwnerName;
            this.strStartTime = strStartTime;
            this.strEndTime = strEndTime;
            this.ResAddress = ResAddress;
            this.NationalCode = NationalCode;
            this.Password = Password;
        }
        public int BtnSignUp()
        {
            return dto.BtnSignUp(RestaurantName, OwnerName, strStartTime, strEndTime, ResAddress, NationalCode, Password);
        }
        public int BtnLogin()
        {
            return dto.BtnLogin(NationalCode, Password);
        }
        public List<(int Id, string RestaurantName)> GetRestaurants()
        {
            return dto.GetRestaurants();
        }
    }
}
