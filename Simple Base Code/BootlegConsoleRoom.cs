using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{

    class BootlegConsoleRoom
    {
        int roomNum;
        bool Slowmode;
        public bool die = false;
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
            "Copy of inking 2 the game",
            "Red hat with L on it",
            "Picture of What if Zelda was a girl but its link as a girl",
            "A news article about weeknight come to a handheld console ",
            "N-Zapp",
            "A ten on the wall crossed out to nine",
            "Copy of Ballz",
            "Copy of mincraft",
            "Weird \"off brand\" Japanese manga",
            "Ps5 controller",
            "A bag of circus peanuts",
            "A clown costume",
            "What you think is mayonnaise",
            "A box with both packing peanuts and circus peanuts and the name is bosnian roulette"
        };


        public void seeItems()
        {
            for (int i = 0; i < items.Length; i++)
            {
                printSlowly(items[i]);
            }

        }

        public BootlegConsoleRoom(bool slowMode, bool[] roomsCompleted)
        {
            Slowmode = slowMode;
            printSlowly("You walk into the dining hall.");
            printSlowly("The dining hall is a big, bland room with a very long table lined with chairs.");
            printSlowly("In the middle of the room, though, is a gaming setup.");
            printSlowly("A big tube TV, a Dendy type console, some decorations and a filing cabinet with all several hundred Mario games, about ten being real.");
            printSlowly("The console is bolted down with an alphabetical locking device of sorts, the kind you might find in a puzzle game about words.");
            printSlowly("You get an idea to challenge your arch nemesis, Tim Bluehelmet, to a gaming tournament.");
            printSlowly("To be safe though, you'd need to cram in some practice.");
            printSlowly("The dining hall isn't open 24/7, so you'd need to get a Dendy for your own room.");
            printSlowly("Unfortunately, a Dendy can cost hundreds of cents.");
            printSlowly("If only you could, say, guess the word to unlock the Dendy and steal it for a night.");
            Mastermind mastermindgame = new Mastermind("ninninedo");
            bool finishedThis = false;
            while (!finishedThis && die == false)
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
                    case "bosnian-Roulette":
                        Random rnd = new Random();
                        int coinflip = rnd.Next(2);
                        if (coinflip == 1)
                        {
                            mastermindgame.getNext3Chars();
                        }
                        else
                        {
                            Console.WriteLine("wait that was a packing peanut");
                            Console.WriteLine("you died");
                            die = true;
                        }
                        break;

                    default:
                        if (mastermindgame.guess(input) == true)
                        {
                            finishedThis = true;
                        }
                        break;
                }
            }
            if (die == false)
            {
                printSlowly("Having successfully unlocked the console, you inconspicuously shove it into your back pocket and bring it up to your apartment.");
                printSlowly("You also drag the filing cabinet full of games with you, but conspicuously. For the rest of the day and into the following morning you game nonstop.");
                printSlowly("The next day, keeping yourself awake with suspicious energy drinks, you challenge Tim Bluehelmet to game at the dining hall, with his family and most of the city in attendance.");
                printSlowly("After he accepts and you start the game, you perfectly execute a cheat code and annihilate him completely. ");
                printSlowly("It is so very embarrassing, and the whole city, including his very own family, see how bad he is at Mario Super 13 and chase him out of the dining hall for how cringe it was. Great Success!");




                roomsCompleted[2] = true;
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
}
