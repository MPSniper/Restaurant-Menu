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

        public int FoodId { get; private set; }
        public string FoodName { get; private set; }
        public decimal FoodPrice { get; private set; }
        public int Count { get; set; }
    }
}
