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
            
            
            List <string> studentNames = new List<string> {"Billy Bob Thorton", "Lester Neigard", "Peggy Valone", "Steve Wizouski", "Mike Sullivan", "Alvin Collins", "Charlie Humpkins", "Delta Flyer", "Eugine Elward", "Frank Lloyde-Wright"};
            List<string> studentCities = new List<string> { "Washington DC", "Grand Rapids", "Portland", "Chicago", "Marquette", "the South Side", "the North Pole", "Whoville", "where you're from", "Holland" };
            List<string> studentTalents = new List<string> { "Chewing bubblegum", "Taking names", "cashing checks", "hopschotch", "armed robery", "throwing rocks at trains", "absolutely nothing", "running", "looting", "arsen" };
            List<string> studentGames = new List<string> { "Settlers of Catan", "Monopoly", "Betrayal at the House on the Hill", "Above and Below", "Life", "Dungeons and Dragons", "Near and Far", "Monster Hunter", "Mary Me Mister Darcy", "7 Wonders" };

            

            

            Console.WriteLine("As the new teacher in school it is wise to learn up on who you'll be teaching.");

            bool repeat= true;
            do
            {
                Console.WriteLine("Would you like to learn about a student or add a student? (learn) (add)");
                var learnOrAdd = Console.ReadLine();
                if (learnOrAdd == "learn")
                {
                    int userEntry = ValidateUserEntry();
                    int validatedUserEntry = --userEntry;

                    Console.WriteLine($"You have selected {studentNames[validatedUserEntry]}.");
                    Console.WriteLine("Would you like to know more about their hometown, talents, or boardgames? If yes please select type (hometown), (talents), or (boardgames).");
                    var userChoice = Console.ReadLine();
                    Console.ReadKey();

                    if (userChoice == "hometown")
                    {
                        Console.WriteLine($"{studentNames[validatedUserEntry]} is from {studentCities[validatedUserEntry]}");
                        Console.ReadKey();
                    }
                    else if (userChoice == "talents")
                    {
                        Console.WriteLine($"{studentNames[validatedUserEntry]} is good at {studentTalents[validatedUserEntry]}");
                    }
                    else if (userChoice == "boardgames")
                    {
                        Console.WriteLine($"{studentNames[validatedUserEntry]} likes to play {studentGames[validatedUserEntry]}");
                    }
                    else
                    {
                        Console.WriteLine($"That is not a valid input. That seems like something that {studentNames[8]} would do.");
                    }
                }
                else if (learnOrAdd == "add")
                {
                    
                    
                        Console.WriteLine("What is the name of the new student?");
                        studentNames.Add(Console.ReadLine());
                        Console.WriteLine($"Where are they from?");
                        studentCities.Add(Console.ReadLine());
                        Console.WriteLine("That sounds pretty cool. What are they good at?");
                        studentTalents.Add(Console.ReadLine());
                        Console.WriteLine("Oh fun! What is their favorite boardgame?");
                        studentGames.Add(Console.ReadLine());
                    
                }
                repeat = DoAgain(repeat);
            } while (repeat == true);
        }

        private static bool DoAgain(bool repeat)
        {
            Console.WriteLine("Would you like to learn more or add another student? (y/n)");
            var doAgain = Console.ReadLine().ToLower();
            if (doAgain == "y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Thank you.");
                return false;
            }
        }

        private static int ValidateUserEntry()
        {
            Console.WriteLine("Which student would you like to learn about? Enter a number between 1-10");
            int userInput = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (userInput > 0 && userInput < 10)
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 10.");
                    return ValidateUserEntry();
                }
            }
            catch  (IndexOutOfRangeException) 
            {
                Console.WriteLine("That is not a valid number");
                return ValidateUserEntry();
            }
        }
    }
}
