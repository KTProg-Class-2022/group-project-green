using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    class Commands
    {
        //nick ge the ability for us to input commands from console working. That Is all Very Cool
        public Commands()
        {

        }

        public void addItem()
        {
            
         
            
        }
        public bool BosnianRoulette(Mastermind mastermind)
        {
            //Vaansh will work on this
            Random random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                Console.WriteLine("first three letters of mastermind password is :{0}, {1}, {2}", mastermind.password[0], mastermind.password[1], mastermind.password[2]);
                return true;
            }
            else
            {
                //if false it will be a death statement later
                Console.WriteLine("you died");
                return false;
            }


        }

        public void selectRoom()
        {
            //future command
        }
        Mastermind mastermind;
        //i just realized start mastermind should be in the  room object so ignore code
        /*public void StartMastermind(string password)
        {
            //bruno
            mastermind = new Mastermind(password);
            playMastermind(mastermind);


        }*/
        public bool playMastermind(Mastermind mastermind)
        {
            while (true)
            {
                Console.WriteLine("Take a guess of something {0} characters(-1 to exit mastermind)", mastermind.password.Length);
                string guess = Console.ReadLine();
                if(guess == "-1")
                {
                    return false;
                }
                else
                {
                    if (mastermind.guess(guess))
                    {
                        return true;
                    }
                }
            }
        }

    }
}
