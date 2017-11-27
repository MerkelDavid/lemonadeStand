using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Player
    {
        private string name;
        Inventory playerInventory = new Inventory();
        private double money;

        public Player()
        {
            name = "David";
            money = 100;
        }

        public double getMoney()
        {
            return money;
        }

        public string getName()
        {
            return name;
        }

        public Inventory getInventory()
        {
            return playerInventory;
        }

        public void setMoney(double newValue)
        {
            money = newValue;
        }
    }
}
