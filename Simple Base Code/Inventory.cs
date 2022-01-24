using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    class Inventory
    {
        Item[] ItemArray;
        int i;
        public Inventory()
        {
            ItemArray = new Item[5];
            i = 0;
        }
        public void addObject(Item itemToAdd)
        {
            if (i >= 5)
            {
                for (i = 1; i < 5; i++)
                {
                    ItemArray[i - 1] = ItemArray[i];
                }
                ItemArray[4] = itemToAdd;
            }
            else
            {
                ItemArray[i] = itemToAdd;
                i = i + 1;
            }
        }
    }
}
