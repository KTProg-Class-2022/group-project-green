using System;

namespace Simple_Base_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Class!");
            Mastermind mastermindgame = new Mastermind("coolio");
            while(mastermindgame.completed == false)
            {
                string guess = Console.ReadLine();
                mastermindgame.guess(guess);
            }
        }
    }
}
