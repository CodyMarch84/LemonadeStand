using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        // member variables
        Inventory inventory;
        Bank bank;
        Recipe recipe;

        public Inventory Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }


        public Recipe Recipe
        {
            get { return recipe; }
            set { recipe = value; }
        }

    }
}
