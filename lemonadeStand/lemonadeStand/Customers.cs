using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Customers
    {
        private Random randomSeed = new Random();
        private int ChanceToPurchase;

        public Customers()
        {
            ChanceToPurchase = randomSeed.Next(1,10);
        }

        public int generateNumberOfCustomers(Lemonade recipe, Weather forcast)
        {
            int numberOfCustomers = randomSeed.Next(1, 100);

            return numberOfCustomers;
        }

        public bool isBuying()
        {
            if(ChanceToPurchase >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
