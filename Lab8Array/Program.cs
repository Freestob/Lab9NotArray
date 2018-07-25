using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Console;


namespace Lab8Array
{
    class Program
    {
        
         
        static void Main(string[] args)
        {
            List<List<string>> _classmates = new List<List<string>>()
            {
            new List<string>() { "Billy Bob Thorton","Washington DC"," Chewing bubblegum", "Settlers of Catan"},
            new List<string>() { "Lester Neigard", "Grand Rapids", "Taking names", "Monopoly" },
            new List<string>() { "Peggy Valone", "Portland", "cashing checks", "Betrayal at the House on the Hill" },
            new List<string>() { "Steve Wizouski", "Chicago", "hopschotch", "Above and Below" },
            new List<string>() { "Mike Sullivan", "Marquette", "armed robery", "Life" },
            new List<string>() { "Alvin Collins", "the South Side","throwing rocks at trains", "Dungeons and Dragons" },
            new List<string>() { "Charlie Humpkins", "the North Pole", "absolutely nothing", "Near and Far" },
            new List<string>() { "Delta Flyer", "Whoville", "running", "Monster Hunter" },
            new List<string>() { "Eugine Elward", "where you're from", "looting", "Mary Me Mister Darcy" },
            new List<string>() { "Frank Lloyde-Wright", "Holland", "arsen", "7 Wonders" },
        };
           
            

            Console.WriteLine("As the new teacher in school it is wise to learn up on who you'll be teaching.");
            Console.WriteLine("Which student do you want to learn about? Enter a number 1-20");

            int userInput = int.Parse(Console.ReadLine());
            int i = userInput - 1;
            Console.WriteLine("This is " + _classmates[i]);
            Console.WriteLine("Would you like to know more about their hometown or talents? If yes please select type hometown or talents.");
            var userChoice = Console.ReadLine();



            if (userChoice == "hometown")
            {
                Console.WriteLine(_classmates[i] + " is from " + _hometown[i]);
                Console.WriteLine("Would you like to know about their talents? (y/n)");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine(_classmates[i] + " is good at " + _talents[i]);
                    Console.ReadKey();
                    return;
                }
            }
            else if (userChoice == "talents")
            {
                Console.WriteLine(_classmates[i] + "is good at " + _talents[i]);
                Console.WriteLine("Would you like to know about their hometown? (y/n)");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine(_classmates[i] + " is from " + _hometown[i]);
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("That is not a valid answer");
            }
        }
    }
}
