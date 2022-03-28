﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    class BitcoinRoom
    {
        int roomNum;
        bool Slowmode;
        public int getNextRoom()
        {
            return roomNum;
        }
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
            "A bitcoin pillow",
            "To the moon poster",
            "Doge plushies",
            "A diamond shaped mirror",
            "A number 2 varsity jacket"
        };


        public void seeItems()
        {
            for (int i = 0; i < items.Length; i++)
            {
                printSlowly(items[i]);
            }

        }
        public BitcoinRoom(bool slowMode, bool[] roomsCompleted)
        {
            Slowmode = slowMode;

            printSlowly("When you enter the room, you see a ton of different items. ");
            printSlowly("You notice a desk at the end of the room with a brass cash register.");
            printSlowly("You think to yourself that this is, or was, a store. ");
            printSlowly("You look around and find a golden woopie coushion");
            printSlowly("You think to yourself this would be a perfect item to get revenge");
            printSlowly("Your then look at the price tag and find out it costs ten dollars and you only have one cent");
            printSlowly("You then find a small computer");
            printSlowly("You log on to the computer and find time BlueHemet previously logged on to twitter, however all you need is the password");
            printSlowly("You as a previous programming student from keefe tech know how to hack into the twitter account so you start the attempt");
            Mastermind mastermindgame = new Mastermind("ethereum");
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
            printSlowly("You log in ");
            printSlowly("You then build your own cryptocurrency and call it slobbycoin");
            printSlowly("you advertise slobby coin on Tims Twitter Account");
            printSlowly("The price skyrockets and you become a billionare, you sell all your coin, and the next day the economy crashes");
            printSlowly("This makes tim bluehelmet look cringe since it looks like he scamed millions of people including un members");
            printSlowly("You now have enough to buy the woopie cushion as the economy crashing makes the cushion cost 1 cent, and you are a billionare, Great success!");




            roomsCompleted[1] = true;
            if (!((roomsCompleted[1] == true && roomsCompleted[0] == true) && roomsCompleted[2] == true))
            {
                printSlowly("You head back to where you originally saw tim bluehelmet, you look around and see three doors.");
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
                            if (roomsCompleted[0] == true)
                            {
                                printSlowly("you were blocked by a security guard, while drake seems to know you they do not choose a different door");
                                bad = true;
                            }
                            else
                            {
                                roomNum = 1;
                                printSlowly("You enter the first room.");
                                bad = false;
                            }
                        }
                        else if (roomNum == 2)
                        {
                            if (roomsCompleted[1] == true)
                            {
                                printSlowly("The door is blocked by a firewall, choose a different room");
                                bad = true;
                            }
                            else
                            {
                                printSlowly("You enter the second room.");
                                roomNum = 2;
                                bad = false;
                            }
                        }
                        else if (roomNum == 3)
                        {
                            if (roomsCompleted[2] == true)
                            {
                                printSlowly("Due to the use of a bootleg console the police have arrived and are blocking your path, choose a different room");
                                bad = true;
                            }
                            else
                            {
                                printSlowly("You enter the second room.");
                                roomNum = 3;
                                bad = false;
                            }
                        }
                        else
                        {
                            printSlowly("Invalid number. Try again.");
                            bad = true;
                        }
                    }
                }
            }
            else
            {
                roomNum = 0;
            }











        }
    }
}
