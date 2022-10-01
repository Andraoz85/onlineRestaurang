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

        public string GetfoodType()
        {
            return foodType;
        }
        public int GetfoodPrice()
        {
            return foodPrice;
        }


    }
}

