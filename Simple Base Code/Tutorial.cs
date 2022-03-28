using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Base_Code
{


    class Tutorial
    {
        int roomNum;
        bool Slowmode;
        Item nokia = new Item("Nokia Phone", "A Nokia Phone that is not even in production anymore.", 0, false);
        Item ransom = new Item("Ransomware Computer", "A computer that is infected with ransomware.", 0, false);
        Item printer = new Item("Printer", "A printer that broke a while ago.", 0, false);
        Item phoneBook = new Item("Phone Book", "A book that contains all of your most resent calls. Most are tech support angents.", 0, false);
        Item teaCup = new Item("Tea Cup", "A mysterious cup of tea. It could give good fortune to those who drink it.", 0, true);
        Item hair = new Item("Hair", "A strand of hair.", 0, true);
        Item spider = new Item("Spider", "A spider that has hid in the janitors cart. He stares at you with his big eyes", 0, true);
        Item eviction = new Item("Eviction Notice", "An eviction notice. You have been ignoring it since it was mailed to you.", 0, true);
        Item flashlight = new Item("Flashlight", "A flashlight. You remember using it recently.", 0, true);


        public void printSlowly(string String)
        {
            if (Slowmode)
            {
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                string stringy = "Press any key to continue";
                for (int i = 0; i < stringy.Length; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);


                for (int i = 0; i < String.Length; i++)
                {
                    Console.Write(String[i]);
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue");


                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(String);
            }
        }
        string[] items =
        {
            "Nokia Phone",
            "A massive spider on his janitors cart",
            "Computer infected with ransomware",
            "a broken phone",
            "strand of hair",
            "A book that stores all his previous calls and most of them are to tech support",
            "eviction notice",
            "A flashlight"
        };


        public void seeItems()
        {
            for (int i = 0; i < items.Length; i++)
            {
                printSlowly(items[i]);
            }

        }
        public Tutorial(bool slowmode)
        {
            Slowmode = slowmode;

            //int roomNum;
            Console.WriteLine();
            /* Nick first half */
            printSlowly("Your alarm has woken you up.");
            printSlowly("You, Vaansh Mansharamani, visiting the fair country of Bosnia, have recently ordered a Nuclear Missile off the black market.");
            printSlowly("(not for anything nefarious, just to fly you to mars)");
            printSlowly("Today, you are to meet your dealer, Nick, outside the apartment complex at which you are staying.");
            printSlowly("Unfortunately, the elevator has gone out (approx. 30 years ago) and your budget-friendly luxury penthouse is on the 50th floor.");
            printSlowly("Time to start down the stairs.\n");

            //When we have all the commands done and the mastermind finished we can add a rundown of the gameplay here
            //Console.WriteLine("insert guide here\n");

            printSlowly("After leaving your apartment, you find out a number of rapscallions have left small round objects,");
            printSlowly("such as pens and marbles, all over the stairs, making them dangerous to walk down.");
            printSlowly("You remember there's some sort of OSHA guideline about tripping hazards,");
            printSlowly("So you decide that the only way to safely make it down the stairs is to be OSHA certified.\n");
            printSlowly("As you look around for a spare OSHA certification card, you happen to spot the janitor in the Janitor Closet™.");
            printSlowly("The janitor locks up his one prized possession, an OSHA certification card, in a little chest and leaves.");
            printSlowly("He neglects to lock the door and appears to be too drunk or hungover to even notice you.");
            printSlowly("After he's out of sight, you start snooping around in the room.");

            //Start of first/tutorial puzzle


            Mastermind mastermindgame = new Mastermind("password");
            bool finishedThis = false;
            while (!finishedThis)
            {
                Console.WriteLine("Enter a command or Guess a word help to see commands");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "help":
                        Console.WriteLine("mastermind-length : sees how many characters the mastermind game is");
                        Console.WriteLine("check-items : get list of items");
                        break;
                    case "mastermind-length":
                        Console.WriteLine("{0}", mastermindgame.getLength());
                        break;
                    case "check-items":
                        seeItems();
                        break;

                    default:
                        if (mastermindgame.guess(input) == true)
                        {
                            finishedThis = true;
                        }
                        break;
                }
            }



            /*Ella second half*/

            printSlowly("You stare at Nick as he is taken away in handcufs.");
            printSlowly("The blue helmeted heads of those men haunt you as you walk behind them.");
            /* Code prompts user to enter the room*/
            printSlowly("You swear that you will get revenge on the UN for crushing your dreams and going to Mars.");
            printSlowly("While entering the room, you bump into a UN member. He apologizes quickly");
            printSlowly("At this moment, you, Vaansh Mansharamani, decide that he is the one you will target.");
            printSlowly("You read his name tag: Tim Bluehelmet");
            printSlowly("After he leaves the room, you look around and see three doors.");
            printSlowly("One door has a radio next to it.");
            printSlowly("The second door has a sign in front that says Buy Crypto Here.");
            printSlowly("The last door has an advertisement for a new gaming console.");
            printSlowly("What door will you pick?");

            bool bad = true;
            while (bad)
            {
                if (Int32.TryParse(Console.ReadLine(), out roomNum))
                {
                    if (roomNum == 1)
                    {
                        printSlowly("You enter the first room.");
                        bad = false;
                    }
                    else if (roomNum == 2)
                    {
                        printSlowly("You enter the second room.");
                        bad = false;
                    }
                    else if (roomNum == 3)
                    {
                        printSlowly("You enter the third room.");
                        bad = false;
                    }
                    else
                    {
                        printSlowly("Invalid number. Try again.");
                        bad = true;
                    }
                }
            }
        }
        public int getNextRoom()
        {
            return roomNum;
        }

    }
}