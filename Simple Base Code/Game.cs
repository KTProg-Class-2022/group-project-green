﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    public class Game
    {

        //enable slow mode
        //if false will make text go fast
        bool slowMode = false;


        public Game()
        {

        }
        public void StartGame()
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
                        roomsCompleted[0] = true;
                        nextRoom = 0;
                        break;
                    case 2:
                        break;
                    case 3:
                        break;

                    default:
                        nextRoom = 0;
                        break;

                }
            }
        }
    }
    
}
