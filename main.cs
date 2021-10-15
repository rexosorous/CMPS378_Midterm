using System;

/*
Author: J-Zach Loke
Class: CMPS-378
Due Date: 10/14/2021
Description:
    Mimicks a POS system for the Rigby Restaurant by gathering orders and calculating the bill's total on a per-party basis.
*/

namespace Midterm
{
    class MainClass
    {
        static void getOrder(string question, ref char[] orders)
        {
            /* Gets orders from the user

            Args:
                question (string): the question to print and prompt the user for input
                orders (ref char[]): the array to append responses to

            Note:
                Resizes the orders array to fit the new order
            */
            Console.Write(question);
            char response = Convert.ToChar(Console.ReadLine());
            Array.Resize(ref orders, orders.Length+1);
            orders[orders.Length-1] = response;
        }

        /* The root / driver of the program */
        static void Main(string[] args)
        {
            // declare variables
            char[] orders = new char[0];

            // print menu
            Console.WriteLine("Welcome to Rigby Restaurant");
            Console.WriteLine("----------------------Food----------------------");
            Console.WriteLine("Pizza\tChicken\tSpaghetti");
            Console.WriteLine("$20\t$15\t$25\n");
            Console.WriteLine("----------------------Drinks----------------------");
            Console.WriteLine("Sprite\tCoke\tMountain Dew");
            Console.WriteLine("$5\t$4\t$3\n");
            Console.WriteLine("----------------------Desserts----------------------");
            Console.WriteLine("Ice Cream\tPie\tCinnamon Roll");
            Console.WriteLine("$10\t\t$12\t$8\n");

            // take orders
            while (true) {
                getOrder("Choose your Food ", ref orders);
                getOrder("Choose your Drink ", ref orders);
                getOrder("Do you want Desserts? ", ref orders);
                if (orders[orders.Length-1]  == 'Y') {
                    getOrder("Choose your Dessert ", ref orders);
                }

                Console.Write("Another Order? ");
                char cont = Convert.ToChar(Console.ReadLine());
                if (cont == 'N') break;
                else Console.WriteLine('\n');
            }

            // print bill
            int total = 0;
            Console.WriteLine("\n\nYour order was:");
            for (int i = 0; i < orders.Length; ++i) {
                switch (orders[i]) {
                    case 'P':   // pizza
                        Console.WriteLine("Pizza for $20");
                        total += 20;
                        break;
                    case 'C':   // chicken
                        Console.WriteLine("Chicken for $15");
                        total += 15;
                        break;
                    case 'S':   // spaghetti
                        Console.WriteLine("Spaghetti for $25");
                        total += 25;
                        break;
                }
                switch (orders[++i]) {
                    case 'S':   // sprite
                        Console.WriteLine("Sprite for $5");
                        total += 5;
                        break;
                    case 'C':   // coke
                        Console.WriteLine("Coke for $4");
                        total += 4;
                        break;
                    case 'M':   // mountain dew
                        Console.WriteLine("Mountain Dew for $3");
                        total += 3;
                        break;
                }
                if (orders[++i] == 'Y') {
                    switch (orders[++i]) {
                        case 'I':   // ice cream
                            Console.WriteLine("Ice Cream for $10");
                            total += 10;
                            break;
                        case 'P':   // pie
                            Console.WriteLine("Pie for $12");
                            total += 12;
                            break;
                        case 'C':   // cinnamon roll
                            Console.WriteLine("Cinnamon Roll for $8");
                            total += 8;
                            break;
                    }
                }
            }
            Console.WriteLine($"Your total is ${total}");


            // geenerate random fortune cookie quote
            string[] COOKIE_QUOTES = {
                "The early bird gets the worm, but the second mouse gets the cheese.",
                "Be on the alert to recognize your prime at whatever time of your life it may occur.",
                "Your road to glory will be rocky, but fulfilling.",
                "Courage is not simply one of the virtues, but the form of every virtue at the testing point.",
                "Patience is your ally at the moment. Don't worry!",
                "Nothing is impossible to a willing heart.",
                "Don't worry about money. The best things in life are free.",
                "Don't pursue happiness - create it.",
                "Courage is not the absence of fear; it is the conquest of it.",
                "Nothing is so much to be feared as fear."
            };

            Random rng = new Random();
            int cookie = rng.Next(0, 9);
            Console.WriteLine($"\nNow, your fortune cookie quote is \"{COOKIE_QUOTES[cookie]}\"");

            Console.WriteLine("\nThanks for dining with us.");
            Console.ReadKey();
        }
    }
}