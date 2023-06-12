using Service.DTO;

namespace Repository.DataModel
{
    public class Foods
    {
        FoodsDTO dto = new FoodsDTO();
        public string Food;
        public int ID, RestaurantKey;
        public decimal Price;

        public Foods()
        {
        }

        public Foods(string food, int restaurantKey, decimal price)
        {
            Food = food;
            RestaurantKey = restaurantKey;
            Price = price;
        }

        public List<(int ID, string Food, decimal Price)> GetResturanFoods(int RestaurantKey)
        {
           return dto.GetResturanFoods(RestaurantKey);
        }

        public List<(int ID, string Food, decimal Price)> SearchFoods(int RestaurantKey, string Food)
        {
           return dto.SearchFoods(RestaurantKey, Food);
        }

        public int AddFood()
        {
            return dto.AddFood(Food, RestaurantKey, Price);
        }

        public int EditFood(int ID)
        {
            return dto.EditFood(Food, Price, ID);
        }

        public int RemoveFood(int ID)
        {
            return dto.RemoveFood(ID);
        }
    }
}
