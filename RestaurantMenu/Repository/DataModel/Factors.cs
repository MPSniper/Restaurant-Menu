using Service.DTO;
using System.Data;

namespace Repository.DataModel
{
    public class Factors
    {
        FactorsDTO dto = new FactorsDTO();
        public int ID, UserKey, RestaurantKey;
        public decimal Sum;

        public Factors() {}
        public Factors(int userKey, int restaurantKey, decimal sum)
        {
            UserKey = userKey;
            RestaurantKey = restaurantKey;
            Sum = sum;
        }

        public int InsertFactor()
        {
            return dto.InsertFactor(UserKey, RestaurantKey, Sum);
        }

        public (DataTable, string) ShowFactors(int ID)
        {
            return dto.ShowFactors(ID);
        }
    }
}