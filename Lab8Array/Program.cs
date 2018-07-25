using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Lab8Array
{
    class Program
    {
        private static List <string> _classmates;
        private static string[] _hometown;
        private static string [] _talents;
        static void Main(string[] args)
        {
            
            _classmates[0] = "Billy Bob Thorton";
            _classmates[1] = "Lester Neigard";
            _classmates[2] = "Peggy Valone";
            _classmates[3] = "Steve Wizouski";
            _classmates[4] = "Mike Sullivan";
            _classmates[5] = "Alvin Collins";
            _classmates[6] = "Charlie Humpkins";
            _classmates[7] = "Delta Flyer";
            _classmates[8] = "Eugine Elward";
            _classmates[9] = "Frank Lloyde-Wright";
        

            _hometown = new string[] { "Washington DC", "Grand Rapids", "Portland", "Chicago", "Marquette", "the South Side", "the North Pole", "Whoville", "where you're from", "Holland" };
            _talents = new string[] { "chewing bublegum", "taking names", "chashing checks", "hopscotch", "armed robery", "playing hooky","throwing rocks at trains","absolutely nothing","running", "looting"};

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
