using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    class Player
    {
        private Inventory inventory;

        public Player()
        {
            inventory = new Inventory();
        }
        public void addObjectToInventory(Item ItemToAdd)
        {
            inventory.addObject(ItemToAdd);
        }
        public void printItems()
        {
            inventory.printItems();
        }
        public void printDescription(string getThisItemsDescription)
        {
            inventory.printDescription(getThisItemsDescription);
        }
    }
}
