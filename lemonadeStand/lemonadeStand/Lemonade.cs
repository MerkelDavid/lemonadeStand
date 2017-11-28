using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Lemonade
    {
        private int lemons;
        private int sugar;
        private int iceCubes;
        private double price;

        public Lemonade(int lemonCount, int sugarCount, int iceCubeCount, double price)
        {
            lemons = lemonCount;
            sugar = sugarCount;
            iceCubes = iceCubeCount;
            this.price = price;
        }

        public int getLemons()
        {
            return lemons;
        }

        public int getSugar()
        {
            return sugar;
        }

        public int getIceCubes()
        {
            return iceCubes;
        }

        public double getPrice()
        {
            return price;
        } 
    }
}
