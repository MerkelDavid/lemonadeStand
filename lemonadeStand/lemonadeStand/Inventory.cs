using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Inventory
    {
        private List<Lemon> lemonBasket = new List<Lemon>();
        private int numOfIceCubes;
        private int numOfCups;
        private int numOfSugar;

        public Inventory()
        {
            Lemon newLemon = new Lemon();
            lemonBasket.Add(newLemon);
            numOfCups = 0;
            numOfIceCubes = 0;
            numOfSugar = 0;
        }

        public int getCups()
        {
            return numOfCups;
        }

        public void setCups(int newValue)
        {
            numOfCups = newValue;
        }

        public int getIceCubes()
        {
            return numOfIceCubes;
        }

        public void setIceCubes(int newValue)
        {
            numOfIceCubes = newValue;
        }

        public int getSugar()
        {
            return numOfSugar;
        }

        public void setSugar(int newValue)
        {
            numOfSugar = newValue;
        }

        public int getNumOfLemons()
        {
            return lemonBasket.Count;
        }

        public void addCups(int count)
        {
            numOfCups += count;
        }

        public void decrementCups()
        {
            numOfCups--;
        }

        public void addSugar(int count)
        {
            numOfSugar += count;
        }

        public void addIceCubes(int count)
        {
            numOfIceCubes += count;
        }

        public void addLemons(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Lemon newLemon = new Lemon();
                lemonBasket.Add(newLemon);
            }
        }

        public void subtractSugar(int count)
        {
            numOfSugar -= count;
        }

        public void subtractIceCubes(int count)
        {
            numOfIceCubes -= count;
        }

        public void subtractLemons(int count)
        {
            for (int i = 0; i < count; i++)
            {
                lemonBasket.RemoveAt(0);
            }
        }

        public bool enoughIngredients(Lemonade recipe)
        {
            if(lemonBasket.Count < recipe.getLemons() || numOfIceCubes < recipe.getIceCubes()|| numOfSugar < recipe.getSugar())
            {
                return false;
            }

            return true;
        }

        public bool areEnoughCups()
        {
            if(numOfCups > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int clearBasket()
        {
            int spoilCount = 0;
            int numOfLemons = lemonBasket.Count();

            for (int i=0; i<lemonBasket.Count(); i++)
            {
                if (lemonBasket[i].IsSpoiled())
                {
                    lemonBasket.RemoveAt(i);
                    spoilCount++;
                    //accounting for the removeAt()
                    i--;
                }
            }

            return spoilCount;
        }

        public void spoilLemons()
        {

            for (int i = 0; i < lemonBasket.Count; i++)
            {
                lemonBasket[i].IncrementDaysOld();
            }
        }
    }
}
