using System;
using System.Xml.Schema;

namespace GuessMyColor
{
    class Program
    {
        private static string userInput;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int compNum = rnd.Next(1, 4);
            bool Rightguess = false;

            while(Rightguess)
            {
                Console.WriteLine("what is my color?");
                string userInput;
                 Console.ReadLine().ToLower();
            }
            if (compNum == 1 && userInput == "red")
            {
                Console.WriteLine("you won");
                Rightguess = true;
            }
            else if (compNum == 2 && userInput = "green")
            {
                Console.WriteLine("you won");
                Rightguess = true;
            }
            else if (compNum == 3 && userInput == "blue") 
            {
                Console.WriteLine("you won");
                Rightguess = true;
            }







        }
    }
}
