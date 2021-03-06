using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    public class Game
    {

        //enable slow mode
        //if false will make text go fast
        bool slowMode = true;


        public Game()
        {

        }
        public int StartGame()
        {

            Tutorial tutorial = new Tutorial(slowMode);
            int nextRoom = tutorial.getNextRoom();
            bool[] roomsCompleted = { false, false, false };
            

            
            while (nextRoom != 0)
            {
                switch (nextRoom)
                {
                    case 1:
                        DrakeRoom drakeRoom = new DrakeRoom(slowMode, roomsCompleted);
                        if (drakeRoom.die)
                        {
                            return 1;
                        }
                        else
                        {
                            roomsCompleted[0] = true;
                            nextRoom = drakeRoom.getNextRoom();
                        }
                        break;
                    case 2:
                        BitcoinRoom bitcoin = new BitcoinRoom(slowMode, roomsCompleted);
                        if (bitcoin.die)
                        {
                            return 1;
                        }
                        else
                        {
                            roomsCompleted[1] = true;
                            nextRoom = bitcoin.getNextRoom();
                        }
                        
                        break;
                    case 3:
                        BootlegConsoleRoom bootleg = new BootlegConsoleRoom(slowMode, roomsCompleted);
                        if (bootleg.die)
                        {
                            return 1;
                        }
                        else
                        {
                            roomsCompleted[2] = true;
                            nextRoom = bootleg.getNextRoom();
                        }
                        break;

                    default:
                        nextRoom = 0;
                        break;

                }
            }
            
            FinalRoom finalRoom = new FinalRoom(slowMode);
            return 0;
        }
    }

}
