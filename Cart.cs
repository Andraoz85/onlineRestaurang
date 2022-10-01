namespace Onlinerestaurang
{
    class Cart
    {
        private string foodType;
        private int foodPrice;

        public Cart(string foodType, int foodPrice)
        {
            this.foodType = foodType;
            this.foodPrice = foodPrice;
        }


        public object AddToCart()
        {
            return foodType + foodPrice;
        }

        public string AddFood()
        {
            return foodType;
        }
        public int AddPrice()
        {
            return foodPrice;
        }
    }
}
