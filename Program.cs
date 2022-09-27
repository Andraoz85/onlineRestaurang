using System;

namespace Onlinerestaurang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin Admin = new Admin("Napoli", "Kungsgatan 1", "08-262626");

            Customer David = new Customer("David", "Högerkrogen 18", "076 243 55 65", "david@hotmail.com");
            Customer Andy = new Customer("Andy", "Fiskgatan 18", "031 55 55 33", "andy@hotmail.com");
            Customer Anders = new Customer("Anders", "skolgatan 5", "08 44 32 22", "anders@hotmail.com");

            Menu menu1 = new Menu("a: Hamburgertallrik med dricka ", 89);
            Menu menu2 = new Menu("b: Pizza med dricka ", 99);
            Menu menu3 = new Menu("c: Kebabtallrik med dricka ", 109);

            Cart cart = new Cart("", 0);

            Console.WriteLine("Welcome to " + Admin.RestaurantName());
            Console.WriteLine("Type 'C' if you are a customer, A if you are Admin");
            string input1 = Console.ReadLine();

            while (input1 != "c" && input1 != "C" && input1 != "a" && input1 != "A")
            {
                Console.WriteLine("wrong input, try agin");
                input1 = Console.ReadLine();

                if (input1 == "c" || input1 == "C")
                {
                    Console.WriteLine("Here is the menu for today:\n" + menu1.ShowMenu() + "\n" + menu2.ShowMenu() + "\n" + menu3.ShowMenu());
                    Console.WriteLine("Chose menu: ");
                    string chooseMenu = Console.ReadLine();
                    while (chooseMenu != "a" && chooseMenu != "b" && chooseMenu != "c")
                    {
                        Console.WriteLine("wrong input, try agin");
                        chooseMenu = Console.ReadLine();
                    }
                    if (chooseMenu == "a")
                    {
                        cart.addToCart(menu1.GetFoodType(), menu1.GetFoodPrice());
                        Console.WriteLine("you added menu " + menu1.GetFoodType() + "to the cart");
                        break;

                    }
                    else if (chooseMenu == "b")
                    {
                        cart.addToCart(menu2.GetFoodType(), menu2.GetFoodPrice());
                        Console.WriteLine("you added menu " + menu2.GetFoodType() + "to the cart");
                        break;

                    }
                    else
                    {
                        cart.addToCart(menu3.GetFoodType(), menu3.GetFoodPrice());
                        Console.WriteLine("you added menu " + menu3.GetFoodType() + "to the cart");
                        break;
                    }
                }
                /*if (input1 == "A" || input1 == "a")
                {
                    Console.WriteLine("Hello Admin");
                }
                else if
                {
                    Console.WriteLine("wrong input");
                }
                Console.ReadLine();*/
            }
            Console.WriteLine("Please login and proceed to payment");
            Console.WriteLine("Username: ");
            string userName = Console.ReadLine();
            while (userName != "David" && userName != "Andy" && userName != "Anders")
            {
                Console.WriteLine("Wrong Username. Please try again :");
                userName = Console.ReadLine();
            }
            while (userName == "David" || userName == "Andy" || userName == "Anders")
            {
                Console.WriteLine("Password: ");
                string userPass = Console.ReadLine();


                if (userName == "David" && userPass == "David")
                {
                    Console.WriteLine("Hello " + David.ShowInfo());
                    break;
                }
                else if (userName == "Andy" && userPass == "Andy")
                {
                    Console.WriteLine("Hello " + Andy.ShowInfo());
                    break;
                }
                else if (userName == "Anders" && userPass == "Anders")
                {
                    Console.WriteLine("Hello " + Anders.ShowInfo());
                    break;
                }
                else
                {
                    Console.WriteLine("You typed in wrong password, please try again");
                }


            }

            Console.ReadLine();

        }

    }


}



