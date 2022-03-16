using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    class RoomTwo
    {
        public RoomTwo()
        {
            Item pillow = new Item("Bitcoin Pillow", "A round pillow with a bitcoin design printed on it. Looks cheap.", 2, false);
            Item moonPoster = new Item("To the Moon Poster", "||I Don't Know What This Is Supposed To Be||", 2, false);
            Item plushy = new Item("Doge Plush Toys", "Plush toys designed to look like the meme dog. Cute?", 2, false);
            Item mirror = new Item("Diamond-Shaped Mirror", "A mirror in a diamond shape. The edges look kinda sharp.", 2, false);
            Item jacket = new Item("Varsity Jacket", "A varsity jacket with a huge number '2' on it. Looks like it hasn't been washed in a few decades.", 2, false);



            /* The string will serve as placeholder text until the commands are done,
             this is so we can have some sort of srtucture*/
            string test = "";
            Console.WriteLine("The second door leads to a room.");
            Console.WriteLine("When you enter the room, you see a ton of different items.");
            Console.WriteLine("You notice a desk at the end of the room with a brass cash register.");
            Console.WriteLine("You think to yourself that this is, or was, a store.");
            Console.WriteLine("While observing the room, you find a mastermind game.");
            Console.WriteLine("A lot of the items in this store look like they have a similar theme...");
            Console.WriteLine("You hear a sudden slam on the door, youre locked in.");
            Console.WriteLine("You can't get out unless you complete the puzzle.");
            Console.WriteLine("You think the items around you can help you solve the puzzle.");
            /*Here we prompt the user to either investigate and item or start the puzzle,
            playres can investigate one item per check and should be able to view items
            multiple times.*/
            Mastermind mastermindgameTwo = new Mastermind("Ethereum");
            Console.WriteLine("The puzzle is completed!!!");
            Console.WriteLine("You hear a click from the back of the room.");
            Console.WriteLine("The door has reopened!");
            Console.WriteLine("Exit the room?");

            if (test== "Yes" || test == "Y")
            {
                Console.WriteLine("You exit the room");
            }
            else if (test=="No" || test=="n")
            {
                Console.WriteLine("You do not exit the room. Why?");
            }
            else
            {
                Console.WriteLine("This isnt a rhetorical question... try again.");
            }
        }
    }
}
