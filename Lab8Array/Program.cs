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
            List<List<string>> studentInformation = new List<List<string>>()
            {
                (new List<string>() {"Billy Bob Thorton", "Lester Neigard", "Peggy Valone", "Steve Wizouski", "Mike Sullivan", "Alvin Collins", "Charlie Humpkins", "Delta Flyer", "Eugine Elward", "Frank Lloyde-Wright"}),
                (new List<string>() { "Washington DC", "Grand Rapids", "Portland", "Chicago", "Marquette", "the South Side", "the North Pole", "Whoville", "where you're from", "Holland"}),
                (new List<string>() {"Chewing bubblegum", "Taking names","cashing checks", "hopschotch","armed robery", "throwing rocks at trains","absolutely nothing", "running","looting","arsen"}),
                (new List<string>() {"Settlers of Catan", "Monopoly", "Betrayal at the House on the Hill", "Above and Below", "Life", "Dungeons and Dragons", "Near and Far", "Monster Hunter", "Mary Me Mister Darcy", "7 Wonders"}

                new List<string>() { "Billy Bob Thorton","Washington DC"," Chewing bubblegum", "Settlers of Catan"},
            new List<string>() { "Lester Neigard", "Grand Rapids", "Taking names", "Monopoly", },
            new List<string>() { "Peggy Valone", "Portland", "cashing checks", "Betrayal at the House on the Hill" },
            new List<string>() { "Steve Wizouski", "Chicago", "hopschotch", "Above and Below" },
            new List<string>() { "Mike Sullivan", "Marquette", "armed robery", "Life" },
            new List<string>() { "Alvin Collins", "the South Side","throwing rocks at trains", "Dungeons and Dragons" },
            new List<string>() { "Charlie Humpkins", "the North Pole", "absolutely nothing", "Near and Far" },
            new List<string>() { "Delta Flyer", "Whoville", "running", "Monster Hunter" },
            new List<string>() { "Eugine Elward", "where you're from", "looting", "Mary Me Mister Darcy" },
            new List<string>() { "Frank Lloyde-Wright", "Holland", "arsen", "7 Wonders" },
            };

            var studentNames = 

            Console.WriteLine("As the new teacher in school it is wise to learn up on who you'll be teaching.");

            
            Console.WriteLine("Would you like to learn about a student or add a student? (learn) (add)");
            if (Console.ReadLine() == "learn")
            {
                Console.WriteLine("Which student would you like to learn about? Enter a number between 1-10");
                int userInput = int.Parse(Console.ReadLine());
                int i = userInput - 1;
                var student = classmates[i];
                Console.WriteLine($"This is {student[0]}");
                Console.WriteLine("Would you like to know more about their hometown, talents, or boardgames? If yes please select type (hometown), (talents), or (boardgames).");
                var userChoice = Console.ReadLine();
                Console.ReadKey();

                if (userChoice == "hometown")
                {
                    Console.WriteLine($"{student[0]} is from {student[1]}");
                    Console.ReadKey();
                }
                else if (userChoice == "talents")
                {
                    Console.WriteLine($"{student[0]} is good at {student[2]}");
                }
                else if (userChoice == "boardgames")
                {
                    Console.WriteLine($"{student[0]} likes to play {student[3]}");
                }
                else
                {
                    Console.WriteLine($"That is not a valid input. That seems like something that {student[8]} would do.");
                }
            }
            else if(Console.ReadLine()=="add")
            {
             
            }
        }

        
    }
}
