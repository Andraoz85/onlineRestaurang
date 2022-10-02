using System;
using static System.Console;

namespace Onlinerestaurang
{

    class Restaurant
    {

        Menu[] foodMenu = new Menu[4];
        Cart cart = new Cart("", 0, 0);

        public Restaurant()
        {
            Menu menus1 = new Menu("Pizza  med dricka \t\t Pris: ", 129);
            Menu menus2 = new Menu("Hamburgertallrik med dricka \t Pris: ", 99);
            Menu menus3 = new Menu("Kebabtallrik med dricka  \t Pris: ", 119);

            foodMenu[1] = menus1;
            foodMenu[2] = menus2;
            foodMenu[3] = menus3;
        }

        public void RunOperations()
        {
            Console.WriteLine("Welcome to pizzeria Rimini. Please make a choice:");
            Console.WriteLine("1: View Menu");
            Console.WriteLine("2: Exit");
            bool quit = false;
            while (quit == false)
            {
                string input = Console.ReadLine();
                if (input == "1")
                {
                    ShowMenu();
                    ChooseMenu();
                    DisplayOutro();
                    break;
                }
                else if (input == "2")
                {
                    DisplayOutro();
                    quit = true;
                }
                else
                {
                    Console.WriteLine("wrong input, try again");
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
                string makeChoice = ReadLine();
                if (makeChoice == "1")
                {
                    cart.AddToCart(foodMenu[1]);
                    quit = true;
                }
                else if (makeChoice == "2")
                {
                    cart.AddToCart(foodMenu[2]);
                    quit = true;
                }
                else if (makeChoice == "3")
                {
                    cart.AddToCart(foodMenu[3]);
                    quit = true;
                }
                else
                {
                    Console.WriteLine("wrong input, try again");
                }
            }
        }
        public void DisplayOutro()
        {
            Console.WriteLine("Thanks for stopping by!");
            ReadKey();
        }
    }
}

