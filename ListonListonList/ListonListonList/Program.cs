using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListonListonList
{
    class Program
    {
        public static string stringAdded;
        public static string choice;
        public static string search;
        public static List<string> listOfLists = new List<string> { "Gargamel", "Big Easy", "Piezoelectricity", "Mother of Witches", "Big Mood", "Chandler from Friends" };
        public static List<string> sublist = new List<string>();
        static void Main()
        {
            mainMenu();
        }
        static void mainMenu()//adds options to access all other methods
        {
            Console.Write("\nWelcome to the List on List Main Menu." +
                "\nPlease enter a number corresponding to the following options:" +
                "\n1): View all items in list" +
                "\n2): Search list for value" +
                "\n3): Sort list by alphabetical order" +
                "\n4): Add item to list" +
                "\n5): Exit terminal" +
                "\nEnter choice: ");
            int choice;
            choice = mainMenuChecker(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    listViewer();
                    break;
                case 2:
                    listSearch();
                    break;
                case 3:
                    listSorter();
                    break;
                case 4:
                    listAdder();
                    break;
                case 5:
                    Console.WriteLine("\nGoodbye");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        public static int mainMenuChecker(string choice)
        {
            int num;
            bool parse = int.TryParse(choice, out num);
            while (!parse || num < 1 || num > 5)
            {
                    Console.WriteLine("Invalid choice. Please enter a number 1 - 5.");
                    choice = Console.ReadLine();
                    parse = int.TryParse(choice, out num);
            }
            return num;
        }//verifies choice made for main menu
        static void listAdder()
        {
            Console.Write("\nPlease enter a new value to be added to the list: ");
            stringAdded = "";
            choice = "";
            stringAdded = Console.ReadLine();
            listOfLists.Add(stringAdded);
            Console.Write($"\nAdding {stringAdded} to list . . . " +
                $"\n\nWould you like to add another item to the list? (y/n)");
            choice = yesNoChecker(Console.ReadLine());
            if (choice == "y")
            {
                listAdder();
            }
            else if (choice == "n")
            { 
                    Console.WriteLine("\nReturning to main menu . . .\n");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    mainMenu();
            }
        }
        public static string yesNoChecker(string choice) //validates the many y/n decisions in this program
        {
            while (choice != "y" || choice != "n")
            {
                Console.WriteLine("Invalid choice. Please enter \"y\" for yes or \"n\" for no.");
                choice = Console.ReadLine();
            }
            return choice;
        }
        static void listSearch()
        {
            Console.Write("Please enter a value to search by: ");
            search = "";
            search = Console.ReadLine();
            sublist.Clear();
            foreach(string word in listOfLists)
            {
                if(word.Contains(search))
                {
                    sublist.Add(word);
                }
            }
            if (sublist.Count == 0)
            {
                Console.WriteLine("\nNo matches found.");
            }
            else
            {
                foreach (string word in sublist)
                {
                    Console.WriteLine($"\"{word}\"");
                }
            }
            Console.Write("Would you like to add another item to the list? (y/n)");
            choice = "";
            choice = yesNoChecker(Console.ReadLine());
            if (choice == "y")
            {
                listSearch();
            }
            else if (choice == "n")
            {
                Console.WriteLine("\nReturning to main menu . . .\n");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                mainMenu();
            }
        }
        static void listSorter()
        {
            Console.WriteLine("Preparing to sort list");
            System.Threading.Thread.Sleep(500);
            Console.Write(". ");
            System.Threading.Thread.Sleep(500);
            Console.Write(". ");
            System.Threading.Thread.Sleep(500);
            Console.Write(". ");
            System.Threading.Thread.Sleep(500);
            listOfLists.Sort();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nList sorted.");
            Console.WriteLine("\nReturning to main menu . . .\n");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
            mainMenu();
        }
        static void listViewer()
        {
            Console.WriteLine("\nDisplaying current items in list");
            System.Threading.Thread.Sleep(500);
            Console.Write(". ");
            System.Threading.Thread.Sleep(500);
            Console.Write(". ");
            System.Threading.Thread.Sleep(500);
            Console.Write(". \n");
            System.Threading.Thread.Sleep(500);
            int i = 0;
            foreach(string word in listOfLists)
            {
                i++;
                Console.WriteLine($"{i}. {word}");
            }
            Console.WriteLine($"\nThere are currently {listOfLists.Count} items in the list.");
            Console.WriteLine("\nPress any key to return to the Main Menu");
            Console.ReadKey();
            Console.Clear();
            mainMenu();
        }
    }
}
