using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(4);

            Console.WriteLine("Rock, paper or scissors?");
            string userChoice = Console.ReadLine();

            if (randomNumber == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("It is a tie.");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("It is a tie.");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("It is a tie.");
                }
                else
                {
                    Console.WriteLine("You must choose rock, paper or scissors!");

                }

            }

            else if (randomNumber == 2)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("Sorry you lose, paper beats rock.");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("Sorry you lose, scissors beats paper.");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("Sorry you lose, rock beats scissors.");
                }
                else
                {
                    Console.WriteLine("You must choose rock, paper or scissors!");
                }
            }
            else if (randomNumber == 3)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("You win, rock beats scissors.");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("You win, paper beats rock.");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("You win, scissors beats paper.");

                }
                else
                {
                    Console.WriteLine("You must choose rock, paper or scissors!");

                }

            }

            Console.ReadLine();
        }
    }
}
