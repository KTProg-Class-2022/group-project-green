using System;
using System.Collections.Generic;
using System.Text;


namespace Simple_Base_Code
{
    class Tutorial
    {
        public Tutorial()
        {

            /* Room Turotial */
            Item nokia = new Item("Nokia Phone", "A Nokia Phone that is not even in production anymore.", 0, false);
            Item ransom = new Item("Ransomware Computer", "A computer that is infected with ransomware.", 0, false);
            Item printer = new Item("Printer", "A printer that broke a while ago.", 0, false);
            Item phoneBook = new Item("Phone Book", "A book that contains all of your most resent calls. Most are tech support angents.", 0, false);
            Item teaCup = new Item("Tea Cup", "A mysterious cup of tea. It could give good fortune to those who drink it.", 0, true);
            Item hair = new Item("Hair", "A strand of hair.", 0, true);
            Item spider = new Item("Spider", "A spider that has hid in the janitors cart. He stares at you with his big eyes", 0, true);
            Item eviction = new Item("Eviction Notice", "An eviction notice. You have been ignoring it since it was mailed to you.", 0, true);
            Item flashlight = new Item("Flashlight", "A flashlight. You remember using it recently.", 0, true);

            int roomNum;

            /* Nick first half */
            Console.WriteLine("Your alarm has woken you up.");
            Console.WriteLine("You, Vaansh Mansharamani, visiting the fair country of Bosnia, have recently ordered a Nuclear Missile off the black market.");
            Console.WriteLine("(not for anything nefarious, just to fly you to mars)");
            Console.WriteLine("Today, you are to meet your dealer, Nick, outside the apartment complex at which you are staying.");
            Console.WriteLine("Unfortunately, the elevator has gone out (approx. 30 years ago) and your budget-friendly luxury penthouse is on the 50th floor.");
            Console.WriteLine("Time to start down the stairs.\n");

            //When we have all the commands done and the mastermind finished we can add a rundown of the gameplay here
            //Console.WriteLine("insert guide here\n");

            Console.WriteLine("After leaving your apartment, you find out a number of rapscallions have left small round objects,");
            Console.WriteLine("such as pens and marbles, all over the stairs, making them dangerous to walk down.");
            Console.WriteLine("You remember there's some sort of OSHA guideline about tripping hazards,");
            Console.WriteLine("So you decide that the only way to safely make it down the stairs is to be OSHA certified.\n");
            Console.WriteLine("As you look around for a spare OSHA certification card, you happen to spot the janitor in the Janitor Closet™.");
            Console.WriteLine("The janitor locks up his one prized possession, an OSHA certification card, in a little chest and leaves.");
            Console.WriteLine("He neglects to lock the door and appears to be too drunk or hungover to even notice you.");
            Console.WriteLine("After he's out of sight, you start snooping around in the room.");

            //Start of first/tutorial puzzle


            Mastermind mastermindgame = new Mastermind("Tutorial");

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