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
        public void StartGame()
        {
            Tutorial tutorial = new Tutorial(slowMode);
        }
    }
    
}
