using System;
using System.Collections.Generic;

namespace Onlinerestaurang
{
    class Cart : Menu
    {
        private int totalPrice;

        public List<Menu> cartList = new List<Menu>();

        public Cart(string foodType, int foodPrice, int totalPrice)
                    : base(foodType, foodPrice)
        {
            this.totalPrice = totalPrice;
        }


        public void AddToCart(Menu menu)
        {
            cartList.Add(menu);
            Console.WriteLine("You ordered: \t " + menu.GetfoodType() + menu.GetfoodPrice());
        }

    }
}
