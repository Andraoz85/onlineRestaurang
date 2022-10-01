using System;

namespace Onlinerestaurang
{
    class Customer : Users
    {
        private string customerName;
        private string customerAdress;

        public Customer(string customerName, string customerAdress)
        {
            this.customerName = customerName;
            this.customerAdress = customerAdress;
        }


        public string ShowInfo()
        {
            return $"{customerName}\n {customerAdress}";
        }
        public void AddToCart(string meal)
        {
            Console.WriteLine("You added {0} to the cart", meal);
        }

    }


}
