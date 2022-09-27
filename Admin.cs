namespace Onlinerestaurang
{
    internal class Admin : Users
    {
        private string restaurantName;
        private string restaurantAdress;
        private string restaurantPhoneNr;

        public Admin(string restaurantName, string restaurantAdress, string restaurantPhoneNr)
        {
            this.restaurantName = restaurantName;
            this.restaurantAdress = restaurantAdress;
            this.restaurantPhoneNr = restaurantPhoneNr;
        }
        public string RestaurantName() { return restaurantName; }

        public void AddFood()
        {

        }

        public void RemoveFood()
        {

        }




    }

}
