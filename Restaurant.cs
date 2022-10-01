using System;

namespace Onlinerestaurang
{
    class Restaurant
    {


        Menu[] foodMenu = new Menu[3];

        public Restaurant()
        {
            Menu menus1 = new Menu("Hamburgertallrik med dricka \t Pris: ", 89);
            Menu menus2 = new Menu("Pizza med dricka \t Pris: ", 99);
            Menu menus3 = new Menu("Kebabtallrik med dricka  \t Pris: ", 95);

            foodMenu[0] = menus1;
            foodMenu[1] = menus2;
            foodMenu[2] = menus3;
        }


        public void Greetings()
        {
            bool quit = false;

            while (quit == false)
            {
                Console.WriteLine("Hello, Make a choice:");
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
            for (int i = 0; i < foodMenu.Length; i++)
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
                if (makeChoice == "0")
                {
                    Console.WriteLine("you added menu 0");
                    quit = true;
                }
                else if (makeChoice == "1")
                {
                    Console.WriteLine("you added menu 1");
                    quit = true;
                }
                else if (makeChoice == "2")
                {
                    Console.WriteLine("you added menu nr 2");
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
