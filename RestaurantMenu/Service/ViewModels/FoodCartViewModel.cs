namespace Service.ViewModels
{
    public class FoodCartViewModel
    {
        public FoodCartViewModel(int foodId, string foodName, decimal foodPrice, int count)
        {
            FoodId = foodId;
            FoodName = foodName;
            FoodPrice = foodPrice;
            Count = count;
        }

        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public decimal FoodPrice { get; set; }
        public int Count { get; set; }
    }
}
