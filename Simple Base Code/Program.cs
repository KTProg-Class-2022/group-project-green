using System;

namespace Simple_Base_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Class!");
            Mastermind mastermindgame = new Mastermind("ihateella");
            while(mastermindgame.completed == false)
            {
                Console.WriteLine("Enter a String of {0} characters", password.Length);
                string guess = Console.ReadLine();
                mastermindgame.guess(guess);
            }
        }
    }
}
