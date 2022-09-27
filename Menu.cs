namespace Onlinerestaurang
{
    class Menu
    {
        private string foodType;
        private int foodPrice;


        public Menu(string foodType, int foodPrice)
        {
            this.foodType = foodType;
            this.foodPrice = foodPrice;
        }

        public void UpdateFoodType()
        {

        }

        public void UpdatePrice()
        {

        }
        public string ShowMenu()
        {
            return foodType + foodPrice;
        }
        public string GetFoodType()
        {
            return foodType;
        }
        public int GetFoodPrice()
        {
            return foodPrice;
        }
    }
}

