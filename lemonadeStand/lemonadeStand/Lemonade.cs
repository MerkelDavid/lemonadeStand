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
        private int cupsLeft;
        private double price;


        public Lemonade(int lemonCount, int sugarCount, int iceCubeCount, double price)
        {
            lemons = lemonCount;
            sugar = sugarCount;
            iceCubes = iceCubeCount;
            this.price = price;
            
            //cup value based on number of ice cubes rounded down
            decimal cupsLeftDecimal =10 * (1 + (iceCubes * 2 / 10));
            cupsLeftDecimal = Math.Floor(cupsLeftDecimal);
            cupsLeft = Convert.ToInt32(cupsLeftDecimal);
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
