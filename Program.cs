using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labnum8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Kendra", "Justin", "Evan", "Mauricio", "Kent", "Karrar", "Jackie", "Rudy", "Levi", "Steve", "Ronald", "Stephen", "Laura", "Brian", "Noha", "Tommy", "Anna" };
            string[] Hometown = { "West bloomfield", "Southwest detroit", "Waterville", "Royal oak", "Redford", "Livonia", "Down river", "Downtown ", "Upstate Newyork", "Ann arbor", "Grand canyon", "North korea", "Yellow stone", "Maui" };
            string[] FavFood = { "Pizza", "Hamburgers", "Mac & Cheese", "Chicken", "Salad", "Steak", "Salmon", "Hot Dogs", "Lobster", "Tacos", "Spaghetti", "Shawarma", "Lasagna", "French Fries", "Chocolate Ice Cream" };

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?(Enter a number 1-20):");

            int nameInput;
            while (!int.TryParse(Console.ReadLine(), out nameInput) || nameInput < 1 || nameInput > 15)
            {
                Console.WriteLine("Invalid input. Please enter number between 1 and 15.");
            }
            bool UserContinue = true;
            while (UserContinue)
            {
                Console.WriteLine("Student " + nameInput + " is " + Names[nameInput - 1] + ". What would you like to know about " + Names[nameInput - 1] + "? (enter \"Hometown\" or \"Favorite Food\")");
                string choice1 = Console.ReadLine();
                if (choice1.ToLower().Contains("hometown"))
                {
                    Console.WriteLine(Hometown[nameInput - 1]);
                    UserContinue = false;
                }
                else if (choice1.ToLower().Contains("favorite food"))
                {
                    Console.WriteLine(FavFood[nameInput - 1]);
                    UserContinue = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }
    }
}