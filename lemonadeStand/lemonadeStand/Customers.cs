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

        public Customers(Lemonade recipe, Weather forcast)
        {
            ChanceToPurchase = generatePurchaseChance(recipe, forcast);
        }

        public int generatePurchaseChance(Lemonade recipe, Weather forcast)
        {
            int chanceToPurchase = randomSeed.Next(1, 20);
            if (forcast.getTempurature()>75 && recipe.getIceCubes()> 2)
            {
                chanceToPurchase += 4;
            }

            double CTPDouble = ((recipe.getPrice()+1) / 3);
            CTPDouble = Math.Floor(CTPDouble);
            chanceToPurchase -= Convert.ToInt32(CTPDouble);

            int wateredDown = (recipe.getSugar() + recipe.getLemons()) - recipe.getIceCubes();

            if (wateredDown > 0)
            {
                chanceToPurchase += 2;
            }
            else
            {
                chanceToPurchase -= wateredDown;
            }

            return chanceToPurchase;

        }

        public bool isBuying()
        {
            if(ChanceToPurchase > 5)
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
