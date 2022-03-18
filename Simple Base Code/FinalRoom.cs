using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    class FinalRoom
    {
        bool Slowmode;
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
        public FinalRoom(bool slowMode)
        {
            Slowmode = slowMode;
            string[] lines = System.IO.File.ReadAllLines("../../../../engmix.txt");
            Random rand = new Random();
            int index = rand.Next(lines.Length);
            printSlowly("Tim Bluehelmet has had enough!");
            printSlowly("All these embarrassing pranks have led him nearly to ruination.");
            printSlowly("He runs back to the UN Home Base in Bosnia like a baby or something to escape all these ruthless pranks.");
            printSlowly("Seeing this, a mysterious figure (not drake) approaches you.");
            printSlowly("\tSlobby John: I see you also are a pranker of the UN, nice work.");
            printSlowly("\tI have a favor to ask of you, fellow prankster, whatever your name is.");
            printSlowly("\tTake this jar of Slobby John's Magic Juice (Patent Pending) and pour it into the UN building's central air conditioner.");
            printSlowly("\tPretty please with a cherry on top.");
            printSlowly("This \"Slobby John\" guy hands you a small jam jar full of what looks to be orange juice with a box of laxatives (including the cardboard box) floating in it. ");
            printSlowly("Since you don't really have any other plans, what with the rocket being unavailable and all that, you decide to actually do what he just said.");
            printSlowly("You make your way into the UN's Home Base with the jar of magic juice carefully hidden (by holding it behind your back).");
            printSlowly("Sneaking loudly into the Air Conditioning room, you discover the central air conditioner is locked with, shockingly, a big word padlock.");
            printSlowly("Unfortunately, there are no clues to be found in this room, being completely empty aside from the air conditioner. You will have to totally guess this word.");


            //Console.WriteLine(lines[index]);
            Mastermind mastermindgame = new Mastermind(lines[index]);
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
                        break;

                    default:
                        if (mastermindgame.guess(input) == true)
                        {
                            finishedThis = true;
                        }
                        break;
                }
            }

            printSlowly("With the Air Conditioner successfully open, you carefully dump the whole jar into the machine.");
            printSlowly("It sputters and shakes and eventually coughs and ejects the contents of the jar through the vents of the building.");
            printSlowly("Tim Bluehelmet, being so cringe he was demoted to janitor, happens to be standing in front of a vent, and inhales some of Slobby John's plague sauce.");
            printSlowly("The rest of the UN building also happens to inhale some of Slobby John's plague sauce, as well as the whole city and a significant portion of Bosnia.");
            printSlowly("The plague seems to make people really embarrased");
            printSlowly("In the aftermath of the highly embarrassing event, you, Vaansh Mansharimani, are at last declared a war criminal. Great success!");



        }
    }
}
