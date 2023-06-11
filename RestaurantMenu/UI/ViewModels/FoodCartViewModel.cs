namespace UI.ViewModels
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

        public int FoodId { get; }
        public string FoodName { get; }
        public decimal FoodPrice { get; }
        public int Count { get; set; }
    }
}
