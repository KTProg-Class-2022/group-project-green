using System;
using System.Collections.Generic;
using System.Text;


namespace Simple_Base_Code
{
    class Tutorial
    {
        public void TextForTutorial()
        {
            int roomNum;
            /* Nick first half */





            /*Ella second half*/

            Console.WriteLine("You stare at Nick as he is taken away in handcufs.");
            Console.WriteLine("The blue helmeted heads of those men haunt you as you walk behind them.");
            /* Code prompts user to enter the room*/
            Console.WriteLine("You swear that you will get revenge on the UN for crushing your dreams and going to Mars.");
            Console.WriteLine("While entering the room, you bump into a UN member. He apologizes quickly");
            Console.WriteLine("At this moment, you, Vaansh Mansharamani, decide that he is the one you will target.");
            Console.WriteLine("You read his name tag: Tim Bluehelmet");
            Console.WriteLine("After he leaves the room, you look around and see three doors.");
            Console.WriteLine("One door has a radio next to it.");
            Console.WriteLine("The second door has a sign in front that says Buy Crypto Here.");
            Console.WriteLine("The last door has an advertisement for a new gaming console.");
            Console.WriteLine("What door will you pick?");
            roomNum = int.Parse(Console.ReadLine());
            if(roomNum == 1)
            {
                Console.WriteLine("You enter the first room.");
            }
            else if(roomNum == 2)
            {
                Console.WriteLine("You enter the second room.");
            }
            else if(roomNum == 3)
            {
                Console.WriteLine("You enter the third room.");
            }
            else
            {
                Console.WriteLine("Invalid number. Try again.");
            }
        }

    }
}
