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

        public void addToCart(string foodType, int foodPrice)
        {
            this.foodType = foodType;
            this.foodPrice = foodPrice;
        }
    }
}
