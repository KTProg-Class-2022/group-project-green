using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{

    class DrakeRoom
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



        public DrakeRoom(bool slowMode)
        {
            Slowmode = slowMode;
            printSlowly("You walk into the back of the nearby concert venue. ");
            printSlowly("Normally, this area is reserved for staff only, but someone stole the doorknobs to all the doors here, \n as well as the paint that made up the letters \"STAFF ONLY\" on some of them, so you couldn't really tell.");
            printSlowly("As you walk down the hallway of dressing rooms and storage closets, you are suddenly jumpscared by a mysterious and surprising figure.");
            printSlowly("Drake: Hello Vaansh Mansharamani I need you to unlock this safe in my special room in this concert place for it holds the secret i need to defeat my arch nemesis Evil Drake");
            printSlowly("The real and actual Drake is here, in this very building, and he quickly shoves you into a room, whose door has a paper star glued onto it, with \"DRAKE!\" sharpied on.");
            printSlowly("A number of questions rise up regarding this entire situation, but you decide not to ask any of them, for fear of more questions.");
            printSlowly("You look around the room, noticing a huge 19th century old-west-style bank safe in the exact middle of an otherwise normal(ish) dressing room.");
            Mastermind mastermindgame = new Mastermind("encrypted");
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
            printSlowly("Having unlocked the safe, you open it to find a small wooden box labeled \"Comedically Timed Lit Stick of Dynamite\", and a Drake album.");
            printSlowly("Drake appears behind you, grabs the box, shouts \"Eureka!\", and runs away while giggling in a childlike manner, leaving you with the album.");
            printSlowly("Going back from the concert venue, you happen to encounter Tim Bluehelmet, and gift him the Drake album you found.");
            printSlowly("The next day, you challenge him to a rap battle inside the venue, with his family and most of the city in attendance. ");
            printSlowly("With his most recent exposure to rap music being the Drake album, his bars are cursed to be silly and wacky. ");
            printSlowly("Cringe, even. He loses devastatingly, and his very own family thinks him to be cringe now. Great success!");





        }



    }
}
