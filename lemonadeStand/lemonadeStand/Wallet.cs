using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Wallet
    {
        private double money;

        public Wallet(double cash)
        {
            money = cash;
        }

        public double getMoney()
        {
            return money;
        }

        public void subtractMoney(double price)
        {
            money -= price;
        }

        public void addMoney(double price)
        {
            money += price;
        }
    }
}
