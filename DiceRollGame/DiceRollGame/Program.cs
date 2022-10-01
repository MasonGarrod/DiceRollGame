using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Two Player Dice Game \\

            // Declare Variables \\
            string p1 = "";
            string p2 = "";
            int p1score = 0;
            int p2score = 0;
            int p1roll1 = 0;
            int p1roll2 = 0;
            int p2roll1 = 0;
            int p2roll2 = 0;

            // Enters names and validates \\
            Console.Write("Player 1, enter your name: ");
            p1 = Console.ReadLine();

            while (p1 == "")
            {
                Console.Write("Invalid, enter your name again player 1: ");
                p1 = Console.ReadLine();
            }

            Console.Write("Player 2, enter your name: ");
            p2 = Console.ReadLine();

            while (p2 == "")
            {
                Console.Write("Invalid, enter your name again player 2: ");
                p2 = Console.ReadLine();
            }

            // RNG \\
            Random rng = new Random();
     
            while (true) // im sorry it had to be done, there was no other way my program would work \\
            {
                // Player 1 Rolls Dice \\ 
                Console.WriteLine("Player 1, press any key to roll your first dice: ");
                Console.ReadKey();

                p1roll1 = rng.Next(1, 7);
                Console.WriteLine("You have rolled a: " + p1roll1);
                p1score = p1score + p1roll1;

                Console.WriteLine("Player 1, press any key to roll your second dice: ");
                Console.ReadKey();

                p1roll2 = rng.Next(1, 7);
                Console.WriteLine("You have rolled a: " + p1roll2);
                p1score = p1score + p1roll2;

                // Checks for a double \\
                if (p1roll1 == p1roll2)
                {
                    Console.WriteLine("You have rolled a double! Your total score is now double!");
                    p1score = p1score * 2;
                }

                Console.WriteLine("Player 1, your total score this round is: " + p1score);

                // Player 2 Rolls Dice \\
                Console.WriteLine("Player 2, press any key to roll your first dice: ");
                Console.ReadKey();

                p2roll1 = rng.Next(1, 7);
                Console.WriteLine("You have rolled a: " + p2roll1);
                p2score = p2score + p2roll1;

                Console.WriteLine("Player 2, press any key to roll your second dice: ");
                Console.ReadKey();

                p2roll2 = rng.Next(1, 7);
                Console.WriteLine("You have rolled a: " + p2roll2);
                p2score = p2score + p2roll2;

                // Checks for a double \\
                if (p2roll1 == p2roll2)
                {
                    Console.WriteLine("You have rolled a double! Your total score is now double!");
                    p2score = p2score * 2;
                }

                Console.WriteLine("Player 2, your total score this round is: " + p2score);

                // Decides who wins, score MUST be over 100 \\
                if (p1score >= 100)
                {
                    Console.WriteLine("Player 1 Wins! with a total score of: " + p1score + " Player 2 Loses! with a score of: " + p2score);
                    Console.ReadKey();
                    break;
                }

                if (p2score >= 100)
                {
                    Console.WriteLine("Player 2 Wins! with a total score of: " + p2score + " Player 1 Loses! with a score of: " + p1score);
                    Console.ReadKey();
                    break;
                }

            }

        }
    }
}
