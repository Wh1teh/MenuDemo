using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDemoClassLibrary
{
    public class RestaurantMenuFunctions
    {


        static public bool GetYesOrNoFromUser(string question=null)
        {
            bool success = false;
            while (!success)
            {
                if (question != null)
                {
                    Console.WriteLine(question);
                }

                ConsoleKey consoleKey = Console.ReadKey().Key;
                
                if (consoleKey == ConsoleKey.Y)
                {
                    return true;
                }
                if (consoleKey == ConsoleKey.N)
                {
                    return false;
                }
            }
            return false;
        }


        public static int AskIDFromUser() //asks for ID from user , todo: check for wrong inputs
        {
            Console.Write("Give ID: "); var userGivenID = int.Parse(Console.ReadLine());

            return userGivenID;
        }

        //private Restaurant ShowActiveRestaurant()
        //{
        //    return activeRestaurant;
        //}

        public void StartMainMenu()
        {
            bool showMenu = true;

            var rdh = new RestaurantDataHandler();

            rdh.InitTestData();

            while (showMenu)
            {
                Console.Clear();
                string str = "\n--------- Menu Demo ----------";
                str += "\n1. Add new restaurant";
                str += "\n2. Choose restaurant";
                str += "\n3. ";
                str += "\n4. ";
                str += "\n0. Exit";
                str += "\n9. debug: print everything";

                str += "\n\nChoose option";
                Console.WriteLine(str);
                ConsoleKey selectedOption = Console.ReadKey(true).Key;

                switch (selectedOption)
                {
                    case ConsoleKey.D1:
                        rdh.AddNewRestaurant();
                        Console.Write("\n\n\nPress any key to continue..."); Console.ReadKey();
                        break;

                    case ConsoleKey.D0:
                        showMenu = false;
                        break;

                    case ConsoleKey.D9:
                        rdh.TestPrintEveryRestaurant();
                        Console.Write("\n\n\nPress any key to continue..."); Console.ReadKey();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
