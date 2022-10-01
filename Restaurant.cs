using System;

namespace Onlinerestaurang
{

    class Restaurant
    {

        Menu[] foodMenu = new Menu[4];
        Cart[] cart = new Cart[4];

        public Restaurant()
        {
            Menu menus1 = new Menu("Pizza  med dricka \t\t Pris: ", 129);
            Menu menus2 = new Menu("Hamburgertallrik med dricka \t Pris: ", 99);
            Menu menus3 = new Menu("Kebabtallrik med dricka  \t Pris: ", 119);

            Cart cart1 = new Cart("", 0);
            Cart cart2 = new Cart("", 0);
            Cart cart3 = new Cart("", 0);

            cart[1] = cart1;
            cart[2] = cart2;
            cart[3] = cart3;

            foodMenu[1] = menus1;
            foodMenu[2] = menus2;
            foodMenu[3] = menus3;
        }


        public void Greetings()
        {
            bool quit = false;

            while (quit == false)
            {
                Console.WriteLine("Welcome to pizzeria Rimini. Please make a choice:");
                Console.WriteLine("1: View Menu");
                Console.WriteLine("2: Exit");
                string input = Console.ReadLine();



                if (input == "1")
                {
                    ShowMenu();
                    ChooseMenu();
                    break;
                }
                else if (input != "2")
                {
                    Console.WriteLine("wrong input, try again");
                }
                else
                {
                    quit = true;
                    Console.WriteLine("Thanks for stopping by!");
                }
            }

        }

        public void ShowMenu()
        {
            for (int i = 1; i < foodMenu.Length; i++)
            {
                Menu menu = foodMenu[i];
                Console.WriteLine("Menu:" + i + "\t" + menu.GetfoodType() + menu.GetfoodPrice());

            }
        }

        public void ChooseMenu()
        {

            Console.WriteLine("Which menu would you like to add?");
            bool quit = false;
            while (quit == false)
            {
                string makeChoice = Console.ReadLine();
                if (makeChoice == "1")
                {
                    Console.WriteLine("you added menu 1 to the cart");
                    quit = true;
                }
                else if (makeChoice == "2")
                {
                    Console.WriteLine("you added menu 2 to the cart");
                    quit = true;
                }
                else if (makeChoice == "3")
                {
                    Console.WriteLine("you added menu nr 3 to the cart");
                    quit = !true;
                }
                else
                {
                    Console.WriteLine("wrong input, try again");
                }
            }
        }


    }


}

